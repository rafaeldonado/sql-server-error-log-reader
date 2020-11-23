<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseInstanceForm
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
        Me.InstancesListView = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChooseInstanceLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InstancesListView
        '
        Me.InstancesListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.InstancesListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InstancesListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstancesListView.FullRowSelect = True
        Me.InstancesListView.GridLines = True
        Me.InstancesListView.HideSelection = False
        Me.InstancesListView.Location = New System.Drawing.Point(10, 48)
        Me.InstancesListView.Name = "InstancesListView"
        Me.InstancesListView.Size = New System.Drawing.Size(300, 120)
        Me.InstancesListView.TabIndex = 0
        Me.InstancesListView.UseCompatibleStateImageBehavior = False
        Me.InstancesListView.View = System.Windows.Forms.View.List
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ChooseInstanceLabel)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 30)
        Me.Panel1.TabIndex = 1
        '
        'ChooseInstanceLabel
        '
        Me.ChooseInstanceLabel.AutoSize = True
        Me.ChooseInstanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChooseInstanceLabel.Location = New System.Drawing.Point(4, 4)
        Me.ChooseInstanceLabel.Name = "ChooseInstanceLabel"
        Me.ChooseInstanceLabel.Size = New System.Drawing.Size(216, 17)
        Me.ChooseInstanceLabel.TabIndex = 0
        Me.ChooseInstanceLabel.Text = "Por favor seleccione la instancia:"
        '
        'ChooseInstanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 176)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.InstancesListView)
        Me.Name = "ChooseInstanceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instancia"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InstancesListView As ListView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ChooseInstanceLabel As Label
End Class
