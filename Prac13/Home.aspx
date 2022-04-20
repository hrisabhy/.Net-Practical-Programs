<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Prac13.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Number 1:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Number 2:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="AddButton" runat="server" Text="Add" OnClick="AddButton_Click" />
&nbsp;&nbsp;
            <asp:Button ID="MultiplyButton" runat="server" Text="Multiply" OnClick="MultiplyButton_Click" />
            <br />
            <br />
            <asp:Label ID="resullLabel" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
