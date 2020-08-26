<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Panel.aspx.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 1133px;
        }
    </style>
</head>
<body style="height: 11px">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="Disc">
            <asp:ListItem>Mango</asp:ListItem>
            <asp:ListItem>Banana</asp:ListItem>
            <asp:ListItem>Apple</asp:ListItem>
            <asp:ListItem>Pinaple</asp:ListItem>
            <asp:ListItem>Orange</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:BulletedList>
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" OnSelectionChanged="Calendar1_SelectionChanged" Width="220px">
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
        </asp:Calendar>
        <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/myimage.png" Width="200px" />
        <asp:Button ID="Button1" runat="server" Height="26px" OnClick="Button1_Click1" Text="Button" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Janevery</asp:ListItem>
                <asp:ListItem>Februvery</asp:ListItem>
                <asp:ListItem>March</asp:ListItem>
                <asp:ListItem>April</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:CheckBoxList>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Radio</asp:ListItem>
                <asp:ListItem>Button</asp:ListItem>
                <asp:ListItem>List</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:AdRotator ID="AdRotator1" runat="server" />
        <br />
    </form>
</body>
</html>
