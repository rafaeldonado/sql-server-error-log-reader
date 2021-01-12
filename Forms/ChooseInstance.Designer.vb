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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChooseInstanceForm))
        Me.InstancesListView = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChooseInstanceLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InstancesListView
        '
        Me.InstancesListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        resources.ApplyResources(Me.InstancesListView, "InstancesListView")
        Me.InstancesListView.FullRowSelect = True
        Me.InstancesListView.GridLines = True
        Me.InstancesListView.HideSelection = False
        Me.InstancesListView.Name = "InstancesListView"
        Me.InstancesListView.UseCompatibleStateImageBehavior = False
        Me.InstancesListView.View = System.Windows.Forms.View.List
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ChooseInstanceLabel)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'ChooseInstanceLabel
        '
        resources.ApplyResources(Me.ChooseInstanceLabel, "ChooseInstanceLabel")
        Me.ChooseInstanceLabel.Name = "ChooseInstanceLabel"
        '
        'ChooseInstanceForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.InstancesListView)
        Me.Name = "ChooseInstanceForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InstancesListView As ListView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ChooseInstanceLabel As Label
End Class
