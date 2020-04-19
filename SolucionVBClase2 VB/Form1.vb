Public Class Form1
    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        System.Diagnostics.Process.Start("https://www.google.com/search?sxsrf=ALeKk00FM66tKMxv08qH4poIKmOxzDTxMw%3A1586371526334&source=hp&ei=xhuOXpnxEY655OUP9oej8AE&q=" & bTexto.Text & "&oq=" & bTexto.Text & " &gs_lcp=CgZwc3ktYWIQAzICCAAyAggAMgIIADICCAAyAggAMgIIADICCAAyAggAMgUIABCDATICCAA6BAgjECdKGQgXEhUwZzE0M2cxNzZnMTY3ZzE3MWcxMzVKDwgYEgswZzFnMWcxZzFnMVDqDFi3FGDGF2gAcAB4AIABf4gBrQSSAQMyLjOYAQCgAQGqAQdnd3Mtd2l6&sclient=psy-ab&ved=0ahUKEwiZ7Lm6vtnoAhWOHLkGHfbDCB4Q4dUDCAY&uact=5")

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("/Documentos/Programacion III/Navegador/bin/debug/Navegador.exe")
    End Sub
End Class
