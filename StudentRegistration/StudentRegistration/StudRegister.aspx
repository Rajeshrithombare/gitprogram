<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudRegister.aspx.cs" Inherits="StudentRegistration.StudRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style2 {
            width: 65%;
        }
        .auto-style3 {
            font-size: medium;
        }
        .auto-style4 {
            height: 32px;
        }
        .auto-style5 {
            font-size: medium;
            height: 19px;
            width: 95px;
        }
        .auto-style6 {
            height: 19px;
        }
        .auto-style7 {
            font-size: medium;
            color: #FF0000;
        }
        .auto-style8 {
            color: #FF0000;
        }
        .auto-style9 {
            font-size: medium;
            height: 54px;
            width: 95px;
        }
        .auto-style10 {
            height: 54px;
        }
        .auto-style11 {
            font-size: medium;
            width: 95px;
        }
        .auto-style12 {
            width: 95px;
        }
        .auto-style13 {
            height: 32px;
            width: 95px;
        }
        .auto-style14 {
            font-size: medium;
            width: 95px;
            height: 43px;
        }
        .auto-style15 {
            height: 43px;
        }
        .auto-style16 {
            width: 219px;
        }
        .auto-style17 {
            height: 43px;
            width: 219px;
        }
        .auto-style18 {
            height: 32px;
            width: 219px;
        }
        .auto-style19 {
            height: 54px;
            width: 219px;
        }
        .auto-style20 {
            height: 19px;
            width: 219px;
        }
    </style>
</head>
<body style="background-color:azure">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Registration Form<br />
            <br />
            </strong>
            <table align="center" class="auto-style2">
                <tr>
                    <td class="auto-style11">First Name<span class="auto-style8">*</span></td>
                    <strong>
                    <td class="auto-style16">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    </strong>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" CssClass="auto-style7" ErrorMessage="*First Name is mandetory "></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox1" CssClass="auto-style7" ErrorMessage="Enter First Name Properly" ValidationExpression="[a-zA-Z]*$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <strong>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">Middal Name</td>
                    <td class="auto-style16">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">Last Name<strong><span class="auto-style8">*</span></strong></td>
                    <td class="auto-style16">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" CssClass="auto-style7" ErrorMessage="*Can not blank Last name"></asp:RequiredFieldValidator>
                        &nbsp;&nbsp;&nbsp; &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox3" CssClass="auto-style7" ErrorMessage="Enter First Name Properly" ValidationExpression="[a-zA-Z]*$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style14">Gender</td>
                    <td class="auto-style17">
                        <asp:RadioButton ID="RadioButton1" runat="server" CssClass="auto-style3" GroupName="gen" Text="Male" />
                        <asp:RadioButton ID="RadioButton2" runat="server" CssClass="auto-style3" GroupName="gen" Text="Female" />
                        <asp:RadioButton ID="RadioButton3" runat="server" CssClass="auto-style3" GroupName="gen" Text="Other" />
                    </td>
                    <td class="auto-style15"></td>
                </tr>
                <tr>
                    <td class="auto-style13"></td>
                    <td class="auto-style18"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style9">Date of Birth<strong><span class="auto-style8">*</span></strong></td>
                    <td class="auto-style19">
                        <asp:TextBox ID="TextBox4" runat="server" TextMode="Date" AutoPostBack="True" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" CssClass="auto-style7" ErrorMessage="*Date of Birth is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style10">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Age</td>
                    <td class="auto-style19">
                        <asp:TextBox ID="TextBox9" runat="server" OnTextChanged="TextBox9_TextChanged"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style19">
                        &nbsp;</td>
                    <td class="auto-style10">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">Email Id<strong><span class="auto-style8">*</span></strong></td>
                    <td class="auto-style16">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox6" CssClass="auto-style7" ErrorMessage="*Email Id can not be blank"></asp:RequiredFieldValidator>
&nbsp;
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox6" CssClass="auto-style7" ErrorMessage="*Emaile Id is not in Correct formate" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">Mobile No.<strong><span class="auto-style8">*</span></strong></td>
                    <td class="auto-style16">
                        <asp:TextBox ID="TextBox7" runat="server" TextMode="Phone"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox7" CssClass="auto-style7" ErrorMessage="*Mobile Number should be 10 digit" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">Cource</td>
                    <td class="auto-style16">&nbsp;
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" CssClass="auto-style3">
                            <asp:ListItem>Python</asp:ListItem>
                            <asp:ListItem>java</asp:ListItem>
                            <asp:ListItem>.Net</asp:ListItem>
                            <asp:ListItem>C++</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">Address</td>
                    <td class="auto-style20">
                        <asp:TextBox ID="TextBox8" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox8" CssClass="auto-style7" ErrorMessage="*Address is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">Country</td>
                    <td class="auto-style16">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>India</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DropDownList1" CssClass="auto-style7" ErrorMessage="*Select Country"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">City</td>
                    <td class="auto-style16">
                        <asp:DropDownList ID="DropDownList2" runat="server">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Nagpur</asp:ListItem>
                            <asp:ListItem>Bhopal</asp:ListItem>
                            <asp:ListItem>Patna</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DropDownList2" CssClass="auto-style7" ErrorMessage="*Select City"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">State</td>
                    <td class="auto-style16">
                        <asp:DropDownList ID="DropDownList3" runat="server">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Maharashtra</asp:ListItem>
                            <asp:ListItem>MP</asp:ListItem>
                            <asp:ListItem>Bihar</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DropDownList3" CssClass="auto-style7" ErrorMessage="*Select State"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="width: 70px; height: 26px;" Text="Register" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">
                        <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Text="Status"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            </strong>
        </div>
    </form>
</body>
</html>
