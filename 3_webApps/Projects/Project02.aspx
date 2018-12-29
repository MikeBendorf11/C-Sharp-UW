<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Project02.aspx.cs" Inherits="Projects.Project02" MasterPageFile="~/Projects.Master" %>

<%@ Import Namespace="Projects.App_Code" %>

<asp:Content ContentPlaceHolderID="phHead" runat="server">
    <title>Project 02</title>
    <script>
        var flag = true;
        $(document).ready(function () {
            $(":text, #phContent1_TBReason").click(function () {
                if (flag) {
                    $(":text, #phContent1_TBReason").val('');
                    flag = false;
                }
            });
            $('.blink').each(function () {
                var elem = $(this);
                setInterval(function () {
                    if (elem.css('visibility') == 'hidden') {
                        elem.css('visibility', 'visible');
                    } else {
                        elem.css('visibility', 'hidden');
                    }
                }, 1500);
            });
        });
    </script>

</asp:Content>



<asp:Content ID="Content1" ContentPlaceHolderID="phContent1" runat="server">
    <div class="templatemo-flex-row flex-content-row">
        <div id="asg1" class="templatemo-content-widget white-bg col-1" style="height: fit-content">
            <i class="fa fa-times"></i>
            <div class="square-light"></div>
            <h2 class="templatemo-inline-block">Writing Files</h2>
            
            <h4>Controls and Master Pages</h4>
            <p>After reviewing HTML, Server and Validation Controls, I decided to use User Controls. I also moved all projects to be under a master page whereas before I was using HTML template tags</p>
            <ul style="list-style-type: decimal; padding-left:25px">
                <li>Experimented with code behind files</li>
                <li>By creating Controls with the same name I was able to put the logic in a separate file</li>
                <li>The same idea stands for creating events</li>
                <li>Notice I'm not using a designer page</li>

          
          
            <asp:Label class="blink" ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
        </div>
        <div class="col-1">

            <div class="templatemo-content-widget blue-bg">
                <i class="fa fa-times"></i>
                <div class="templatemo-login-form">
                    <%-- style="color:lightgray"--%>
                    <table style="margin: auto; width: 90%;">
                        <tr>
                            <td><span>Name: </span></td>
                            <td>
                                <asp:TextBox class="form-control" Width="200px" ID="TBName" runat="server" Text="A name"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td><span>Email Address: </span></td>
                            <td colspan="2">
                                <asp:TextBox class="form-control" Width="200px" ID="TBEmail" runat="server" Text="name@domain.com"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td><span>Login Name: </span></td>
                            <td colspan="2">
                                <asp:TextBox class="form-control" Width="200px" ID="TBLogin" runat="server" Text="Initials"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td colspan="2"><span>
                                <br>
                                Reason for Access?</span></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:TextBox class="form-control" Width="330" Height="250" ID="TBReason" runat="server" TextMode="MultiLine">Click the boxes to clear the form or just click send to write the file</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <br />
                                <asp:Button class="templatemo-blue-button" ID="Button1" Width="110" runat="server" Text="Summit" OnClick="Button1_Click" />
                                &nbsp;
                            
                            </td>
                        </tr>
                    </table>
                </div>

            </div>
        </div>
    </div>

</asp:Content>


