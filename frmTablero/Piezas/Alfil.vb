Public Class Alfil

    Public Function mover(ByVal nCasillas(,) As Integer, ByVal filaInicial As Integer, ByVal columnaInicial As Integer,
                          ByVal filaFinal As Integer, ByVal columnaFinal As Integer)

        If columnaInicial = columnaFinal And filaInicial = filaFinal Then
            Return 1
        End If

        If filaFinal = filaInicial Or columnaFinal = columnaInicial Then
            Return 1
        End If

        'diagonal izquierda
        If filaFinal > filaInicial Then
            If columnaFinal < columnaInicial Then
                For y = columnaInicial To columnaFinal
                    For x = filaInicial To filaFinal
                        If nCasillas(y, x) <> 0 Then
                            Return 1
                        End If
                    Next
                Next
            End If
        End If

        'diagonal derecha
        If filaInicial < filaFinal Then
            If columnaFinal > columnaFinal Then
                For y = columnaInicial To columnaFinal
                    For x = filaInicial To filaFinal
                        If nCasillas(y, x) <> 0 Then
                            Return 1
                        End If
                    Next
                Next
            End If
            Return 0
        End If

    End Function

End Class
