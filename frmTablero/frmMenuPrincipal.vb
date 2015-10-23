Public Class frmMenuPrincipal
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    mostrarSplash()
    'End Sub

    'Private Sub mostrarSplash()
    '    Me.Hide()
    '    frmSplash.ShowDialog()
    'End Sub

    Private Sub pbJugar_MouseHover(sender As Object, e As EventArgs) Handles pbJugar.MouseHover
        pbJugar.Load(Application.StartupPath & ("/images/jugarHover.png"))

    End Sub

    Private Sub pbJugar_MouseLeave(sender As Object, e As EventArgs) Handles pbJugar.MouseLeave
        pbJugar.Load(Application.StartupPath & ("/images/jugarLeave.png"))

    End Sub

    Private Sub pbSalir_MouseHover(sender As Object, e As EventArgs) Handles pbSalir.MouseHover
        pbSalir.Load(Application.StartupPath & ("/images/salirHover.png"))

    End Sub

    Private Sub pbSalir_MouseLeave(sender As Object, e As EventArgs) Handles pbSalir.MouseLeave
        pbSalir.Load(Application.StartupPath & ("/images/salirLeave.png"))
    End Sub


    'ESTO ES LO QUE HE AÑADIDO

    Private Sub pbSalir_Click(sender As Object, e As EventArgs) Handles pbSalir.Click

        Dim resp As String
        resp = MsgBox("¿Desea salir del programa?", MsgBoxStyle.YesNo, "Salir del juego")
        If (resp = 6) Then
            End
        Else
            Me.Show()
        End If

    End Sub

    Private Sub pbJugar_MouseDown(sender As Object, e As MouseEventArgs) Handles pbJugar.MouseDown
        pbJugar.Load(Application.StartupPath & ("/images/jugarHun.png"))
    End Sub

    Private Sub pbJugar_MouseUp(sender As Object, e As MouseEventArgs) Handles pbJugar.MouseUp
        pbJugar.Load(Application.StartupPath & ("/images/jugarHover.png"))

    End Sub

    Private Sub pbSalir_MouseDown(sender As Object, e As MouseEventArgs) Handles pbSalir.MouseDown
        pbSalir.Load(Application.StartupPath & ("/images/salirHun.png"))

    End Sub

    Private Sub pbSalir_MouseUp(sender As Object, e As MouseEventArgs) Handles pbSalir.MouseUp
        pbSalir.Load(Application.StartupPath & ("/images/salirHover.png"))
    End Sub

    Private Sub pbJugar_Click(sender As Object, e As EventArgs) Handles pbJugar.Click
        frmTiempo.Show()
        Me.Close()
    End Sub
End Class
