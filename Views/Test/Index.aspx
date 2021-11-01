<%@ Page Inherits="Layouts.Default" Using="System.Text,System.Text.RegularExpressions" %>
<% Context.Data.Title = Context.Data.Name %>
Email: <input type="text" value="<%= Context.Data.Email %>"></input>
Test: <input type="text" value="<%= "<?/!@#$$%^&*()_+-={}[]|\\:""';,.>"%>"></input>