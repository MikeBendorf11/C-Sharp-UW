<%@ Page Language="C#" MasterPageFile="~/Assignments.Master" %>

<asp:Content ContentPlaceHolderID="phHead" runat="server">
    <title>Home</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="phContent1" runat="server">
    <div class="templatemo-flex-row flex-content-row">
        <div class="templatemo-content-widget white-bg col-1">
            <i class="fa fa-times"></i>
            <div class="square"></div>
            <h2 class="templatemo-inline-block">Topics include:</h2>
            <hr>
            <ul style="list-style-type: circle">
                <li>HTML5 concepts</li>
                <li>Using Javascript</li>
                <li>Intro to jQuery</li>
                <li>ODATA</li>
                <li>REST</li>
                <li>JSON</li>
                <li>CSS 3</li>
                <li>ASP.NET MVC</li>
                <li>Using web services from server</li>
            </ul>
        </div>
        <div class="templatemo-content-widget orange-bg">
            <i class="fa fa-times"></i>
            <div class="square"></div>
            <h2 class="templatemo-inline-block">Resources:</h2>
            <hr>
            <p>1) HTML (from Home to HTML Styles)</p>
            <a href="http://www.w3schools.com/html/default.asp">http://www.w3schools.com/html/default.asp</a>
            <p>2) JavaScript (from Home to JS Objects)</p>
            <a href="http://www.w3schools.com/js/default.asp">http://www.w3schools.com/js/default.asp</a>
            <p>3) ASP.NET (from Home to ASP)</p>
            <a href="https://www.w3schools.com/asp/default.asp">https://www.w3schools.com/asp/default.asp</a>
        </div>
    </div>
</asp:Content>


