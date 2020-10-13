<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SinglePiece
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_solve = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.tb_console = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 338)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(378, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 338)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'btn_solve
        '
        Me.btn_solve.Location = New System.Drawing.Point(663, 356)
        Me.btn_solve.Name = "btn_solve"
        Me.btn_solve.Size = New System.Drawing.Size(75, 50)
        Me.btn_solve.TabIndex = 2
        Me.btn_solve.Text = "Solve!"
        Me.btn_solve.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(663, 412)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 26)
        Me.btn_clear.TabIndex = 3
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'tb_console
        '
        Me.tb_console.Location = New System.Drawing.Point(12, 356)
        Me.tb_console.Multiline = True
        Me.tb_console.Name = "tb_console"
        Me.tb_console.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tb_console.Size = New System.Drawing.Size(645, 82)
        Me.tb_console.TabIndex = 4
        Me.tb_console.WordWrap = False
        '
        'Frm_SinglePiece
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 442)
        Me.Controls.Add(Me.tb_console)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_solve)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_SinglePiece"
        Me.Text = "WoodworkingEstimator | Single Piece"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_solve As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents tb_console As TextBox
End Class
