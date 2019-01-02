<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileSystem.aspx.cs" Inherits="Projects.FileSystem" MasterPageFile="~/Projects.Master" %>

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
    <div id="asg1" class="templatemo-flex-row flex-content-row">
        <div class="templatemo-content-widget white-bg col-1" style="height:fit-content">
            <i class="fa fa-times"></i>
            <div class="square-light"></div>
            <h2 class="templatemo-inline-block">Writing Files</h2>
            
            <h4>Controls and Master Pages</h4>
            <p>This form writes data to the server</p>
            <ul style="list-style-type: decimal; padding-left:25px">
                <li>Experimented with code behind files</li>
                <li>By creating Controls with the same name I was able to put the logic in a separate file</li>
                <li>The same idea stands for creating events</li>
               </ul>

          <br />
          
            <asp:Label class="blink" ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
        </div>
        <div class="col-1">

            <div class="templatemo-content-widget blue-bg">
                <i class="fa fa-times"></i>
                <div class="templatemo-login-form">
                    <%-- style="color:lightgray"--%>
                    <table class="table-condensed">
                        <tr>
                            <td><span>Name: </span></td>
                            <td>
                                <asp:TextBox class="form-control" ID="TBName" runat="server" Text="A name"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td><span>Email: </span></td>
                            <td colspan="2">
                                <asp:TextBox class="form-control" ID="TBEmail" runat="server" Text="name@domain.com"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td><span>Initials: </span></td>
                            <td colspan="2">
                                <asp:TextBox class="form-control" ID="TBLogin" runat="server" Text="Initials"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td colspan="2"><span>
                                <br>
                                Reason for Access?</span></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:TextBox class="form-control" style="display: block; height: 100px" ID="TBReason" runat="server" TextMode="MultiLine">Click send to write a file to the server pr click the boxes to clear the form and edit</asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <br />
                                <asp:Button class="form-control" ID="Button1" Width="110" runat="server" Text="Summit" OnClick="Button1_Click" />
                                &nbsp;
                            
                            </td>
                        </tr>
                    </table>
                </div>

            </div>
        </div>
    </div>

</asp:Content>


