<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    About Us
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Descripcion del sistema</h2>
    <p>
        Actualmente el sistema esta en una etapa Beta y unicamente permite hacer informes diarios para proyectos.
    </p>
</asp:Content>
