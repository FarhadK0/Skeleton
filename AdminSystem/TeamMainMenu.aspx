<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblMainMenu" runat="server" Font-Size="Large" style="z-index: 1; left: 62px; top: 57px; position: absolute" Text="Piano Guys Main Menu"></asp:Label>
        <asp:Button ID="btnCustomer" runat="server" height="26px" OnClick="btnCustomer_Click" style="z-index: 1; left: 69px; top: 99px; position: absolute" Text="Customer" width="159px" />
        <asp:Button ID="btnCustomerSupport" runat="server" OnClick="btnCustomerSupport_Click" style="z-index: 1; left: 69px; top: 144px; position: absolute" Text="Customer Support" />
        <asp:Button ID="btnPurchases" runat="server" height="26px" OnClick="btnPurchases_Click" style="z-index: 1; left: 69px; top: 231px; position: absolute" Text="Purchases" width="159px" />
        <asp:Button ID="btnPiano" runat="server" height="26px" OnClick="btnPiano_Click" style="z-index: 1; left: 69px; top: 187px; position: absolute" Text="Piano" width="159px" />
        <asp:Button ID="btnStaff" runat="server" height="26px" OnClick="btnStaff_Click" style="z-index: 1; left: 69px; top: 275px; position: absolute" Text="Staff" width="159px" />
    </form>
</body>
</html>
