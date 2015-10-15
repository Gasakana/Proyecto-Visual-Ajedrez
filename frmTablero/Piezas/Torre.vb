Public Class Torre
    Dim retorno As Integer = 1
    Public Function mover(ByVal nCasillas(,) As Integer, ByVal filaInicial As Integer, ByVal columnaInicial As Integer,
                          ByVal filaFinal As Integer, ByVal columnaFinal As Integer)

        'If filaInicial <> filaFinal And columnaInicial <> columnaFinal Then
        '    Return 1
        'End If

        'If columnaInicial = columnaFinal And filaInicial = filaFinal Then
        '    Return 1
        'End If

        'Es horizontal
        If filaInicial = filaFinal Then
            ' --------->
            If columnaFinal > columnaInicial Then
                For y = columnaInicial + 1 To columnaFinal
                    If nCasillas(y, filaInicial) <> 0 Then
                        Return 1
                    End If
                    If y = columnaFinal Then
                        retorno = 0
                    End If
                Next
                '<----------
            ElseIf columnaFinal < columnaInicial
                For y = columnaFinal To columnaInicial - 1
                    If nCasillas(y, filaInicial) <> 0 Then
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
            If filaFinal > filaInicial Then
                For x = filaInicial + 1 To filaFinal
                    If nCasillas(columnaInicial, x) <> 0 Then
                        Return 1
                    End If
                    If x = filaFinal Then
                        retorno = 0
                    End If
                Next
                'arriba
            ElseIf filaFinal < filaInicial
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
        Return retorno

    End Function

End Class
