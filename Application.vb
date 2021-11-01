Imports System.Reflection
Imports Maussoft.Mvc

Public Class Application
	Public Shared Sub Main()
		Dim w as New WebServer(Of Session)("appsettings.json")
		w.Run()
	End Sub
End Class
