<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<shellCloud.Models.ProjectInformModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Proyectos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Informes Pendientes</h2>
<% using (Html.BeginForm()) { %>
    <%if(Model.PendingProjectInforms.Count == 0)
    {%>
        <h3>Actualmente no posee informes pendientes</h3>
    <%}else{%>
        
        <%: Html.ValidationSummary(true, "Datos Incompletos. Revise sus datos e intente de nuevo.") %>
            <table border="0" width="100%" cellpadding="0" cellspacing="0" id="product-table">
                <thead>
        	        <tr>
				    <th class="table-header-check"><a id="toggle-all" ></a> </th>
				    <th class="table-header-repeat line-left"><a href="">Last Name</a>	</th>
				    <th class="table-header-repeat line-left"><a href="">First Name</a></th>
				    <th class="table-header-repeat line-left"><a href="">Email</a></th>
				    <th class="table-header-repeat line-left"><a href="">Due</a></th>
				    <th class="table-header-repeat line-left"><a href="">Website</a></th>
				    <th class="table-header-options line-left"><a href="">Options</a></th>
			    </tr>
                </thead>		
                <tbody>
			        <tr>
				    <td><input  type="checkbox"/></td>
				    <td>Sabev</td>
				    <td>George</td>
				    <td><a href="">george@mainevent.co.za</a></td>
				    <td>R250</td>
				    <td><a href="">www.mainevent.co.za</a></td>
				    <td class="options-width">
				    <a href="" title="Edit" class="icon-1 info-tooltip"></a>
				    <a href="" title="Edit" class="icon-2 info-tooltip"></a>
				    <a href="" title="Edit" class="icon-3 info-tooltip"></a>
				    <a href="" title="Edit" class="icon-4 info-tooltip"></a>
				    <a href="" title="Edit" class="icon-5 info-tooltip"></a>
				    </td>
			    </tr>
			        <tr class="alternate-row">
				    <td><input  type="checkbox"/></td>
				    <td>Sabev</td>
				    <td>George</td>
				    <td><a href="">george@mainevent.co.za</a></td>
				    <td>R250</td>
				    <td><a href="">www.mainevent.co.za</a></td>
				    <td class="options-width">
				    <a href="" title="Edit" class="icon-1 info-tooltip"></a>
				    <a href="" title="Edit" class="icon-2 info-tooltip"></a>
				    <a href="" title="Edit" class="icon-3 info-tooltip"></a>
				    <a href="" title="Edit" class="icon-4 info-tooltip"></a>
				    <a href="" title="Edit" class="icon-5 info-tooltip"></a>
				    </td>
			    </tr>
                </tbody>		
		    </table>        
		    <!--  end product-table................................... -->           
        <%}%>
        <div id="buttonpanel">
            <input id="pending-projects-button" type="button" value="Crear Nuevo"/>
        </div>
        <div id="pending-projects-dialog" class="invisible">
            algos
        </div>
<% } %>
</asp:Content>
