'Formulario que muestra el menú principal del Juego
Public Class frmMenuPrincipal
    'Evento que se acciona al pasar el ratón por encima del botón jugar, cambiando la imagen a un estado de selección 
    Private Sub pbJugar_MouseHover(sender As Object, e As EventArgs) Handles pbJugar.MouseHover
        pbJugar.Load(Application.StartupPath & ("/images/jugarHover.png"))
    End Sub

    'Evento que se acciona al quitar el ratón del botón jugar, cambiando la imagen a un estado de no seleccionado
    Private Sub pbJugar_MouseLeave(sender As Object, e As EventArgs) Handles pbJugar.MouseLeave
        pbJugar.Load(Application.StartupPath & ("/images/jugarLeave.png"))
    End Sub

    'Evento que se acciona al pasar el ratón por encima del botón salir, cambiando la imagen a un estado de selección 
    Private Sub pbSalir_MouseHover(sender As Object, e As EventArgs) Handles pbSalir.MouseHover
        pbSalir.Load(Application.StartupPath & ("/images/salirHover.png"))
    End Sub

    'Evento que se acciona al quitar el ratón del botón salir, cambiando la imagen a un estado de no seleccionado
    Private Sub pbSalir_MouseLeave(sender As Object, e As EventArgs) Handles pbSalir.MouseLeave
        pbSalir.Load(Application.StartupPath & ("/images/salirLeave.png"))
    End Sub

    'Evento que se acciona al pulsar el botón salir, para preguntar al usuario si desea salir del juego
    Private Sub pbSalir_Click(sender As Object, e As EventArgs) Handles pbSalir.Click

        Dim resp As String 'Variable que guarda la respuesta que vaya a dar el usuario 

        'Guarda el valor que muestra el MsgBox 
        resp = MsgBox("¿Desea salir del juego?", MsgBoxStyle.YesNo, "Salir del juego")

        'Comprueba el valor de la respuesta para salir del juego
        'Si la respuesta es Sí, finaliza el juego y si es No, sigue mostrándose el formulario del menú   
        If (resp = 6) Then
            End
        Else
            Me.Show()
        End If
    End Sub

    'Evento que se acciona al mantener pulsado el botón jugar, cambiando la imagen a un estado de presionado
    Private Sub pbJugar_MouseDown(sender As Object, e As MouseEventArgs) Handles pbJugar.MouseDown
        pbJugar.Load(Application.StartupPath & ("/images/jugarHun.png"))
    End Sub

    'Evento que se acciona al dejar de mantener pulsado el botón jugar, cambiando la imagen a un estado de no presionado
    Private Sub pbJugar_MouseUp(sender As Object, e As MouseEventArgs) Handles pbJugar.MouseUp
        pbJugar.Load(Application.StartupPath & ("/images/jugarHover.png"))
    End Sub

    'Evento que se acciona al mantener pulsado el botón salir, cambiando la imagen a un estado de presionado
    Private Sub pbSalir_MouseDown(sender As Object, e As MouseEventArgs) Handles pbSalir.MouseDown
        pbSalir.Load(Application.StartupPath & ("/images/salirHun.png"))
    End Sub

    'Evento que se acciona al dejar de mantener pulsado el botón salir, cambiando la imagen a un estado de no presionado
    Private Sub pbSalir_MouseUp(sender As Object, e As MouseEventArgs) Handles pbSalir.MouseUp
        pbSalir.Load(Application.StartupPath & ("/images/salirHover.png"))
    End Sub

    'Evento que se acciona al pulsar el botón jugar, para mostrar un formulario donde el usuario selecciona el tiempo del turno que vayan a tener ambos 
    'y cierra el formulario del menú
    Private Sub pbJugar_Click(sender As Object, e As EventArgs) Handles pbJugar.Click
        frmTiempo.Show()
        Me.Close()
    End Sub
End Class
