<%@ Page Inherits="Layouts.Default" %>
<form method="post">
	<div>
		<label>Item</label><br>
		<input type="text" name="Item" value="<%= Context.Data.Values.Item %>"></input><br>
		<% If Context.Data.Errors?.Item.Length Then %>
		<span>
			<%= Context.Data.Errors.Item %>
		</span><br>
		<% End If %>
		<input type="submit" value="Add" />
	</div>
</form>