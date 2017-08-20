<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SessionVApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        Enter your name:
        <asp:TextBox ID="EnteredName" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter your email:
        <asp:TextBox ID="EnteredEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="SaveState" runat="server" OnClick="SaveState_Click" Text="Save" />
&nbsp;<asp:Button ID="RetrieveState" runat="server" OnClick="RetrieveState_Click" Text="Retrieve" />
        <br />
        <asp:Label ID="NameAndEmail" runat="server"></asp:Label>
        <br />
        <asp:Label ID="RetrievedNameAndEmail" runat="server"></asp:Label>
    </form>
</body>
</html>
