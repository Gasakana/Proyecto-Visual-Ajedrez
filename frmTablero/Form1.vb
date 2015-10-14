Public Class frmTablero

    'Variables globales

    Dim nCasillas(7, 7) As Integer 'Matriz de 8 x 8 de tipo Integer para comprobar los movimientos de las piezas
    Dim comprueba As Boolean 'Booleano que comprueba la casilla inicial y la casilla final en la que se encuentra la pieza seleccionada
    Dim ncolumnainicial, nfilainicial, ncolumnafinal, nfilafinal As Integer 'Variables donde se guarda el valor de la fila inicial/final y columna inicial/final
    Dim casillasPB(7, 7) As PictureBox 'Matriz de 8 x 8 de tipo PictureBox para colocar las casillas del tablero

    'Metodos/Eventos

    'Evento Load: Al cargar el formulario aparece el tablero de ajedrez coloreado 
    'y con las piezas de ambos jugadores colocadas

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim filas As Integer 'Variable de tipo Integer, el cual se usa para crear el número de filas del tablero
        Dim columnas As Integer 'Variable de tipo Integer, el cual se usa para crear el número de columnas del tablero 

        'Bucle anidado para crear las filas y columnas del tablero
        For filas = 0 To 7
            For columnas = 0 To 7
                Dim pb As New PictureBox 'Variable de tipo PictureBox que sirve para reflejar cada casilla del tablero
                casillasPB(filas, columnas) = pb 'En la matriz de PictureBox, especificamos las distintas posiciones (filas y columnas) en las que almacenaremos los PictureBox para formar las casillas

                'Añadimos las distintas propiedades a los PictureBox
                With pb
                    .Size = New System.Drawing.Size(60, 60) 'Tamaño
                    .BorderStyle = BorderStyle.FixedSingle 'Borde
                    .Location = New System.Drawing.Point(60 * filas, 60 * columnas) 'Posicionamiento
                    .SizeMode = PictureBoxSizeMode.StretchImage 'Tamaño de las imágenes de las piezas
                    .Name = filas & columnas 'Nombre
                    .Tag = "0"

                    'Coloreamos las filas/columnas pares de un color y las filas/columnas impares de otro

                    'columna par
                    If columnas Mod 2 = 0 Then
                        'fila par
                        If filas Mod 2 = 0 Then
                            pb.BackColor = Color.Bisque
                            'fila impar
                        Else
                            pb.BackColor = Color.SaddleBrown
                        End If
                        'columna impar
                    ElseIf columnas Mod 2 = 1 Then
                        'fila par
                        If filas Mod 2 = 0 Then
                            pb.BackColor = Color.SaddleBrown
                            'fila impar
                        Else
                            pb.BackColor = Color.Bisque
                        End If
                    End If

                    'Colocamos inicialmente las piezas de ambos colores en sus casillas correspondientes
                    'y le asignamos una identificación de dos dígitos: primer digito: Color, segundo dígito: Pieza

                    'Colocamos y asignamos la identificación de los peones blancos
                    If columnas = 6 Then
                        casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/peonB.png"))
                        nCasillas(filas, columnas) = 11
                    End If

                    'Colocamos y asignamos la identificación de los peones negros
                    If columnas = 1 Then
                        casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/peonN.png"))
                        nCasillas(filas, columnas) = 21
                    End If

                    If columnas = 0 Then

                        'Colocamos y asignamos la identificación de las torres negras
                        If filas = 0 Or filas = 7 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/TorreN.png"))
                            nCasillas(filas, columnas) = 22
                        End If

                        'Colocamos y asignamos la identificación de los caballos negros
                        If filas = 1 Or filas = 6 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/caballoN.png"))
                            nCasillas(filas, columnas) = 23
                        End If

                        'Colocamos y asignamos la identificación de los alfiles negros
                        If filas = 2 Or filas = 5 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/alfilN.png"))
                            nCasillas(filas, columnas) = 24
                        End If

                        'Colocamos y asignamos la identificación de la reina negra
                        If filas = 3 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/reinaN.png"))
                            nCasillas(filas, columnas) = 25
                        End If

                        'Colocamos y asignamos la identificación del rey negro
                        If filas = 4 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/reyN.png"))
                            nCasillas(filas, columnas) = 26
                        End If
                    End If

                    If columnas = 7 Then

                        'Colocamos y asignamos la identificación de las torres blancas
                        If filas = 0 Or filas = 7 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/TorreB.png"))
                            nCasillas(filas, columnas) = 12
                        End If

                        'Colocamos y asignamos la identificación de los caballos blancos
                        If filas = 1 Or filas = 6 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/caballoB.png"))
                            nCasillas(filas, columnas) = 13
                        End If

                        'Colocamos y asignamos la identificación de los alfiles blancos
                        If filas = 2 Or filas = 5 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/alfilB.png"))
                            nCasillas(filas, columnas) = 14
                        End If

                        'Colocamos y asignamos la identificación de la reina blanca
                        If filas = 3 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/reinaB.png"))
                            nCasillas(filas, columnas) = 15
                        End If

                        'Colocamos y asignamos la identificación del rey blanco
                        If filas = 4 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/reyB.png"))
                            nCasillas(filas, columnas) = 16
                        End If
                    End If

                    'Añadimos los controles de PictureBox en el formulario 
                    Me.Controls.Add(pb)
                    'Añadimos el manejador cuando vayas a hacer click e indicamos el método a ejecutar 
                    AddHandler pb.MouseClick, AddressOf moverFicha
                End With
            Next
        Next
    End Sub

    'Método a ejecutar en el manejador
    Private Sub moverFicha(sender As Object, e As EventArgs)


        If (comprueba) Then 'usando este boolean utilizamos el mismo metodo para la inicial y la final
            Dim torre As New Torre
            Dim alfil As New Alfil
            Dim movimientoTorre As Integer
            Dim movimientoAlfil As Integer

            ncolumnafinal = CInt(sender.name.ToString.Substring(0, 1)) 'extraemos la columna final en la que se va a colocar la pieza
            nfilafinal = CInt(sender.name.ToString.Substring(1, 1)) 'extraemos la fila final en la que se va a colocar la pieza
            MsgBox(ncolumnafinal & nfilafinal & "segundo")
            movimientoTorre = torre.mover(nCasillas, nfilainicial, ncolumnainicial, nfilafinal, ncolumnafinal)
            movimientoAlfil = alfil.mover(nCasillas, nfilainicial, ncolumnainicial, nfilafinal, ncolumnafinal)
            MsgBox(movimientoAlfil)
            If movimientoTorre = 0 Then
                If nCasillas(ncolumnainicial, nfilainicial) = 12 Then
                    casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/peonB.png"))
                    casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                    nCasillas(ncolumnainicial, nfilainicial) = 0
                    nCasillas(ncolumnafinal, nfilafinal) = 12

                End If
            End If


            If movimientoAlfil = 0 Then
                If nCasillas(ncolumnainicial, nfilainicial) = 21 Then
                    casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/peonN.png"))
                    casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                    nCasillas(ncolumnainicial, nfilainicial) = 0
                    nCasillas(ncolumnafinal, nfilafinal) = 21

                End If

            End If


            comprueba = False 'se restablece comprobar a false para el siguiente uso
        Else
            MsgBox(sender.name)
            ncolumnainicial = CInt(sender.name.ToString.Substring(0, 1)) 'extraemos la columna actual donde esta colocada la pieza
            nfilainicial = CInt(sender.name.ToString.Substring(1, 1)) 'extraemos la fila actual donde esta colocada la pieza
            If nCasillas(ncolumnainicial, nfilainicial) = 0 Then 'si la casilla está vacia...
                MsgBox("no puedes hacer nada")
            Else
                MsgBox("funciona")
                If nCasillas(ncolumnainicial, nfilainicial) = 12 Then 'se lo he asignado al peon para mejor comprobacion
                    comprueba = True
                End If
                If nCasillas(ncolumnainicial, nfilainicial) = 21 Then 'se lo he asignado al peon para mejor comprobacion
                    comprueba = True
                End If

            End If
        End If
    End Sub


    Private Function comprobarFila(ByVal fila As Integer) As Integer
        For y = 0 To 7
            If nCasillas(fila, y) = 1 Then
                Return 1
            End If
        Next
        Return 0
    End Function

    Private Function comprobarColumna(ByVal columna As Integer) As Integer
        For x = 0 To 7
            If nCasillas(x, columna) = 1 Then
                Return 1
            End If
        Next
        Return 0
    End Function

    Private Function comprobarDiagIzq(ByVal fila As Integer, ByVal columna As Integer)
        'diagonal hacia abajo
        For i = 0 To 7
            If (fila >= 0 And fila < 7) And (columna >= 0 And columna < 7) Then
                columna += 1
                fila += 1
                If nCasillas(fila, columna) = 1 Then
                    Return 1
                End If
            End If
        Next

        'diagonal hacia arriba
        For i = 0 To 7
            If (fila > 0 And fila <= 7) And (columna > 0 And columna <= 7) Then
                columna -= 1
                fila -= 1
                If (nCasillas(fila, columna) = 1) Then
                    Return 1
                End If
            End If
        Next
        Return 0
    End Function

    Private Function comprobarDiagDrch(ByVal fila As Integer, ByVal columna As Integer)
        'diagonal hacia arriba
        For i = 0 To 7
            If (fila >= 0 And fila < 7) And (columna > 0 And columna <= 7) Then
                columna -= 1
                fila += 1
                If nCasillas(fila, columna) = 1 Then
                    Return 1
                End If
            End If
        Next

        'diagonal hacia abajo
        For i = 0 To 7
            If (fila > 0 And fila <= 7) And (columna >= 0 And columna < 7) Then
                columna += 1
                fila -= 1
                If nCasillas(fila, columna) = 1 Then
                    Return 1
                End If
            End If
        Next
        Return 0
    End Function
End Class