Public Class BstSymbolTable

    Private root As BstItem

    Public Sub Insert(ByVal item As Item)
        Insert(root, item)
    End Sub

    Public Function Find(ByVal key As Integer) As BstItem
        Return Find(root, key)
    End Function

    Private Function Find(ByVal tree As BstItem, ByVal key As Integer) As BstItem
        If tree Is Nothing Then
            Return Nothing
        End If

        If tree.Key = key Then
            Return tree
        End If

        If tree.Key < key Then
            Return Find(tree.Right, key)
        Else
            Return Find(tree.Left, key)
        End If
    End Function

    Private Sub Insert(ByRef tree As BstItem, ByVal item As Item)
        Dim key As Integer = item.Key
        If tree Is Nothing Then
            tree = New BstItem(item)
            Return
        End If
        If key > tree.Key Then
            Insert(tree.Right, item)
        Else
            Insert(tree.Left, item)
        End If
    End Sub

End Class
