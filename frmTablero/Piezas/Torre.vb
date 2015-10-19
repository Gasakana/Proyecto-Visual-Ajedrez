Public Class Torre
    Dim retorno As Integer = 1
    Public Function mover(ByVal nCasillas(,) As String, ByVal filaInicial As Integer, ByVal columnaInicial As Integer,
                          ByVal filaFinal As Integer, ByVal columnaFinal As Integer, ByVal color As String)


        'Es horizontal
        If filaInicial = filaFinal Then
            ' --------->
            If columnaFinal > columnaInicial Then
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
                '<----------
            ElseIf columnaFinal < columnaInicial
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
            ' abajo
            If filaFinal > filaInicial Then
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
                'arriba
            ElseIf filaFinal < filaInicial
                'For x = filaFinal To filaInicial - 1

                '    If nCasillas(columnaInicial, x).Substring(0, 1) <> color And (nCasillas(columnaInicial, x).Substring(0, 1) <> "x") Then

                '            Return 0
                '        End If

                '    If nCasillas(columnaInicial, x) <> "xx" Then
                '        Return 1
                '    End If
                '    If x = filaInicial - 1 Then
                '        retorno = 0
                '    End If
                'Next
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
        Return retorno

    End Function

End Class
