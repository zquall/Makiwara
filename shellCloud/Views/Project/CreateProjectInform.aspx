<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ReplicantRepository.DataTransferObjects.ProjectInformDto>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    CreateProjectInform
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>CreateProjectInform</h2>


<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>ProjectInformDto</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ProjectId) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ProjectId) %>
            <%: Html.ValidationMessageFor(model => model.ProjectId) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.StateId) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.StateId) %>
            <%: Html.ValidationMessageFor(model => model.StateId) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.WasDeleted) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.WasDeleted) %>
            <%: Html.ValidationMessageFor(model => model.WasDeleted) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DateCreated) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DateCreated) %>
            <%: Html.ValidationMessageFor(model => model.DateCreated) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DateModified) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.DateModified) %>
            <%: Html.ValidationMessageFor(model => model.DateModified) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Advanced) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Advanced) %>
            <%: Html.ValidationMessageFor(model => model.Advanced) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.UserId) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.UserId) %>
            <%: Html.ValidationMessageFor(model => model.UserId) %>
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
