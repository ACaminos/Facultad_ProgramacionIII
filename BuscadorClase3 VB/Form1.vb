Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BackColor = Color.Red
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BackColor = Color.Green
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.BackColor = Color.Blue
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Visible = Not Button4.Visible
    End Sub

    Private Sub bUrl_Click(sender As Object, e As EventArgs) Handles bUrl.Click
        If String.IsNullOrEmpty(tBuscador.Text) Then Return
        If tBuscador.Equals("about:blank") Then Return
        If Not tBuscador.Text.StartsWith("http://") And Not tBuscador.Text.StartsWith("https://") Then
            tBuscador.Text = "http://" & tBuscador.Text
        End If
        Try
            WebBrowser1.Navigate(New Uri(tBuscador.Text))
        Catch
            MessageBox.Show("Se produjo un error")
        End Try
    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        System.Diagnostics.Process.Start("https://www.google.com.ar/search?sxsrf=ALeKk02D89EyZlLwfcRlnhYWPLdo3XOmng%3A1586734702291&source=hp&ei=bqaTXqiTD4G95OUPyfuIkAI&q=" + tBuscador.Text + "&oq=" + tBuscador.Text + "&gs_lcp=CgZwc3ktYWIQAzIECCMQJzICCAAyAggAMgIIADICCAAyAggAMgIIADICCAAyAggAMgIIADoFCAAQgwFKGAgXEhQyLTU3NWcxNzY5ZzE4MjlnMTg5MUoNCBgSCTItMWcxZzFnMVDumAFYwp8BYOazAWgAcAB4AYABpQ6IAdw1kgEJMi0xLjctMS4zmAEAoAEBqgEHZ3dzLXdperABAA&sclient=psy-ab&ved=0ahUKEwiogp-yh-ToAhWBHrkGHck9AiIQ4dUDCAY&uact=5")
    End Sub
End Class
