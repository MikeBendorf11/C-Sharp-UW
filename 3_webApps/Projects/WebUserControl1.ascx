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
                <span><b>Last Visited: </b><%= UserData.StrPrevPage(Request.QueryString["prev"]) %></span>
            </div>
            <div class="col-1">
                Another field: xxxxxxxxxxxx
            </div>
        </div>
        <div class="templatemo-flex-row flex-content-row">
            <div class="col-1">
                Another field: aaaaaaaaaaaa
            </div>
            <div class="col-1">
                Another field: bbbbbbbbbbbb
            </div>
        </div>
    </div>
    <table>
        <tr>
            <td>Welcome!&nbsp;
            </td>
            <td>
                <div class="img-circular-small" style="background-image: url('images/avatar7.jpg')" />
            </td>
        </tr>
    </table>
</div>






