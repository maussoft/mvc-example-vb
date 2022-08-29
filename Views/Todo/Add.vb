'
' WARNING: Generated file, do not edit, changes will be lost!
'


Namespace Views.Todo
	Public Class Add
		Inherits Layouts.Default
		
		Public Overrides Sub Content()
			WriteLine()
			WriteLine("<form method=""post"">")
			WriteLine("	<div>")
			WriteLine("		<label>Item</label><br>")
			WriteLine("		<input type=""text"" name=""Item"" value=""{0}""></input><br>",  Context.Data.Values.Item )
			Write("		") : If Context.Data.Errors?.Item.Length Then  : WriteLine()
			WriteLine("		<span>")
			WriteLine("			{0}",  Context.Data.Errors.Item )
			WriteLine("		</span><br>")
			Write("		") : End If  : WriteLine()
			WriteLine("		<input type=""submit"" value=""Add"" />")
			WriteLine("	</div>")
			Write("</form>")
		End Sub
	End Class
End Namespace