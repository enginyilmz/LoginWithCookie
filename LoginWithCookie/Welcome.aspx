<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="LoginWithCookie.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   
    
        Welcome
        <asp:Label ID="lbl_username" runat="server"></asp:Label>
        <br />
        <asp:LinkButton ID="lb_logout" runat="server" OnClick="lb_logout_Click">Logout</asp:LinkButton>
   
    
    </div>
    </form>
</body>
</html>
