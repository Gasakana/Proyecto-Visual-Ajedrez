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

                    Me.Controls.Add(pb)
                    AddHandler pb.MouseClick, AddressOf posicionarReina
                End With
            Next
        Next
    End Sub

    Private Sub posicionarReina(sender As Object, e As EventArgs)
        sender.Load(Application.StartupPath & ("/images/reyN.png"))
        MsgBox(sender.name)
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
