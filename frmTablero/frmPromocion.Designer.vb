<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromocion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbTorre = New System.Windows.Forms.PictureBox()
        Me.rbTorre = New System.Windows.Forms.RadioButton()
        Me.btnPromocionar = New System.Windows.Forms.Button()
        Me.pbAlfil = New System.Windows.Forms.PictureBox()
        Me.pbCaballo = New System.Windows.Forms.PictureBox()
        Me.pbReina = New System.Windows.Forms.PictureBox()
        Me.rbAlfil = New System.Windows.Forms.RadioButton()
        Me.rbCaballo = New System.Windows.Forms.RadioButton()
        Me.rbReina = New System.Windows.Forms.RadioButton()
        CType(Me.pbTorre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAlfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCaballo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Elija la figura a la que desea promocionar:"
        '
        'pbTorre
        '
        Me.pbTorre.Location = New System.Drawing.Point(84, 55)
        Me.pbTorre.Name = "pbTorre"
        Me.pbTorre.Size = New System.Drawing.Size(41, 42)
        Me.pbTorre.TabIndex = 1
        Me.pbTorre.TabStop = False
        '
        'rbTorre
        '
        Me.rbTorre.AutoSize = True
        Me.rbTorre.Location = New System.Drawing.Point(15, 64)
        Me.rbTorre.Name = "rbTorre"
        Me.rbTorre.Size = New System.Drawing.Size(50, 17)
        Me.rbTorre.TabIndex = 2
        Me.rbTorre.TabStop = True
        Me.rbTorre.Text = "Torre"
        Me.rbTorre.UseVisualStyleBackColor = True
        '
        'btnPromocionar
        '
        Me.btnPromocionar.Location = New System.Drawing.Point(14, 310)
        Me.btnPromocionar.Name = "btnPromocionar"
        Me.btnPromocionar.Size = New System.Drawing.Size(195, 36)
        Me.btnPromocionar.TabIndex = 3
        Me.btnPromocionar.Text = "Promocionar"
        Me.btnPromocionar.UseVisualStyleBackColor = True
        '
        'pbAlfil
        '
        Me.pbAlfil.Location = New System.Drawing.Point(84, 117)
        Me.pbAlfil.Name = "pbAlfil"
        Me.pbAlfil.Size = New System.Drawing.Size(41, 42)
        Me.pbAlfil.TabIndex = 4
        Me.pbAlfil.TabStop = False
        '
        'pbCaballo
        '
        Me.pbCaballo.Location = New System.Drawing.Point(84, 179)
        Me.pbCaballo.Name = "pbCaballo"
        Me.pbCaballo.Size = New System.Drawing.Size(41, 42)
        Me.pbCaballo.TabIndex = 5
        Me.pbCaballo.TabStop = False
        '
        'pbReina
        '
        Me.pbReina.Location = New System.Drawing.Point(84, 243)
        Me.pbReina.Name = "pbReina"
        Me.pbReina.Size = New System.Drawing.Size(41, 42)
        Me.pbReina.TabIndex = 6
        Me.pbReina.TabStop = False
        '
        'rbAlfil
        '
        Me.rbAlfil.AutoSize = True
        Me.rbAlfil.Location = New System.Drawing.Point(15, 127)
        Me.rbAlfil.Name = "rbAlfil"
        Me.rbAlfil.Size = New System.Drawing.Size(41, 17)
        Me.rbAlfil.TabIndex = 7
        Me.rbAlfil.TabStop = True
        Me.rbAlfil.Text = "Alfil"
        Me.rbAlfil.UseVisualStyleBackColor = True
        '
        'rbCaballo
        '
        Me.rbCaballo.AutoSize = True
        Me.rbCaballo.Location = New System.Drawing.Point(15, 190)
        Me.rbCaballo.Name = "rbCaballo"
        Me.rbCaballo.Size = New System.Drawing.Size(60, 17)
        Me.rbCaballo.TabIndex = 8
        Me.rbCaballo.TabStop = True
        Me.rbCaballo.Text = "Caballo"
        Me.rbCaballo.UseVisualStyleBackColor = True
        '
        'rbReina
        '
        Me.rbReina.AutoSize = True
        Me.rbReina.Location = New System.Drawing.Point(15, 254)
        Me.rbReina.Name = "rbReina"
        Me.rbReina.Size = New System.Drawing.Size(53, 17)
        Me.rbReina.TabIndex = 9
        Me.rbReina.TabStop = True
        Me.rbReina.Text = "Reina"
        Me.rbReina.UseVisualStyleBackColor = True
        '
        'frmPromocion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 358)
        Me.ControlBox = False
        Me.Controls.Add(Me.rbReina)
        Me.Controls.Add(Me.rbCaballo)
        Me.Controls.Add(Me.rbAlfil)
        Me.Controls.Add(Me.pbReina)
        Me.Controls.Add(Me.pbCaballo)
        Me.Controls.Add(Me.pbAlfil)
        Me.Controls.Add(Me.btnPromocionar)
        Me.Controls.Add(Me.rbTorre)
        Me.Controls.Add(Me.pbTorre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPromocion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promoción"
        CType(Me.pbTorre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAlfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCaballo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pbTorre As PictureBox
    Friend WithEvents rbTorre As RadioButton
    Friend WithEvents btnPromocionar As Button
    Friend WithEvents pbAlfil As PictureBox
    Friend WithEvents pbCaballo As PictureBox
    Friend WithEvents pbReina As PictureBox
    Friend WithEvents rbAlfil As RadioButton
    Friend WithEvents rbCaballo As RadioButton
    Friend WithEvents rbReina As RadioButton
End Class
