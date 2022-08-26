'
' WARNING: Generated file, do not edit, changes will be lost!
'


Namespace Views.Test
	Public Class Hello(Of TSession As New)
		Inherits Global.Maussoft.Mvc.View(Of TSession)
		
		Public Overrides Sub Content()
			Write("{0}",  Context.Data.Html )
		End Sub
	End Class
End Namespace