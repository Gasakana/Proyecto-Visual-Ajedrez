﻿Public Class Alfil
    Dim retorno As Integer = 1
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





        'diagonal izquierda
        'If filaFinal > filaInicial Then
        '    If columnaFinal > columnaInicial Then
        '        For y = columnaInicial To columnaFinal - 1
        '            For x = filaInicial To filaFinal - 1
        '                If nCasillas(y, x) <> 0 Then
        '                    Return 1
        '                End If
        '                If y = columnaFinal - 1 And x = filaFinal - 1 Then
        '                    retorno = 0
        '                End If

        '            Next

        '        Next
        '    End If
        'End If

        'diagonal derecha
        'If filaInicial < filaFinal Then
        '    If columnaFinal > columnaFinal Then
        '        For y = columnaInicial To columnaFinal
        '            For x = filaInicial To filaFinal
        '                If nCasillas(y, x) <> 0 Then
        '                    Return 1
        '                End If

        '            Next

        '        Next
        '    End If
        'End If


        Return retorno

    End Function

End Class
