Public Class counter

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        AmountDueTB.Text = NumberOfPagesTB.Text * PricePerPageTB.Text
    End Sub
End Class
