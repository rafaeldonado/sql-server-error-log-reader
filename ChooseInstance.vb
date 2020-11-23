Imports System.IO
Imports System.Management.Automation.Runspaces
Imports Microsoft.Win32

Public Class ChooseInstanceForm

    Public InstanceName As String

    Private Sub InitialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlRegistryKey As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Microsoft SQL Server\\Instance Names\\SQL")

        For Each subkey In sqlRegistryKey.GetValueNames()
            InstancesListView.Items.Add(New ListViewItem(subkey))
        Next
    End Sub

    Private Sub InstancesListView_ItemActivate(sender As Object, e As EventArgs) Handles InstancesListView.ItemActivate
        InstanceName = InstancesListView.SelectedItems(0).Text
        ErrorLogViewerForm.Show()
    End Sub
End Class