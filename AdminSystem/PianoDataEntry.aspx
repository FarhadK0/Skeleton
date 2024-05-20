<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PianoDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblPianoId" runat="server" style="z-index: 1; left: 10px; top: 30px; position: absolute" Text="Piano ID" height="19px" width="88px"></asp:Label>
            <asp:TextBox ID="txtPianoId" runat="server" style="z-index: 1; left: 110px; top: 29px; position: absolute; width: 126px;"></asp:TextBox>
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 10px; top: 63px; position: absolute" Text="Date Added" height="19px" width="88px"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 110px; top: 58px; position: absolute" height="22px" width="126px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 10px; top: 93px; position: absolute; bottom: 564px;" Text="Price" height="19px" width="88px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 110px; top: 91px; position: absolute" height="22px" width="126px"></asp:TextBox>
            <asp:TextBox ID="txtManufacturer" runat="server" style="z-index: 1; left: 110px; top: 119px; position: absolute" height="22px" width="126px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblManufacturer" runat="server" style="z-index: 1; left: 10px; top: 119px; position: absolute; " Text="Manufacturer" height="19px" width="88px"></asp:Label>
            </p>
        <asp:Label ID="lblModelName" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute" Text="Model Name" height="19px" width="88px"></asp:Label>
        <asp:TextBox ID="txtModelName" runat="server" style="z-index: 1; left: 110px; top: 148px; position: absolute" height="22px" width="126px"></asp:TextBox>
        <asp:Label ID="lblSerialNumber" runat="server" style="z-index: 1; left: 10px; top: 178px; position: absolute" Text="Serial Number" height="19px" width="88px"></asp:Label>
        <p>
            <asp:TextBox ID="txtSerialNumber" runat="server" style="z-index: 1; left: 110px; top: 176px; position: absolute" height="22px" width="126px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkIsInStock" runat="server" style="z-index: 1; left: 109px; top: 210px; position: absolute" Text="In Stock" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 236px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 10px; top: 262px; position: absolute" Text="OK" OnClick="btnOK_Click1" />
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 63px; top: 262px; position: absolute" Text="Cancel" />
        </p>

        <p>
            <asp:Button ID="btnFind" runat="server" Height="43px" OnClick="btnFind_Click" Text="Find" Width="63px" />
        </p>
        <p>
            &nbsp;</p>

        <p>
            &nbsp;</p>

    </form>
</body>
</html>
