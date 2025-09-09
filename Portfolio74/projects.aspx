<%@ Page Title="" Language="C#" MasterPageFile="~/profile.master" AutoEventWireup="true" CodeBehind="projects.aspx.cs" Inherits="Portfolio74.projects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Ziadul Hasan's Profile</title>
    <link rel="stylesheet" href="styles1.css?v=2" runat="server"/>
    <script src="scripts.js?v=2" defer="defer"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="menu">
        <br /><br />
    <asp:Repeater ID="ProjectsRepeater" runat="server">
        <ItemTemplate>
            <div class="item">
                <h1 class ="Project-title"><%# Eval("Title") %></h1>
                <p class ="Project-description"><%# Eval("Description") %></p>
                <a class="Project-link" href='<%# Eval("GitHub_Link") %>' target="_blank"><img src="https://github.githubassets.com/images/modules/logos_page/GitHub-Mark.png" class="github-logo">View on GitHub</a>
                <a class="Project-edit" href='<%# "updel.aspx?title=" + Server.UrlEncode(Eval("Title").ToString()) %>'>Edit</a>
            </div>
        </ItemTemplate>
    </asp:Repeater>
        <br />
        <a class="add-button" href="updel.aspx">Add New Project</a>
    </div>
</asp:Content>
