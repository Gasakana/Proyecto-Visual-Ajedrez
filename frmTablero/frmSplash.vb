Public Class frmSplash

    Private Sub tmFundirse_Tick(sender As Object, e As EventArgs) Handles tmFundirse.Tick
        Me.Opacity = Me.Opacity + 0.01
        If Me.Opacity = 1 Then
            tmFundirse.Enabled = False
            tmTiempo.Enabled = True
        End If
    End Sub

    Private Sub tmDesaparicion_Tick(sender As Object, e As EventArgs) Handles tmDesaparicion.Tick
        Me.Opacity = Me.Opacity - 0.01
        If Me.Opacity < 0.01 Then
            frmMenuPrincipal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub tmTiempo_Tick(sender As Object, e As EventArgs) Handles tmTiempo.Tick
        tmDesaparicion.Enabled = True
        tmFundirse.Enabled = False
    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class