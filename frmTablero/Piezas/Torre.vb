Public Class Torre


    Public Sub Torre()

    End Sub

    Public Function mover(ByVal nCasillas(,) As Integer, ByVal filaInicial As Integer, ByVal columnaInicial As Integer,
                          ByVal filaFinal As Integer, ByVal columnaFinal As Integer)


        For y = 0 To columnaFinal
            If nCasillas(filaInicial, y) <> 0 Then
                Return 1
            End If
        Next

        For x = 0 To filaFinal
            If nCasillas(x, columnaInicial) <> 0 Then
                Return 1
            End If
        Next

        Return 0

    End Function


End Class
