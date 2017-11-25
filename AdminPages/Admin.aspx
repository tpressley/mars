<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="AdminPages_Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="AllianceNameEntry" runat="server"></asp:TextBox>
            <asp:Button ID="AddFriendly" runat="server" Text="Button" OnClick="AddFriendly_Click" />
            <asp:Button ID="AddHostile" runat="server" Text="Button" OnClick="AddHostile_Click" />
        </div>
    </form>
</body>
</html>
