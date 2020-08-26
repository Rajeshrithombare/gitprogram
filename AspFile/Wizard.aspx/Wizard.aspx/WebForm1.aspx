<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Wizard.aspx.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="2" Height="224px" OnFinishButtonClick="Wizard1_FinishButtonClick" Width="531px">
            <WizardSteps>
                <asp:WizardStep runat="server" title="Step 1">
                    Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server" title="Step 2">
                    Sirname
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep runat="server">
                    email&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep ID="end" runat="server" StepType="Complete">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    </form>
    <p>
&nbsp;</p>
</body>
</html>
