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
        Me.ErrorLogDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorLogDataGridView.AutoGenerateColumns = False
        Me.ErrorLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ErrorLogDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLogDateDataGridViewTextBoxColumn, Me.CIdDataGridViewTextBoxColumn, Me.CMessageDataGridViewTextBoxColumn})
        Me.ErrorLogDataGridView.DataSource = Me.ErrorLogClassBindingSource
        Me.ErrorLogDataGridView.Location = New System.Drawing.Point(13, 27)
        Me.ErrorLogDataGridView.Name = "ErrorLogDataGridView"
        Me.ErrorLogDataGridView.ReadOnly = True
        Me.ErrorLogDataGridView.Size = New System.Drawing.Size(775, 350)
        Me.ErrorLogDataGridView.TabIndex = 0
        '
        'CLogDateDataGridViewTextBoxColumn
        '
        Me.CLogDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CLogDateDataGridViewTextBoxColumn.DataPropertyName = "CLogDate"
        DataGridViewCellStyle1.Format = "F"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CLogDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CLogDateDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.CLogDateDataGridViewTextBoxColumn.Name = "CLogDateDataGridViewTextBoxColumn"
        Me.CLogDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLogDateDataGridViewTextBoxColumn.Width = 62
        '
        'CIdDataGridViewTextBoxColumn
        '
        Me.CIdDataGridViewTextBoxColumn.DataPropertyName = "CId"
        Me.CIdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.CIdDataGridViewTextBoxColumn.Name = "CIdDataGridViewTextBoxColumn"
        Me.CIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CMessageDataGridViewTextBoxColumn
        '
        Me.CMessageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CMessageDataGridViewTextBoxColumn.DataPropertyName = "CMessage"
        Me.CMessageDataGridViewTextBoxColumn.HeaderText = "Mensaje"
        Me.CMessageDataGridViewTextBoxColumn.Name = "CMessageDataGridViewTextBoxColumn"
        Me.CMessageDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ErrorLogClassBindingSource
        '
        Me.ErrorLogClassBindingSource.DataSource = GetType(SQLServerErrorLogReader.ErrorLogClass)
        '
        'ReverseOrderButton
        '
        Me.ReverseOrderButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReverseOrderButton.Location = New System.Drawing.Point(605, 415)
        Me.ReverseOrderButton.Name = "ReverseOrderButton"
        Me.ReverseOrderButton.Size = New System.Drawing.Size(183, 23)
        Me.ReverseOrderButton.TabIndex = 1
        Me.ReverseOrderButton.Text = "Orden Inverso"
        Me.ReverseOrderButton.UseVisualStyleBackColor = True
        '
        'ErrorLogViewerMenuStrip
        '
        Me.ErrorLogViewerMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenuItem, Me.SettingsMenuItem, Me.HelpMenuItem})
        Me.ErrorLogViewerMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.ErrorLogViewerMenuStrip.Name = "ErrorLogViewerMenuStrip"
        Me.ErrorLogViewerMenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.ErrorLogViewerMenuStrip.TabIndex = 2
        Me.ErrorLogViewerMenuStrip.Text = "Menu"
        '
        'FileMenuItem
        '
        Me.FileMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenMenuSubItem})
        Me.FileMenuItem.Name = "FileMenuItem"
        Me.FileMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.FileMenuItem.Text = "Archivo"
        '
        'OpenMenuSubItem
        '
        Me.OpenMenuSubItem.Name = "OpenMenuSubItem"
        Me.OpenMenuSubItem.Size = New System.Drawing.Size(176, 22)
        Me.OpenMenuSubItem.Text = "Abrir otro archivo..."
        '
        'SettingsMenuItem
        '
        Me.SettingsMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsMenuSubItem})
        Me.SettingsMenuItem.Name = "SettingsMenuItem"
        Me.SettingsMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.SettingsMenuItem.Text = "Configuración"
        '
        'OptionsMenuSubItem
        '
        Me.OptionsMenuSubItem.Enabled = False
        Me.OptionsMenuSubItem.Name = "OptionsMenuSubItem"
        Me.OptionsMenuSubItem.Size = New System.Drawing.Size(133, 22)
        Me.OptionsMenuSubItem.Text = "Opciones..."
        '
        'HelpMenuItem
        '
        Me.HelpMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutMenuSubItem})
        Me.HelpMenuItem.Name = "HelpMenuItem"
        Me.HelpMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.HelpMenuItem.Text = "Ayuda"
        '
        'AboutMenuSubItem
        '
        Me.AboutMenuSubItem.Name = "AboutMenuSubItem"
        Me.AboutMenuSubItem.Size = New System.Drawing.Size(283, 22)
        Me.AboutMenuSubItem.Text = "Acerca de SQL Server Error Log Viewer..."
        '
        'InstanceInformationLabel
        '
        Me.InstanceInformationLabel.AutoSize = True
        Me.InstanceInformationLabel.Location = New System.Drawing.Point(3, 3)
        Me.InstanceInformationLabel.Name = "InstanceInformationLabel"
        Me.InstanceInformationLabel.Size = New System.Drawing.Size(126, 13)
        Me.InstanceInformationLabel.TabIndex = 4
        Me.InstanceInformationLabel.Text = "InstanceInformationLabel"
        '
        'InformationPanel
        '
        Me.InformationPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InformationPanel.Controls.Add(Me.ErrorLogPathLabel)
        Me.InformationPanel.Controls.Add(Me.InstanceInformationLabel)
        Me.InformationPanel.Location = New System.Drawing.Point(13, 384)
        Me.InformationPanel.Name = "InformationPanel"
        Me.InformationPanel.Size = New System.Drawing.Size(586, 54)
        Me.InformationPanel.TabIndex = 5
        '
        'ErrorLogPathLabel
        '
        Me.ErrorLogPathLabel.AutoSize = True
        Me.ErrorLogPathLabel.Location = New System.Drawing.Point(3, 20)
        Me.ErrorLogPathLabel.Name = "ErrorLogPathLabel"
        Me.ErrorLogPathLabel.Size = New System.Drawing.Size(95, 13)
        Me.ErrorLogPathLabel.TabIndex = 5
        Me.ErrorLogPathLabel.Text = "ErrorLogPathLabel"
        '
        'ChangeInstanceButton
        '
        Me.ChangeInstanceButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChangeInstanceButton.Location = New System.Drawing.Point(605, 384)
        Me.ChangeInstanceButton.Name = "ChangeInstanceButton"
        Me.ChangeInstanceButton.Size = New System.Drawing.Size(183, 23)
        Me.ChangeInstanceButton.TabIndex = 6
        Me.ChangeInstanceButton.Text = "Cambiar Instancia"
        Me.ChangeInstanceButton.UseVisualStyleBackColor = True
        '
        'ErrorLogViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ChangeInstanceButton)
        Me.Controls.Add(Me.InformationPanel)
        Me.Controls.Add(Me.ReverseOrderButton)
        Me.Controls.Add(Me.ErrorLogDataGridView)
        Me.Controls.Add(Me.ErrorLogViewerMenuStrip)
        Me.Name = "ErrorLogViewerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Error Log Viewer"
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
End Class
