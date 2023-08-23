Public Class Form1
    Private Sub CheckEligibilityButton_Click(sender As Object, e As EventArgs) Handles CheckEligibilityButton.Click

        ' Read GPA from the textbox

        Dim gpa As Double = CDbl(GpaTextBox.Text)



        ' Determine scholarship eligibility using a For loop

        Dim eligible As Boolean = False



        For year As Integer = 1 To 4

            If gpa >= 3.5 Then

                eligible = True

                Exit For

            End If

        Next



        ' Display eligibility message

        If eligible Then

            EligibilityStatusLabel.Text = "Congratulations! You are eligible for a scholarship."

        Else

            EligibilityStatusLabel.Text = "Sorry, you are not eligible for a scholarship."

        End If

    End Sub
End Class
