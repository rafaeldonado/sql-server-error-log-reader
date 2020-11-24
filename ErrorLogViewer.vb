Imports System.IO
Imports System.Management.Automation.Runspaces
Imports Microsoft.Win32

Public Class ErrorLogViewerForm

    Private Function GetErrorLogData(ErrorLogPath As String)
        Dim TempPath = Path.GetTempPath() + "ERRORLOG"
        Dim PowerShellRunspace As Runspace = RunspaceFactory.CreateRunspace()
        PowerShellRunspace.Open()
        Dim PowerShellCommand As Pipeline = PowerShellRunspace.CreatePipeline()
        PowerShellCommand.Commands.AddScript("(((Get-Content -path """ + ErrorLogPath + """ -Raw).Replace(""`r`n`t"","""")).Replace(""`r`n`r`n"",""`r`n"")).Replace("" `n "","" "") | Set-Content """ + TempPath + """")
        PowerShellCommand.Invoke()

        Dim ErrorLogLines As List(Of String) = File.ReadAllLines(TempPath).ToList()
        Dim ErrorLogList As List(Of ErrorLogClass) = New List(Of ErrorLogClass)

        For i As Integer = 5 To ErrorLogLines.Count - 2
            Dim data As String() = ErrorLogLines(i).Split(CType(" ", Char()), StringSplitOptions.RemoveEmptyEntries)
            Dim errorMessage = ErrorLogLines(i).Substring(ErrorLogLines(i).IndexOf("    "))
            Dim DateTimeLog As DateTime
            If DateTime.TryParse(data(0).Trim + " " + data(1).Trim, DateTimeLog) = False Then
                DateTimeLog = DateTime.Now()
            End If

            ErrorLogList.Add(New ErrorLogClass() With {
            .CLogDate = DateTimeLog,
            .CId = data(2).Trim,
            .CMessage = errorMessage.Trim
            })
        Next
        Return ErrorLogList
    End Function

    Private Sub ErrorLogViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SQLServerKey = "SOFTWARE\\Microsoft\\Microsoft SQL Server\\Instance Names\\SQL\\"
        Dim SQLRegistryKey As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry64).OpenSubKey(SQLServerKey)

        Dim FullInstanceName = SQLRegistryKey.GetValue(ChooseInstanceForm.InstanceName)
        Dim RegistrySubKey = "SOFTWARE\\Microsoft\\Microsoft SQL Server\\" + FullInstanceName + "\\MSSQLServer\\Parameters\\"
        Dim ErrorLogPathRegistryKey As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry64).OpenSubKey(RegistrySubKey)
        Dim CurrentErrorLogPath = ErrorLogPathRegistryKey.GetValue("SQLArg1").ToString.Substring(2)

        Dim ErrorLogList = GetErrorLogData(CurrentErrorLogPath)
        ErrorLogClassBindingSource.DataSource = ErrorLogList
        InstanceInformationLabel.Text = FullInstanceName
        ErrorLogPathLabel.Text = CurrentErrorLogPath
        ChooseInstanceForm.Close()
    End Sub

    Private Sub OpenMenuSubItem_Click(sender As Object, e As EventArgs) Handles OpenMenuSubItem.Click
        Using FileDialogObject As OpenFileDialog = New OpenFileDialog() With {.Filter = "SQL Server Error Log File | ERRORLOG*", .InitialDirectory = "C:\"}
            If FileDialogObject.ShowDialog() = DialogResult.OK Then
                Dim ErrorLogList = GetErrorLogData(FileDialogObject.FileName)
                ErrorLogClassBindingSource.DataSource = ErrorLogList
                ErrorLogPathLabel.Text = FileDialogObject.FileName
            End If
        End Using
    End Sub

    Private Sub AboutMenuSubItem_Click(sender As Object, e As EventArgs) Handles AboutMenuSubItem.Click
        About.Show()
    End Sub

    Private Sub ReverseOrderButton_Click(sender As Object, e As EventArgs) Handles ReverseOrderButton.Click





        ErrorLogClassBindingSource.DataSource.Reverse()
        ErrorLogClassBindingSource.ResetBindings(True)


    End Sub

    Private Sub SelectInstanceButton_Click(sender As Object, e As EventArgs) Handles ChangeInstanceButton.Click
        ChooseInstanceForm.Show()
    End Sub
End Class
