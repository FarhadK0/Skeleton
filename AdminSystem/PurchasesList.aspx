<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PurchasesList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstPurchaseList" runat="server" Height="357px" Width="467px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" height="26px" style="z-index: 1; left: 10px; top: 414px; position: absolute" width="55px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 85px; top: 414px; position: absolute; right: 1008px;" Text="Edit" height="26px" width="55px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 159px; top: 414px; position: absolute" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 23px; top: 567px; position: absolute"></asp:Label>
            <asp:Label ID="lblEnterACustName" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="12pt" style="z-index: 1; left: 29px; top: 476px; position: absolute" Text="Enter a Customer Name:"></asp:Label>
            <asp:Button ID="btnApplyFilter" runat="server" height="26px" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 32px; top: 520px; position: absolute" Text="Apply Filter" width="95px" />
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 153px; top: 520px; position: absolute" Text="Clear Filter" />
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 229px; top: 475px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnMainmenu" runat="server" OnClick="btnMainmenu_Click" style="z-index: 1; left: 276px; top: 414px; position: absolute; width: 96px" Text="Main menu" />
    </form>
</body>
</html>
