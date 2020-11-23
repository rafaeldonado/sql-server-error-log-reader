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
        Me.ErrorLogDataGridView = New System.Windows.Forms.DataGridView()
        Me.OpenFileButton = New System.Windows.Forms.Button()
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
        Me.CLogDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLogTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMessageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorLogClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ErrorLogDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ErrorLogViewerMenuStrip.SuspendLayout()
        Me.InformationPanel.SuspendLayout()
        CType(Me.ErrorLogClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorLogDataGridView
        '
        Me.ErrorLogDataGridView.AllowUserToOrderColumns = True
        Me.ErrorLogDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorLogDataGridView.AutoGenerateColumns = False
        Me.ErrorLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ErrorLogDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLogDateDataGridViewTextBoxColumn, Me.CLogTimeDataGridViewTextBoxColumn, Me.CIdDataGridViewTextBoxColumn, Me.CMessageDataGridViewTextBoxColumn})
        Me.ErrorLogDataGridView.DataSource = Me.ErrorLogClassBindingSource
        Me.ErrorLogDataGridView.Location = New System.Drawing.Point(13, 27)
        Me.ErrorLogDataGridView.Name = "ErrorLogDataGridView"
        Me.ErrorLogDataGridView.Size = New System.Drawing.Size(775, 350)
        Me.ErrorLogDataGridView.TabIndex = 0
        '
        'OpenFileButton
        '
        Me.OpenFileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OpenFileButton.Location = New System.Drawing.Point(713, 415)
        Me.OpenFileButton.Name = "OpenFileButton"
        Me.OpenFileButton.Size = New System.Drawing.Size(75, 23)
        Me.OpenFileButton.TabIndex = 1
        Me.OpenFileButton.Text = "Abrir Log"
        Me.OpenFileButton.UseVisualStyleBackColor = True
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
        Me.InformationPanel.Size = New System.Drawing.Size(694, 54)
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
        'CLogDateDataGridViewTextBoxColumn
        '
        Me.CLogDateDataGridViewTextBoxColumn.DataPropertyName = "CLogDate"
        Me.CLogDateDataGridViewTextBoxColumn.HeaderText = "CLogDate"
        Me.CLogDateDataGridViewTextBoxColumn.Name = "CLogDateDataGridViewTextBoxColumn"
        '
        'CLogTimeDataGridViewTextBoxColumn
        '
        Me.CLogTimeDataGridViewTextBoxColumn.DataPropertyName = "CLogTime"
        Me.CLogTimeDataGridViewTextBoxColumn.HeaderText = "CLogTime"
        Me.CLogTimeDataGridViewTextBoxColumn.Name = "CLogTimeDataGridViewTextBoxColumn"
        '
        'CIdDataGridViewTextBoxColumn
        '
        Me.CIdDataGridViewTextBoxColumn.DataPropertyName = "CId"
        Me.CIdDataGridViewTextBoxColumn.HeaderText = "CId"
        Me.CIdDataGridViewTextBoxColumn.Name = "CIdDataGridViewTextBoxColumn"
        '
        'CMessageDataGridViewTextBoxColumn
        '
        Me.CMessageDataGridViewTextBoxColumn.DataPropertyName = "CMessage"
        Me.CMessageDataGridViewTextBoxColumn.HeaderText = "CMessage"
        Me.CMessageDataGridViewTextBoxColumn.Name = "CMessageDataGridViewTextBoxColumn"
        '
        'ErrorLogClassBindingSource
        '
        Me.ErrorLogClassBindingSource.DataSource = GetType(SQLServerErrorLogReader.ErrorLogClass)
        '
        'ErrorLogViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.InformationPanel)
        Me.Controls.Add(Me.OpenFileButton)
        Me.Controls.Add(Me.ErrorLogDataGridView)
        Me.Controls.Add(Me.ErrorLogViewerMenuStrip)
        Me.Name = "ErrorLogViewerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Error Log Viewer"
        CType(Me.ErrorLogDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ErrorLogViewerMenuStrip.ResumeLayout(False)
        Me.ErrorLogViewerMenuStrip.PerformLayout()
        Me.InformationPanel.ResumeLayout(False)
        Me.InformationPanel.PerformLayout()
        CType(Me.ErrorLogClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ErrorLogDataGridView As DataGridView
    Friend WithEvents OpenFileButton As Button
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
    Friend WithEvents CLogDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLogTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CMessageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
