'
' WARNING: Generated file, do not edit, changes will be lost!
'


Namespace Views.Layouts
	Public Class [Default]
		Inherits Global.Maussoft.Mvc.View(Of Acme.Example.Session)
		
		Public Overrides Sub Header()
			WriteLine()
			WriteLine("<!DOCTYPE html>")
			WriteLine("<html>")
			WriteLine()
			WriteLine("<head>")
			WriteLine("	<title>")
			WriteLine("		{0}",  Context.Data.Title )
			WriteLine("	</title>")
			WriteLine("</head>")
			WriteLine()
			WriteLine("<body>")
			Write("	")
		End Sub

		Public Overrides Sub Footer()
			WriteLine()
			WriteLine("</body>")
			WriteLine()
			Write("</html>")
		End Sub
	End Class
End Namespace