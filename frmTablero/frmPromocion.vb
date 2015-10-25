Public Class frmPromocion
    'Formulario que se llama cuando un peon llega al otro extremo del tablero, se le pasa la variable
    'color que solo puede dar dos valores
    Public Sub New(ByVal color As String)

        InitializeComponent()
        'Comprobamos el color del peon que promociona
        If color = "b" Then 'mostrara picture box de las piezas en blanco
            pbTorre.Load(Application.StartupPath & ("/images/torreB.png"))
            pbCaballo.Load(Application.StartupPath & ("/images/caballoB.png"))
            pbAlfil.Load(Application.StartupPath & ("/images/alfilB.png"))
            pbReina.Load(Application.StartupPath & ("/images/reinaB.png"))
        ElseIf color = "n" Then 'mostrara picture box de las piezas en negro
            pbTorre.Load(Application.StartupPath & ("/images/torreN.png"))
            pbCaballo.Load(Application.StartupPath & ("/images/caballoN.png"))
            pbAlfil.Load(Application.StartupPath & ("/images/alfilN.png"))
            pbReina.Load(Application.StartupPath & ("/images/reinaN.png"))
        End If

    End Sub
    'Seleccionamos el tipo de figura que queremos con radio button
    'La variable promo del tablero es pública y es la que utilizamos para decirle a que promocionar
    Private Sub btnPromocionar_Click(sender As Object, e As EventArgs) Handles btnPromocionar.Click
        If rbTorre.Checked Then
            frmTablero.promo = "torre"
        ElseIf rbAlfil.Checked
            frmTablero.promo = "alfil"
        ElseIf rbCaballo.Checked
            frmTablero.promo = "caballo"
        ElseIf rbReina.Checked
            frmTablero.promo = "reina"
        End If
        Me.Close()

    End Sub
End Class