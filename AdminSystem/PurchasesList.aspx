﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PurchasesList.aspx.cs" Inherits="_1_List" %>

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
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" height="26px" style="z-index: 1; left: 10px; top: 411px; position: absolute" width="55px" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 85px; top: 411px; position: absolute; right: 1008px;" Text="Edit" height="26px" width="55px" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 159px; top: 411px; position: absolute" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 36px; top: 456px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
