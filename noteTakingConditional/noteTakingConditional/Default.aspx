<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="noteTakingConditional.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Note Taking Preferences:<br />
            <br />
            <asp:RadioButton ID="pencilCheck" runat="server" Checked="True" GroupName="NoteGroup" OnCheckedChanged="pencilCheck_CheckedChanged" Text="Pencil" />
            <br />
            <asp:RadioButton ID="penCheck" runat="server" Checked="True" GroupName="NoteGroup" OnCheckedChanged="penCheck_CheckedChanged" Text="Pen" />
            <br />
            <asp:RadioButton ID="phoneCheck" runat="server" Checked="True" GroupName="NoteGroup" OnCheckedChanged="phoneCheck_CheckedChanged" Text="Phone" />
            <br />
            <asp:RadioButton ID="tabletCheck" runat="server" Checked="True" GroupName="NoteGroup" OnCheckedChanged="tabletCheck_CheckedChanged" Text="Tablet" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Image ID="imageSet" runat="server" Height="336px" Width="418px" />
    </form>
</body>
</html>
