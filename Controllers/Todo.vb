Imports Maussoft.Mvc

Namespace Controllers
	Public Class Todo
		
        Public Sub Add(context As WebContext(Of Session))
            context.Data.Title = "Add Todo"
            If context.Method = "POST" Then
                context.Data.Values = New ViewData(context.Post)
                context.Data.Errors = New ViewData()
                If context.Data.Values.Item.Length = 0 Then
                    context.Data.Errors.Item = "Field is mandatory"
                End If
                If context.Data.Errors.Empty() Then
                    context.Session.Items.Add(context.Data.Values.Item)
                    context.Redirect("/Todo")
                    Return
                End If
            Else
                context.Data.Values = New ViewData()
            End If
        End Sub

        Public Sub Index(context As WebContext(Of Session))
            context.Data.Title = "List Todos"
        End Sub

	End Class

End Namespace