<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Select Start Date:&nbsp;
        </p>
        <asp:Calendar ID="startDate" runat="server"></asp:Calendar>
&nbsp;<br />
        Estimate Low/High Remaining User Stories:&nbsp;
        <asp:TextBox ID="txtLowRemainingStories" runat="server" AutoPostBack="True"></asp:TextBox>
        /
        <asp:TextBox ID="txtHighRemainingStories" runat="server" AutoPostBack="True"></asp:TextBox>
        <br />
        Estimate Low/High Split Probability:
        <asp:TextBox ID="txtLowProb" runat="server" AutoPostBack="True"></asp:TextBox>
&nbsp;/
        <asp:TextBox ID="txtHighProb" runat="server"></asp:TextBox>
        <br />
        Model Size (Recommend at least 100,000):
        <asp:TextBox ID="txtModelSize" runat="server" AutoPostBack="True">100000</asp:TextBox>
        <br />
        Historic Samples (at least 7, separated by comma):&nbsp;
        <asp:TextBox ID="txtSamples" runat="server" AutoPostBack="True"></asp:TextBox>
        <asp:Button ID="btnForecastHistory" runat="server" OnClick="btnForecastHistory_Click" Text="Forecast (history based)" />
        <br />
        Estimate Low/High Guess stories per week:&nbsp;
        <asp:TextBox ID="txtEstLowVelocity" runat="server" AutoPostBack="True"></asp:TextBox>
&nbsp;/
        <asp:TextBox ID="txtEstHighVelocity" runat="server" AutoPostBack="True"></asp:TextBox>
        <asp:Button ID="btnForecastGuess" runat="server" OnClick="btnForecastGuess_Click" Text="Forecast (Guess based)" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="356px" TextMode="MultiLine" Width="692px"></asp:TextBox>
    </form>
</body>
</html>
