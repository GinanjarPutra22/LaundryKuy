Public Class Form1
    Dim f2 As Form2

    Private Sub textclear()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Jk As String
        If RadioButton1.Checked = True Then
            Jk = RadioButton1.Text
        Else
            Jk = RadioButton2.Text

        End If

        Form_Data_Pelanggan.DataGridView1.Rows.Add(1)
        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(0).Value = txtNama.Text
        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(1).Value = txtAlamat.Text
        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(1).Value = txtAlamat.Text
        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(1).Value = txtAlamat.Text
        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(2).Value = txtHp.Text
        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(3).Value = txtCatatan.Text
        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(4).Value = DateTimePicker1.Value
        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(5).Value = DateTimePicker2.Value
        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(6).Value = cbJenis.Text
        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(7).Value = txtBerat.Text
        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(8).Value = Jk


        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(9).Value = txtHarga.Text
        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(10).Value = txtTotal.Text
        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(11).Value = txtuang.Text
        Form_Data_Pelanggan.DataGridView1.Rows(Form_Data_Pelanggan.DataGridView1.RowCount - 2).Cells(12).Value = txtKembalian.Text
        MsgBox("Data Berhasil Disimpan!", MsgBoxStyle.Information)
        Form_Data_Pelanggan.Show()
        Me.Hide()

        txtNama.Text = ""
        txtAlamat.Text = ""
        txtHp.Text = ""
        txtCatatan.Text = ""
        txtBerat.Text = ""
        txtAlamat.Text = ""
        txtAlamat.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        cbJenis.Text = ""
        txtHarga.Text = ""
        txtTotal.Text = ""
        txtuang.Text = ""
        txtKembalian.Text = ""




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form_Data_Pelanggan.Show()
        Me.Hide()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtHp.Text = ""
        txtCatatan.Text = ""
        txtBerat.Text = ""
        txtAlamat.Text = ""
        txtAlamat.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        cbJenis.Text = ""
        txtHarga.Text = ""
        txtTotal.Text = ""
        txtuang.Text = ""
        txtKembalian.Text = ""


    End Sub

    Private Sub combojenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenis.SelectedIndexChanged
        If cbJenis.Text = "Pakaian" Then
            txtHarga.Text = "7000"
        ElseIf cbJenis.Text = "Karpet" Then
            txtHarga.Text = "12000"
        ElseIf cbJenis.Text = "Selimut" Then
            txtHarga.Text = "10000"
        ElseIf cbJenis.Text = "Boneka" Then
            txtHarga.Text = "8000"

        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles txtKembalian.TextChanged

    End Sub

    Private Sub txtHarga_TextChanged(sender As Object, e As EventArgs) Handles txtHarga.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim a, b As Integer
        Dim c = "5000"
        Dim hasil As Integer
        a = txtBerat.Text
        b = txtHarga.Text
        c = "5000"
        hasil = a * b
        txtTotal.Text = hasil
        If RadioButton2.Checked Then
            txtTotal.Text = hasil + c


        End If



    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim p, q, Kembalian As Integer
        p = txtuang.Text
        q = txtTotal.Text
        Kembalian = p - q
        txtKembalian.Text = Kembalian
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtHp.Text = ""
        txtCatatan.Text = ""
        txtBerat.Text = ""
        txtAlamat.Text = ""
        txtAlamat.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        cbJenis.Text = ""
        txtHarga.Text = ""
        txtTotal.Text = ""
        txtuang.Text = ""
        txtKembalian.Text = ""

    End Sub
End Class
