<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.pbJugar = New System.Windows.Forms.PictureBox()
        Me.pbSalir = New System.Windows.Forms.PictureBox()
        CType(Me.pbJugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbJugar
        '
        Me.pbJugar.BackColor = System.Drawing.Color.Transparent
        Me.pbJugar.BackgroundImage = CType(resources.GetObject("pbJugar.BackgroundImage"), System.Drawing.Image)
        Me.pbJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbJugar.Location = New System.Drawing.Point(298, 185)
        Me.pbJugar.Name = "pbJugar"
        Me.pbJugar.Size = New System.Drawing.Size(218, 51)
        Me.pbJugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbJugar.TabIndex = 2
        Me.pbJugar.TabStop = False
        '
        'pbSalir
        '
        Me.pbSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbSalir.BackgroundImage = CType(resources.GetObject("pbSalir.BackgroundImage"), System.Drawing.Image)
        Me.pbSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSalir.Location = New System.Drawing.Point(298, 294)
        Me.pbSalir.Name = "pbSalir"
        Me.pbSalir.Size = New System.Drawing.Size(218, 51)
        Me.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSalir.TabIndex = 3
        Me.pbSalir.TabStop = False
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(563, 479)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbSalir)
        Me.Controls.Add(Me.pbJugar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pbJugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbJugar As PictureBox
    Friend WithEvents pbSalir As PictureBox
End Class
