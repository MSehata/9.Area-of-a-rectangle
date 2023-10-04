Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnCalculateArea_Click(sender As Object, e As EventArgs) Handles btnCalculateArea.Click
        Dim height As Double, length As Double, area As Double
        height = Val(txtHeight.Text)
        length = Val(txtLength.Text)

        area = height * length
        txtArea.Text = area
    End Sub
End Class
