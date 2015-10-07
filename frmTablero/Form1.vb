Public Class frmTablero
    Dim nCasillas(7, 7) As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim casillasPB(7, 7) As PictureBox

        Dim filas As Integer
        Dim columnas As Integer

        For filas = 0 To 7
            For columnas = 0 To 7
                Dim pb As New PictureBox
                casillasPB(filas, columnas) = pb

                With pb
                    .Size = New System.Drawing.Size(60, 60)
                    .BorderStyle = BorderStyle.FixedSingle
                    .Location = New System.Drawing.Point(60 * filas, 60 * columnas)
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    .Name = filas & columnas
                    .Tag = "0"

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

                    If columnas = 6 Then
                        casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/peonB.png"))
                        nCasillas(filas, columnas) = 11
                    End If

                    If columnas = 1 Then
                        casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/peonN.png"))
                        nCasillas(filas, columnas) = 21
                    End If

                    If columnas = 0 Then
                        If filas = 0 Or filas = 7 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/TorreN.png"))
                            nCasillas(filas, columnas) = 22
                        End If

                        If filas = 1 Or filas = 6 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/caballoN.png"))
                            nCasillas(filas, columnas) = 23
                        End If

                        If filas = 2 Or filas = 5 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/alfilN.png"))
                            nCasillas(filas, columnas) = 24
                        End If

                        If filas = 3 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/reinaN.png"))
                            nCasillas(filas, columnas) = 25
                        End If

                        If filas = 4 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/reyN.png"))
                            nCasillas(filas, columnas) = 26
                        End If

                    End If

                    If columnas = 7 Then
                        If filas = 0 Or filas = 7 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/TorreB.png"))
                            nCasillas(filas, columnas) = 12
                        End If

                        If filas = 1 Or filas = 6 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/caballoB.png"))
                            nCasillas(filas, columnas) = 13
                        End If

                        If filas = 2 Or filas = 5 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/alfilB.png"))
                            nCasillas(filas, columnas) = 14
                        End If

                        If filas = 3 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/reinaB.png"))
                            nCasillas(filas, columnas) = 15
                        End If

                        If filas = 4 Then
                            casillasPB(filas, columnas).Load(Application.StartupPath & ("/images/reyB.png"))
                            nCasillas(filas, columnas) = 16
                        End If

                    End If
                    Me.Controls.Add(pb)
                    AddHandler pb.MouseClick, AddressOf moverFicha
                End With
            Next
        Next
    End Sub

    Private Sub moverFicha(sender As Object, e As EventArgs)
        Dim final As String
        Dim ncolumna, nfila, ncolumnafinal, nfilafinal As Integer
        MsgBox(sender.name)
        ncolumna = CInt(sender.name.ToString.Substring(0, 1))
        nfila = CInt(sender.name.ToString.Substring(1, 1))
        If nCasillas(ncolumna, nfila) = 0 Then
            MsgBox("no puedes hacer nada")
        Else
            MsgBox("funciona")
            If nCasillas(ncolumna, nfila) = 12 Then
                Dim torre As New Torre

                While (True)
                    final = posicionarFicha(sender, e)
                    ncolumnafinal = CInt(final.Substring(0, 1))
                    nfilafinal = CInt(final.Substring(1, 1))
                    Exit While


                End While
                MsgBox(ncolumnafinal & nfilafinal)
                'torre.mover(nCasillas, nfila, ncolumna, )

            End If
        End If

    End Sub

    Private Function posicionarFicha(sender As Object, e As EventArgs)
        Dim ncolumna, nfila As Integer
        Return sender.name

    End Function

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
