<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<shellCloud.Models.ProjectInformModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    CreateProjectInform
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Mantenimiento de Informes</h2>


<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Informe del Proyecto</legend>
        <p><%: Model.Project.Name %></p>
        <p><%: Model.Project.Code %></p>
        <p><%: Model.Project.State %></p>
        <p><%: Model.Project.Customer.Name %></p>
        <p><%: Model.DateCreated %></p>
        <p><%: Model.DateModified %></p>
        <p><%: Model.InspectorName %></p>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Project.Name) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Project.Name)%>
            <%: Html.ValidationMessageFor(model => model.Project.Name)%>
        </div>
        
        <p>
            <input type="submit" value="Guardar" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
