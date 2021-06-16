Public Class Form1

    Dim contaMacoratti As New Conta("Macoratti")
    Dim contaPoupancaMacoratti As New Poupanca("Macoratti")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        atualizaSaldo()
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim valor As Decimal = 0D

        If String.IsNullOrEmpty(txtValorDeposito.Text) Then
            MessageBox.Show("Informe um valor para depósito!")
        Else
            valor = Convert.ToDecimal(txtValorDeposito.Text)
            If rdbDepositoConta.Checked Then
                contaMacoratti.Deposito(valor)
            ElseIf rdbDepositoPoupanca.Checked Then
                contaPoupancaMacoratti.Deposito(valor)
            End If
            atualizaSaldo()
            End If
    End Sub

    Private Sub btnSacar_Click(sender As Object, e As EventArgs) Handles btnSacar.Click
        Dim valor As Decimal = 0D

        If String.IsNullOrEmpty(txtValorSaque.Text) Then
            MessageBox.Show("Informe um valor para Saque!")
        Else
            valor = Convert.ToDecimal(txtValorSaque.Text)
            If rdbSaqueConta.Checked Then
                contaMacoratti.Saque(valor)
            ElseIf rdbSaquePoupanca.Checked Then
                contaPoupancaMacoratti.Saque(valor)
            End If
            atualizaSaldo()
        End If
    End Sub

    Private Sub atualizaSaldo()
        lblTitularConta.Text = contaMacoratti.ID
        lblSaldo.Text = contaMacoratti.Saldo.ToString("C")
        lblTitularPoupanca.Text = contaPoupancaMacoratti.ID
        lblSaldoPoupanca.Text = contaPoupancaMacoratti.Saldo.ToString("C")
    End Sub

    Private Sub txtValorDeposito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValorDeposito.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValorSaque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorSaque.KeyPress, txtJurosPoupanca.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAdicionarJurosPoupanca_Click(sender As Object, e As EventArgs) Handles btnAdicionarJurosPoupanca.Click
        Dim taxaJuros As Decimal = 0D
        taxaJuros = Convert.ToDecimal(txtJurosPoupanca.Text)
        If taxaJuros <> 0 Then
            'define o valor da taxa de juros na classe de poupança
            contaPoupancaMacoratti.Juros = taxaJuros
        End If
        'inclui os juros na conta de poupança
        contaPoupancaMacoratti.AdicionarJuros()
        atualizaSaldo()
    End Sub

End Class
