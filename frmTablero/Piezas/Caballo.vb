Public Class Caballo

    Public Function mover(ByVal nCasillas(,) As String, ByVal filaInicial As Integer, ByVal columnaInicial As Integer,
                          ByVal filaFinal As Integer, ByVal columnaFinal As Integer, ByVal color As String)

        If columnaFinal = columnaInicial + 2 And filaFinal = filaInicial - 1 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If

        If columnaFinal = columnaInicial + 1 And filaFinal = filaInicial - 2 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If

        If columnaFinal = columnaInicial - 1 And filaFinal = filaInicial - 2 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If

        If columnaFinal = columnaInicial - 2 And filaFinal = filaInicial - 1 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If

        If columnaFinal = columnaInicial - 2 And filaFinal = filaInicial + 1 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If

        If columnaFinal = columnaInicial - 1 And filaFinal = filaInicial + 2 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If

        If columnaFinal = columnaInicial + 1 And filaFinal = filaInicial + 2 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If

        If columnaFinal = columnaInicial + 2 And filaFinal = filaInicial + 1 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If

        Return 1
    End Function
End Class
