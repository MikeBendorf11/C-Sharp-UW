<%@ Page Language="C#" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Demo3</title>
<script type="text/javascript">
// With Standard HTML controls you write JavaScript to add functionality
function StdHTMLCtrl() {
    var strData = document.getElementById("Text1").value += " from Std HTML Control";
    alert("Pause before sending this (" + strData + " ) to the server")
    document.forms[0].submit() //Send to Server
}

function HTMLSvrCtrl() {
    document.getElementById("Text2").value += " Client Side Result";
    alert("Pause before sending to server")
    document.forms[0].submit() //Send to Server
}
</script>

<script runat="server">
    
protected void Page_Load(object sender, EventArgs e)
{ //When PostBack == true, it means that data is being SUBMITED from a client
    if (IsPostBack == true)
    { Response.Write(Request.Form["Text1"] + " Server Side Results "); }
    else if (IsPostBack == false)
    { Response.Write("The browser requested the page for the first time"); }
}

//HTML Server controls have access to Server Side Event handling!
protected void Button2_Click(object sender, EventArgs e)
{
    //Note how simple it is to a work with the Web Sever Control!
    Response.Write(Text2.Value + "<br />");
    Response.Write("<b><i>Note:</i></b>Response.Write works, but is not recommended!");
}
</script>

<style type="text/css">
.auto-style1 {
    color: #FF0000;
}
</style>

</head>
<body>
<p>
NOTE: You must include an<span class="auto-style1"> <strong>"onsubmit" attribute it the Form tag</strong></span><br />
if you want to include client side scripting with HTML Server controls!<br />
This is due to the Auto generated JavaScript block added automatically by Microsoft.<br />
<span class="auto-style1"><strong>Use View Source to see the Client Side code </strong></span>added and how<br />
it checks to see if the attribute has been added before it allows Client Side event handling!
<br />
</p>
<form id="form1" runat="server" onsubmit="return HTMLSvrCtrl()">
<!-- Required for Client Side Event Handling!-->
<div>
    <p>
        These are a standard HTML textbox and button.<br />
        You write your own JavaScript to interact with them.<br />
        <input id="Text1" name="Text1" type="text" />
        Note how the textbox data is reset each time!<br />
        <!-- NOTE: You must include a NAME attribute for Processing Std HTML on the Server ! -->
        <input id="Button1" type="button" value="button" onclick="StdHTMLCtrl()" />
    </p>
    <p>
        These are the same standard HTML controls turned into HTML Server Controls<br />
        <%-- Note the runat and the OnServerClick attributes!--%>
        <input id="Text2" type="text" runat="server" />
        Note how the textbox data is kept automatically!<br />
        <input id="Button2" type="button" value="button" runat="server" onserverclick="Button2_Click" /><br />

    </p>
</div>
</form>
</body>
</html>
