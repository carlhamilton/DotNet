<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/epic-spies-logo.jpg" />
            <br />
        </div>
        <p>
            &nbsp;</p>
        <h1>Spy New Assignment Form</h1>
        <p>
            &nbsp;</p>
        <p>
            Spy Code Name:&nbsp;
            <asp:TextBox ID="spyTextBox" runat="server" OnTextChanged="spyTextBox_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            New Assignment Name:&nbsp;
            <asp:TextBox ID="assignmentTextBox" runat="server" OnTextChanged="assignmentTextBox_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            End Date Of Previous Assignment:</p>
        <p>
            <asp:Calendar ID="previousAssignment" runat="server"></asp:Calendar>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Start Date of New Assignment:</p>
        <p>
            <asp:Calendar ID="newAssignment" runat="server"></asp:Calendar>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Projected End Date Of New Assignment:</p>
        <p>
            <asp:Calendar ID="newAssignmentEnd" runat="server"></asp:Calendar>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="assignButton" runat="server" OnClick="assignButton_Click" Text="Assign Spy" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="clauseLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
