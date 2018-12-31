<%@ Page Title="Final" Language="C#" MasterPageFile="~/Projects.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phContent1" runat="server">


     <div class="templatemo-flex-row flex-content-row">
         
         <div class="col-1" 
			  style=" width:100%; 
				      background-color: #e2efef;
					  background-image:url(images/loader.gif), url(images/bar.png);
					  background-position: 50% 50%, 0% 0%;
					  background-repeat: no-repeat, no-repeat;
					  background-size: 70px, auto auto;
					  ">
					  
             <%-- Was just /Final/ --%>
                  <iframe 
					id="theiframe" 
					
					src="http://localhost:61452/"></iframe>    
					<!-- http://localhost:61452/
					style="visibility:hidden;" 
					onload="this.style.visibility='visible';" 
					-->
         </div>
         
     </div>
</asp:Content>
