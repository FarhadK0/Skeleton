<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        This is the
        Customer Data entry Page.<asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" style="text-align: right; position: relative; top: 8px; left: 161px; z-index: 1" />
        &nbsp;<div>
        </div>
        <asp:Label ID="IblCustomerID" runat="server" style="z-index: 1; left: 19px; top: 54px; position: absolute; width: 82px;" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 153px; top: 52px; position: absolute; width: 179px; margin-top: 0px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 152px; top: 92px; position: absolute; width: 175px"></asp:TextBox>
            <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 20px; top: 91px; position: absolute" Text="Name" width="78px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 21px; top: 128px; position: absolute" Text="Email" width="78px"></asp:Label>
            <asp:TextBox ID="txtEamil" runat="server" style="z-index: 1; left: 150px; top: 128px; position: absolute; width: 179px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 148px; top: 168px; position: absolute; width: 183px"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtDateofbirth" runat="server" style="z-index: 1; left: 145px; top: 237px; position: absolute; width: 183px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkhasPurchases" runat="server" style="top: 292px; left: 22px; position: absolute; height: 21px; width: 106px" Text="hasPurchases" />
        <asp:Label ID="lblDateofbirth" runat="server" style="z-index: 1; left: 21px; top: 236px; position: absolute" Text="Date of Birth" width="78px"></asp:Label>
        </p>
        <p>
            &nbsp;<asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 21px; top: 169px; position: absolute; width: 94px;" Text="Phone Number"></asp:Label>
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 20px; top: 204px; position: absolute; right: 1187px;" Text="Address" width="78px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 146px; top: 204px; position: absolute; width: 188px" OnTextChanged="txtAddress_TextChanged"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" style="top: 337px; left: 120px; position: absolute; height: 26px; width: 60px" OnClick="btnCancel_Click" />
        </p>
        <asp:Button ID="btnOk" runat="server" Text="OK" style="top: 336px; left: 46px; position: absolute; height: 26px; width: 33px; right: 1406px" OnClick="btnOk_Click" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
