<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PianoList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            left: 13px;
            top: 500px;
            position: absolute;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstPianoList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 464px; width: 549px"></asp:ListBox>
        <div>
        </div>
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style1" Text="Add" OnClick="btnAdd_Click1" height="26px" width="55px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 586px; position: absolute"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 74px; top: 500px; position: absolute" Text="Edit" OnClick="btnEdit_Click1" height="26px" width="55px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 135px; top: 500px; position: absolute" Text="Delete" />
        <asp:Label ID="lblFilterBySerialNumber" runat="server" style="z-index: 1; left: 275px; top: 503px; position: absolute" Text="Enter a Serial Number:"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 430px; top: 538px; position: absolute" Text="Clear Filter" />
        <asp:TextBox ID="txtFilterBySerialNumber" runat="server" style="z-index: 1; left: 431px; top: 499px; position: absolute; height: 22px"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 298px; top: 538px; position: absolute" Text="Apply Filter" />
    </form>
</body>
</html>
