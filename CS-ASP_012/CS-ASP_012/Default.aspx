<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_012.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Is&nbsp;
            <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp;equal to&nbsp;
            <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp; ?<br />
            <br />
        </div>
        <asp:CheckBox ID="oldCheckBox" runat="server" Checked="True" OnCheckedChanged="oldCheckBox_CheckedChanged" />
        <p>
            &nbsp;</p>
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <p>
            Your score:
            <asp:Label ID="scoreResult" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
