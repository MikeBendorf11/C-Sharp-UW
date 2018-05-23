<%@ Page Title="Project04" Language="C#" MasterPageFile="~/Projects.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phHead" runat="server">
    <script>
        $(document).ready(function () {
            $("#PanelProj4").show();
            $("#DivProj4").animate({
                'margin':'0 20px 0 20px'
            }, 2000);
            $(".table-assi4").show(2000);

        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phContent1" runat="server">
   

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="phProj4" runat="server">
     <div class="templatemo-flex-row flex-content-row">
        <div class="templatemo-content-widget grey-bg col-1" style="padding-bottom: 15px; padding-top: 15px">
            <h1>Project 04</h1>
        </div>
    </div>
    <div class="templatemo-flex-row flex-content-row">
        <div class="col-1"></div>
        <div class="templatemo-content-widget blue-bg col-2" style="">

               <iframe style="float:right" src="gh.html?sha=1238da42174a915d1acfcbafbdfaa07760b24fbc"
                    allowtransparency="true" frameborder="0" scrolling="no" width="350px" height="130px"></iframe>
            <i class="fa fa-times"></i>
            <div class="square-dark"></div>
            <h2 class="templatemo-inline-block">User Activity</h2>
            <h4>Managing State Data:</h4>
            <p>
                A combination of methods where used to track data and personalize settings for the user. 
            </p>
            <p>The Session is tracked using the TimeSpan and StopWatch C# classes and the information collected is transferred directly to a UserData class</p>
        </div>
    </div>
</asp:Content>
