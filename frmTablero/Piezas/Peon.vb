Public Class Peon
    Dim retorno As Integer = 1
    Public Function mover(ByVal nCasillas(,) As String, ByVal filaInicial As Integer, ByVal columnaInicial As Integer,
                          ByVal filaFinal As Integer, ByVal columnaFinal As Integer, ByVal color As String)

        If color = "b" Then
            If columnaInicial = columnaFinal Then
                If filaInicial = 6 Then
                    If filaFinal = filaInicial - 2 Then

                        For x = filaInicial - 1 To filaFinal Step -1


                            If nCasillas(columnaInicial, x) <> "xx" Then
                                Return 1
                            End If
                            If x = filaInicial - 1 Then
                                retorno = 0
                            End If
                        Next
                    End If
                End If
            End If

            If filaFinal = filaInicial - 1 Then
                If columnaInicial = columnaFinal Then

                    For x = filaInicial - 1 To filaFinal Step -1


                        If nCasillas(columnaInicial, x) <> "xx" Then
                            Return 1
                        End If
                        If x = 0 Then
                            Return 2
                        End If
                        If x = filaInicial - 1 Then
                            retorno = 0
                        End If
                    Next
                End If
                'diagonal izquierda
                If filaInicial - 1 = filaFinal And columnaInicial - 1 = columnaFinal Then
                    While (filaInicial <> filaFinal And columnaInicial <> columnaFinal)
                        filaInicial -= 1
                        columnaInicial -= 1

                        If nCasillas(columnaInicial, filaInicial).ToString.Substring(0, 1) = color Or nCasillas(columnaInicial, filaInicial).ToString.Substring(0, 1) = "x" Then
                            Return 1
                        End If
                        If filaInicial = 0 Then
                            Return 2
                        End If
                        If columnaInicial = columnaFinal And filaInicial = filaFinal Then
                            retorno = 0
                        End If

                    End While
                End If

                'Diagonal derecha
                If filaInicial - 1 = filaFinal And columnaInicial + 1 = columnaFinal Then
                    While (filaInicial <> filaFinal And columnaInicial <> columnaFinal)
                        filaInicial -= 1
                        columnaInicial += 1

                        If nCasillas(columnaInicial, filaInicial).ToString.Substring(0, 1) = color Or nCasillas(columnaInicial, filaInicial).ToString.Substring(0, 1) = "x" Then

                            Return 1
                        Else
                            retorno = 0
                        End If
                        If filaInicial = 0 Then
                            Return 2
                        End If
                        If columnaInicial = columnaFinal And filaInicial = filaFinal Then
                            retorno = 0
                        End If

                    End While
                End If

            End If

        ElseIf color = "n" Then
            If columnaInicial = columnaFinal Then
                If filaInicial = 1 Then
                    If filaFinal = filaInicial + 2 Then

                        For x = filaInicial + 1 To filaFinal


                            If nCasillas(columnaInicial, x) <> "xx" Then
                                Return 1
                            End If
                            If x = 7 Then
                                Return 2
                            End If
                            If x = filaFinal Then
                                retorno = 0
                            End If
                        Next
                    End If
                End If
            End If

            If filaFinal = filaInicial + 1 Then
                If columnaInicial = columnaFinal Then

                    For x = filaInicial + 1 To filaFinal


                        If nCasillas(columnaInicial, x) <> "xx" Then
                            Return 1
                        End If
                        If filaInicial = 7 Then
                            Return 2
                        End If
                        If x = filaInicial + 1 Then
                            retorno = 0
                        End If
                    Next
                End If
            End If
            'diagonal izquierda
            If filaInicial + 1 = filaFinal And columnaInicial + 1 = columnaFinal Then
                While (filaInicial <> filaFinal And columnaInicial <> columnaFinal)
                    filaInicial += 1
                    columnaInicial += 1

                    If nCasillas(columnaInicial, filaInicial).ToString.Substring(0, 1) = color Or nCasillas(columnaInicial, filaInicial).ToString.Substring(0, 1) = "x" Then
                        Return 1
                    End If
                    If filaInicial = 7 Then
                        Return 2
                    End If
                    If columnaInicial = columnaFinal And filaInicial = filaFinal Then
                        retorno = 0
                    End If

                End While
            End If

            'Diagonal derecha
            If filaInicial + 1 = filaFinal And columnaInicial - 1 = columnaFinal Then
                While (filaInicial <> filaFinal And columnaInicial <> columnaFinal)
                    filaInicial += 1
                    columnaInicial -= 1

                    If nCasillas(columnaInicial, filaInicial).ToString.Substring(0, 1) = color Or nCasillas(columnaInicial, filaInicial).ToString.Substring(0, 1) = "x" Then

                        Return 1
                    Else
                        retorno = 0
                    End If
                    If filaInicial = 7 Then
                        Return 2
                    End If
                    If columnaInicial = columnaFinal And filaInicial = filaFinal Then
                        retorno = 0
                    End If

                End While
            End If

        End If

        Return retorno

    End Function

End Class
