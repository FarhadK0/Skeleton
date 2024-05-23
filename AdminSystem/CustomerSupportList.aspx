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
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 25px; top: 476px; position: absolute" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click1" style="z-index: 1; left: 87px; top: 476px; position: absolute" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click1" style="z-index: 1; left: 174px; top: 477px; position: absolute" Text="Delete" />
        </p
        

        <p>
        <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 268px; top: 566px; position: absolute" Text="Clear Filter" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 524px; position: absolute" Text="Enter a Ticket Type"></asp:Label>
           
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 167px; top: 523px; position: absolute"></asp:TextBox>
           
        </p>
        
      
        
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 44px; top: 566px; position: absolute" Text="Apply Filter" />
        
      
        
    </form>
</body>
</html>

