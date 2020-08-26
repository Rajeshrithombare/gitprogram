<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Assignment18RadioButton.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #990033;
        }
    </style>
</head>
<body style="height: 499px">
    <form id="form1" runat="server">
        <div>
        </div>
        <p class="auto-style1">
            <strong>MCQ QUETIONS</strong></p>
        <div style="height: 330px; margin-left: 200px">
            <asp:Label ID="Label1" runat="server" Text="Q 1: Capital of india?"></asp:Label>
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Mumbai" />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Delhi" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Q 2: Capital of maharashtra"></asp:Label>
            <br />
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Mumbai" />
            <asp:RadioButton ID="RadioButton4" runat="server" Text="Nagpur" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Q 3: Capital of MP?"></asp:Label>
            <br />
            <asp:RadioButton ID="RadioButton5" runat="server" Text="Bhopal" />
            <asp:RadioButton ID="RadioButton6" runat="server" Text="Baitul" />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Result" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Result:"></asp:Label>
        </div>
    </form>
</body>
</html>
