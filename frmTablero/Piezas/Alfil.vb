Public Class Alfil
    Dim retorno As Integer = 1 'variable que indica si el movimiento es posible o no solo cuando
    'es 0 el movimiento se realiza

    'Metodo que comprueba la ruta entre la posicion inicial y la final en caso de haber un
    'obstáculo devolvera 1 y no permitira el movimiento. Tambien controla si puede comerse
    'una pieza
    Public Function mover(ByVal nCasillas(,) As String, ByVal filaInicial As Integer, ByVal columnaInicial As Integer,
                          ByVal filaFinal As Integer, ByVal columnaFinal As Integer, ByVal color As String)

        'Diagonal derecha hacia abajo
        If filaInicial < filaFinal And columnaInicial < columnaFinal Then
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
        If filaInicial < filaFinal And columnaInicial > columnaFinal Then
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
        If filaInicial > filaFinal And columnaInicial > columnaFinal Then
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
        If filaInicial > filaFinal And columnaInicial < columnaFinal Then
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
