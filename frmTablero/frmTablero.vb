Imports System.ComponentModel

Public Class frmTablero

    'Variables globales, las que son publicas son accedidas por otros formularios
    Public temporizador As Boolean 'variable booleana que comprueba si el juego tendra temporizador o no
    Public minB, minN, segB, segN As Integer 'variables utilizadas para los minutos y segundos del temporizador de cada jugador
    Public promo As String 'variable utilizada para que en caso de promocion se determine a que pieza promociona el peón
    Dim reyblanco, reynegro, torreblanca1, torreblanca2, torrenegra1, torrenegra2 As Integer 'variables que determinan si las piezas que son necesarias para el enroque se han movido con anterioridad
    Dim jugadores As Integer 'variable que determina que jugador juega dependiendo de si es par o impar sera el turno de un jugador u otro
    Dim nCasillas(7, 7) As String 'Matriz de 8 x 8 de tipo String para comprobar los movimientos de las piezas los valores estan compuestos de color y tipo de pieza o xx en caso de no haber pieza
    Dim comprueba As Boolean 'Booleano que comprueba si el metodo click del tablero se refiere a la posicion inicial o a la final
    Dim ncolumnainicial, nfilainicial, ncolumnafinal, nfilafinal As Integer 'Variables donde se guarda el valor de la fila inicial/final y columna inicial/final
    Dim casillasPB(7, 7) As PictureBox 'Matriz de 8 x 8 de tipo PictureBox para colocar las casillas del tablero


    'Metodos/Eventos

    'Evento Load: Al cargar el formulario aparece el tablero de ajedrez coloreado 
    'y con las piezas de ambos jugadores colocadas

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'comprueba que modo de juego se ha elegido utilizando el valor de temporizador que le pasa frmTiempo
        If temporizador Then
            lblBlanco.Text = minB.ToString.PadLeft(2, "0") & ":00"
            lblNegro.Text = minN.ToString.PadLeft(2, "0") & ":00"
            timerBlanco.Start()
            timerNegro.Start()
            timerNegro.Enabled = False
        End If

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
                        nCasillas(filas, columnas) = "bp"
                    ElseIf columnas = 1 Then

                        'Colocamos y asignamos la identificación de los peones negros

                        casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/peonN.png"))
                        nCasillas(filas, columnas) = "np"


                    ElseIf columnas = 0 Then

                        'Colocamos y asignamos la identificación de las torres negras
                        If filas = 0 Or filas = 7 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/TorreN.png"))
                            nCasillas(filas, columnas) = "nt"
                        End If

                        'Colocamos y asignamos la identificación de los caballos negros
                        If filas = 1 Or filas = 6 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/caballoN.png"))
                            nCasillas(filas, columnas) = "nc"
                        End If

                        'Colocamos y asignamos la identificación de los alfiles negros
                        If filas = 2 Or filas = 5 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/alfilN.png"))
                            nCasillas(filas, columnas) = "na"
                        End If

                        'Colocamos y asignamos la identificación de la reina negra
                        If filas = 3 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/reinaN.png"))
                            nCasillas(filas, columnas) = "nr"
                        End If

                        'Colocamos y asignamos la identificación del rey negro
                        If filas = 4 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/reyN.png"))
                            nCasillas(filas, columnas) = "nR"
                        End If


                    ElseIf columnas = 7 Then

                        'Colocamos y asignamos la identificación de las torres blancas
                        If filas = 0 Or filas = 7 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/TorreB.png"))
                            nCasillas(filas, columnas) = "bt"
                        End If

                        'Colocamos y asignamos la identificación de los caballos blancos
                        If filas = 1 Or filas = 6 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/caballoB.png"))
                            nCasillas(filas, columnas) = "bc"
                        End If

                        'Colocamos y asignamos la identificación de los alfiles blancos
                        If filas = 2 Or filas = 5 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/alfilB.png"))
                            nCasillas(filas, columnas) = "ba"
                        End If

                        'Colocamos y asignamos la identificación de la reina blanca
                        If filas = 3 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/reinaB.png"))
                            nCasillas(filas, columnas) = "br"
                        End If

                        'Colocamos y asignamos la identificación del rey blanco
                        If filas = 4 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/reyB.png"))
                            nCasillas(filas, columnas) = "bR"
                        End If
                    Else
                        nCasillas(filas, columnas) = "xx"
                    End If

                    'Añadimos los controles de PictureBox en el formulario 
                    Me.Controls.Add(pb)
                    'Añadimos el manejador cuando vayas a hacer click e indicamos el método a ejecutar 
                    AddHandler pb.MouseClick, AddressOf moverFicha
                End With
            Next
        Next
    End Sub

    'Método a ejecutar en el manejador dependiendo donde hagas click podras o no mover una pieza
    Private Sub moverFicha(sender As Object, e As EventArgs)


        If (comprueba) Then 'usando este boolean comprobamos si se seleccionas la pieza por primera vez o si vas a intentar
            'mover una pieza ya seleccionada

            Dim movimientoFicha As Integer 'variable Integer que determinara si el movimiento es posible o no. Su valor puede ser 0,1 y 2(solo en caso del peon)
            'dependiendo de la variable ficha guarda el resultado del metodo mover de la clase pieza correspondiente

            ncolumnafinal = CInt(sender.name.ToString.Substring(0, 1)) 'extraemos la columna final en la que se va a colocar la pieza
            nfilafinal = CInt(sender.name.ToString.Substring(1, 1)) 'extraemos la fila final en la que se va a colocar la pieza


            Dim color As String = nCasillas(ncolumnainicial, nfilainicial).Substring(0, 1) 'variable que sirve para comprobar si es blanca o negra la pieza de no haber nada es x
            Dim ficha As String = nCasillas(ncolumnainicial, nfilainicial).Substring(1, 1) 'variable que sirve para comprobar el tipo de pieza de no haber nada es x
            'En lo referente a la torre...
            If ficha = "t" Then
                Dim torre As New Torre '

                movimientoFicha = torre.mover(nCasillas, nfilainicial, ncolumnainicial, nfilafinal, ncolumnafinal, color)
                If movimientoFicha = 0 Then
                    If color = "b" Then
                        If ncolumnainicial = 0 Then
                            torreblanca1 += 1
                        ElseIf ncolumnainicial = 7 Then
                            torreblanca2 += 1
                        End If
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/torreB.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                        If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                            MsgBox("Han ganado las blancas")
                            frmMenuPrincipal.Show()
                            Me.Close()
                        End If
                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "bt"
                    ElseIf color = "n" Then
                        If ncolumnainicial = 0 Then
                            torrenegra1 += 1
                        ElseIf ncolumnainicial = 7 Then
                            torrenegra2 += 1
                        End If
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/torreN.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                        If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                            MsgBox("Han ganado las negras")
                            frmMenuPrincipal.Show()
                            Me.Close()
                        End If
                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "nt"

                    End If

                Else
                    MsgBox("movimiento no permitido")
                    jugadores -= 1

                End If
                'En lo referente al peon...
            ElseIf ficha = "p" Then
                Dim peon As New Peon
                movimientoFicha = peon.mover(nCasillas, nfilainicial, ncolumnainicial, nfilafinal, ncolumnafinal, color)
                If movimientoFicha = 0 Then
                    If color = "b" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/peonB.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                        If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                            MsgBox("Han ganado las blancas")
                            frmMenuPrincipal.Show()
                            Me.Close()
                        End If
                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "bp"
                    ElseIf color = "n" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/peonN.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                        If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                            MsgBox("Han ganado las negras")
                            frmMenuPrincipal.Show()
                            Me.Close()
                        End If
                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "np"


                    End If
                    'Esto solo se da cuando promociona, se contempla que se pueda ganar la partida con el peon a la vez que promociona
                ElseIf movimientoFicha = 2 Then
                    Dim frmpromo As New frmPromocion(color)
                    frmpromo.ShowDialog()
                    If color = "b" Then
                        If promo = "torre" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/torreB.png"))
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                            If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                                MsgBox("Han ganado las blancas")
                                frmMenuPrincipal.Show()
                                Me.Close()
                            End If
                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "bt"
                        ElseIf promo = "alfil" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/alfilB.png"))
                            If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                                MsgBox("Han ganado las blancas")
                                frmMenuPrincipal.Show()
                                Me.Close()
                            End If
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "ba"
                        ElseIf promo = "caballo" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/caballoB.png"))
                            If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                                MsgBox("Han ganado las blancas")
                                frmMenuPrincipal.Show()
                                Me.Close()
                            End If
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "bc"
                        ElseIf promo = "reina" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reinaB.png"))
                            If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                                MsgBox("Han ganado las blancas")
                                frmMenuPrincipal.Show()
                                Me.Close()
                            End If
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "br"
                        End If
                    ElseIf color = "n" Then
                        If promo = "torre" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/torreN.png"))
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                            If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                                MsgBox("Han ganado las negras")
                                frmMenuPrincipal.Show()
                                Me.Close()
                            End If
                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "nt"
                        ElseIf promo = "alfil" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/alfilN.png"))
                            If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                                MsgBox("Han ganado las negras")
                                frmMenuPrincipal.Show()
                                Me.Close()
                            End If
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "na"
                        ElseIf promo = "caballo" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/caballoN.png"))
                            If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                                MsgBox("Han ganado las negras")
                                frmMenuPrincipal.Show()
                                Me.Close()
                            End If
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "nc"
                        ElseIf promo = "reina" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reinaN.png"))
                            If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                                MsgBox("Han ganado las negras")
                                frmMenuPrincipal.Show()
                                Me.Close()
                            End If
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "nr"
                        End If
                    End If

                Else
                    MsgBox("movimiento no permitido")
                    jugadores -= 1
                End If
                'Lo referente al caballo
            ElseIf ficha = "c" Then
                Dim caballo As New Caballo
                movimientoFicha = caballo.mover(nCasillas, nfilainicial, ncolumnainicial, nfilafinal, ncolumnafinal, color)

                If movimientoFicha = 0 Then


                    If nCasillas(ncolumnainicial, nfilainicial) = "bc" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/caballoB.png"))
                        If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                            MsgBox("Han ganado las blancas")
                            frmMenuPrincipal.Show()
                            Me.Close()
                        End If
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "bc"
                    ElseIf color = "n" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/caballoN.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                        If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                            MsgBox("Han ganado las negras")
                            frmMenuPrincipal.Show()
                            Me.Close()
                        End If
                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "nc"
                    End If
                Else
                    MsgBox("movimiento no permitido")
                    jugadores -= 1
                End If



                'En lo referente al Rey
            ElseIf ficha = "R" Then
                Dim rey As New Rey
                movimientoFicha = rey.mover(nCasillas, nfilainicial, ncolumnainicial, nfilafinal, ncolumnafinal, color)

                'Para realizar el enroque habrá que decirle al rey que se mueva dos pasos a la izquierda o derecha de su posicion inicial
                'Comprobamos si se cumplen todas las condiciones para que se pueda realizar, tanto si se puede realizar como si no mostrará un mensaje

                'Enroque largo blanco
                If (ncolumnafinal = 2 And nfilafinal = 7) And reyblanco = 0 Then
                    If torreblanca1 = 0 And nCasillas(ncolumnafinal - 2, nfilafinal) = "bt" Then
                        If nCasillas(ncolumnafinal, nfilafinal) = "xx" And nCasillas(ncolumnafinal + 1, nfilafinal) = "xx" And nCasillas(ncolumnafinal - 1, nfilafinal) = "xx" Then
                            reyblanco += 1
                            torreblanca1 += 1
                            MsgBox("enroque")
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "bR"
                            nCasillas(ncolumnafinal - 2, nfilafinal) = "xx"
                            casillasPB(ncolumnafinal - 2, nfilafinal).Image = Nothing
                            nCasillas(ncolumnafinal + 1, nfilafinal) = "bt"
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reyB.png"))
                            casillasPB(ncolumnafinal + 1, nfilafinal).Load(Application.StartupPath & ("/images/torreB.png"))
                        Else
                            MsgBox("enroque no permitido")
                            jugadores -= 1
                        End If


                    End If
                    'Enroque corto blanco
                ElseIf (ncolumnafinal = 6 And nfilafinal = 7) And reyblanco = 0 Then
                    If torreblanca2 = 0 And nCasillas(ncolumnafinal + 1, nfilafinal) = "bt" Then
                        If nCasillas(ncolumnafinal, nfilafinal) = "xx" And nCasillas(ncolumnafinal - 1, nfilafinal) = "xx" Then
                            reyblanco += 1
                            torreblanca2 += 1
                            MsgBox("enroque")
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "bR"
                            nCasillas(ncolumnafinal + 1, nfilafinal) = "xx"
                            casillasPB(ncolumnafinal + 1, nfilafinal).Image = Nothing
                            nCasillas(ncolumnafinal - 1, nfilafinal) = "bt"
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reyB.png"))
                            casillasPB(ncolumnafinal - 1, nfilafinal).Load(Application.StartupPath & ("/images/torreB.png"))
                        Else
                            MsgBox("enroque no permitido")
                            jugadores -= 1
                        End If

                    End If
                    'Enroque largo negro
                ElseIf (ncolumnafinal = 2 And nfilafinal = 0) And reynegro = 0 Then
                    If torrenegra1 = 0 And nCasillas(ncolumnafinal - 2, nfilafinal) = "nt" Then
                        If nCasillas(ncolumnafinal, nfilafinal) = "xx" And nCasillas(ncolumnafinal + 1, nfilafinal) = "xx" And nCasillas(ncolumnafinal - 1, nfilafinal) = "xx" Then
                            reynegro += 1
                            torrenegra1 += 1
                            MsgBox("enroque")
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "nR"
                            nCasillas(ncolumnafinal - 2, nfilafinal) = "xx"
                            casillasPB(ncolumnafinal - 2, nfilafinal).Image = Nothing
                            nCasillas(ncolumnafinal + 1, nfilafinal) = "nt"
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reyN.png"))
                            casillasPB(ncolumnafinal + 1, nfilafinal).Load(Application.StartupPath & ("/images/torreN.png"))
                        Else
                            MsgBox("enroque no permitido")
                            jugadores -= 1
                        End If

                    End If
                    'Enroque corto negro
                ElseIf (ncolumnafinal = 6 And nfilafinal = 0) And reynegro = 0 Then
                    If torrenegra2 = 0 And nCasillas(ncolumnafinal + 1, nfilafinal) = "nt" Then
                        If nCasillas(ncolumnafinal, nfilafinal) = "xx" And nCasillas(ncolumnafinal - 1, nfilafinal) = "xx" Then
                            reynegro += 1
                            torrenegra2 += 1
                            MsgBox("enroque")
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "nR"
                            nCasillas(ncolumnafinal + 1, nfilafinal) = "xx"
                            casillasPB(ncolumnafinal + 1, nfilafinal).Image = Nothing
                            nCasillas(ncolumnafinal - 1, nfilafinal) = "nt"
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reyN.png"))
                            casillasPB(ncolumnafinal - 1, nfilafinal).Load(Application.StartupPath & ("/images/torreN.png"))
                        Else
                            MsgBox("enroque no permitido")
                            jugadores -= 1
                        End If

                    End If


                ElseIf movimientoFicha = 0 Then

                    'El movimiento del rey
                    If color = "b" Then
                        reyblanco += 1
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reyB.png"))
                        If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                            MsgBox("Han ganado las blancas")
                            frmMenuPrincipal.Show()
                            Me.Close()
                        End If
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "bR"
                    ElseIf color = "n" Then
                        reynegro += 1
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reyN.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                        If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                            MsgBox("Han ganado las negras")
                            frmMenuPrincipal.Show()
                            Me.Close()
                        End If
                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "nR"
                    End If
                Else
                    MsgBox("movimiento no permitido")
                    jugadores -= 1
                End If


                'En referente a la reina
            ElseIf ficha = "r" Then
                Dim reina As New Reina
                movimientoFicha = reina.mover(nCasillas, nfilainicial, ncolumnainicial, nfilafinal, ncolumnafinal, color)

                If movimientoFicha = 0 Then
                    If nCasillas(ncolumnainicial, nfilainicial) = "br" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reinaB.png"))
                        If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                            MsgBox("Han ganado las blancas")
                            frmMenuPrincipal.Show()
                            Me.Close()
                        End If
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "br"
                    ElseIf color = "n" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reinaN.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                        If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                            MsgBox("Han ganado las negras")
                            frmMenuPrincipal.Show()
                            Me.Close()
                        End If
                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "nr"
                    End If
                Else
                    MsgBox("movimiento no permitido")
                    jugadores -= 1
                End If



                'En lo que concierne al alfil
            ElseIf ficha = "a" Then
                Dim alfil As New Alfil
                movimientoFicha = alfil.mover(nCasillas, nfilainicial, ncolumnainicial, nfilafinal, ncolumnafinal, color)

                If movimientoFicha = 0 Then
                    If nCasillas(ncolumnainicial, nfilainicial) = "ba" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/alfilB.png"))
                        If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                            MsgBox("Han ganado las blancas")
                            frmMenuPrincipal.Show()
                            Me.Close()
                        End If
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "ba"
                    ElseIf color = "n" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/alfilN.png"))
                        If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                            MsgBox("Han ganado las negras")
                            frmMenuPrincipal.Show()
                            Me.Close()
                        End If
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing
                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "na"
                    End If
                Else
                    MsgBox("movimiento no permitido")
                    jugadores -= 1
                End If

            End If
            If jugadores Mod 2 = 0 Then
                pbJugador.Load(Application.StartupPath & ("/images/colorB.png"))
                If temporizador Then
                    timerNegro.Enabled = False
                    timerBlanco.Enabled = True
                End If


            Else
                pbJugador.Load(Application.StartupPath & ("/images/colorN.png"))
                If temporizador Then
                    timerBlanco.Enabled = False
                    timerNegro.Enabled = True
                End If

            End If


            comprueba = False 'se restablece comprobar a false para el siguiente uso
        Else

            ncolumnainicial = CInt(sender.name.ToString.Substring(0, 1)) 'extraemos la columna actual donde esta colocada la pieza
            nfilainicial = CInt(sender.name.ToString.Substring(1, 1)) 'extraemos la fila actual donde esta colocada la pieza
            If nCasillas(ncolumnainicial, nfilainicial) = "xx" Then 'si la casilla está vacia...
                'MsgBox("no puedes hacer nada")
            ElseIf jugadores Mod 2 = 0 Then
                If nCasillas(ncolumnainicial, nfilainicial).ToString.Substring(0, 1) = "b" Then

                    comprueba = True
                    jugadores += 1
                Else
                    MsgBox("turno de las blancas")
                End If
            ElseIf jugadores Mod 2 <> 0 Then
                If nCasillas(ncolumnainicial, nfilainicial).ToString.Substring(0, 1) = "n" Then

                    comprueba = True
                    jugadores += 1
                Else
                    MsgBox("turno de las negras")
                End If
            Else

            End If
        End If

    End Sub
    'Gestion de los cronometros de cada jugador, aquel que llegue a 0 le dara la victoria al otro jugador
    Private Sub timerBlanco_Tick(sender As Object, e As EventArgs) Handles timerBlanco.Tick
        If minB > 0 Or segB > 0 Then
            lblBlanco.Text = minB.ToString.PadLeft(2, "0") & ":" & segB.ToString.PadLeft(2, "0")
            segB -= 1
            If segB <= 0 And minB <> 0 Then
                segB = 59
                minB -= 1
            End If
        Else
            lblBlanco.Text = minB.ToString.PadLeft(2, "0") & ":" & segB.ToString.PadLeft(2, "0")
            timerBlanco.Stop()
            MsgBox("Se acabó el tiempo, Negras ganan")

            End
        End If
    End Sub

    Private Sub timerNegro_Tick(sender As Object, e As EventArgs) Handles timerNegro.Tick
        If minN > 0 Or segN > 0 Then
            lblNegro.Text = minN.ToString.PadLeft(2, "0") & ":" & segN.ToString.PadLeft(2, "0")
            segN -= 1
            If segN < 0 And minN <> 0 Then
                segN = 59
                minN -= 1
            End If
        Else
            lblNegro.Text = minN.ToString.PadLeft(2, "0") & ":" & segN.ToString.PadLeft(2, "0")
            timerNegro.Stop()
            MsgBox("Se acabó el tiempo, Blancas ganan")
            End
        End If
    End Sub
End Class