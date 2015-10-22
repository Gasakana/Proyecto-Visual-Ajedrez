<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTablero
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTablero))
        Me.lblJugador = New System.Windows.Forms.Label()
        Me.pbJugador = New System.Windows.Forms.PictureBox()
        Me.timerBlanco = New System.Windows.Forms.Timer(Me.components)
        Me.timerNegro = New System.Windows.Forms.Timer(Me.components)
        Me.lblBlanco = New System.Windows.Forms.Label()
        Me.lblNegro = New System.Windows.Forms.Label()
        Me.lbltblanco = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbJugador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJugador
        '
        Me.lblJugador.AutoSize = True
        Me.lblJugador.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJugador.Location = New System.Drawing.Point(501, 44)
        Me.lblJugador.Name = "lblJugador"
        Me.lblJugador.Size = New System.Drawing.Size(90, 22)
        Me.lblJugador.TabIndex = 0
        Me.lblJugador.Text = "JUGADOR"
        '
        'pbJugador
        '
        Me.pbJugador.Image = Global.Ajedrez.My.Resources.Resources.colorB
        Me.pbJugador.Location = New System.Drawing.Point(498, 82)
        Me.pbJugador.Name = "pbJugador"
        Me.pbJugador.Size = New System.Drawing.Size(98, 101)
        Me.pbJugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbJugador.TabIndex = 1
        Me.pbJugador.TabStop = False
        '
        'timerBlanco
        '
        Me.timerBlanco.Interval = 1000
        '
        'timerNegro
        '
        Me.timerNegro.Interval = 1000
        '
        'lblBlanco
        '
        Me.lblBlanco.AutoSize = True
        Me.lblBlanco.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlanco.Location = New System.Drawing.Point(501, 237)
        Me.lblBlanco.Name = "lblBlanco"
        Me.lblBlanco.Size = New System.Drawing.Size(46, 22)
        Me.lblBlanco.TabIndex = 2
        Me.lblBlanco.Text = "05:00"
        '
        'lblNegro
        '
        Me.lblNegro.AutoSize = True
        Me.lblNegro.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNegro.Location = New System.Drawing.Point(501, 315)
        Me.lblNegro.Name = "lblNegro"
        Me.lblNegro.Size = New System.Drawing.Size(46, 22)
        Me.lblNegro.TabIndex = 3
        Me.lblNegro.Text = "05:00"
        '
        'lbltblanco
        '
        Me.lbltblanco.AutoSize = True
        Me.lbltblanco.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltblanco.Location = New System.Drawing.Point(501, 215)
        Me.lbltblanco.Name = "lbltblanco"
        Me.lbltblanco.Size = New System.Drawing.Size(60, 22)
        Me.lbltblanco.TabIndex = 4
        Me.lbltblanco.Text = "Blanco"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(501, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Negro"
        '
        'frmTablero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 477)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbltblanco)
        Me.Controls.Add(Me.lblNegro)
        Me.Controls.Add(Me.lblBlanco)
        Me.Controls.Add(Me.pbJugador)
        Me.Controls.Add(Me.lblJugador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTablero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajedrez"
        CType(Me.pbJugador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJugador As Label
    Friend WithEvents pbJugador As PictureBox
    Friend WithEvents timerBlanco As Timer
    Friend WithEvents timerNegro As Timer
    Friend WithEvents lblBlanco As Label
    Friend WithEvents lblNegro As Label
    Friend WithEvents lbltblanco As Label
    Friend WithEvents Label1 As Label
End Class
