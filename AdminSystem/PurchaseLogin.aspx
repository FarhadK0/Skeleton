<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PurchaseLogin.aspx.cs" Inherits="PurchaseLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
<asp:Label ID="lblPurchasesLogin" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Purchase Management Login Page"></asp:Label>
<asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 216px; top: 220px; position: absolute" Text="Cancel" />
<asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 107px; top: 133px; position: absolute" Text="Username:"></asp:Label>
<asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 107px; top: 178px; position: absolute" Text="Password:"></asp:Label>
<asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 462px; top: 149px; position: absolute"></asp:Label>
<asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 184px; top: 133px; position: absolute"></asp:TextBox>
<asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 183px; top: 176px; position: absolute" TextMode="Password"></asp:TextBox>
<asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 139px; top: 220px; position: absolute" Text="Login" />
    </form>
</body>
</html>
