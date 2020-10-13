<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btn_single = New System.Windows.Forms.Button()
        Me.Btn_settings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_single
        '
        Me.Btn_single.Location = New System.Drawing.Point(12, 141)
        Me.Btn_single.Name = "Btn_single"
        Me.Btn_single.Size = New System.Drawing.Size(150, 23)
        Me.Btn_single.TabIndex = 0
        Me.Btn_single.Text = "Single Piece..."
        Me.Btn_single.UseVisualStyleBackColor = True
        '
        'Btn_settings
        '
        Me.Btn_settings.Location = New System.Drawing.Point(12, 291)
        Me.Btn_settings.Name = "Btn_settings"
        Me.Btn_settings.Size = New System.Drawing.Size(75, 23)
        Me.Btn_settings.TabIndex = 1
        Me.Btn_settings.Text = "Settings..."
        Me.Btn_settings.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 326)
        Me.Controls.Add(Me.Btn_settings)
        Me.Controls.Add(Me.Btn_single)
        Me.Name = "Form1"
        Me.Text = "WoodworkingEstimator | Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_single As Button
    Friend WithEvents Btn_settings As Button
End Class
