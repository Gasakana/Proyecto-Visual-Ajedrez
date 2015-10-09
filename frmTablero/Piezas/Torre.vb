Public Class Torre

    Public Function mover(ByVal nCasillas(,) As Integer, ByVal filaInicial As Integer, ByVal columnaInicial As Integer,
                          ByVal filaFinal As Integer, ByVal columnaFinal As Integer)

        If columnaFinal > columnaInicial Then
            For y = columnaInicial To columnaFinal
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

        If filaFinal > filaInicial Then
            For x = filaInicial To filaFinal
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


        Return 1

    End Function


End Class
