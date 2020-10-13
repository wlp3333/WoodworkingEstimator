<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Settings
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
        Me.cb_BisRos = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tb_BlaKer = New System.Windows.Forms.TextBox()
        Me.lb_BlaKer = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_BisRos
        '
        Me.cb_BisRos.AutoSize = True
        Me.cb_BisRos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_BisRos.Location = New System.Drawing.Point(6, 19)
        Me.cb_BisRos.Name = "cb_BisRos"
        Me.cb_BisRos.Size = New System.Drawing.Size(98, 17)
        Me.cb_BisRos.TabIndex = 0
        Me.cb_BisRos.Text = "is Rough Sawn"
        Me.cb_BisRos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tb_BlaKer)
        Me.GroupBox1.Controls.Add(Me.lb_BlaKer)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 178)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Saw Settings"
        '
        'Tb_BlaKer
        '
        Me.Tb_BlaKer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_BlaKer.Location = New System.Drawing.Point(68, 19)
        Me.Tb_BlaKer.Name = "Tb_BlaKer"
        Me.Tb_BlaKer.Size = New System.Drawing.Size(83, 20)
        Me.Tb_BlaKer.TabIndex = 1
        '
        'lb_BlaKer
        '
        Me.lb_BlaKer.AutoSize = True
        Me.lb_BlaKer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_BlaKer.Location = New System.Drawing.Point(6, 22)
        Me.lb_BlaKer.Name = "lb_BlaKer"
        Me.lb_BlaKer.Size = New System.Drawing.Size(56, 13)
        Me.lb_BlaKer.TabIndex = 0
        Me.lb_BlaKer.Text = "Blade Kerf"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_BisRos)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 178)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Board Settings"
        '
        'Frm_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 202)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Settings"
        Me.Text = "WoodworkingEstimator | Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cb_BisRos As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tb_BlaKer As TextBox
    Friend WithEvents lb_BlaKer As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
