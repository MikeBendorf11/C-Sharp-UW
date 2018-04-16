<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Assignments.Master" %>

<script runat="server">

    protected void Button_Click(object sender, EventArgs e)
    {
         if (Page.IsValid) 
          {
            tbUser.Text= "Success!";
            tbUser.BackColor = System.Drawing.Color.Aquamarine;
            tbPass.BackColor = System.Drawing.Color.Aquamarine;
          }
          else 
          {
             tbUser.Text = "Enter a valid e-mail.";
          }

    }
</script>


<asp:Content ContentPlaceHolderID="phHead" runat="server">
    <title>Login</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="phContent1" runat="server">
    <div class="templatemo-content-widget templatemo-login-widget white-bg">
			<header class="text-center">
	          <div class="square"></div>
	          <h1>User Access</h1>
	        </header>
	        <form id="form1" runat="server">
	        	<div class="form-group">
	        		<div class="input-group">
		        		<div class="input-group-addon"><i class="fa fa-user fa-fw"></i></div>	        		
		              	<asp:TextBox ID="tbUser" OnClick="this.value=''"  runat="server" type="text" class="form-control" placeholder="your_email"/>   
		          	</div>	
	        	</div>
	        	<div class="form-group">
	        		<div class="input-group">
		        		<div class="input-group-addon"><i class="fa fa-key fa-fw"></i></div>	        		
		              	<asp:TextBox OnClick="this.value=''" ID="tbPass" runat="server" type="password" class="form-control" placeholder="**************"/>           
		          	</div>	
	        	</div>	          	
	          	<div class="form-group">
				    <div class="checkbox squaredTwo">
				        <input type="checkbox" id="c1" name="cc">
						<label for="c1"><span></span>Remember me</label>
				    </div>				    
				</div>
				<div class="form-group">
					<asp:Button runat="server" type="submit" class="templatemo-blue-button width-100" Text="Login" OnClick="Button_Click"/>
				    <br />
				</div>
                 <asp:RequiredFieldValidator ControlToValidate="tbUser" ID="RequiredFieldValidator1" runat="server" EnableClientScript="False"></asp:RequiredFieldValidator>   
                        <asp:RegularExpressionValidator ControlToValidate="tbUser" ValidationExpression="([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})" ID="RegularExpressionValidator1" runat="server"  EnableClientScript="False"></asp:RegularExpressionValidator> 
	        </form>

		</div>

</asp:Content>