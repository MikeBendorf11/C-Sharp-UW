<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment02.aspx.cs" Inherits="Assignments.Assignment02" MasterPageFile="~/Assignments.Master" %>

<asp:Content ContentPlaceHolderID="phHead" runat="server">
    <title>Assingment 02</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="phContent1" runat="server">
    <div class="templatemo-flex-row flex-content-row">
        <div id="asg1" class="templatemo-content-widget white-bg col-1">
            <i class="fa fa-times"></i>
            <div class="square-light"></div>
            <h2 class="templatemo-inline-block">Assignment02:</h2>
            <hr>
            <h4>Write a file on the server</h4>
            <p>In this homework you will collect registration data from the user and write it to a text file on the web server. Once that is working you need to add at least one CSS3 and on HTML5 feature to the page. Finally you must create a document of what you did </p>
            <ul style="list-style-type: decimal">
                <li>Create a new Empty ASP.NET page.</li>
                <li>Create a web page that includes ASP.NET (C#), HTML, CSS and JavaScript.</li>
            </ul>
        </div>
        <div class="col-2">
            <div style="height:180px"></div>
            <div class="templatemo-content-widget blue-bg">
                <i class="fa fa-times"></i>
                <form runat="server" class="templatemo-login-form">
                    <table style="margin: auto; width: 70%;">
                        <tr>
                            <td><span>Name: </span></td>
                            <td>
                                <asp:TextBox class="form-control" Width="150px" Height="16px" ID="TBName" runat="server"></asp:TextBox></td>
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
                            <td colspan="3"><span><br>Reason for Access?</span></td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:TextBox class="form-control" Width="100%" Height="250" ID="TBReason" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <br />
                                <asp:Button class="templatemo-blue-button" ID="Button1" Width="110" runat="server" Text="Summit" OnClick="Button1_Click" />
                                &nbsp;
                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                    </table>
                </form>

            </div>
        </div>
    </div>

</asp:Content>


