<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%
    if (Request.IsAuthenticated)
    {
%>
<div class="nav-submenu">
    <div class="nav-text text-blue">
        <b> Bienvenido <strong><%:Page.User.Identity.Name%></strong>!</b>
    </div>
</div>
<div class="nav-submenu">
    <div class="nav-text">
        <b> <%:Html.ActionLink("Cerrar Sesion", "LogOff", "Account")%></b>
    </div>
</div>

<%
    }
    else
    {
%> 
<div class="nav-submenu">
    <div class="nav-text">
        <b> <%:Html.ActionLink("Iniciar Sesion", "LogOn", "Account")%></b>
    </div>
</div>
<%
    }
%>