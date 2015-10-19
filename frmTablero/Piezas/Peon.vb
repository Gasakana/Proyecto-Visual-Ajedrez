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
                        If x = filaInicial - 1 Then
                            retorno = 0
                        End If
                    Next
                End If
            End If

        ElseIf color = "n" Then

            End If

        Return retorno

    End Function

End Class
