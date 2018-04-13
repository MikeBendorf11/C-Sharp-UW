<%@ Page Language="C#" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Demo1</title>

<script type="text/javascript">
// With Standard HTML controls you write JavaScript to add functionality
function StdHTMLCtrl() {
document.getElementById("Text1").value += " from Std HTML Control";
//alert("Pause before sending to server")
//document.forms[0].submit() //Send to Server
}
function writeToTB() {
    document.getElementById("Text1").value = "xxxxxxxxxx";
}
</script>

<script runat="server">
    // Std HTML controls don’t offer a server side Event model so you use the Page_Load event  
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write(DateTime.Now.ToString());
        Response.Write(Request.Form["Text1"]);
        
            
    }
</script>

</head>
<body>
<%--NOTE: the runat attribute is required to allow ASP.NET Processing --%>
<form id="form1" runat="server" onsubmit="writeToTB()">
<div>
 <p>
 This is a standard HTML textbox and button. 
 You write your own JavaScript to interact with it. <br />
 <!-- NOTE: You must include a NAME attribute for Processing Std HTML on the Server! -->
 <input id="Text1" name="Text1" type="text" />
 <input id="Button1" type="button" value="button" onclick="StdHTMLCtrl()" />
 </p>
</div>
</form>

</body>
</html>
