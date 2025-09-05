<%@ Page Title="" Language="C#" MasterPageFile="~/profile.master" AutoEventWireup="true" CodeBehind="updel.aspx.cs" Inherits="Portfolio74.updel" %>
<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
    <title>Edit My Profile</title>
    <link href="styles.css?v=10" rel="stylesheet" />
    <script src="scripts.js?v=2" defer="defer"></script>
</asp:Content>
<asp:Content ID="mainContent" ContentPlaceHolderID="Maincontent" runat="server">
    <div class="project-list">
        <h1 class="navbar-title">Update or Delete Project</h1>
        <label for="titlebox">Project Title</label><br />
        <asp:TextBox ID="titlebox" runat="server" CssClass="input-field" /><br />
        <label for="descriptionbox">Project Description</label><br />
        <asp:TextBox ID="descriptionbox" runat="server" CssClass="input-field" TextMode="MultiLine" Rows="4" /><br />
        <label for="githublinkbox">GitHub Link</label><br />
        <asp:TextBox ID="githublinkbox" runat="server" CssClass="input-field" /><br />
        <asp:Label ID="errorlabel" runat="server" ForeColor="Red" Text=""></asp:Label><br />
        <asp:Button ID="updateBtn" runat="server" Text="Update Project" CssClass="emailButton" OnClick="UpdateProject" />
        <asp:Button ID="deleteBtn" runat="server" Text="Delete Project" CssClass="emailButton" OnClick="DeleteProject" />
        <asp:Button ID="addBtn" runat="server" Text="Add Project" CssClass="emailButton" OnClick="AddProject" />
    </div>
</asp:Content>
