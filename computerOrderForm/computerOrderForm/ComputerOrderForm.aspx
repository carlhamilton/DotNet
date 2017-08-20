<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComputerOrderForm.aspx.cs" Inherits="computerOrderForm.ComputerOrderForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Computer Order</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Computer Order" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            <br />
            <br />
            <asp:Label ID="OrderID" runat="server" Text="Order ID ="></asp:Label>
&nbsp;<br />
            <asp:Label ID="Order" runat="server" Text="Order Name: "></asp:Label>
&nbsp;<asp:TextBox ID="OrderName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="custName" runat="server" Text="Customer Name: "></asp:Label>
&nbsp;<asp:TextBox ID="CustomerName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="custEmail" runat="server" Text="Customer Email: "></asp:Label>
&nbsp;<asp:TextBox ID="CustomerEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="DeliveryD" runat="server" Text="Delivery Date:"></asp:Label>
            <asp:Calendar ID="DeliveryDate" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                <DayStyle BackColor="#CCCCCC" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                <TodayDayStyle BackColor="#999999" ForeColor="White" />
            </asp:Calendar>
            <br />
            <asp:Label ID="PartN" runat="server" Text="Part Number: "></asp:Label>
&nbsp;<asp:TextBox ID="PartNumber" runat="server" Height="51px" Width="74px"></asp:TextBox>
            <br />
            Rush? <asp:RadioButton ID="RushYes" runat="server" GroupName="Rush" Text="Yes" />
&nbsp;<asp:RadioButton ID="RushNo" runat="server" Checked="True" GroupName="Rush" Text="No" />
            <br />
            <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="OK" />
            <br />
        </div>
    </form>
</body>
</html>
