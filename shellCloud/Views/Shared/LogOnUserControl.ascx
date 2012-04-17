<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%
    if (Request.IsAuthenticated)
    {
%>
        <div class="nav-submenu">
            <div class="nav-text text-blue">
                Bienvenido <strong><%:Page.User.Identity.Name%></strong>!
            </div>
        </div>
        <div class="nav-submenu">
            <div class="nav-text">
                <%:Html.ActionLink("Cerrar Sesion", "LogOff", "Account")%>
            </div>
        </div>
<%
    }
    else
    {
%> 
        <div class="nav-submenu">
            <div class="nav-text">
               <%:Html.ActionLink("Iniciar Sesion", "LogOn", "Account")%>
            </div>
        </div>
<%
    }
%>