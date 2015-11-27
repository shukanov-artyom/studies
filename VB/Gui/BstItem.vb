Imports System

Public Class BstItem

    Public Sub New(ByVal inp As Item)
        Key = inp.Key
        Item = inp
    End Sub

    Public Left As BstItem

    Public Right As BstItem

    Public Key As Integer

    Public Property Item As Item

End Class
