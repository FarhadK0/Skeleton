<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerSupportDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 341px">
    <form id="form1" runat="server">
        <div>
            
        </div>
        <asp:TextBox ID="txtTicketID" runat="server" style="z-index: 1; left: 160px; top: 44px; position: absolute; width: 153px; margin-top: 0px" height="22px"></asp:TextBox>
        <asp:Label ID="lblTicketID" runat="server" style="z-index: 1; left: 7px; top: 47px; position: absolute" Text="TicketID"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblTicketID0" runat="server" style="z-index: 1; left: 7px; top: 47px; position: absolute" Text="TicketID"></asp:Label>
            <asp:Label ID="lblSubject" runat="server" height="19px" style="z-index: 1; left: 9px; top: 127px; position: absolute" Text="Subject" width="54px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblDescription" runat="server" height="19px" style="z-index: 1; left: 8px; top: 167px; position: absolute" Text="Description" width="54px"></asp:Label>
        <asp:Label ID="lblTicketType" runat="server" height="19px" style="z-index: 1; left: 7px; top: 82px; position: absolute" Text="TicketType" width="54px"></asp:Label>
        <asp:Label ID="lblDate" runat="server" height="19px" style="z-index: 1; left: 7px; top: 214px; position: absolute" Text="SubmissionDate" width="54px"></asp:Label>
        <asp:Label ID="lblStatus" runat="server" height="19px" style="z-index: 1; left: 6px; top: 268px; position: absolute" Text="TicketStatus" width="54px"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server" height="22px" style="z-index: 1; left: 160px; top: 162px; position: absolute" width="153px"></asp:TextBox>
        <asp:TextBox ID="txtSbmissionDate" runat="server" height="22px" style="z-index: 1; left: 160px; top: 208px; position: absolute" width="153px"></asp:TextBox>
        <asp:TextBox ID="txtTicketStatus" runat="server" height="22px" style="z-index: 1; left: 160px; top: 263px; position: absolute" width="153px"></asp:TextBox>
        <asp:TextBox ID="txtTicketType" runat="server" height="22px" style="z-index: 1; left: 160px; top: 87px; position: absolute" width="153px"></asp:TextBox>
        <asp:TextBox ID="txtSubject" runat="server" height="22px" style="z-index: 1; left: 162px; top: 123px; position: absolute" width="153px"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" style="z-index: 1; left: 29px; top: 377px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 119px; top: 379px; position: absolute" Text="Cancel" />
        <asp:CheckBox ID="chkElevated" runat="server" style="z-index: 1; left: 165px; top: 321px; position: absolute" Text="TicketElevated" />
    </form>
</body>
</html>
