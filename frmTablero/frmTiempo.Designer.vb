<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiempo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTiempo))
        Me.rb5 = New System.Windows.Forms.RadioButton()
        Me.rb0 = New System.Windows.Forms.RadioButton()
        Me.rb20 = New System.Windows.Forms.RadioButton()
        Me.rb10 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rb5
        '
        Me.rb5.AutoSize = True
        Me.rb5.Location = New System.Drawing.Point(37, 37)
        Me.rb5.Name = "rb5"
        Me.rb5.Size = New System.Drawing.Size(50, 17)
        Me.rb5.TabIndex = 3
        Me.rb5.TabStop = True
        Me.rb5.Text = "5 min"
        Me.rb5.UseVisualStyleBackColor = True
        '
        'rb0
        '
        Me.rb0.AutoSize = True
        Me.rb0.Location = New System.Drawing.Point(272, 37)
        Me.rb0.Name = "rb0"
        Me.rb0.Size = New System.Drawing.Size(74, 17)
        Me.rb0.TabIndex = 12
        Me.rb0.TabStop = True
        Me.rb0.Text = "Sin tiempo"
        Me.rb0.UseVisualStyleBackColor = True
        '
        'rb20
        '
        Me.rb20.AutoSize = True
        Me.rb20.Location = New System.Drawing.Point(198, 37)
        Me.rb20.Name = "rb20"
        Me.rb20.Size = New System.Drawing.Size(56, 17)
        Me.rb20.TabIndex = 11
        Me.rb20.TabStop = True
        Me.rb20.Text = "20 min"
        Me.rb20.UseVisualStyleBackColor = True
        '
        'rb10
        '
        Me.rb10.AutoSize = True
        Me.rb10.Location = New System.Drawing.Point(115, 37)
        Me.rb10.Name = "rb10"
        Me.rb10.Size = New System.Drawing.Size(56, 17)
        Me.rb10.TabIndex = 10
        Me.rb10.TabStop = True
        Me.rb10.Text = "10 min"
        Me.rb10.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(101, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 39)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "EMPEZAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmTiempo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 182)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rb0)
        Me.Controls.Add(Me.rb20)
        Me.Controls.Add(Me.rb10)
        Me.Controls.Add(Me.rb5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTiempo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elija modo de juego"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rb5 As RadioButton
    Friend WithEvents rb0 As RadioButton
    Friend WithEvents rb20 As RadioButton
    Friend WithEvents rb10 As RadioButton
    Friend WithEvents Button1 As Button
End Class
