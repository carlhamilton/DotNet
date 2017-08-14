<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_009.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Width="614px"></asp:TextBox>
        </div>
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Go" />
        <p>
            &nbsp;</p>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
