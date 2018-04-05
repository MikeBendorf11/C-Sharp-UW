<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
 div.relative {
    margin: auto;
    position: relative;
    width: 500px;
    height: 800px;
    border: 3px solid #ff0000;
} 

div.absolute {
    position: absolute;
    right: 0;
    width: 350px;
    height: 400px;
    border: 3px solid #73AD21;
}
div.nav{
    position: absolute;
    width: 130px;
    left: 0;
    height: 400px;
    border: 3px solid #1a1db6
}
    </style>
    <script runat="server">
        protected void Button1_Click(object sender, EventArgs e)
        {
            String str = TextBox1.Text + "," + TextBox2.Text;
            Response.Write(str);
        }
    </script>
</head>
<body>
    <div class="relative">
        <div style="height: 50px; background-color: aqua;"></div>
        <div class="nav"></div>
        <div class="absolute">
            <hr />
            <p>Joe User 123</p>
            <hr />
            <p>Please login using your name and password: </p>
            <form id="form1" runat="server">
                <table style="width: 50%; margin: auto;">
                    <tr>
                        <td>Name:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Pass: </td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="text-align:center;" colspan="2"><br />
                            <asp:Button ID="Button1" runat="server" Text="Button" Width="100px" OnClick="Button1_Click" /></td>
                    </tr>
                </table>
            </form>

        </div>
    </div>

    
</body>
</html>
