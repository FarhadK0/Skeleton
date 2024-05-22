<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerSupportList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerSupportList" runat="server" Height="430px" Width="385px"></asp:ListBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 603px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 209px; top: 483px; position: absolute; right: 881px" Text="Delete" />
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 32px; top: 479px; position: absolute" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 121px; top: 481px; position: absolute" Text="Edit" />
        </p>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 153px; top: 530px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 3px; top: 532px; position: absolute" Text="Enter a Ticket Type"></asp:Label>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 14px; top: 569px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 164px; top: 569px; position: absolute" Text="Clear Filter" />
    </form>
</body>
</html>
