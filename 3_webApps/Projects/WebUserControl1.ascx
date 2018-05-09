<%@ Control Language="C#" %>
<%@ Import Namespace="Projects.App_Code" %>
<%@ Import Namespace="System.Diagnostics" %>

<script src="scripts/jquery-3.3.1.js"></script>
<script>
</script>

<div class="templatemo-flex-row flex-content-row">
    <div class="col-1">
        <div class="templatemo-flex-row flex-content-row">
            <div class="col-1">
                <span><b>Order Visited: </b><%= UserData.StrPrevPage(Request.QueryString["prev"]) %></span>
            </div>
            <div class="col-1">
                <b>Another field: </b> [No data yet]
            </div>
        </div>
        <div class="templatemo-flex-row flex-content-row">
            <div class="col-1">
                <b>Another field: </b> [No data yet]
            </div>
            <div class="col-1">
                <b>Another field: </b> [No data yet]
            </div>
        </div>
    </div>
    <table>
        <tr>
            <td><b>WELCOME!</b>&nbsp;
            </td>
            <td>
                <img class="img-circular-small" src="images/<%=UserData.Avatar + ".jpg"%>" Title="<%=UserData.Avatar%>" />
            </td>
        </tr>
    </table>
</div>






