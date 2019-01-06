<%@ Page Title="Final" Language="C#" MasterPageFile="~/Projects.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="phContent1" runat="server">


     
         
         <div id="iframeCont" class="col-1" 
			  style=" 
					  ">
					  
             <%-- Was just /Final/ --%>
                  <iframe 
					id="theiframe"
					style="visibility:hidden;"
                    onload="this.style.visibility='visible'"
					src="/Final/"></iframe>    
					<!-- https://localhost:61452/
					style="visibility:hidden;" 
					onload="this.style.visibility='visible';" 
					-->
         </div>
         
     
</asp:Content>
