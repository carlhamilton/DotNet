<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="178px" ImageUrl="~/epic-spies-logo.jpg" Width="150px" />
            <br />
            <br />
            <h1>Asset Performance Tracker</h1>
        </div>
        <p>
            &nbsp;</p>
        <p>
            Asset Name:&nbsp;
            <asp:TextBox ID="assetTextBox" runat="server" OnTextChanged="assetTextBox_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Elections Rigged:&nbsp;
            <asp:TextBox ID="electionTextBox" runat="server" OnTextChanged="electionTextBox_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Acts Of Subterfuge Performed:&nbsp;
            <asp:TextBox ID="aospTextBox" runat="server" OnTextChanged="aospTextBox_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="assetButton" runat="server" OnClick="assetButton_Click" Text="Add Asset" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
