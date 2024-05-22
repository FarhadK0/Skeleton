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
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 532px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 32px; top: 479px; position: absolute" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 121px; top: 481px; position: absolute" Text="Edit" />
        </p>
    </form>
</body>
</html>
