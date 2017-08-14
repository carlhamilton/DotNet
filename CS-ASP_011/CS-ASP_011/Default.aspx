<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_011.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Is&nbsp;
            <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp;equal to
            <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp;?</p>
        <p>
            &nbsp;</p>
        <p>
&nbsp;</p>
        <asp:Button ID="OkButton" runat="server" OnClick="OkButton_Click" Text="OK" />
        <p>
            &nbsp;</p>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        If you could only eat one food for the rest of your life, what would you choose?<br />
        <asp:RadioButton ID="PizzaButton" runat="server" Checked="True" GroupName="FoodGroup" Text="Pizza" />
        <br />
        <asp:RadioButton ID="ChineseButton" runat="server" Checked="True" GroupName="FoodGroup" Text="Chinese" />
        <br />
        <asp:RadioButton ID="ChickenNVeg" runat="server" Checked="True" GroupName="FoodGroup" Text="Chicken &amp; Veg" />
        <br />
        <br />
        <asp:Button ID="okButton2" runat="server" OnClick="okButton2_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="resultLabel2" runat="server"></asp:Label>
    </form>
</body>
</html>
