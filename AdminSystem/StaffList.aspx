<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="468px" Width="558px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" Style="z-index: 1; left: 80px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Style="z-index: 1; left: 140px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; position: absolute"></asp:Label>

      
    </form>
</body>
</html>
