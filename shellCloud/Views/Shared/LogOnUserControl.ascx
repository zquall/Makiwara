<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (Request.IsAuthenticated) {
%>
        Bienvenido <strong><%: Page.User.Identity.Name %></strong>!
        [ <%: Html.ActionLink("Cerrar Sesion", "LogOff", "Account") %> ]
<%
    }
    else {
%> 
        [ <%: Html.ActionLink("Iniciar Sesion", "LogOn", "Account") %> ]
<%
    }
%>
