<%@ Page Inherits="Layouts.Default" %>
<ul>
    <% For Each item in Context.Session.Items %>
    <li>
        <%= item %>
    </li>
    <% Next %>
</ul>
<a href="/Todo/Add">Add</a>