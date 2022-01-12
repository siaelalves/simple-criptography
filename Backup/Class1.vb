Public Class Class1
    Public Shared board(5, 5) As Char
    Public Shared key As String = "ADFGX"
    Public Shared keyword As String
    Public Shared lgn As Integer
    Public Shared t As String
    Overloads Shared Function ChangeChar(ByVal character As Char) As String
        Dim tx As String
        MsgBox(key(0))
        For i As Integer = 0 To 5
            For j As Integer = 0 To 5
                If board(i, j) = character Then
                    lgn = ChangeChar(character).Length
                    t = ChangeChar(character)
                    tx = key(i) & key(j)
                ElseIf character = " " Then
                    tx = " "
                End If
            Next
        Next
        Return tx
    End Function
    Overloads Shared Function ChangeChar(ByVal key As String) As Char()
        Dim secboard As Char(,)
        For i As Integer = 0 To Int(t.Length / keyword.Length) + 1
            For j As Integer = 0 To keyword.Length

            Next
        Next
    End Function
End Class
