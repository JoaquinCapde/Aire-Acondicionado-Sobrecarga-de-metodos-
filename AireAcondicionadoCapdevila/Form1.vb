Public Class Form1
    Dim aire1 As Aire = New Aire()

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        aire1.marca = txtMarca.Text
        aire1.pais = txtPais.Text
        aire1.frigorias = Convert.ToInt32(txtFrigorias.Text)
        aire1.temperatura = 20
        aire1.split = chkSplit.Checked
        If rdbFrioSolo.Checked Then
            aire1.friosolo = True
        End If
        If rdbFrioCalor.Checked Then
            aire1.friosolo = False
        End If
        txtModelo.Text = aire1.Modelo()
        lblTemperatura.Text = aire1.temperatura.ToString()
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        If (lblPower.Text = "OFF") Then
            lblPower.Text = "ON"
            btnMenos.Enabled = True
            btnMas.Enabled = True
            btnMin.Enabled = True
            btnMax.Enabled = True
            txtGrados.Enabled = True
        End If
        If (lblPower.Text = "ON") Then
            lblPower.Text = "OFF"
            btnMenos.Enabled = False
            btnMas.Enabled = False
            btnMin.Enabled = False
            btnMax.Enabled = False
            txtGrados.Enabled = False
        End If
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        txtGrados.Text = aire1.BAJAR(Convert.ToInt32(txtGrados.Text)).ToString()
    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        txtGrados.Text = aire1.Subir(Convert.ToInt32(txtGrados.Text)).ToString()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        txtGrados.Text = aire1.BAJAR().ToString()
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        txtGrados.Text = aire1.SUBIR().ToString()
    End Sub
End Class
