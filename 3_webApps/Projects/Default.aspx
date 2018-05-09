<%@ Page Language="C#" MasterPageFile="~/Projects.Master" %>
<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>

<asp:Content ContentPlaceHolderID="phHead" runat="server">
    <title>Home</title>


</asp:Content>

<asp:Content ContentPlaceHolderID="phUserInfo" runat="server" >
    <uc1:WebUserControl1 runat="server" ID="WebUserControl1" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="phContent1" runat="server">

    <div class="templatemo-flex-row flex-content-row">
        <div class="templatemo-content-widget grey-bg col-1" style="">
            <h1>- UW - TOPICS COVERED</h1>
        </div>
    </div>
    <div class="templatemo-flex-row flex-content-row">
        <div class="templatemo-content-widget white-bg col-1">
            <i class="fa fa-times"></i>
            <h2 class="templatemo-inline-block">Web Applications:</h2>
            <hr>
            <table style="width: 300px">
                <tr>
                    <td>
                        <ul style="list-style-type: circle">
                            <li>HTML5 concepts</li>
                            <li>Using Javascript</li>
                            <li>Intro to jQuery</li>
                            <li>ODATA</li>
                            <li>REST</li>
                        </ul>
                    </td>
                    <td>
                        <ul style="list-style-type: circle">
                            <li>JSON</li>
                            <li>CSS 3</li>
                            <li>ASP.NET MVC</li>
                            <li>Web services</li>
                        </ul>
                    </td>
                </tr>
            </table>

        </div>
        <div class="templatemo-content-widget blue-bg col-1" style="">
            <i class="fa fa-times"></i>
            <h2 class="templatemo-inline-block">Client Applications:</h2>
            <hr>
            <table style="width: 300px">
                <tr>
                    <td>
                        <ul style="list-style-type: circle">
                            <li>Data Structures</li>
                            <li>Generics</li>
                            <li>Common WPF Controls</li>
                            <li>Data Binding</li>
                            <li>DataGridView</li>
                        </ul>
                    </td>
                    <td>
                        <ul style="list-style-type: circle">
                            <li>ADO.NET and databases</li>
                            <li>Advanced Exception Handling</li>
                            <li>Events and Delegates</li>
                            <li>Regex, Collections</li>
                        </ul>
                    </td>
                </tr>
            </table>

        </div>


    </div>
    <div class="templatemo-flex-row flex-content-row">
        <div class="col-1"></div>
         <div class="templatemo-content-widget pink-bg col-1" style="">
            <i class="fa fa-times"></i>
            <h2 class="templatemo-inline-block">Introduction/Review:</h2>
            <hr>
            <table style="width: 300px">
                <tr>
                    <td>
                        <ul style="list-style-type: circle">
                            <li>Classes, Objecs</li>
                            <li>Types, Structures</li>
                            <li>Inheritance, Polymorphism</li>
                            <li>Properties</li>
                            <li>Methods, Constructors</li>
                        </ul>
                    </td>
                    <td>
                        <ul style="list-style-type: circle">
                            <li>Static members</li>
                            <li>Collections, Lists, Dictionary</li>
                            <li>Strings, Concatenation </li>
                            <li>Exception Objects</li>
                        </ul>
                    </td>
                </tr>
            </table>

        </div>
        <div class="col-1"></div>
    </div>
</asp:Content>


