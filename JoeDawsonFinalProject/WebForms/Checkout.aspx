<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="JoeDawsonFinalProject.WebPages.CheckoutPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" type="text/css" href="../CSSFiles/CheckoutStyle.css"/>

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 477px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <asp:ListBox ID="mediaListBox" runat="server" Height="225px" Width="700px" AutoPostBack="True" OnSelectedIndexChanged="mediaListBox_SelectedIndexChanged"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Change Quantity:
                    <asp:TextBox ID="quanTXT" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="QtyEditBtn" runat="server" Text="Accept Changes" OnClick="acceptButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="payBtn" runat="server" Text="Pay" Width="124px" OnClick="payButton_Click" />
                </td>
                <td>
                    <asp:Button ID="ExitBtn" runat="server" Text="Exit" Width="125px" OnClick="exitButton_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Total:
                    <asp:Label ID="totalLabel" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
