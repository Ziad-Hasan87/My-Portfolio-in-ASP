<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Portfolio74.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="stylesheet" href ="styles.css?v=2" runat="server"/>
    <script src="scripts.js" defer="defer"></script>
    <title>Ziadul Hasan's Profile</title>
</head>
<body>
    <form id="form1" runat="server">
            <nav class="navbar">
                <div class="navbar-container">
                    <a href="home.aspx" class ="navbar-title">Ziadul Hasan</a>
                    <button type="button" class="navbar-toggle">
                        <span class ="bar"></span>
                        <span class ="bar"></span>
                        <span class ="bar"></span>

                    </button>
                    <ul class="navbar-menu">
                        <li><a href="#" class="active">Home</a></li>
                        <li><a href="#Projects" >Projects</a></li>
                        <li><a href="#">Skills</a></li>
                        <li><a href="#Contact">Contact</a></li>
                    </ul>
                </div>
            </nav>
        <section id="Projects">
            <div class ="menu">
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
        <section id="Contact">
            <asp:Label ID="Label1" runat="server" Text="LabelWWWW">Hahahaha</asp:Label>
        </section>
    </form>
</body>
</html>
