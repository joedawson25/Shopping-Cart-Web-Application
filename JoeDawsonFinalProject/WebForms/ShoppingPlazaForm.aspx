<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingPlazaForm.aspx.cs" Inherits="JoeDawsonFinalProject.WebPages.MainShoppingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type ="text/css" href="../CSSFiles/PlazaStyle.css"/>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-bottom: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <h1> Here you make your selections. You can select one book title and one DVD title.</h1>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td>Books:&nbsp;
                    <asp:DropDownList ID="bookDDL" runat="server" Width="298px" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td>Quantity:&nbsp;
                    <asp:TextBox class="entry" ID="bookTB" runat="server"></asp:TextBox>
                </td>
                <td>Price of Book:
                    <asp:Label ID="priceofBookLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>DVDs:&nbsp;
                    <asp:DropDownList ID="dvdDDL" runat="server" Width="298px" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td>Quantity:&nbsp;
                    <asp:TextBox class="entry" ID="dvdTB" runat="server"></asp:TextBox>
                </td>
                <td>Price of DVD:
                    <asp:Label ID="priceofDVDLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label class="validator" ID="MessageLbl" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="confrimMessage" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button class="mybutton" ID="AddItemBtn" runat="server" Text="Add" Width="124px" OnClick="addButton_Click" />
                </td>
                <td>
                    <asp:Button class="mybutton" ID="checkoutButton" runat="server" Text="Checkout" Width="124px" OnClick="checkoutButton_Click" />
                </td>
                <td>
                    <asp:Button class="mybutton" ID="ExitBtn" runat="server" Text="Exit" Width="124px" OnClick="exitButton_Click" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
