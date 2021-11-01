Imports System.Net
Imports System.Text
Imports System.Collections.Generic
Imports Maussoft.Mvc

Namespace Controllers
	Public Class Test
		
		' before handler?
		Public Sub New()
		End Sub

		Public Sub Hello(context As WebContext(Of Session), id As Long, test As Integer, test3 As UInt32, test4 As String, Optional name As String = "world")
			Dim names As List(Of String)

			If context.Session.Names IsNot Nothing Then
				names = context.Session.Names
			Else
				names = New List(Of String)()
				context.Session.Names = names
			End If

			Dim rstr As String = [String].Format("{0}" & vbLf & "{1}" & vbLf & "{2}" & vbLf & "{3}" & vbLf & "hello {4}" & vbLf & "old: {5}", id, test, test3, test4, name, _
				[String].Join(",", names.ToArray()))

			names.Add(name)

			context.Data.Name = "World"
			context.Data.Html = rstr

			context.SendString(rstr)
		End Sub

		Public Sub Index(context As WebContext(Of Session))
			context.Data.Name = "World"
			context.Data.Email = "test@test.com"
		End Sub

		Public Sub Index2(context As WebContext(Of Session))
			Index(context)
			context.View = "Test.Index"
		End Sub

	End Class

End Namespace