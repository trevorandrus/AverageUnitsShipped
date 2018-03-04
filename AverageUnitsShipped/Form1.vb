Public Class Form1
    'Creates variables to be used in our form
    Private daysPassed As Integer = 1
    Private sumSold As Integer = 0
    Private inputValidated As Integer
    Private averageSold As Double
    Dim salesAmounts(7) As Integer

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Checks how many days have passed
        If daysPassed <= 7 Then
            'Checks if input is valid

            If Integer.TryParse(tbInput.Text, inputValidated) And inputValidated >= 0 And inputValidated <= 1000 Then
                'If input is valid takes the input and adds it to the list of entries and continues to the next day
                salesAmounts(daysPassed - 1) = tbInput.Text

                tbPreviousValues.Text() = tbPreviousValues.Text() & salesAmounts(daysPassed - 1) & vbNewLine
                daysPassed += 1
                lbDaysPassed.Text = "Day: " & daysPassed
                tbInput.Clear()

                If (daysPassed = 8) Then
                    'Once we have 7 pieces of valid input calculates the average and prevents further entries
                    lbDaysPassed.Text = "Day: 7"
                    tbInput.ReadOnly = True
                    'Loops through the array and finds the sum
                    For counter As Integer = 0 To 6 Step 1
                        sumSold += salesAmounts(counter)
                    Next counter

                    averageSold = sumSold / 7
                    averageSold = Math.Round(averageSold, 2)
                    tbAverage.Text = "Average per day: " & averageSold
                End If

            Else
                'If input is invalid displays an error message and allows the user to try again
                tbInput.Focus()
                MessageBox.Show("You must enter a whole number from 1 - 1000.")
            End If
        End If

    End Sub

    Private Sub btnExitForm_Click(sender As Object, e As EventArgs) Handles btnExitForm.Click
        'Closes form
        Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clears all text boxes and resets variables to their defaults
        tbPreviousValues.Clear()
        tbInput.Clear()
        tbAverage.Clear()
        tbInput.ReadOnly = False
        lbDaysPassed.Text = "Day: 1"
        daysPassed = 1
        sumSold = 0
        inputValidated = 0
        averageSold = 0

    End Sub


End Class
