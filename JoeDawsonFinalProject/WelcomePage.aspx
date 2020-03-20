<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePage.aspx.cs" Inherits="JoeDawsonFinalProject.WebPages.WelcomeScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome Page</title>
    <link rel ="stylesheet" type ="text/css" href ="CSSFiles/Site.css"/> 
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 522px;
        }
        .auto-style4 {
            height: 37px;
        }
        .auto-style5 {
            height: 27px;
        }
        .auto-style6 {
            height: 41px;
        }
        .auto-style7 {
            height: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <h1>Welcome to the Shopping Page!</h1>
    <table class="auto-style1">
        
        <tr>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">Here you can purchase books and DVDs. Simply follow the instructions provided below:</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">Instructions:</td>
        </tr>
        <tr>
            <td class="auto-style7" >1. Select the book and enter the quantity. Click Add.</td>
        </tr>
        <tr>
            <td class="auto-style7">2. Select the DVD and enter the quantity. Click Add.</td>
        </tr>
        <tr>
            <td class="auto-style7">3. To check out, click Check-Out.</td>
        </tr>
        <tr>
            <td class="auto-style7">4. To close the application, click Exit. you will lose your selections </td>
        </tr>
        <tr>
            <td class="auto-style4">5. In the check out screen, revise the quantities if you wish to. If you do, click Edit.</td>
        </tr>
        <tr>
            <td class="auto-style4">6. To place final order, click Pay.</td>
        </tr>
        <tr>
            <td class="auto-style4">7. To close the application, click Exit. You will lose your selections. </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:Button ID="shoppingPlazaButton" runat="server" Text="Go to Shopping Plaza" OnClick="shoppingPlazaButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="ExitBtn" runat="server" Text="Exit" Width="114px" OnClick="exitButton_Click" />
                      
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
</html>
