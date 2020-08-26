<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Radiobutton.aspx.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #FF0000;
            font-size: xx-large;
        }
    </style>
</head>
<body style="height: 316px; background-color: #CCCCCC">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Mk Placement<br />
            </strong>
        </div>
        <div style="height: 347px; width: 681px; margin-left: 169px">
            <asp:Label ID="Label1" runat="server" Text="Account Number"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Ammount Number"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Deposite" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Withdrow" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" BackColor="#66FFCC" BorderColor="#FF6600" BorderStyle="Solid" ForeColor="#333333" OnClick="Button1_Click" Text="Ok" Width="73px" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
            :</div>
    </form>
</body>
</html>
