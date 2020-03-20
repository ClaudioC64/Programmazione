Public Class Form1
    Dim memoria As Integer
    Dim somma As Integer
    Dim Operatore As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        memoria = 0
        somma = 0
        Operatore = 0


        'Dichiarazione variabili per dimensione pulsanti
        Dim DimPulsanti As Object
        DimPulsanti = New Size(30, 30)

        'Creazione pulsanti

        Button1.Size = DimPulsanti
        Button2.Size = DimPulsanti
        Button3.Size = DimPulsanti
        Button4.Size = DimPulsanti
        Button5.Size = DimPulsanti
        Button6.Size = DimPulsanti
        Button7.Size = DimPulsanti
        Button8.Size = DimPulsanti
        Button9.Size = DimPulsanti
        Button10.Size = DimPulsanti
        Button11.Size = DimPulsanti
        Button12.Size = DimPulsanti
        Button13.Size = DimPulsanti
        Button14.Size = DimPulsanti
        Button15.Size = DimPulsanti
        Button16.Size = DimPulsanti

        'Disposizione pulsanti
        Button1.Location = New Point(50, 100)
        Button2.Location = New Point(100, 100)
        Button3.Location = New Point(150, 100)
        Button4.Location = New Point(50, 150)
        Button5.Location = New Point(100, 150)
        Button6.Location = New Point(150, 150)
        Button7.Location = New Point(50, 200)
        Button8.Location = New Point(100, 200)
        Button9.Location = New Point(150, 200)
        Button10.Location = New Point(100, 250)
        Button11.Location = New Point(200, 100) '+
        Button12.Location = New Point(200, 150) '-
        Button13.Location = New Point(200, 200) 'x
        Button14.Location = New Point(200, 250) '/
        Button15.Location = New Point(150, 250) '=
        Button16.Location = New Point(50, 250) 'C

        'Display risultato
        Label2.Location = New Point(50, 10)
        Label2.Text = memoria

        'Casella di testo
        TextBox1.Location = New Point(50, 50)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = TextBox1.Text + "1"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Addizione
        memoria = Int(TextBox1.Text)
        TextBox1.Text = ""
        If Operatore = 0 Then
            somma = memoria
        ElseIf Operatore = 1 Then
            somma = somma + memoria
        ElseIf Operatore = 2 Then
            somma = somma - memoria
        ElseIf Operatore = 3 Then
            somma = somma * memoria
        ElseIf Operatore = 4 Then
            somma = somma / memoria
        End If
        Operatore = 1
        Label1.Text = memoria
        Label2.Text = somma
        Label3.Text = Operatore


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'Sottrazione
        memoria = Int(TextBox1.Text)
        TextBox1.Text = ""
        If Operatore = 0 Then
            somma = memoria
        ElseIf Operatore = 1 Then
            somma = somma + memoria
        ElseIf Operatore = 2 Then
            somma = somma - memoria
        ElseIf Operatore = 3 Then
            somma = somma * memoria
        ElseIf Operatore = 4 Then
            somma = somma / memoria
        End If
        Operatore = 2
        Label1.Text = memoria
        Label2.Text = somma
        Label3.Text = Operatore

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'Moltiplicazione
        memoria = Int(TextBox1.Text)
        TextBox1.Text = ""
        If Operatore = 0 Then
            somma = memoria
        ElseIf Operatore = 1 Then
            somma = somma + memoria
        ElseIf Operatore = 2 Then
            somma = somma - memoria
        ElseIf Operatore = 3 Then
            somma = somma * memoria
        ElseIf Operatore = 4 Then
            somma = somma / memoria
        End If
        Operatore = 3
        Label1.Text = memoria
        Label2.Text = somma
        Label3.Text = Operatore

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'Divisione
        memoria = Int(TextBox1.Text)
        TextBox1.Text = ""
        If Operatore = 0 Then
            somma = memoria
        ElseIf Operatore = 1 Then
            somma = somma + memoria
        ElseIf Operatore = 2 Then
            somma = somma - memoria
        ElseIf Operatore = 3 Then
            somma = somma * memoria
        ElseIf Operatore = 4 Then
            somma = somma / memoria
        End If
        Operatore = 4
        Label1.Text = memoria
        Label2.Text = somma
        Label3.Text = Operatore


    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'Uguale
        memoria = Int(TextBox1.Text)
        TextBox1.Text = ""
        If Operatore = 0 Then
            somma = memoria
        ElseIf Operatore = 1 Then
            somma = somma + memoria
        ElseIf Operatore = 2 Then
            somma = somma - memoria
        ElseIf Operatore = 3 Then
            somma = somma * memoria
        ElseIf Operatore = 4 Then
            somma = somma / memoria
        End If
        TextBox1.Text = somma
        Operatore = 4
        Label1.Text = memoria
        Label2.Text = somma
        Label3.Text = Operatore


    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        'Cancella
        memoria = 0
        somma = 0
        Operatore = 0
        TextBox1.Text = ""
        Label1.Text = memoria
        Label2.Text = somma
        Label3.Text = Operatore

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
