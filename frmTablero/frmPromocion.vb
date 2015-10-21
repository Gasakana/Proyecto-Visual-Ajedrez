Public Class frmPromocion

    Dim form As New frmTablero
    Private Sub frmPromocion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPromocionar_Click(sender As Object, e As EventArgs) Handles btnPromocionar.Click
        If rbTorre.Checked Then

        ElseIf rbAlfil.Checked

        ElseIf rbCaballo.Checked

        ElseIf rbReina.Checked

        End If
    End Sub
End Class