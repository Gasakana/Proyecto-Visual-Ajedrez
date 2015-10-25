Imports System.ComponentModel

Public Class frmTablero

    'Variables globales, las que son publicas son accedidas por otros formularios

    Public temporizador As Boolean 'Variable booleana que comprueba si el juego tendra temporizador o no
    Public minB, minN, segB, segN As Integer 'Variables utilizadas para los minutos y segundos del temporizador de cada jugador
    Public promo As String 'Variable utilizada para que en caso de promoción se determine a que pieza promociona el peón
    Dim reyblanco, reynegro, torreblanca1, torreblanca2, torrenegra1, torrenegra2 As Integer 'Variables que determinan si las piezas que son necesarias para el enroque se han movido con anterioridad
    Dim jugadores As Integer 'Variable que determina que jugador juega dependiendo de si es par o impar sera el turno de un jugador u otro
    Dim nCasillas(7, 7) As String 'Matriz de 8 x 8 de tipo String para comprobar los movimientos de las piezas los valores estan compuestos de color y tipo de pieza o xx en caso de no haber pieza
    Dim comprueba As Boolean 'Boolean que comprueba si el metodo click del tablero se refiere a la posicion inicial o a la final
    Dim ncolumnainicial, nfilainicial, ncolumnafinal, nfilafinal As Integer 'Variables donde se guarda el valor de la fila inicial/final y columna inicial/final
    Dim casillasPB(7, 7) As PictureBox 'Matriz de 8 x 8 de tipo PictureBox para colocar las casillas del tablero


    'CREACIÓN DEL TABLERO

    'Evento Load: Al cargar el formulario aparece el tablero de ajedrez coloreado 
    'y con las piezas de ambos jugadores colocadas

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Comprueba que modo de juego se ha elegido utilizando el valor de temporizador que le pasa frmTiempo
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
                    .Size = New System.Drawing.Size(80, 80) 'Tamaño
                    .BorderStyle = BorderStyle.FixedSingle 'Borde
                    .Location = New System.Drawing.Point(80 * filas, 80 * columnas) 'Posicionamiento
                    .SizeMode = PictureBoxSizeMode.StretchImage 'Tamaño de las imágenes de las piezas
                    .Name = filas & columnas 'Nombre

                    'Coloreamos las filas/columnas pares de un color y las filas/columnas impares de otro

                    'Columna par
                    If columnas Mod 2 = 0 Then
                        'Fila par
                        If filas Mod 2 = 0 Then
                            pb.BackColor = Color.Bisque
                            'Fila impar
                        Else
                            pb.BackColor = Color.SaddleBrown
                        End If
                        'Columna impar
                    ElseIf columnas Mod 2 = 1 Then
                        'Fila par
                        If filas Mod 2 = 0 Then
                            pb.BackColor = Color.SaddleBrown
                            'Fila impar
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

    'MOVIMIENTOS DE LAS PIEZAS

    'Método a ejecutar en el manejador dependiendo donde hagas click podras o no mover una pieza
    Private Sub moverFicha(sender As Object, e As EventArgs)


        If (comprueba) Then 'Usando este boolean comprobamos si se seleccionas la pieza por primera vez o si vas a intentar
            'mover una pieza ya seleccionada

            Dim movimientoFicha As Integer 'Variable Integer que determinará si el movimiento es posible o no. Su valor puede ser 0, 1 (y 2 solo en caso del peón).
            'dependiendo de la variable ficha, guarda el resultado del método mover de la clase pieza correspondiente

            ncolumnafinal = CInt(sender.name.ToString.Substring(0, 1)) 'Extraemos la columna final en la que se va a colocar la pieza
            nfilafinal = CInt(sender.name.ToString.Substring(1, 1)) 'Extraemos la fila final en la que se va a colocar la pieza


            Dim color As String = nCasillas(ncolumnainicial, nfilainicial).Substring(0, 1) 'Variable que sirve para comprobar si es blanca o negra la pieza de no haber nada es x
            Dim ficha As String = nCasillas(ncolumnainicial, nfilainicial).Substring(1, 1) 'Variable que sirve para comprobar el tipo de pieza de no haber nada es x

            'Movimiento de la TORRE

            'Si selecciona una torre se crea un Objeto de tipo Torre y se guarda en la variable movimientoFicha.
            'Se comprueba si el movimiento es posible, en caso de serlo se comprueba el color de la pieza para el trato de las imágenes, 
            'en caso de no serlo se muestra un mensaje y se restaura el turno

            'Se comprueba si se come un rey del color opuesto para comprobar que ha ganado la partida.

            If ficha = "t" Then

                Dim torre As New Torre
                movimientoFicha = torre.mover(nCasillas, nfilainicial, ncolumnainicial, nfilafinal, ncolumnafinal, color)

                If movimientoFicha = 0 Then

                    If color = "b" Then

                        'Se comprueba que torre es, para determinar que esa torre ya no se puede enrocar

                        If ncolumnainicial = 0 Then
                            torreblanca1 += 1
                        ElseIf ncolumnainicial = 7 Then
                            torreblanca2 += 1
                        End If

                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/torreB.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                        If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                            MsgBox("Han ganado las blancas")
                            Me.Close()
                        End If

                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "bt"

                    ElseIf color = "n" Then

                        'Se comprueba que torre es, para determinar que esa torre ya no se puede enrocar

                        If ncolumnainicial = 0 Then
                            torrenegra1 += 1
                        ElseIf ncolumnainicial = 7 Then
                            torrenegra2 += 1
                        End If

                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/torreN.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                        If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                            MsgBox("Han ganado las negras")
                            Me.Close()

                        End If
                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "nt"

                    End If

                Else
                    MsgBox("movimiento no permitido")
                    jugadores -= 1

                End If

                'Movimiento del PEÓN

                'Si selecciona un peón se crea un Objeto de tipo Peón y se guarda en la variable movimientoFicha.
                'Se comprueba si el movimiento es posible, en caso de serlo se comprueba el color de la pieza para el trato de las imágenes, 
                'en caso de no serlo se muestra un mensaje y se restaura el turno.

                'Se comprueba si el peón llega al extremo opuesto del tablero, para realizar la promoción a otra de las 4 piezas permitidas.

                'Se comprueba si se come un rey del color opuesto para comprobar que ha ganado la partida.

            ElseIf ficha = "p" Then

                Dim peon As New Peon
                movimientoFicha = peon.mover(nCasillas, nfilainicial, ncolumnainicial, nfilafinal, ncolumnafinal, color)

                If movimientoFicha = 0 Then

                    If color = "b" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/peonB.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                        If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                            MsgBox("Han ganado las blancas")
                            Me.Close()
                        End If

                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "bp"

                    ElseIf color = "n" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/peonN.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                        If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                            MsgBox("Han ganado las negras")
                            Me.Close()
                        End If

                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "np"

                    End If

                    'Si el resultado del movimiento es 2, se llama al formulario de promoción, pasando por parámetro el color del peón
                    'mediante el cual se determina la pieza a la que va a promocionar

                ElseIf movimientoFicha = 2 Then

                    Dim frmpromo As New frmPromocion(color)
                    frmpromo.ShowDialog()

                    If color = "b" Then

                        If promo = "torre" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/torreB.png"))
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                            If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                                MsgBox("Han ganado las blancas")
                                Me.Close()
                            End If

                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "bt"

                        ElseIf promo = "alfil" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/alfilB.png"))
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                            If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                                MsgBox("Han ganado las blancas")
                                Me.Close()
                            End If

                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "ba"

                        ElseIf promo = "caballo" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/caballoB.png"))
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                            If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                                MsgBox("Han ganado las blancas")
                                Me.Close()
                            End If

                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "bc"

                        ElseIf promo = "reina" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reinaB.png"))
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                            If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                                MsgBox("Han ganado las blancas")
                                Me.Close()
                            End If

                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "br"
                        End If

                    ElseIf color = "n" Then

                        If promo = "torre" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/torreN.png"))
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                            If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                                MsgBox("Han ganado las negras")
                                Me.Close()
                            End If

                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "nt"

                        ElseIf promo = "alfil" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/alfilN.png"))
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                            If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                                MsgBox("Han ganado las negras")
                                Me.Close()
                            End If

                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "na"

                        ElseIf promo = "caballo" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/caballoN.png"))
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                            If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                                MsgBox("Han ganado las negras")
                                Me.Close()
                            End If

                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "nc"

                        ElseIf promo = "reina" Then
                            casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reinaN.png"))
                            casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                            If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                                MsgBox("Han ganado las negras")
                                Me.Close()
                            End If

                            nCasillas(ncolumnainicial, nfilainicial) = "xx"
                            nCasillas(ncolumnafinal, nfilafinal) = "nr"

                        End If
                    End If

                Else
                    MsgBox("movimiento no permitido")
                    jugadores -= 1
                End If

                'Movimiento del CABALLO

                'Si selecciona un caballo se crea un Objeto de tipo Caballo y se guarda en la variable movimientoFicha.
                'Se comprueba si el movimiento es posible, en caso de serlo se comprueba el color de la pieza para el trato de las imágenes, 
                'en caso de no serlo se muestra un mensaje y se restaura el turno.

                'Se comprueba si se come un rey del color opuesto para comprobar que ha ganado la partida.

            ElseIf ficha = "c" Then
                Dim caballo As New Caballo
                movimientoFicha = caballo.mover(nCasillas, nfilainicial, ncolumnainicial, nfilafinal, ncolumnafinal, color)

                If movimientoFicha = 0 Then

                    If color = "b" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/caballoB.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                        If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                            MsgBox("Han ganado las blancas")
                            Me.Close()
                        End If

                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "bc"

                    ElseIf color = "n" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/caballoN.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                        If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                            MsgBox("Han ganado las negras")
                            Me.Close()
                        End If

                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "nc"
                    End If
                Else
                    MsgBox("movimiento no permitido")
                    jugadores -= 1
                End If

                'Movimiento del REY

                'Si selecciona un rey se crea un Objeto de tipo Rey y se guarda en la variable movimientoFicha.

                'Se comprueba si es posible realizar un enroque, mediante variables Integer, que determinan si las piezas que se moverán en el enroque,
                'cumplen los requisitos para realizarlo.

                'Se comprueba si el movimiento es posible, en caso de serlo se comprueba el color de la pieza para el trato de las imágenes, 
                'en caso de no serlo se muestra un mensaje y se restaura el turno.

                'Se comprueba si se come un rey del color opuesto para comprobar que ha ganado la partida.

            ElseIf ficha = "R" Then
                Dim rey As New Rey
                movimientoFicha = rey.mover(nCasillas, nfilainicial, ncolumnainicial, nfilafinal, ncolumnafinal, color)

                'Para realizar el enroque habrá que decirle al rey que se mueva dos pasos a la izquierda o derecha de su posición inicial.
                'Comprobamos si se cumplen todas las condiciones para que se pueda realizar, tanto si se puede realizar como si no, mostrará un mensaje.

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

                    If color = "b" Then
                        reyblanco += 1
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reyB.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                        If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                            MsgBox("Han ganado las blancas")
                            Me.Close()
                        End If

                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "bR"

                    ElseIf color = "n" Then
                        reynegro += 1
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reyN.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                        If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                            MsgBox("Han ganado las negras")
                            Me.Close()
                        End If

                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "nR"
                    End If
                Else
                    MsgBox("movimiento no permitido")
                    jugadores -= 1
                End If


                'Movimiento de la REINA

                'Si selecciona una reina se crea un Objeto de tipo Reina y se guarda en la variable movimientoFicha.
                'Se comprueba si el movimiento es posible, en caso de serlo se comprueba el color de la pieza para el trato de las imágenes, 
                'en caso de no serlo se muestra un mensaje y se restaura el turno.

                'Se comprueba si se come un rey del color opuesto para comprobar que ha ganado la partida.

            ElseIf ficha = "r" Then
                Dim reina As New Reina
                movimientoFicha = reina.mover(nCasillas, nfilainicial, ncolumnainicial, nfilafinal, ncolumnafinal, color)

                If movimientoFicha = 0 Then

                    If color = "b" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/reinaB.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                        If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                            MsgBox("Han ganado las blancas")
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
                            Me.Close()
                        End If

                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "nr"
                    End If
                Else
                    MsgBox("movimiento no permitido")
                    jugadores -= 1
                End If

                'Movimiento del ALFIL

                'Si selecciona un alfil se crea un Objeto de tipo Alfil y se guarda en la variable movimientoFicha.
                'Se comprueba si el movimiento es posible, en caso de serlo se comprueba el color de la pieza para el trato de las imágenes, 
                'en caso de no serlo se muestra un mensaje y se restaura el turno.

                'Se comprueba si se come un rey del color opuesto para comprobar que ha ganado la partida.

            ElseIf ficha = "a" Then
                Dim alfil As New Alfil
                movimientoFicha = alfil.mover(nCasillas, nfilainicial, ncolumnainicial, nfilafinal, ncolumnafinal, color)

                If movimientoFicha = 0 Then

                    If color = "b" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/alfilB.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                        If nCasillas(ncolumnafinal, nfilafinal) = "nR" Then
                            MsgBox("Han ganado las blancas")
                            Me.Close()
                        End If

                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "ba"

                    ElseIf color = "n" Then
                        casillasPB(ncolumnafinal, nfilafinal).Load(Application.StartupPath & ("/images/alfilN.png"))
                        casillasPB(ncolumnainicial, nfilainicial).Image = Nothing

                        If nCasillas(ncolumnafinal, nfilafinal) = "bR" Then
                            MsgBox("Han ganado las negras")
                            Me.Close()
                        End If

                        nCasillas(ncolumnainicial, nfilainicial) = "xx"
                        nCasillas(ncolumnafinal, nfilafinal) = "na"
                    End If
                Else
                    MsgBox("movimiento no permitido")
                    jugadores -= 1
                End If

            End If

            'TURNOS DE LOS JUGADORES

            'Se comprueba si la variable jugadores es par (blancas) o impar (negras) para determinar el turno.

            'En cada turno se muestra una imagen del color correspondiente al turno actual y si se ha seleccionado que se juegue con
            'temporizador, se para el del jugador contrario y se habilita el propio.

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

            comprueba = False 'Se restablece la variable comprueba a false para el siguiente movimiento

        Else

            ncolumnainicial = CInt(sender.name.ToString.Substring(0, 1)) 'Extraemos la columna actual donde esta colocada la pieza
            nfilainicial = CInt(sender.name.ToString.Substring(1, 1)) 'Extraemos la fila actual donde esta colocada la pieza

            'En caso de que la casilla inicial esté vacía para que el jugador no pierda el turno

            'En caso de que la pieza seleccionada es del jugador contrario, muestra un mensaje, no puede moverse y no gasta un turno

            If nCasillas(ncolumnainicial, nfilainicial) = "xx" Then

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

    'TEMPORIZADORES

    'Aquí se gestionan los cronómetros de cada jugador

    'A cada segundo se va actualizando el Label que muestra el tiempo restante al jugador correspondiente.
    'En caso de que los minutos y segundos lleguen a 0, se otorga la victoria al jugador contrario,
    'y se finaliza la partida, cerrando el juego.

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
            Me.Close()
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
            Me.Close()
        End If
    End Sub

    'Evento que se acciona al dejar de mantener pulsado el botón cerrar, cambiando la imagen a un estado de no presionado
    Private Sub pbCerrar_MouseUp(sender As Object, e As MouseEventArgs) Handles pbCerrar.MouseUp
        pbCerrar.Load(Application.StartupPath & ("/images/cerrar.png"))
    End Sub

    'Evento que se acciona al mantener pulsado el botón cerrar, cambiando la imagen a un estado de presionado
    Private Sub pbCerrar_MouseDown(sender As Object, e As MouseEventArgs) Handles pbCerrar.MouseDown
        pbCerrar.Load(Application.StartupPath & ("/images/cerrarHun.png"))
    End Sub

    'Evento que se acciona al pulsar el botón cerrar, para preguntar al usuario si desea salir del juego
    Private Sub pbCerrar_Click(sender As Object, e As EventArgs) Handles pbCerrar.Click
        Dim resp As String 'Variable que guarda la respuesta que vaya a dar el usuario 

        'Guarda el valor que muestra el MsgBox 
        resp = MsgBox("¿Desea salir del juego?", MsgBoxStyle.YesNo, "Salir del juego")

        'Comprueba el valor de la respuesta para salir del juego
        'Si la respuesta es Sí, finaliza el juego y si es No, sigue mostrándose el formulario del tablero   
        If (resp = 6) Then
            End
        Else
            Me.Show()
        End If
    End Sub

End Class