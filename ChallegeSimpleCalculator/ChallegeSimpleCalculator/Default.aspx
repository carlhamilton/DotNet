<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallegeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <h1>Simple Calculator</h1>
        <p>
            &nbsp;</p>
        <p>
            First Value:&nbsp;&nbsp;
            <asp:TextBox ID="firstNumberTextBox" runat="server" style="font-family: Arial, Helvetica, sans-serif"></asp:TextBox>
&nbsp;</p>
        <p>
            Second Value:&nbsp;
            <asp:TextBox ID="secondNumberTextBox" runat="server" style="font-family: Arial, Helvetica, sans-serif"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="AdditionBox" runat="server" OnClick="AdditionBox_Click" style="margin-left: 30px" Text="+" Width="64px" />
            <asp:Button ID="MinusBox" runat="server" OnClick="Button2_Click" style="margin-left: 38px" Text="-" Width="61px" />
            <asp:Button ID="MultiplicatonBox" runat="server" OnClick="MultiplicatonBox_Click" style="margin-left: 36px" Text="*" Width="57px" />
            <asp:Button ID="DivisionBox" runat="server" OnClick="DivisionBox_Click" style="margin-left: 36px" Text="/" Width="52px" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="ResultLabel" runat="server" BackColor="#0099FF" Font-Bold="True" Font-Size="Larger"></asp:Label>
    </form>
</body>
</html>
