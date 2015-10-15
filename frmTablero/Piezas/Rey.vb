Public Class Rey

    Dim retorno As Integer = 1
    Public Function mover(ByVal nCasillas(,) As String, ByVal filaInicial As Integer, ByVal columnaInicial As Integer,
                          ByVal filaFinal As Integer, ByVal columnaFinal As Integer)

        'Es horizontal
        If filaInicial = filaFinal Then
            ' --------->
            If columnaFinal = columnaInicial + 1 Then
                For y = columnaInicial + 1 To columnaFinal
                    If nCasillas(y, filaInicial) <> "" Then
                        Return 1
                    End If
                    If y = columnaFinal Then
                        retorno = 0
                    End If
                Next
                '<----------
            ElseIf columnaFinal = columnaInicial - 1
                For y = columnaFinal To columnaInicial - 1
                    If nCasillas(y, filaInicial) <> "" Then
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
            ' abajo
            If filaFinal = filaInicial + 1 Then
                For x = filaInicial + 1 To filaFinal
                    If nCasillas(columnaInicial, x) <> "" Then
                        Return 1
                    End If
                    If x = filaFinal Then
                        retorno = 0
                    End If
                Next
                'arriba
            ElseIf filaFinal = filaInicial - 1
                For x = filaFinal To filaInicial - 1
                    If nCasillas(columnaInicial, x) <> 0 Then
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
                If nCasillas(columnaInicial, filaInicial) <> "" Then
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
                If nCasillas(columnaInicial, filaInicial) <> "" Then
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
                If nCasillas(columnaInicial, filaInicial) <> "" Then
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
                If nCasillas(columnaInicial, filaInicial) <> "" Then
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
