'
' WARNING: Generated file, do not edit, changes will be lost!
'

Imports System.Text
Imports System.Text.RegularExpressions

Namespace Views.Test
	Public Class Index(Of TSession As New)
		Inherits Layouts.Default(Of TSession)
		
		Public Overrides Sub Content()
			WriteLine()
			Context.Data.Title = Context.Data.Name  : WriteLine()
			WriteLine("Email: <input type=""text"" value=""{0}""></input>",  Context.Data.Email )
			Write("Test: <input type=""text"" value=""{0}""></input>",  "<?/!@#$$%^&*()_+-={}[]|\\:""';,.>")
		End Sub
	End Class
End Namespace