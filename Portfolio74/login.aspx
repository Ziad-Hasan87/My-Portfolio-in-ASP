<%@ Page Title="" Language="C#" MasterPageFile="~/profile.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Portfolio74.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class ="Login-container">
        <h1 class ="navbar-title">Log In</h1>
        <label for="usernamebox">Username</label>
        <asp:TextBox ID="usernamebox" runat="server" CssClass="input-field" />

        <label for="passwordbox">Password</label>
        <asp:TextBox ID="passwordbox" runat="server" CssClass="input-field" TextMode="Password" /><br />
        <asp:Label ID="errorlabel" runat="server" ForeColor="Red" Text=""></asp:Label>
        <asp:Button ID="loginBtn" runat="server" Text="Log In" CssClass="emailButton" OnClick="LogIn" />
    </div>
</asp:Content>
