Public Class Caballo

    'Metodo que comprueba si la posicion final del caballo es una de las posibles que puede hacer
    'este devolviendo 1 en caso de no poder o de estar ocupada por una pieza del mismo color
    Public Function mover(ByVal nCasillas(,) As String, ByVal filaInicial As Integer, ByVal columnaInicial As Integer,
                          ByVal filaFinal As Integer, ByVal columnaFinal As Integer, ByVal color As String)
        'Dos casillas a la derecha, una arriba
        If columnaFinal = columnaInicial + 2 And filaFinal = filaInicial - 1 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If
        'Una casilla a la derecha, dos arriba
        If columnaFinal = columnaInicial + 1 And filaFinal = filaInicial - 2 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If
        'Una casilla a la izquierda, dos arriba
        If columnaFinal = columnaInicial - 1 And filaFinal = filaInicial - 2 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If
        'Dos casillas a la izquierda, una arriba
        If columnaFinal = columnaInicial - 2 And filaFinal = filaInicial - 1 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If
        'Dos casillas a la izquierda, una abajo
        If columnaFinal = columnaInicial - 2 And filaFinal = filaInicial + 1 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If
        'Una casilla a la izquierda, dos abajo
        If columnaFinal = columnaInicial - 1 And filaFinal = filaInicial + 2 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If
        'Una casilla a la derecha, dos abajo
        If columnaFinal = columnaInicial + 1 And filaFinal = filaInicial + 2 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If
        'Dos casillas a la derecha, una abajo
        If columnaFinal = columnaInicial + 2 And filaFinal = filaInicial + 1 Then
            If nCasillas(columnaFinal, filaFinal) = "xx" Or nCasillas(columnaFinal, filaFinal).Substring(0, 1) <> color Then
                Return 0
            End If
        End If

        Return 1
    End Function
End Class
