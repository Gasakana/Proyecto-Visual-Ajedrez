'Formulario que se muestra como una pantalla de bienvenida al juego con un efecto de aparación y desaparición suaves
Public Class frmSplash

    'Evento del Timer para realizar el efecto de aparición

    'Inicialmente el Timer está habilitado y la opacidad del formulario es de 0%, 
    'por lo tanto se le va añadiendo 0.01 de opacidad cada 10 milisegundos hasta llegar a 1 que es el 100%.

    'Una vez llegue a 1, deshabilitamos el Timer de aparición y habilitamos el Timer del tiempo que va a mostrarse el Splash. 
    Private Sub tmFundirse_Tick(sender As Object, e As EventArgs) Handles tmFundirse.Tick
        Me.Opacity = Me.Opacity + 0.01
        If Me.Opacity = 1 Then
            tmFundirse.Enabled = False
            tmTiempo.Enabled = True
        End If
    End Sub

    'Evento del Timer para realizar el efecto de la desaparición

    'Inicialmente el Timer está deshabilitado (se habilita en el evento del Timer de demostración del Splash) y la opacidad del formulario es de 100%, 
    'por lo tanto se le va quitando 0.01 de opacidad cada 10 milisegundos hasta llegar a 0 que es el 0%.

    'Una vez llegue a 0, mostramos el formulario del menú del juego y cerramos el Splash. 
    Private Sub tmDesaparicion_Tick(sender As Object, e As EventArgs) Handles tmDesaparicion.Tick
        Me.Opacity = Me.Opacity - 0.01
        If Me.Opacity < 0.01 Then
            frmMenuPrincipal.Show()
            Me.Close()
        End If
    End Sub

    'Evento del Timer para realizar la demostración del Splash durante tres segundos

    'Habilitamos el Timer del efecto de desaparición y deshabilitamos el Timer del efecto aparición.

    Private Sub tmTiempo_Tick(sender As Object, e As EventArgs) Handles tmTiempo.Tick
        tmDesaparicion.Enabled = True
        tmFundirse.Enabled = False
    End Sub

End Class