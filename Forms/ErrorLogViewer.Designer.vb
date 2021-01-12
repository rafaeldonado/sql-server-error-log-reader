<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorLogViewerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrorLogViewerForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ErrorLogDataGridView = New System.Windows.Forms.DataGridView()
        Me.CLogDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMessageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorLogClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReverseOrderButton = New System.Windows.Forms.Button()
        Me.ErrorLogViewerMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenMenuSubItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsMenuSubItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMenuSubItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstanceInformationLabel = New System.Windows.Forms.Label()
        Me.InformationPanel = New System.Windows.Forms.Panel()
        Me.ErrorLogPathLabel = New System.Windows.Forms.Label()
        Me.ChangeInstanceButton = New System.Windows.Forms.Button()
        CType(Me.ErrorLogDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorLogClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ErrorLogViewerMenuStrip.SuspendLayout()
        Me.InformationPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorLogDataGridView
        '
        Me.ErrorLogDataGridView.AllowUserToAddRows = False
        Me.ErrorLogDataGridView.AllowUserToDeleteRows = False
        Me.ErrorLogDataGridView.AllowUserToOrderColumns = True
        resources.ApplyResources(Me.ErrorLogDataGridView, "ErrorLogDataGridView")
        Me.ErrorLogDataGridView.AutoGenerateColumns = False
        Me.ErrorLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ErrorLogDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLogDateDataGridViewTextBoxColumn, Me.CIdDataGridViewTextBoxColumn, Me.CMessageDataGridViewTextBoxColumn})
        Me.ErrorLogDataGridView.DataSource = Me.ErrorLogClassBindingSource
        Me.ErrorLogDataGridView.Name = "ErrorLogDataGridView"
        Me.ErrorLogDataGridView.ReadOnly = True
        '
        'CLogDateDataGridViewTextBoxColumn
        '
        Me.CLogDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CLogDateDataGridViewTextBoxColumn.DataPropertyName = "CLogDate"
        DataGridViewCellStyle1.Format = "F"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CLogDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.CLogDateDataGridViewTextBoxColumn, "CLogDateDataGridViewTextBoxColumn")
        Me.CLogDateDataGridViewTextBoxColumn.Name = "CLogDateDataGridViewTextBoxColumn"
        Me.CLogDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CIdDataGridViewTextBoxColumn
        '
        Me.CIdDataGridViewTextBoxColumn.DataPropertyName = "CId"
        resources.ApplyResources(Me.CIdDataGridViewTextBoxColumn, "CIdDataGridViewTextBoxColumn")
        Me.CIdDataGridViewTextBoxColumn.Name = "CIdDataGridViewTextBoxColumn"
        Me.CIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CMessageDataGridViewTextBoxColumn
        '
        Me.CMessageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CMessageDataGridViewTextBoxColumn.DataPropertyName = "CMessage"
        resources.ApplyResources(Me.CMessageDataGridViewTextBoxColumn, "CMessageDataGridViewTextBoxColumn")
        Me.CMessageDataGridViewTextBoxColumn.Name = "CMessageDataGridViewTextBoxColumn"
        Me.CMessageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ErrorLogClassBindingSource
        '
        Me.ErrorLogClassBindingSource.DataSource = GetType(SQLServerErrorLogReader.ErrorLogClass)
        '
        'ReverseOrderButton
        '
        resources.ApplyResources(Me.ReverseOrderButton, "ReverseOrderButton")
        Me.ReverseOrderButton.Name = "ReverseOrderButton"
        Me.ReverseOrderButton.UseVisualStyleBackColor = True
        '
        'ErrorLogViewerMenuStrip
        '
        Me.ErrorLogViewerMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenuItem, Me.SettingsMenuItem, Me.HelpMenuItem})
        resources.ApplyResources(Me.ErrorLogViewerMenuStrip, "ErrorLogViewerMenuStrip")
        Me.ErrorLogViewerMenuStrip.Name = "ErrorLogViewerMenuStrip"
        '
        'FileMenuItem
        '
        Me.FileMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenMenuSubItem, Me.SalirToolStripMenuItem})
        Me.FileMenuItem.Name = "FileMenuItem"
        resources.ApplyResources(Me.FileMenuItem, "FileMenuItem")
        '
        'OpenMenuSubItem
        '
        Me.OpenMenuSubItem.Name = "OpenMenuSubItem"
        resources.ApplyResources(Me.OpenMenuSubItem, "OpenMenuSubItem")
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        resources.ApplyResources(Me.SalirToolStripMenuItem, "SalirToolStripMenuItem")
        '
        'SettingsMenuItem
        '
        Me.SettingsMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsMenuSubItem})
        Me.SettingsMenuItem.Name = "SettingsMenuItem"
        resources.ApplyResources(Me.SettingsMenuItem, "SettingsMenuItem")
        '
        'OptionsMenuSubItem
        '
        resources.ApplyResources(Me.OptionsMenuSubItem, "OptionsMenuSubItem")
        Me.OptionsMenuSubItem.Name = "OptionsMenuSubItem"
        '
        'HelpMenuItem
        '
        Me.HelpMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutMenuSubItem})
        Me.HelpMenuItem.Name = "HelpMenuItem"
        resources.ApplyResources(Me.HelpMenuItem, "HelpMenuItem")
        '
        'AboutMenuSubItem
        '
        Me.AboutMenuSubItem.Name = "AboutMenuSubItem"
        resources.ApplyResources(Me.AboutMenuSubItem, "AboutMenuSubItem")
        '
        'InstanceInformationLabel
        '
        resources.ApplyResources(Me.InstanceInformationLabel, "InstanceInformationLabel")
        Me.InstanceInformationLabel.Name = "InstanceInformationLabel"
        '
        'InformationPanel
        '
        resources.ApplyResources(Me.InformationPanel, "InformationPanel")
        Me.InformationPanel.Controls.Add(Me.ErrorLogPathLabel)
        Me.InformationPanel.Controls.Add(Me.InstanceInformationLabel)
        Me.InformationPanel.Name = "InformationPanel"
        '
        'ErrorLogPathLabel
        '
        resources.ApplyResources(Me.ErrorLogPathLabel, "ErrorLogPathLabel")
        Me.ErrorLogPathLabel.Name = "ErrorLogPathLabel"
        '
        'ChangeInstanceButton
        '
        resources.ApplyResources(Me.ChangeInstanceButton, "ChangeInstanceButton")
        Me.ChangeInstanceButton.Name = "ChangeInstanceButton"
        Me.ChangeInstanceButton.UseVisualStyleBackColor = True
        '
        'ErrorLogViewerForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ChangeInstanceButton)
        Me.Controls.Add(Me.InformationPanel)
        Me.Controls.Add(Me.ReverseOrderButton)
        Me.Controls.Add(Me.ErrorLogDataGridView)
        Me.Controls.Add(Me.ErrorLogViewerMenuStrip)
        Me.Name = "ErrorLogViewerForm"
        CType(Me.ErrorLogDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorLogClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ErrorLogViewerMenuStrip.ResumeLayout(False)
        Me.ErrorLogViewerMenuStrip.PerformLayout()
        Me.InformationPanel.ResumeLayout(False)
        Me.InformationPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ErrorLogDataGridView As DataGridView
    Friend WithEvents ReverseOrderButton As Button
    Friend WithEvents ErrorLogClassBindingSource As BindingSource
    Friend WithEvents ErrorLogViewerMenuStrip As MenuStrip
    Friend WithEvents FileMenuItem As ToolStripMenuItem
    Friend WithEvents OpenMenuSubItem As ToolStripMenuItem
    Friend WithEvents SettingsMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsMenuSubItem As ToolStripMenuItem
    Friend WithEvents HelpMenuItem As ToolStripMenuItem
    Friend WithEvents AboutMenuSubItem As ToolStripMenuItem
    Friend WithEvents InstanceInformationLabel As Label
    Friend WithEvents InformationPanel As Panel
    Friend WithEvents ErrorLogPathLabel As Label
    Friend WithEvents CLogTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChangeInstanceButton As Button
    Friend WithEvents CLogDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CMessageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
