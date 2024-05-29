<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PurchasesDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body style="height: 538px">
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div>
        </div>
        <asp:Label ID="lblTotalAmount" runat="server" style="z-index: 1; left: 10px; top: 344px; position: absolute" Text="Total Amount" height="38px" width="51px"></asp:Label>
        <asp:Label ID="lblPurchaseId" runat="server" style="z-index: 1; left: 10px; top: 20px; position: absolute" Text="Purchase ID" width="51px"></asp:Label>
        <asp:TextBox ID="txtDeliveryOptions" runat="server" style="z-index: 1; left: 86px; top: 132px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 10px; top: 69px; position: absolute" Text="Customer Name" height="38px" width="51px"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 86px; top: 83px; position: absolute; bottom: 528px" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtPurchaseId" runat="server" style="z-index: 1; left: 86px; top: 26px; position: absolute; bottom: 784px;" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="lblDeliveryOptions" runat="server" style="z-index: 1; left: 10px; top: 120px; position: absolute" Text="Delivery Options" height="38px" width="51px"></asp:Label>
        <p>
            <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; left: 213px; top: 538px; position: absolute" Text="Main Menu" />
            </p>
        <p class="auto-style1">
        <asp:Label ID="lblProductPrice" runat="server" style="z-index: 1; left: 10px; top: 176px; position: absolute" Text="Product Price" height="38px" width="51px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 10px; top: 232px; position: absolute" Text="Quantity" height="38px"></asp:Label>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 10px; top: 284px; position: absolute" Text="Order Date" height="38px" width="51px"></asp:Label>
        <asp:TextBox ID="txtProductPrice" runat="server" style="z-index: 1; left: 86px; top: 191px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 86px; top: 239px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 86px; top: 290px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 30px; top: 538px; position: absolute" Text="OK" />
        <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 86px; top: 350px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 110px; top: 538px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 265px; top: 47px; position: absolute; width: 71px" Text="Find" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 38px; top: 455px; position: absolute"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
            <asp:CheckBox ID="chkOrderConfirmed" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged1" Text="OrderConfirmed" height="28px" style="z-index: 1; left: 93px; top: 399px; position: absolute" />
    </form>
</body>
</html>
