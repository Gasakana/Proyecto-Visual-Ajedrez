Public Class frmTiempo
    'formulario que se llama desde frmprincipal nos permite seleccionar si quieres temporizador
    'y cuanto tiempo quieres en él
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '5 minutos
        If rb5.Checked Then
            frmTablero.temporizador = True
            frmTablero.minB = 5
            frmTablero.minN = 5
            '10 minutos
        ElseIf rb10.Checked
            frmTablero.temporizador = True
            frmTablero.minB = 10
            frmTablero.minN = 10
            '20 minutos
        ElseIf rb20.Checked
            frmTablero.temporizador = True
            frmTablero.minB = 20
            frmTablero.minN = 20
            'sin temporizador
        ElseIf rb0.Checked
            frmTablero.temporizador = False
        End If

        frmTablero.Show()
        Me.Close()

    End Sub
End Class