<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="BookEntryRegistration.aspx.cs" Inherits="BookStoreTest.BookEntryRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style5 {
        width: 80%;
    }
    .auto-style6 {
        color: #FF0000;
    }
    .auto-style7 {
        margin-left: 0px;
    }
    .auto-style8 {
        height: 11px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" class="auto-style5">
    <tr>
        <td>&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Log Out" />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>Book Name</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" CssClass="auto-style6" ErrorMessage="Book name can not be blank"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Book MRP</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" CssClass="auto-style6" ErrorMessage="MRP of book can not be blank"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Author</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style7" Height="20px" Width="127px">
                <asp:ListItem>--Select--</asp:ListItem>
                <asp:ListItem>Durjoy datta</asp:ListItem>
                <asp:ListItem>Chetan Bhagat</asp:ListItem>
                <asp:ListItem>Tolstoy</asp:ListItem>
                <asp:ListItem>Emily</asp:ListItem>
                <asp:ListItem>Herman</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList1" CssClass="auto-style6" ErrorMessage="Please select Author name "></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Category</td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style7" Height="24px" Width="127px">
                <asp:ListItem>---Select--</asp:ListItem>
                <asp:ListItem>Love Story</asp:ListItem>
                <asp:ListItem>Triller</asp:ListItem>
                <asp:ListItem>Horror</asp:ListItem>
                <asp:ListItem>Comedy</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList2" CssClass="auto-style6" ErrorMessage="Please select Category of book"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>Publisher</td>
        <td>
            <asp:DropDownList ID="DropDownList3" runat="server" Height="20px" Width="124px">
                <asp:ListItem>--Select--</asp:ListItem>
                <asp:ListItem>Penguin metro reads</asp:ListItem>
                <asp:ListItem>Rolly books</asp:ListItem>
                <asp:ListItem>Hachett India</asp:ListItem>
                <asp:ListItem>Rupa Publications</asp:ListItem>
                <asp:ListItem>Westland Publication</asp:ListItem>
                <asp:ListItem>Aleph Book Company</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="DropDownList3" CssClass="auto-style6" ErrorMessage="Please select Publisher of the book"></asp:RequiredFieldValidator>
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
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Book" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8"></td>
        <td class="auto-style8"></td>
        <td class="auto-style8"></td>
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
