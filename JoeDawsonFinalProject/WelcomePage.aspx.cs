using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JoeDawsonFinalProject.WebPages
{
    public partial class WelcomeScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void shoppingPlazaButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Webforms/ShoppingPlazaForm.aspx");
        }

        protected void exitButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Webforms/ExitPage.aspx");
        }
    }
}