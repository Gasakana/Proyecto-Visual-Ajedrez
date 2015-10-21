Public Class frmPromocion

    Dim form As New frmTablero
    Private Sub frmPromocion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New(color As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If color = "b" Then
            pbTorre.Load(Application.StartupPath & ("/images/torreB.png"))
            pbCaballo.Load(Application.StartupPath & ("/images/caballoB.png"))
            pbAlfil.Load(Application.StartupPath & ("/images/alfilB.png"))
            pbReina.Load(Application.StartupPath & ("/images/reinaB.png"))
        ElseIf color = "n" Then
            pbTorre.Load(Application.StartupPath & ("/images/torreN.png"))
            pbCaballo.Load(Application.StartupPath & ("/images/caballoN.png"))
            pbAlfil.Load(Application.StartupPath & ("/images/alfilN.png"))
            pbReina.Load(Application.StartupPath & ("/images/reinaN.png"))
        End If

    End Sub

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