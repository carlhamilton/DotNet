<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_022.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            From:<br />
            <br />
            <asp:RadioButton ID="fromChicagoRadio" runat="server" GroupName="StartLocation" Text="Chicago" />
            <br />
            <asp:RadioButton ID="fromNewYorkRadio" runat="server" GroupName="StartLocation" Text="New York" />
            <br />
            <asp:RadioButton ID="fromLondonRadio" runat="server" GroupName="StartLocation" Text="London" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            To:</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:RadioButton ID="toChicagoRadio" runat="server" GroupName="DestinationLocation" Text="Chicago" />
        </p>
        <p>
            <asp:RadioButton ID="toNewYorkRadio" runat="server" GroupName="DestinationLocation" Text="New York" />
        </p>
        <p>
            <asp:RadioButton ID="toLondonRadio" runat="server" GroupName="DestinationLocation" Text="London" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        </p>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
