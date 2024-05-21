<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PianoList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 13px;
            top: 498px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstPianoList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 464px; width: 549px"></asp:ListBox>
        <div>
        </div>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style1" Text="Add" OnClick="btnAdd_Click1" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 17px; top: 547px; position: absolute"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 65px; top: 498px; position: absolute" Text="Edit" OnClick="btnEdit_Click1" />
    </form>
</body>
</html>
