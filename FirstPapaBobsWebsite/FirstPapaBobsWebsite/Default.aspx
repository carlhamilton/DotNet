<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FirstPapaBobsWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Image ID="Image1" runat="server" Height="222px" ImageUrl="~/PapaBob.png" Width="218px" />
&nbsp;<h1 style="margin-left: 200px">Papa Bob&#39;s Pizza and Software</h1>
        <p>
            &nbsp;</p>
        <asp:RadioButton ID="BabyBobRadioButton" runat="server" Checked="True" GroupName="PizzaSize" OnCheckedChanged="BabyBobRadioButton_CheckedChanged" Text="Baby Bob Size (10&quot;) - £10" />
        <p>
            <asp:RadioButton ID="MamaBobSizeButton" runat="server" Checked="True" GroupName="PizzaSize" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Mama Bob Size (13&quot;) - £13" />
        </p>
        <asp:RadioButton ID="papaBobRadioButton" runat="server" Checked="True" GroupName="PizzaSize" OnCheckedChanged="papaBobRadioButton_CheckedChanged" Text="Papa Bob Size (16&quot;) - £16" />
        <p>
            &nbsp;</p>
        <asp:RadioButton ID="ThinCrustRadioButton" runat="server" Checked="True" GroupName="BaseChoice" OnCheckedChanged="ThinCrustRadioButton_CheckedChanged" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="DeepDishRadioButton" runat="server" GroupName="BaseChoice" OnCheckedChanged="DeepDishRadioButton_CheckedChanged" Text="Deep Dish (+£1)" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="PepperoniCheckButton" runat="server" Checked="True" OnCheckedChanged="PepperoniCheckButton_CheckedChanged" Text="Pepperoni (+£1.50)" />
        <p>
            <asp:CheckBox ID="OnionsCheckBox" runat="server" Checked="True" OnCheckedChanged="OnionsCheckBox_CheckedChanged" Text="Onions (+£0.75)" />
        </p>
        <p>
            <asp:CheckBox ID="GreenPeppersCheckBox" runat="server" Checked="True" OnCheckedChanged="GreenPeppersCheckBox_CheckedChanged" Text="Green Peppers (+£0.50)" />
        </p>
        <p>
            <asp:CheckBox ID="RedPeppersCheckBox" runat="server" Checked="True" OnCheckedChanged="RedPeppersCheckBox_CheckedChanged" Text="Red Peppers (£0.75)" />
        </p>
        <p>
            <asp:CheckBox ID="AnchoviesCheckBox" runat="server" Checked="True" OnCheckedChanged="AnchoviesCheckBox_CheckedChanged" Text="Anchovies (+£2.00)" />
        </p>
        <p>
            &nbsp;</p>
        <h3>Papa Bob&#39;s <span class="auto-style1">Special Deal</span></h3>
        <p>
            &nbsp;</p>
        <p>
            Save £2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your Pizza.</p>
        <p>
            <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="totalCost" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="ConditionalOrder" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
