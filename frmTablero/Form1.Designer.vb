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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTablero))
        Me.lblJugador = New System.Windows.Forms.Label()
        Me.pbJugador = New System.Windows.Forms.PictureBox()
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
        'frmTablero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 477)
        Me.Controls.Add(Me.pbJugador)
        Me.Controls.Add(Me.lblJugador)
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
End Class
