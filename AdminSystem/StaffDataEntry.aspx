<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 531px">
    <form id="form1" runat="server">
        <div>
            
        </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <p>
            <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 11px; top: 78px; position: absolute" Text="Staff Name" width="95px"></asp:Label>
            <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 104px; top: 75px; position: absolute; width: 219px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 14px; top: 40px; position: absolute; width: 95px; height: 18px" Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 104px; top: 39px; position: absolute" width="219px"></asp:TextBox>
            <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 10px; top: 110px; position: absolute" Text="Staff Email" width="95px"></asp:Label>
            <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 104px; top: 111px; position: absolute; width: 219px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffRegisterDate" runat="server" Style="z-index: 1; left: 10px; top: 148px; position: absolute; right: 1759px; width: 97px" Text="Register Date"></asp:Label>
            <asp:TextBox ID="txtStaffRegisterDate" runat="server" style="z-index: 1; left: 104px; top: 148px; position: absolute" width="219px" TextMode="DateTime"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 10px; top: 186px; position: absolute" Text="Staff Address" width="95px"></asp:Label>
            <asp:TextBox ID="txtStaffAddress" runat="server" style="z-index: 1; left: 104px; top: 186px; position: absolute; width: 219px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStaffAge" runat="server" style="z-index: 1; left: 10px; top: 224px; position: absolute" Text="Staff Age" width="95px"></asp:Label>
            <asp:TextBox ID="txtStaffAge" runat="server" style="z-index: 1; left: 104px; top: 224px; position: absolute" width="219px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkIsManager" runat="server" style="z-index: 1; left: 96px; top: 269px; position: absolute" Text="Is Manager?" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 304px; position: absolute; height: 19px"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 9px; top: 335px; position: absolute" Text="OK" height="26px" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 87px; top: 335px; position: absolute" Text="Cancel" height="26px" />
        </p>
        <p>
            <asp:Button ID="btnFind" runat="server" Height="34px" Text="Find" Width="51px" style="z-index: 1; left: 9px; top: 380px; position: absolute" OnClick="btnFind_Click1" />
        </p>
        <p>
            <asp:Button ID="btnMain" runat="server" style="z-index: 1; left: 200px; top: 335px; position: absolute" Text="Return to Main Menu" height="26px" OnClick="btnMain_Click" />
        </p>
        <p>
            &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
