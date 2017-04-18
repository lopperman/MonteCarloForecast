<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <p class ="heading">
            Select Start Date:&nbsp;
        </p>
        <div >
        <asp:Calendar ID="startDate" runat="server"></asp:Calendar>
&nbsp;<br />
        </div>


        <span><div class ="heading">Estimate Low/High Remaining User Stories:</div>
        <div><asp:TextBox ID="txtLowRemainingStories" CssClass="textbox" runat="server" AutoPostBack="True"></asp:TextBox>/<asp:TextBox ID="txtHighRemainingStories" CssClass="textbox" runat="server" AutoPostBack="True"></asp:TextBox></div></span>
        
        <br />
        
        <div class ="heading">Estimate Low/High Split Probability:</div>
        <div><asp:TextBox ID="txtLowProb" CssClass="textbox" runat="server" AutoPostBack="True"></asp:TextBox>/<asp:TextBox ID="txtHighProb" CssClass="textbox" runat="server" AutoPostBack="True"></asp:TextBox></div></span>
        
        <br />

        <div class ="heading">Model Size (Recommend at least 100,000):</div>
        <div><asp:TextBox ID="txtModelSize" CssClass="textbox" runat="server" AutoPostBack="True"/></div>
        
        <br />

        <div class ="heading">Historic Samples (at least 7, separated by comma):</div>
       
        <div><asp:TextBox ID="txtSamples" CssClass="textboxLarge" runat="server" AutoPostBack="True"/></div>
        <br/>
        <asp:Button ID="btnForecastHistory" CssClass="button" runat="server" OnClick="btnForecastHistory_Click" Text="Forecast (history based) Simple Average" />
        <asp:Button ID="btnForecastHistoryWeighted" CssClass="button" runat="server" OnClick="btnForecastHistoryWeighted_Click" Text="Forecast (history based) Weighted Average" />
        <br />
        <br />
        
        <div class ="heading">Estimate Low/High Guess stories per week:</div>
        <div><asp:Textbox><asp:TextBox ID="txtEstLowVelocity" CssClass="textbox" runat="server" AutoPostBack="True"/></asp:Textbox>/<asp:Textbox><asp:TextBox ID="txtEstHighVelocity" CssClass="textbox" runat="server" AutoPostBack="True"/></asp:Textbox></div>
        <br/>

        <asp:Button ID="btnForecastGuess" CssClass="button" runat="server" OnClick="btnForecastGuess_Click" Text="Forecast (Guess based)" />
        
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="356px" TextMode="MultiLine" Width="692px"></asp:TextBox>
    </form>
</body>
</html>
