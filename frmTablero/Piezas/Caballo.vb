Public Class Caballo

    Public Function mover(ByVal nCasillas(,) As Integer, ByVal filaInicial As Integer, ByVal columnaInicial As Integer,
                          ByVal filaFinal As Integer, ByVal columnaFinal As Integer)

        If columnaFinal = columnaInicial + 2 And filaFinal = filaInicial - 1 Then
            If nCasillas(columnaFinal, filaFinal) = 0 Then
                Return 0
            End If
        End If

        If columnaFinal = columnaInicial + 1 And filaFinal = filaInicial - 2 Then
            If nCasillas(columnaFinal, filaFinal) = 0 Then
                Return 0
            End If
        End If

        If columnaFinal = columnaInicial - 1 And filaFinal = filaInicial - 2 Then
            If nCasillas(columnaFinal, filaFinal) = 0 Then
                Return 0
            End If
        End If

        If columnaFinal = columnaInicial - 2 And filaFinal = filaInicial - 1 Then
            If nCasillas(columnaFinal, filaFinal) = 0 Then
                Return 0
            End If
        End If

        If columnaFinal = columnaInicial - 2 And filaFinal = filaInicial + 1 Then
            If nCasillas(columnaFinal, filaFinal) = 0 Then
                Return 0
            End If
        End If

        If columnaFinal = columnaInicial - 1 And filaFinal = filaInicial + 2 Then
            If nCasillas(columnaFinal, filaFinal) = 0 Then
                Return 0
            End If
        End If

        If columnaFinal = columnaInicial + 1 And filaFinal = filaInicial + 2 Then
            If nCasillas(columnaFinal, filaFinal) = 0 Then
                Return 0
            End If
        End If

        If columnaFinal = columnaInicial + 2 And filaFinal = filaInicial + 1 Then
            If nCasillas(columnaFinal, filaFinal) = 0 Then
                Return 0
            End If
        End If

        Return 1
    End Function
End Class
