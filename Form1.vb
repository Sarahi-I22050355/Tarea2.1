Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New Contacto()
        x.NombreP = TextBox1.Text
        x.TelefonoP = TextBox2.Text
        x.FechaNacimientoP = DateTime.Parse("2003/01/01")
        MsgBox(x.ToString(), MsgBoxStyle.Information, "RESULTADO")

    End Sub


End Class