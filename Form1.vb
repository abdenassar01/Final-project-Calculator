Public Class Calculatrice
    Dim firstnum As Double
    Dim secondnum As Double
    Dim optype As Integer
    Dim opcheck As Boolean = False

    Private Sub nb1_Click(sender As Object, e As EventArgs) Handles nb1.Click
        If Resultbox.Text <> "0" Then
            Resultbox.Text += "1"
        Else
            Resultbox.Text = "1"
        End If
    End Sub

    Private Sub nb2_Click(sender As Object, e As EventArgs) Handles nb2.Click
        If Resultbox.Text <> "0" Then
            Resultbox.Text += "2"
        Else
            Resultbox.Text = "2"
        End If
    End Sub

    Private Sub nb3_Click(sender As Object, e As EventArgs) Handles nb3.Click
        If Resultbox.Text <> "0" Then
            Resultbox.Text += "3"
        Else
            Resultbox.Text = "3"
        End If
    End Sub

    Private Sub nb4_Click(sender As Object, e As EventArgs) Handles nb4.Click
        If Resultbox.Text <> "0" Then
            Resultbox.Text += "4"
        Else
            Resultbox.Text = "4"
        End If
    End Sub

    Private Sub nb5_Click(sender As Object, e As EventArgs) Handles nb5.Click
        If Resultbox.Text <> "0" Then
            Resultbox.Text += "5"
        Else
            Resultbox.Text = "5"
        End If
    End Sub

    Private Sub nb6_Click(sender As Object, e As EventArgs) Handles nb6.Click
        If Resultbox.Text <> "0" Then
            Resultbox.Text += "6"
        Else
            Resultbox.Text = "6"
        End If
    End Sub

    Private Sub nb7_Click(sender As Object, e As EventArgs) Handles nb7.Click
        If Resultbox.Text <> "0" Then
            Resultbox.Text += "7"
        Else
            Resultbox.Text = "7"
        End If
    End Sub

    Private Sub nb8_Click(sender As Object, e As EventArgs) Handles nb8.Click
        If Resultbox.Text <> "0" Then
            Resultbox.Text += "8"
        Else
            Resultbox.Text = "8"
        End If
    End Sub

    Private Sub nb9_Click(sender As Object, e As EventArgs) Handles nb9.Click
        If Resultbox.Text <> "0" Then
            Resultbox.Text += "9"
        Else
            Resultbox.Text = "9"
        End If
    End Sub

    Private Sub nb0_Click(sender As Object, e As EventArgs) Handles nb0.Click
        If Resultbox.Text <> "0" Then
            Resultbox.Text += "0"
        Else
            Resultbox.Text = "0"
        End If
    End Sub

    Private Sub dicimal_Click(sender As Object, e As EventArgs) Handles dicimal.Click
        If Resultbox.Text <> "." Then
            Resultbox.Text += "."
        End If
    End Sub

    Private Sub ac_Click(sender As Object, e As EventArgs) Handles ac.Click
        Resultbox.Text = "0"
    End Sub

    Private Sub multiplication_Click(sender As Object, e As EventArgs) Handles multiplication.Click
        opcheck = True
        optype = 1
        firstnum = Resultbox.Text
        Resultbox.Text = "0"
    End Sub

    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        opcheck = True
        optype = 2
        firstnum = Resultbox.Text
        Resultbox.Text = "0"
    End Sub

    Private Sub addition_Click(sender As Object, e As EventArgs) Handles addition.Click
        opcheck = True
        optype = 3
        firstnum = Resultbox.Text
        Resultbox.Text = "0"
    End Sub

    Private Sub substraction_Click(sender As Object, e As EventArgs) Handles substraction.Click
        opcheck = True
        optype = 4
        firstnum = Resultbox.Text
        Resultbox.Text = "0"
    End Sub

    Private Sub egal_Click(sender As Object, e As EventArgs) Handles egal.Click
        If opcheck = True Then
            secondnum = Resultbox.Text
        End If
        If optype = 1 Then
            Resultbox.Text = firstnum * secondnum
        ElseIf optype = 2 And secondnum = 0 Then
            MsgBox("You can't devide by 0", MessageBoxIcon.Warning)
        ElseIf optype = 2 Then
            Resultbox.Text = firstnum / secondnum
        ElseIf optype = 3 Then
            Resultbox.Text = firstnum + secondnum
        ElseIf optype = 4 Then
            Resultbox.Text = firstnum - secondnum
        End If
    End Sub

End Class
