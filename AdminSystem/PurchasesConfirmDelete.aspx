<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PurchasesConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style1" height="26px" OnClick="btnYes_Click" style="z-index: 1; left: 146px; top: 163px; position: absolute; width: 70px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style1" height="26px" OnClick="btnNo_Click" style="z-index: 1; left: 253px; top: 163px; position: absolute" Text="No" width="70px" />
        <p>
            <asp:Label ID="lblDeleteRecord" runat="server" style="z-index: 1; left: 103px; top: 121px; position: absolute; width: 275px" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
    </form>
</body>
</html>
