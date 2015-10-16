Public Class Peon
    Dim retorno As Integer = 1
    Dim contador As Integer
    Public Function mover(ByVal nCasillas(,) As String, ByVal filaInicial As Integer, ByVal columnaInicial As Integer,
                          ByVal filaFinal As Integer, ByVal columnaFinal As Integer)

        If columnaInicial = columnaFinal Then
            If filaFinal < filaInicial Then

                For x = filaFinal To filaInicial - 1
                    If nCasillas(columnaInicial, x) <> "" Then
                        Return 1
                    End If
                    If x = filaInicial - 1 Then
                        retorno = 0
                    End If
                Next
            End If
        End If

    End Function

End Class
