<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="CreateLogin.aspx.cs" Inherits="BookStoreTest.CreateLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style5 {
        width: 80%;
    }
    .auto-style6 {
        color: #FF0000;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<table align="center" class="auto-style5">
    <tr>
        <td>UserName</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" CssClass="auto-style6" ErrorMessage="Username can not be blank"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Password</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" CssClass="auto-style6" ErrorMessage="Password can not be blank"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" CssClass="auto-style6" ErrorMessage="Password should be atlist 8 character use atliste one number and one upper case one lower case and one number" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d$@$!%*#?&amp;]{8,}$"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Confirm Password</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" CssClass="auto-style6" ErrorMessage="Confiirm Password can not be blank"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" CssClass="auto-style6" ErrorMessage="Password dose not match "></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
