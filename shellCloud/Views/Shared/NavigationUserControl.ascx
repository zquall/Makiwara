<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%
    if (Request.IsAuthenticated)
    {
%>
        <ul class="select">        
            <li>
                <div class="nav-submenu">
                    <div class="nav-text">
                        <%: Html.ActionLink("Dashboard", "Index", "Home")%>
                    </div>
                </div> 
            </li>
            <li>
                <div class="nav-submenu">
                    <div class="nav-text">
                        <%: Html.ActionLink("Proyectos", "Index", "Project")%>
                    </div>
                </div>
            </li>
            <li>
                <div class="nav-submenu">
                    <div class="nav-text">
                        <%: Html.ActionLink("Estado", "About", "Home")%>
                    </div>
                </div>
            </li>
		</ul>
<%
    }
    else
    {
%> 
        <ul class="select">        
            <li>
                <div class="nav-submenu">
                    <div class="nav-text">
                        <%: Html.ActionLink("Dashboard", "Index", "Home")%>
                    </div>
                </div>           
            </li>          
		</ul>
<%
    }
%>