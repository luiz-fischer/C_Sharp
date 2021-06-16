Public Class Conta

    Protected _titular As String
    Public Overridable ReadOnly Property ID() As String
        Get
            Return _titular
        End Get
    End Property

    Private _saldo As Decimal
    Public ReadOnly Property Saldo() As Decimal
        Get
            Return _saldo
        End Get
    End Property

    Public Sub New(ByVal titular As String)
        _titular = titular
        _saldo = 0D
    End Sub

    Public Function Deposito(ByVal valor As Decimal) As Decimal
        _saldo += valor
        Return _saldo
    End Function

    Public Function Saque(ByVal valor As Decimal) As Decimal
        _saldo -= valor
        Return _saldo
    End Function

End Class
