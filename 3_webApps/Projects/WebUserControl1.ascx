<%@ Control Language="C#" %>
<%@ Import Namespace="Projects.App_Code" %>

<script src="scripts/jquery-3.3.1.js"></script>
<script>
</script>



<div class="templatemo-flex-row flex-content-row">
    <div class="col-1">
        <span><b>Last Visited: </b><%= UserData.StrPrevPage(Request.QueryString["prev"]) %></span>
    </div>
    <div class="col-1"><%--###--%>
<%--Another field: <%=proj1Data.StopWatch.Elapsed;%>--%>
    </div>
</div>
<div class="templatemo-flex-row flex-content-row">
    <div class="col-1">
        Another field: xxxxxxxxxxxx
    </div>
    <div class="col-1">
        Another field: xxxxxxxxxxxx
    </div>
</div>

