Public Class Form1
    Dim Azar As Boolean = True
    Dim vprimerDado As Integer = 0
    Dim vsegundoDado As Integer = 0
    Dim vtercerDado As Integer = 0
    Dim vcuartoDado As Integer = 0
    Dim vquintoDado As Integer = 0
    Dim jugada As Integer = 1
    Dim jugador As Integer = 1

    Function NumDado(Random As Boolean) As Integer
        If Random Then Randomize()
        Return Int(Rnd() * 6 + 1)
    End Function

    Sub CambiaDado(ByRef DadoX As PictureBox, ByRef valorDado As Integer)
        Dim num As Integer = NumDado(True) : valorDado = num
        Select Case num
            Case 1 : DadoX.Image = My.Resources.dado1
            Case 2 : DadoX.Image = My.Resources.dado2
            Case 3 : DadoX.Image = My.Resources.dado3
            Case 4 : DadoX.Image = My.Resources.dado4
            Case 5 : DadoX.Image = My.Resources.dado5
            Case 6 : DadoX.Image = My.Resources.dado6
        End Select

    End Sub

    Private Sub cubilete_Click(sender As Object, e As EventArgs) Handles cubilete.Click
        Dim valorDado As Integer = 0

        CambiaDado(primerDado, valorDado) : vprimerDado = valorDado
        CambiaDado(segundoDado, valorDado) : vsegundoDado = valorDado
        CambiaDado(tercerDado, valorDado) : vtercerDado = valorDado
        CambiaDado(cuartoDado, valorDado) : vcuartoDado = valorDado
        CambiaDado(quintoDado, valorDado) : vquintoDado = valorDado


        If vprimerDado = vsegundoDado And vprimerDado = vtercerDado And vprimerDado = vcuartoDado And vprimerDado = vquintoDado Then 'Comparador en para sacar generala
            MessageBox.Show("¡GENERALA!")                                              'Caso contrario se pasa con ElseIf a POKER
        ElseIf vprimerDado = vsegundoDado And vprimerDado = vtercerDado And vprimerDado = vcuartoDado Then ' casos para POKER
            MessageBox.Show("¡POKER!")
        ElseIf vprimerDado = vtercerDado And vprimerDado = vcuartoDado And vprimerDado = vquintoDado Then 'Casos para POKER
            MessageBox.Show("¡POKER!")
        ElseIf vprimerDado = vsegundoDado And vprimerDado = vcuartoDado And vprimerDado = vquintoDado Then 'Casos para POKER
            MessageBox.Show("¡POKER")   
        ElseIf vprimerDado = vsegundoDado And vprimerDado = vtercerDado And vprimerDado = vquintoDado Then 'Casos para POKER
            MessageBox.Show("¡POKER!")
        ElseIf vsegundoDado = vtercerDado And vsegundoDado = vcuartoDado And vsegundoDado = vquintoDado Then 'Casos para POKER
            MessageBox.Show("¡POKER!")
        ElseIf vprimerDado = vsegundoDado And vprimerDado = vtercerDado Then          'En caso que no sea ninguno de los anteriores, pasa con elseif al FULL
            MessageBox.Show("¡FULL!")
        ElseIf vprimerDado = vcuartoDado And vprimerDado = vquintoDado Then
            MessageBox.Show("¡FULL!")
        ElseIf vprimerDado = vtercerDado And vprimerDado = vcuartoDado Then
            MessageBox.Show("¡FULL!")
        ElseIf vprimerDado = vsegundoDado And vprimerDado = vquintoDado Then
            MessageBox.Show("¡FULL!")
        ElseIf vprimerDado = vcuartoDado And vprimerDado = vsegundoDado Then
            MessageBox.Show("¡FULL!")
        ElseIf vprimerDado = vtercerDado And vprimerDado = vquintoDado Then
            MessageBox.Show("¡FULL!")
        ElseIf vsegundoDado = vtercerDado And vsegundoDado = vcuartoDado Then
            MessageBox.Show("¡FULL!")
        ElseIf vsegundoDado = vtercerDado And vsegundoDado = vquintoDado Then
            MessageBox.Show("¡FULL!")
        ElseIf vsegundoDado = vcuartoDado And vsegundoDado = vquintoDado Then
            MessageBox.Show("¡FULL!")
        ElseIf vcuartoDado = vtercerDado And vcuartoDado = vquintoDado Then
            MessageBox.Show("¡FULL!")
        End If
        turnoPartida()
    End Sub
    Public Sub turnoPartida()
        If jugador = 2 Then 'corrobora la cantidad de jugadas que hizo el jugador para cambiar el turno
            MessageBox.Show("Turno Jugador 2")
        Else If jugador = 4 then
            jugador -= 4
            MessageBox.Show("Turno Jugador 1")
        End If
        jugador+=1
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class