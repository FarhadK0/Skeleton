<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnReturnMainMenu" runat="server" OnClick="btnReturnMainMenu_Click" style="z-index: 1; left: 348px; top: 420px; position: absolute" Text="Return to Main Menu" />
        <asp:ListBox ID="lstCustomerList" runat="server" Height="232px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="341px"></asp:ListBox>
        <br />
        <br />
            <asp:Button ID="btnDelete" runat="server" style="text-align: justify; position: relative; top: 0px; left: 204px; width: 56px;" Text="Delete" OnClick="btnDelete_Click" height="26px" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="56px" height="26px" style="text-align: justify; z-index: 1; left: 25px; top: 284px; position: absolute" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 120px; top: 287px; position: absolute; width: 57px;" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Label ID="lblError" runat="server" Text="lblError" style="z-index: 1; left: 23px; top: 470px; position: absolute"></asp:Label>
        <br />
        <br />
        <br />
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 199px; top: 369px; position: absolute; width: 158px"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 23px; top: 372px; position: absolute" Text="Enter a Customer Email"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 53px; top: 421px; position: absolute; text-align: justify" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 184px; top: 420px; position: absolute" Text="Clear Filter" />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
