<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Project02.aspx.cs" Inherits="Projects.Project02" MasterPageFile="~/Projects.Master" %>

<asp:Content ContentPlaceHolderID="phHead" runat="server">
    <title>Project 02</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="phContent1" runat="server">
     <div class="templatemo-flex-row flex-content-row">
        <div class="templatemo-content-widget grey-bg col-1" style="padding-bottom:15px; padding-top: 15px">
            <h1>Project 02</h1>
        </div>
    </div>
    <div class="templatemo-flex-row flex-content-row">
        <div id="asg1" class="templatemo-content-widget white-bg col-1" style="height:fit-content">
            <i class="fa fa-times"></i>
            <div class="square-light"></div>
            <h2 class="templatemo-inline-block">Writing Files</h2>
            <hr>
            <h4>Controls and Master Pages</h4>
            <p>After reviewing HTML, Server and Validation Controls, I decided to use User Controls. I also moved all projects to be under a master page whereas before I was using HTML template tags</p>
            <ul style="list-style-type: decimal">
                <li>Experimented with code behind files</li>
                <li>By creating Controls with the same name I was able to put the logic in a separate file</li>
                <li>The same idea stands for creating events</li>
                <li>Notice I'm not using a designer page</li>
                
            </ul>
        </div>
        <div class="col-1">
            
            <div class="templatemo-content-widget blue-bg">
                <i class="fa fa-times"></i>
                <form runat="server" class="templatemo-login-form">
                    <table style="margin: auto; width: 90%;">
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


