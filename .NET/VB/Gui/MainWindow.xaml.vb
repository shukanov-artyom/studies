Class MainWindow
    Private Sub ButtonBase_OnClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim st = New BstSymbolTable

        st.Insert(New Item() With {.Key = 3, .Value = "c"})
        st.Insert(New Item() With {.Key = 1, .Value = "a"})
        st.Insert(New Item() With {.Key = 2, .Value = "b"})
        st.Insert(New Item() With {.Key = 4, .Value = "d"})

        Dim itemb = st.Find(2)
        Console.WriteLine(itemb.Key)

    End Sub
End Class
