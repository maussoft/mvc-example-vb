<%@ Master %>
<!DOCTYPE html>
<html>
  <head>
    <title>Hello <%= Context.Data.Name %></title>
  </head>
  <body>
    <% RenderViewContent() %>
  </body>
</html>