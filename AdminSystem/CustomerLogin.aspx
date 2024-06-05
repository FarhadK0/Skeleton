<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerBookingLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            Customer Book Login Page</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 372px; top: 206px; position: absolute; color: #FF0000" Text="[lblError]"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 55px; top: 148px; position: absolute" Text="UserName:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 142px; top: 193px; position: absolute" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 142px; top: 241px; position: absolute" Text="Login" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 217px; top: 241px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 55px; top: 196px; position: absolute" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 146px; top: 147px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
