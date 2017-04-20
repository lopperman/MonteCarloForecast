<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Burndown.aspx.cs" Inherits="Burndown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="burndownForm" runat="server">
    <span>&nbsp;<asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" RepeatDirection="Horizontal" AutoPostBack="True">
            <asp:ListItem Selected="True" Value="History">History Based Forecast</asp:ListItem>
            <asp:ListItem Value="Guess">Guess Based Forecast</asp:ListItem>
        </asp:RadioButtonList>
</span>
        <table>
            <tr>
                <td><p class="heading">
        Select Project Start Date:&nbsp;
    </p>
    <div >
        <asp:Calendar ID="startDate" runat="server"></asp:Calendar>
        <br/>
        &nbsp;<br/>
    </div></td>
                <td><p class="heading">
        Select Target End Date:&nbsp;
    </p>
    <div >
        <asp:Calendar ID="endDate" runat="server"></asp:Calendar>
        <br/>
        &nbsp;<br/>
    </div></td>
                <td><p class="heading">
        Select Forecase From Date:&nbsp;
    </p>
    <div >
        <asp:Calendar ID="forecastDate" runat="server"></asp:Calendar>
        <br/>
        &nbsp;<br/>
    </div></td>
            </tr>
        </table>
    


    <span><div class ="heading">Estimate Low/High Remaining User Stories:</div>
        <div><asp:TextBox ID="txtLowRemainingStories" CssClass="textbox" runat="server" AutoPostBack="True"></asp:TextBox>/<asp:TextBox ID="txtHighRemainingStories" CssClass="textbox" runat="server" AutoPostBack="True"></asp:TextBox></div></span>
        
    <br/>

    <div class="heading">Estimate Low/High Split Probability:</div>
    <div><asp:TextBox ID="txtLowProb" CssClass="textbox" runat="server" AutoPostBack="True"></asp:TextBox>/<asp:TextBox ID="txtHighProb" CssClass="textbox" runat="server" AutoPostBack="True"></asp:TextBox>
    </div></span>

    <br/>

    <div class="heading">Model Size (Recommend at least 100,000):</div>
    <div>
        <asp:TextBox ID="txtModelSize" CssClass="textbox" runat="server" AutoPostBack="True"/>
    </div>

    <br/>
    <div id="HistoryForecastElements" runat="server">
        <div class="heading">Historic Samples (at least 7, separated by comma):</div>

        <div>
            <asp:TextBox ID="txtSamples" CssClass="textboxLarge" runat="server" AutoPostBack="True"/>
        </div>
        <br/>
        <asp:Button ID="btnForecastHistory" CssClass="button" runat="server" OnClick="btnForecastHistory_Click" Text="Forecast (history based) Simple Average"/>
        <asp:Button ID="btnForecastHistoryWeighted" CssClass="button" runat="server" OnClick="btnForecastHistoryWeighted_Click" Text="Forecast (history based) Weighted Average"/>
        <br/>
    </div>
    <br/>

    <div id="GuessForecastElements"  runat="server">
        <div class="heading">Estimate Low/High Guess stories per week:</div>
        <div>
            <asp:Textbox>
                <asp:TextBox ID="txtEstLowVelocity" CssClass="textbox" runat="server" AutoPostBack="True"/>
            </asp:Textbox>/<asp:Textbox>
                <asp:TextBox ID="txtEstHighVelocity" CssClass="textbox" runat="server" AutoPostBack="True"/>
            </asp:Textbox>
        </div>
        <br/>

        <asp:Button ID="btnForecastGuess" CssClass="button" runat="server" OnClick="btnForecastGuess_Click" Text="Forecast (Guess based)"/>

        <br/>
    </div>
    <br/>
    </form>
</body>
</html>
