<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment02.aspx.cs" Inherits="Assignments.Assignment02" %>

<!DOCTYPE html>
<html>
<head>
    <title>Assingment 02</title>
    <meta charset="utf-8" />
    <link href="css/font-awesome.min.css" rel="stylesheet">
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/templatemo-style.css" rel="stylesheet">
    <link rel="import" href="Sidebar.html">

</head>
<body>
    <div class="templatemo-flex-row">
        <div id="container" class="templatemo-sidebar"></div>
        <script>
            var link = document.querySelector('link[rel="import"]');
            var template = link.import.querySelector('template');
            var clone = document.importNode(template.content, true);
            document.querySelector('#container').appendChild(clone);
        </script>


        <div class="templatemo-content col-1 light-gray-bg">
            <div class="templatemo-flex-row flex-content-row">
                <div id="asg1" class="templatemo-content-widget white-bg col-1">
                    <i class="fa fa-times"></i>
                    <div class="square"></div>
                    <h2 class="templatemo-inline-block">Assignment02:</h2>
                    <hr>
                    <h4>Write a file on the server</h4>
                    <p>In this homework you will collect registration data from the user and write it to a text file on the web server. Once that is working you need to at at least one CSS3 and on HTML5 feature to the page. Finally you must create a document of what you did </p>
                    <ul style="list-style-type: decimal">
                        <li>Create a new Empty ASP.NET page.</li>
                        <li>Create a web page that includes ASP.NET (C#), HTML, CSS and JavaScript.</li>
                    </ul>
                </div>
            </div>
            <div class="templatemo-content-widget blue-bg">
                <i class="fa fa-times"></i>
                <form runat="server" class="templatemo-login-form">
                    <table style="margin: auto; width: 70%;">
                        <tr>
                            <td><span>Name: </span></td>
                            <td>
                                <asp:TextBox class="form-control" Width="150px" Height="16px" ID="TBName" runat="server" ></asp:TextBox></td>
                            <td style="width: 100px"></td>
                        </tr>
                        <tr>
                            <td><span>Email Address: </span></td>
                            <td>
                                <asp:TextBox class="form-control" Width="150px" Height="16px" ID="TBEmail" runat="server"></asp:TextBox></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td><span>Login Name: </span></td>
                            <td>
                                <asp:TextBox class="form-control" Width="150px" Height="16px" ID="TBLogin" runat="server"></asp:TextBox></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td colspan="3"><span>Reason for Access?</span></td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:TextBox class="form-control" Width="100%" Height="250" ID="TBReason" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr><td><br /><asp:Button class="templatemo-blue-button" ID="Button1" width="110" runat="server" Text="Summit" /></td></tr>
                    </table>
                </form>

            </div>

            <!--table-->
        </div>
    </div>
    <script src="js/jquery-1.11.2.min.js"></script>
    <!-- jQuery -->
    <script src="js/jquery-migrate-1.2.1.min.js"></script>
    <!--  jQuery Migrate Plugin -->
    <script type="text/javascript" src="js/templatemo-script.js"></script>


</body>
</html>
