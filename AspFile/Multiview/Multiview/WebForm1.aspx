<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Multiview.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Login" />
&nbsp;
            <asp:Button ID="Button4" runat="server" Text="View1" />
            <br />
            <br />
            <br />
        </div>
        <asp:MultiView ID="MultiView1" runat="server">
            <br />
            <br />
            <asp:View ID="Login" runat="server">
                <asp:Label ID="Username" runat="server" Text="Username"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server" Height="19px" OnTextChanged="TextBox1_TextChanged" style="margin-left: 70px; margin-bottom: 15px" Width="151px"></asp:TextBox>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Password"></asp:Label>
                &nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Button" />
                <br />
                <br />
            </asp:View>
            <br />
            <br />
            <br />
            <asp:View ID="View1" runat="server">
                <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
                &nbsp;
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" Text="Button" />
                <br />
            </asp:View>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:MultiView>
    </form>
</body>
</html>
