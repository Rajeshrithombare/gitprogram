<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Intrisic.aspx.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #006666;
        }
    </style>
</head>
<body style="font-weight: 700">
    <form id="form1" runat="server">
        <div class="auto-style1">
            Mk Placement<br />
        </div>
        <div style="margin-left: 440px">
            <asp:Label ID="Label1" runat="server" style="text-align: center" Text="Username"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" BorderColor="#66FFFF" BorderStyle="Solid"></asp:TextBox>
            <br />
        </div>
        <div style="margin-left: 440px">
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" BorderColor="#66FFFF" BorderStyle="Solid" TextMode="Password"></asp:TextBox>
            <br />
            <br />
        </div>
        <div style="margin-left: 520px">
            <asp:Button ID="Button1" runat="server" BorderColor="#66FFFF" BorderStyle="Solid" OnClick="Button1_Click" style="font-weight: 700" Text="Login" />
            <br />
            <br />
        </div>
        <div style="margin-left: 440px">
            <asp:Label ID="Label3" runat="server" Text="Result:"></asp:Label>
        </div>
    </form>
</body>
</html>
