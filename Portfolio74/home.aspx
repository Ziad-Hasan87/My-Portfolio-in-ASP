<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Portfolio74.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Ziadul Hasan's Profile</title>
    <link rel="stylesheet" href="styles.css?v=7" runat="server"/>
    <script src="scripts.js?v=2" defer="defer"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section id="Home" class="home-section">
        <div class ="Home-left">
            <img src="images/profile.jpg" alt="Ziadul Hasan" class="profile-pic"/>
            <h1>Welcome to My Portfolio</h1>
        </div>
        <div class="Home-right">
            <h1>Department of CSE</h1>
            <p style="font-size:19px; color:rgba(2, 211, 247, 1)"">Khulna University of Engineering and Technology</p>
            <p style="font-size:17px">I am currently a student studying for my undergraduate degree. I have always loved technology and decided to pursue computer science in my university life. I had prior experience as a competitive programmer and also liked software development community.</p>
            <p style="font-size:17px">Nowadays, I focus more on academics and honing my skills in what I learn. I recently worked on web development, Android app development, graphics design and some game development in Unity. Check out my profile on Github for more recent work updates.</p>
        </div>
    </section>
    <section id="Projects">
        <div class="menu">
            <div class="item">
                <h2>Project</h2>
                <p>This is a sample test project by me.</p>
            </div>
            <div class="item">
                <h2>Project</h2>
                <p>This is a sample test project by me.</p>
            </div>
            <div class="item">
                <h2>Project</h2>
                <p>This is a sample test project by me.</p>
            </div>
            <div class="item">
                <h2>Project</h2>
                <p>This is a sample test project by me.</p>
            </div>
            <div class="item">
                <h2>Project</h2>
                <p>This is a sample test project by me.</p>
            </div>
        </div>
    </section>

    <section id="Skills">
        <div class="skills">
            <div class="item">
                <h3>C/C++</h3>
            </div>
            <div class="item">
                <h3>Java</h3>
            </div>
            <div class="item">
                <h3>Graphics Design & Animation</h3>
            </div>
            <div class="item">
                <h3>3D Render</h3>
            </div>
            <div class="item">
                <h3>Game Development in Unity</h3>
            </div>
            <div class="item">
                <h3>Web Development</h3>
            </div>
        </div>
    </section>
    <section id="Contact">
        <div class="contactBox">
            <div class="item">
                <h1 style="font-size:24px">Let’s build something brilliant</h1>
                <p style="font-size:19px">Have an idea, a product, or a team that needs a developer with taste? I’d love to help.</p>
                <asp:HyperLink ID="emailLink" CssClass="emailButton" runat="server" NavigateUrl="mailto:ziadul87@gmail.com" Text="Email ziadul87@gmail.com" />
                <asp:Button ID="linkedInButton" CssClass="linkedInButton" runat="server" Onclick="RedirectLinkedIn" Text="LinkedIn" />
            </div>
        </div>
    </section>
</asp:Content>
