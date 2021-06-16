<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbDepositoPoupanca = New System.Windows.Forms.RadioButton()
        Me.rdbDepositoConta = New System.Windows.Forms.RadioButton()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValorDeposito = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbSaquePoupanca = New System.Windows.Forms.RadioButton()
        Me.rdbSaqueConta = New System.Windows.Forms.RadioButton()
        Me.btnSacar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValorSaque = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAdicionarJurosPoupanca = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJurosPoupanca = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSaldoPoupanca = New System.Windows.Forms.Label()
        Me.lblTitularConta = New System.Windows.Forms.Label()
        Me.lblTitularPoupanca = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbDepositoPoupanca)
        Me.GroupBox1.Controls.Add(Me.rdbDepositoConta)
        Me.GroupBox1.Controls.Add(Me.btnDepositar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtValorDeposito)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 166)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Depósito (R$)"
        '
        'rdbDepositoPoupanca
        '
        Me.rdbDepositoPoupanca.AutoSize = True
        Me.rdbDepositoPoupanca.Location = New System.Drawing.Point(21, 137)
        Me.rdbDepositoPoupanca.Name = "rdbDepositoPoupanca"
        Me.rdbDepositoPoupanca.Size = New System.Drawing.Size(88, 20)
        Me.rdbDepositoPoupanca.TabIndex = 4
        Me.rdbDepositoPoupanca.Text = "Poupança"
        Me.rdbDepositoPoupanca.UseVisualStyleBackColor = True
        '
        'rdbDepositoConta
        '
        Me.rdbDepositoConta.AutoSize = True
        Me.rdbDepositoConta.Checked = True
        Me.rdbDepositoConta.Location = New System.Drawing.Point(20, 110)
        Me.rdbDepositoConta.Name = "rdbDepositoConta"
        Me.rdbDepositoConta.Size = New System.Drawing.Size(61, 20)
        Me.rdbDepositoConta.TabIndex = 3
        Me.rdbDepositoConta.TabStop = True
        Me.rdbDepositoConta.Text = "Conta"
        Me.rdbDepositoConta.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.Location = New System.Drawing.Point(20, 70)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(75, 33)
        Me.btnDepositar.TabIndex = 2
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor"
        '
        'txtValorDeposito
        '
        Me.txtValorDeposito.Location = New System.Drawing.Point(21, 45)
        Me.txtValorDeposito.Name = "txtValorDeposito"
        Me.txtValorDeposito.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtValorDeposito.Size = New System.Drawing.Size(147, 22)
        Me.txtValorDeposito.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbSaquePoupanca)
        Me.GroupBox2.Controls.Add(Me.rdbSaqueConta)
        Me.GroupBox2.Controls.Add(Me.btnSacar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtValorSaque)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(224, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 166)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saque (R$)"
        '
        'rdbSaquePoupanca
        '
        Me.rdbSaquePoupanca.AutoSize = True
        Me.rdbSaquePoupanca.Location = New System.Drawing.Point(23, 136)
        Me.rdbSaquePoupanca.Name = "rdbSaquePoupanca"
        Me.rdbSaquePoupanca.Size = New System.Drawing.Size(88, 20)
        Me.rdbSaquePoupanca.TabIndex = 6
        Me.rdbSaquePoupanca.Text = "Poupança"
        Me.rdbSaquePoupanca.UseVisualStyleBackColor = True
        '
        'rdbSaqueConta
        '
        Me.rdbSaqueConta.AutoSize = True
        Me.rdbSaqueConta.Checked = True
        Me.rdbSaqueConta.Location = New System.Drawing.Point(22, 109)
        Me.rdbSaqueConta.Name = "rdbSaqueConta"
        Me.rdbSaqueConta.Size = New System.Drawing.Size(61, 20)
        Me.rdbSaqueConta.TabIndex = 5
        Me.rdbSaqueConta.TabStop = True
        Me.rdbSaqueConta.Text = "Conta"
        Me.rdbSaqueConta.UseVisualStyleBackColor = True
        '
        'btnSacar
        '
        Me.btnSacar.Location = New System.Drawing.Point(22, 70)
        Me.btnSacar.Name = "btnSacar"
        Me.btnSacar.Size = New System.Drawing.Size(75, 33)
        Me.btnSacar.TabIndex = 2
        Me.btnSacar.Text = "Sacar"
        Me.btnSacar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor"
        '
        'txtValorSaque
        '
        Me.txtValorSaque.Location = New System.Drawing.Point(22, 45)
        Me.txtValorSaque.Name = "txtValorSaque"
        Me.txtValorSaque.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtValorSaque.Size = New System.Drawing.Size(147, 22)
        Me.txtValorSaque.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Saldo da Conta  (R$) : "
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.Location = New System.Drawing.Point(38, 259)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(83, 25)
        Me.lblSaldo.TabIndex = 2
        Me.lblSaldo.Text = "Label4"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAdicionarJurosPoupanca)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtJurosPoupanca)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(437, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 166)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Poupanca - Juros"
        '
        'btnAdicionarJurosPoupanca
        '
        Me.btnAdicionarJurosPoupanca.Location = New System.Drawing.Point(22, 76)
        Me.btnAdicionarJurosPoupanca.Name = "btnAdicionarJurosPoupanca"
        Me.btnAdicionarJurosPoupanca.Size = New System.Drawing.Size(150, 54)
        Me.btnAdicionarJurosPoupanca.TabIndex = 2
        Me.btnAdicionarJurosPoupanca.Text = "Adicionar Juros na Conta de Poupança"
        Me.btnAdicionarJurosPoupanca.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Taxa de juros"
        '
        'txtJurosPoupanca
        '
        Me.txtJurosPoupanca.Location = New System.Drawing.Point(22, 45)
        Me.txtJurosPoupanca.Name = "txtJurosPoupanca"
        Me.txtJurosPoupanca.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtJurosPoupanca.Size = New System.Drawing.Size(147, 22)
        Me.txtJurosPoupanca.TabIndex = 3
        Me.txtJurosPoupanca.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(443, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Saldo da Poupança  (R$) : "
        '
        'lblSaldoPoupanca
        '
        Me.lblSaldoPoupanca.AutoSize = True
        Me.lblSaldoPoupanca.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoPoupanca.ForeColor = System.Drawing.Color.Blue
        Me.lblSaldoPoupanca.Location = New System.Drawing.Point(499, 259)
        Me.lblSaldoPoupanca.Name = "lblSaldoPoupanca"
        Me.lblSaldoPoupanca.Size = New System.Drawing.Size(83, 25)
        Me.lblSaldoPoupanca.TabIndex = 2
        Me.lblSaldoPoupanca.Text = "Label4"
        '
        'lblTitularConta
        '
        Me.lblTitularConta.AutoSize = True
        Me.lblTitularConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitularConta.Location = New System.Drawing.Point(43, 208)
        Me.lblTitularConta.Name = "lblTitularConta"
        Me.lblTitularConta.Size = New System.Drawing.Size(57, 18)
        Me.lblTitularConta.TabIndex = 3
        Me.lblTitularConta.Text = "Label6"
        '
        'lblTitularPoupanca
        '
        Me.lblTitularPoupanca.AutoSize = True
        Me.lblTitularPoupanca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitularPoupanca.Location = New System.Drawing.Point(501, 208)
        Me.lblTitularPoupanca.Name = "lblTitularPoupanca"
        Me.lblTitularPoupanca.Size = New System.Drawing.Size(57, 18)
        Me.lblTitularPoupanca.TabIndex = 3
        Me.lblTitularPoupanca.Text = "Label6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(663, 293)
        Me.Controls.Add(Me.lblTitularPoupanca)
        Me.Controls.Add(Me.lblTitularConta)
        Me.Controls.Add(Me.lblSaldoPoupanca)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDepositar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtValorDeposito As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSacar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtValorSaque As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdicionarJurosPoupanca As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtJurosPoupanca As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSaldoPoupanca As System.Windows.Forms.Label
    Friend WithEvents rdbDepositoPoupanca As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDepositoConta As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSaquePoupanca As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSaqueConta As System.Windows.Forms.RadioButton
    Friend WithEvents lblTitularConta As System.Windows.Forms.Label
    Friend WithEvents lblTitularPoupanca As System.Windows.Forms.Label

End Class
