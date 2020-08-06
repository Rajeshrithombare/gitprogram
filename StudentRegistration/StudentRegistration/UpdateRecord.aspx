<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateRecord.aspx.cs" Inherits="StudentRegistration.UpdateRecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            width: 60%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <strong><span class="auto-style2">Update And Delete Record<br />
            <br />
            </span></strong>
            <br />
            <table align="center" class="auto-style3">
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="User_id" HeaderText="User Id" />
                                <asp:TemplateField HeaderText="First_Name">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text="<%# eval("First_Name") %>"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text="<%# eval("First_Name") %>"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <EmptyDataTemplate>
                                User Id
                            </EmptyDataTemplate>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
