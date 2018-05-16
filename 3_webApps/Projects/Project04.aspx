<%@ Page Title="Project04" Language="C#" MasterPageFile="~/Projects.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="phHead" runat="server">
    <script>
        $(document).ready(function () {
            $("#PanelUserData").animate({
                'width': '500px',
                'height': '305px',
                'margin-top': '75px',
            }, 3000);
            $("#divUserData").hide(3000);
            $(".table-assi4").show(1000);

        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phContent1" runat="server">
    <div class="templatemo-flex-row flex-content-row">
        <div class="templatemo-content-widget grey-bg col-1" style="padding-bottom: 15px; padding-top: 15px">
            <h1>Project 03</h1>
        </div>
    </div>
    <div class="templatemo-flex-row flex-content-row">
        <div class="col-1"></div>
        <div class="templatemo-content-widget blue-bg col-1" style="">
            <i class="fa fa-times"></i>
            <h2 class="templatemo-inline-block">Managing State Data: </h2>
            <p>
                A combination of methods where used including Query String, Session State and Cookies to track data and personalize settings for the user.
            </p>
            <p>While visiting pages the system was collecting the time spend individually on each page as well as the time since this session started.</p>
        </div>
    </div>

</asp:Content>
