Public Class frmTiempo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If rb5.Checked Then
            frmTablero.temporizador = True
            frmTablero.minB = 5
            frmTablero.minN = 5
        ElseIf rb10.Checked
            frmTablero.temporizador = True
            frmtablero.minB = 10
            frmtablero.minN = 10
        ElseIf rb20.Checked
            frmTablero.temporizador = True
            frmtablero.minB = 20
            frmtablero.minN = 20
        ElseIf rb0.Checked
            frmTablero.temporizador = False
        End If

        frmtablero.Show()
        Me.Close()

    End Sub

    Private Sub frmTiempo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class