Public Class Rey

    Dim retorno As Integer = 1 'Variable que indica si el movimiento es posible o no, solo cuando
    'es 0 el movimiento se realiza

    'Método que comprueba la ruta entre la posición inicial y la final en caso de haber un
    'obstáculo devolverá 1 y no permitirá el movimiento. También controla si puede comerse
    'una pieza
    Public Function mover(ByVal nCasillas(,) As String, ByVal filaInicial As Integer, ByVal columnaInicial As Integer,
                          ByVal filaFinal As Integer, ByVal columnaFinal As Integer, ByVal color As String)
        'Es horizontal
        If filaInicial = filaFinal Then
            'Hacia la derecha
            If columnaFinal = columnaInicial + 1 Then

                For y = columnaInicial + 1 To columnaFinal

                    If y = columnaFinal Then
                        If nCasillas(y, filaInicial).Substring(0, 1) <> color And (nCasillas(y, filaInicial).Substring(0, 1) <> "x") Then
                            Return 0
                        End If
                    End If

                    If nCasillas(y, filaInicial) <> "xx" Then
                        Return 1
                    End If


                    If y = columnaFinal Then
                        retorno = 0
                    End If
                Next

                'Hacia la izquierda
            ElseIf columnaFinal = columnaInicial - 1

                For y = columnaInicial - 1 To columnaFinal Step -1

                    If y = columnaFinal Then
                        If nCasillas(y, filaInicial).Substring(0, 1) <> color And (nCasillas(y, filaInicial).Substring(0, 1) <> "x") Then
                            Return 0
                        End If
                    End If

                    If nCasillas(y, filaInicial).Substring(0, 1) <> color And (nCasillas(y, filaInicial).Substring(0, 1) <> "x") Then
                        retorno = 0
                    End If

                    If nCasillas(y, filaInicial) <> "xx" Then
                        Return 1
                    End If

                    If y = columnaInicial - 1 Then
                        retorno = 0
                    End If

                Next
            End If
        End If

        'Vertical
        If columnaInicial = columnaFinal Then

            'Hacia abajo
            If filaFinal = filaInicial + 1 Then
                For x = filaInicial + 1 To filaFinal
                    If x = filaFinal Then
                        If nCasillas(columnaInicial, x).Substring(0, 1) <> color And (nCasillas(columnaInicial, x).Substring(0, 1) <> "x") Then
                            Return 0
                        End If
                    End If

                    If nCasillas(columnaInicial, x) <> "xx" Then
                        Return 1
                    End If
                    If x = filaFinal Then
                        retorno = 0
                    End If
                Next

                'Hacia arriba
            ElseIf filaFinal = filaInicial - 1
                For x = filaInicial - 1 To filaFinal Step -1
                    If x = filaFinal Then
                        If nCasillas(columnaInicial, x).Substring(0, 1) <> color And (nCasillas(columnaInicial, x).Substring(0, 1) <> "x") Then
                            Return 0
                        End If
                    End If


                    If nCasillas(columnaInicial, x) <> "xx" Then
                        Return 1
                    End If
                    If x = filaInicial - 1 Then
                        retorno = 0
                    End If
                Next
            End If
        End If


        'Diagonal derecha hacia abajo
        If filaInicial + 1 = filaFinal And columnaInicial + 1 = columnaFinal Then
            While (filaInicial <> filaFinal And columnaInicial <> columnaFinal)
                filaInicial += 1
                columnaInicial += 1
                If columnaInicial = columnaFinal And filaInicial = filaFinal Then
                    If nCasillas(columnaInicial, filaInicial).Substring(0, 1) <> color And (nCasillas(columnaInicial, filaInicial).Substring(0, 1) <> "x") Then
                        Return 0
                    End If
                End If

                If nCasillas(columnaInicial, filaInicial) <> "xx" Then
                    Return 1
                End If
                If columnaInicial = columnaFinal And filaInicial = filaFinal Then
                    retorno = 0
                End If

            End While
        End If

        'Diagonal izquierda hacia abajo
        If filaInicial + 1 = filaFinal And columnaInicial - 1 = columnaFinal Then
            While (filaInicial <> filaFinal And columnaInicial <> columnaFinal)
                filaInicial += 1
                columnaInicial -= 1
                If columnaInicial = columnaFinal And filaInicial = filaFinal Then
                    If nCasillas(columnaInicial, filaInicial).Substring(0, 1) <> color And (nCasillas(columnaInicial, filaInicial).Substring(0, 1) <> "x") Then
                        Return 0
                    End If
                End If
                If nCasillas(columnaInicial, filaInicial) <> "xx" Then
                    Return 1
                End If
                If columnaInicial = columnaFinal And filaInicial = filaFinal Then
                    retorno = 0
                End If

            End While
        End If

        'Diagonal derecha hacia arriba
        If filaInicial - 1 = filaFinal And columnaInicial - 1 = columnaFinal Then
            While (filaInicial <> filaFinal And columnaInicial <> columnaFinal)
                filaInicial -= 1
                columnaInicial -= 1
                If columnaInicial = columnaFinal And filaInicial = filaFinal Then
                    If nCasillas(columnaInicial, filaInicial).Substring(0, 1) <> color And (nCasillas(columnaInicial, filaInicial).Substring(0, 1) <> "x") Then
                        Return 0
                    End If
                End If
                If nCasillas(columnaInicial, filaInicial) <> "xx" Then
                    Return 1
                End If
                If columnaInicial = columnaFinal And filaInicial = filaFinal Then
                    retorno = 0
                End If

            End While
        End If

        'Diagonal izquierda hacia arriba
        If filaInicial - 1 = filaFinal And columnaInicial + 1 = columnaFinal Then
            While (filaInicial <> filaFinal And columnaInicial <> columnaFinal)
                filaInicial -= 1
                columnaInicial += 1
                If columnaInicial = columnaFinal And filaInicial = filaFinal Then
                    If nCasillas(columnaInicial, filaInicial).Substring(0, 1) <> color And (nCasillas(columnaInicial, filaInicial).Substring(0, 1) <> "x") Then
                        Return 0
                    End If
                End If
                If nCasillas(columnaInicial, filaInicial) <> "xx" Then
                    Return 1
                End If
                If columnaInicial = columnaFinal And filaInicial = filaFinal Then
                    retorno = 0
                End If

            End While
        End If

        Return retorno

    End Function
End Class
