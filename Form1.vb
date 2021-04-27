Public Class Form1


    Private Sub Button1_MouseMove(ByVal sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        Randomize()
        Dim randx As Integer = 0, randy As Integer = 0
        randx = CInt((Me.Width - 1) * Rnd())
        randy = CInt((Me.Height - 1) * Rnd())

        If randx < Me.Width And randy < Me.Height Then
            If randx > Button1.Width Then randx -= Button1.Width
            If randx > Button1.Height Then randx -= Button1.Height

            Button1.Location = New Point(randx, randy)
        Else
            Button1.Location = New Point(Me.Width / 2, Me.Height / 2)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(" yo tampoco queria ser tu novia jJ ")
    End Sub

End Class
