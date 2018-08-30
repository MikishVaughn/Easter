Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim eventDate = Easter.GetEasterDate()

        ' Drop unneeded time portion of the string 
        tb_Easter.Text = CType(eventDate.Month, String) + "-" +
        CType(eventDate.Day, String) + "-" +
        CType(eventDate.Year, String)

    End Sub
End Class
