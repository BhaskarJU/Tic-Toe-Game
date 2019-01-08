<%@ Page Language="C#"  EnableViewState="true"  EnableViewStateMac="true" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="firstWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center;">
            <h1 style="border-color: #FF00FF; font-family: Algerian; font-size: 35px; font-weight: lighter; font-style: italic; color: #00FFFF; text-decoration: underline overline blink; letter-spacing: 2px; background-color: #FFFF00; background-repeat: no-repeat; border-style: dotted">
                Welcome to TIC-TOE
            </h1>
            <h2>Who wants to be Player 1 i.e Starter???
            </h2>
            <div style="align-items: center">
                <h4 style="font-family: Algerian; font-size: medium; font-weight: normal; font-style: inherit; color: #FF0000; text-decoration: underline blink">
                    First select here:-
                </h4>
                <asp:Button ID="player1" runat="server" Text="Player 1(Starter- X)" Width="50%" OnClick="player1_Click" BackColor="Lime" ForeColor="Black" />             
                <asp:Button ID="player2" runat="server" Text="Player 2(O)" Width="50%" OnClick="player2_Click" BackColor="Fuchsia" ForeColor="White" />
            </div> 
            <br />
            <br />
            <h4 style="color: #00FF00">
                Now
                Click your Cell...
            </h4>
            <table id="Table1" style="width: 60%; margin-left: 20%; margin-right: 20%; text-align: center">
                <tr style="height: 78px">
                    <td style="border-style: solid;">
                        <asp:Button ID="cell1" runat="server" Text="cell1" OnClick="cell1_Click" ForeColor="Red" ToolTip="Can Click" BackColor="Yellow" BorderStyle="Solid" Font-Bold="True" />
                    </td>
                    <td style="border-style: solid;">
                        <asp:Button ID="cell2" runat="server" Text="cell2" OnClick="cell2_Click" ForeColor="red" ToolTip="Can Click" BackColor="Yellow" BorderStyle="Solid" Font-Bold="True" />
                    </td>
                    <td style="border-style: solid">
                        <asp:Button ID="cell3" runat="server" Text="cell3" OnClick="cell3_Click" ForeColor="red" ToolTip="Can Click" BackColor="Yellow" BorderStyle="Solid" Font-Bold="True"/>
                    </td>
                </tr>
                <tr style="height: 78px">
                    <td style="border-style: solid">
                        <asp:Button ID="cell4" runat="server" Text="cell4" OnClick="cell4_Click" ForeColor="red" ToolTip="Can Click" BackColor="Yellow" BorderStyle="Solid" Font-Bold="True" />
                    </td>
                    <td style="border-style: solid">
                        <asp:Button ID="cell5" runat="server" Text="cell5" OnClick="cell5_Click" ForeColor="red" ToolTip="Can Click" BackColor="Yellow" BorderStyle="Solid" Font-Bold="True"/>
                    </td>
                    <td style="border-style: solid">
                        <asp:Button ID="cell6" runat="server" Text="cell6" OnClick="cell6_Click" ForeColor="red" ToolTip="Can Click" BackColor="Yellow" BorderStyle="Solid" Font-Bold="True"/>
                    </td>
                </tr>
                <tr style="height: 78px">
                    <td style="border-style: solid">
                        <asp:Button ID="cell7" runat="server" Text="cell7" OnClick="cell7_Click" ForeColor="red" ToolTip="Can Click" BackColor="Yellow" BorderStyle="Solid" Font-Bold="True"/>
                    </td>
                    <td style="border-style: solid">
                        <asp:Button ID="cell8" runat="server" Text="cell8" OnClick="cell8_Click" ForeColor="red" ToolTip="Can Click" BackColor="Yellow" BorderStyle="Solid" Font-Bold="True"/>
                    </td>
                    <td style="border-style: solid">
                        <asp:Button ID="cell9" runat="server" Text="cell9" OnClick="cell9_Click" ForeColor="red" ToolTip="Can Click" BackColor="Yellow" BorderStyle="Solid" Font-Bold="True"/>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Label ID="msg" runat="server" BackColor="#FFFF99" Font-Bold="True" Font-Underline="True" ForeColor="Lime">Game in Progress....</asp:Label>
            <br />
            <asp:Label ID="msg1" runat="server" BackColor="#FFFF99" Font-Bold="True" Font-Underline="True" ForeColor="Fuchsia"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Underline="True" ForeColor="#0033CC" NavigateUrl="~/WebForm1.aspx" Target="_parent">Click to Play AGAIN..</asp:HyperLink>                                 
        </div>
    </form>
</body>
</html>
