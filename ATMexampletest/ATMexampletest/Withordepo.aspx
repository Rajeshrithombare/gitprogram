<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Withordepo.aspx.cs" Inherits="ATMexampletest.Withordepo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 80%;
        }
        .auto-style4 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <br />
            <span class="auto-style1"><strong>ICICI ATM MACHIE<br />
            <br />
            </strong></span>
            <table align="center" class="auto-style3">
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Catch Withdrow" />
                    </td>
                    <span class="auto-style1">
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Cash Deposite" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Genrate Pin" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            </span>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
