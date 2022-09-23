Public Class Form1
    Dim total As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kode.Focus()
    End Sub

    Private Sub ComboGol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboGol.SelectedIndexChanged
        If ComboGol.Text = "Golongan I" Then
            gol.Text = "10000"
        ElseIf ComboGol.Text = "Golongan II" Then
            gol.Text = "12500"
        ElseIf ComboGol.Text = "Golongan III" Then
            gol.Text = "15000"
        ElseIf ComboGol.Text = "Golongan IV" Then
            gol.Text = "17500"
        End If
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        LvKaryawan.Items.Add(Kode.Text)
        LvKaryawan.Items(LvKaryawan.Items.Count - 1).SubItems.Add(nama.Text)
        LvKaryawan.Items(LvKaryawan.Items.Count - 1).SubItems.Add(gapok.Text)
        LvKaryawan.Items(LvKaryawan.Items.Count - 1).SubItems.Add(ComboGol.Text)
        LvKaryawan.Items(LvKaryawan.Items.Count - 1).SubItems.Add(gol.Text)
    End Sub

    Private Sub hitung_Click(sender As Object, e As EventArgs) Handles hitung.Click
        total = 0
        FormHitung.ListView1.Items.Clear()
        For i As Integer = 0 To LvKaryawan.Items.Count - 1
            FormHitung.ListView1.Items.Add(LvKaryawan.Items(i).Text)
            FormHitung.ListView1.Items(i).SubItems.Add(LvKaryawan.Items(i).SubItems(1).Text)
            FormHitung.ListView1.Items(i).SubItems.Add(LvKaryawan.Items(i).SubItems(2).Text)
            FormHitung.ListView1.Items(i).SubItems.Add(LvKaryawan.Items(i).SubItems(3).Text)
            FormHitung.ListView1.Items(i).SubItems.Add(LvKaryawan.Items(i).SubItems(4).Text)
            FormHitung.ListView1.Items(i).SubItems.Add(CInt(LvKaryawan.Items(i).SubItems(4).Text) +
CInt(LvKaryawan.Items(i).SubItems(2).Text))
        Next
        For i As Integer = 0 To FormHitung.ListView1.Items.Count - 1
            total += CInt(FormHitung.ListView1.Items(i).SubItems(5).Text)
        Next
        FormHitung.total.Text = total
        FormHitung.ShowDialog()

    End Sub
End Class
