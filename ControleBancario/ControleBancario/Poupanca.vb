Public Class Poupanca
    Inherits Conta


    Public Sub New(ByVal _titular As String)
        MyBase.New(_titular)
    End Sub

    Public Overrides ReadOnly Property ID() As String
        Get
            Return Me._titular + "-P"
        End Get
    End Property

    Private _juros As Decimal = 0.01D
    Public Property Juros() As Decimal
        Get
            Return _juros
        End Get
        Set(ByVal Value As Decimal)
            _juros = Value
        End Set
    End Property

    Public Function AdicionarJuros() As Decimal
        Me.Deposito(_juros * Me.Saldo)
        Return Me.Saldo
    End Function

End Class
