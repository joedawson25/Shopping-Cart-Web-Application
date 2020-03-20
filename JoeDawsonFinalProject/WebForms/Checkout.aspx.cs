using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JoeDawsonFinalProject.Models;
using JoeDawsonFinalProject.Controller;
using JoeDawsonFinalProject.WebPages;

namespace JoeDawsonFinalProject.WebPages
{
    public partial class CheckoutPage : System.Web.UI.Page
    {
        List<CartObject> cartobj = new List<CartObject>();
        protected void Page_Load(object sender, EventArgs e)
        {
            cartobj = (List<CartObject>)Session["Cart"];

            if(!IsPostBack)
            {
                foreach(CartObject i in cartobj)
                {
                    mediaListBox.Items.Add(i.OBJ.Title + " - " + i.OBJ.Price.ToString("C"));
                }
            }

            quanTXT.Enabled = false;

            double totalPrice = 0;

            foreach(CartObject i in cartobj)
            {
                totalPrice += (i.OBJ.Price * (1-i.OBJ.DiscountPercentage(i.Quantity)) * i.Quantity);
            }

            totalLabel.Text = totalPrice.ToString("C");
        }

        protected void mediaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quanTXT.Enabled = true;
            CartObject selectedProduct = cartobj[mediaListBox.SelectedIndex];
            quanTXT.Text = selectedProduct.Quantity.ToString();
        }

        protected void acceptButton_Click(object sender, EventArgs e)
        {
            if(int.Parse(quanTXT.Text) == 0)
            {
                cartobj.RemoveAt(mediaListBox.SelectedIndex);
                mediaListBox.Items.RemoveAt(mediaListBox.SelectedIndex);
            }
            else
            {
                cartobj[mediaListBox.SelectedIndex].Quantity = int.Parse(quanTXT.Text);
            }

            mediaListBox.Items.Clear();

            foreach(CartObject i in cartobj)
            {
                mediaListBox.Items.Add(i.OBJ.Title);
            }

            double totalPrice = 0;

            foreach (CartObject i in cartobj)
            {
                totalPrice += (i.OBJ.Price * i.Quantity);
            }

            totalLabel.Text = totalPrice.ToString("C");
        }

        protected void payButton_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;
            double totalDiscount = 0;

            foreach (CartObject i in cartobj)
            {
                totalPrice += (i.OBJ.Price * i.Quantity *(1-i.OBJ.DiscountPercentage(i.Quantity)));
            }

            foreach(CartObject i in cartobj)
            {
                totalDiscount += i.OBJ.DiscountPercentage(i.Quantity);
            }
            

            totalLabel.Text = "Your final price is: " + totalPrice.ToString("C") + ". Your discount is: " + totalDiscount.ToString("P");
        
    }

        protected void exitButton_Click(object sender, EventArgs e)
        {
            Server.Transfer("ExitPage.aspx");
        }
    }
}