Public Class Torre


    Public Sub Torre()

    End Sub

    Public Function mover(ByVal nCasillas(,) As Integer, ByVal filaInicial As Integer, ByVal columnaInicial As Integer,
                          ByVal filaFinal As Integer, ByVal columnaFinal As Integer)
        If filaInicial <> filaFinal And columnaInicial <> columnaFinal Then
            Return 1
        End If

        If columnaInicial = columnaFinal And filaInicial = filaFinal Then
            Return 1
        End If

        If filaInicial = filaFinal Then
            If columnaFinal > columnaInicial Then
                For y = columnaFinal To columnaInicial Step -1
                    If nCasillas(y, filaInicial) <> 0 Then
                        Return 1
                    Else
                        Return 0
                    End If
                Next
            ElseIf columnaFinal < columnaInicial
                For y = columnaFinal To columnaInicial
                    If nCasillas(y, filaInicial) <> 0 Then
                        Return 1
                    Else
                        Return 0
                    End If
                Next
            End If
        End If

        If columnaInicial = columnaFinal Then
            If filaFinal > filaInicial Then
                For x = filaFinal To filaInicial Step -1
                    If nCasillas(columnaInicial, x) <> 0 Then
                        Return 1
                    Else
                        Return 0
                    End If
                Next
            ElseIf filaFinal < filaInicial
                For x = filaFinal To filaInicial
                    If nCasillas(columnaInicial, x) <> 0 Then
                        Return 1
                    Else
                        Return 0
                    End If
                Next
            End If
        End If

    End Function

End Class
