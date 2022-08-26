'
' WARNING: Generated file, do not edit, changes will be lost!
'


Namespace Views.Todo
	Public Class Index
		Inherits Layouts.Default
		
		Public Overrides Sub Content()
			WriteLine()
			WriteLine("    <ul>")
			Write("        ") : For Each item in Context.Session.Items  : WriteLine()
			WriteLine("            <li>")
			WriteLine("                {0}",  item )
			WriteLine("            </li>")
			Write("            ") : Next  : WriteLine()
			WriteLine("    </ul>")
			Write("    <a href=""/Todo/Add"">Add</a>")
		End Sub
	End Class
End Namespace