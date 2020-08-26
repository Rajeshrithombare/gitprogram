<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Checkbox.aspx.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #660033;
        }
    </style>
</head>
<body style="height: 731px">
    <form id="form1" runat="server">
        <div class="auto-style1" style="height: 491px">
            <strong>&nbsp;MK PLACEMENT<br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Q.1: type of inpute device?"></asp:Label>
            <br />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Mouse" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Printer" />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Keybord" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Q.2: Type of outpute devices?"></asp:Label>
            <br />
            <br />
            <asp:CheckBox ID="CheckBox4" runat="server" Text="mouse" />
            <asp:CheckBox ID="CheckBox5" runat="server" Text="printer" />
            <asp:CheckBox ID="CheckBox6" runat="server" Text="ploter" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Result" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Result:"></asp:Label>
            </strong>
        </div>
    </form>
</body>
</html>
