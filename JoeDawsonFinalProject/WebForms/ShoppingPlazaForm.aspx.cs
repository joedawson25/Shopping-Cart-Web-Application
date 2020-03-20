using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JoeDawsonFinalProject.Controller;
using JoeDawsonFinalProject.Models;


namespace JoeDawsonFinalProject.WebPages
{
    public partial class MainShoppingPage : System.Web.UI.Page
    {

        List<Product> ProductList = new List<Product>();
        List<CartObject> cart = new List<CartObject>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AllProducts"] == null)
            {
                BuildProducts genprods = new BuildProducts();
            }

            ProductList = (List<Product>)Session["AllProducts"];

            if (!IsPostBack)
            {
                foreach (Product i in ProductList)
                {
                    if (i.ProductType == "Book")
                    {
                        bookDDL.Items.Add(i.Title);
                    }
                    else
                    {
                        dvdDDL.Items.Add(i.Title);
                    }
                }
            }

            Product selectedBook = ProductList[bookDDL.SelectedIndex];
            Product selectedDVD = ProductList[dvdDDL.SelectedIndex + 5];

            int bookQuantity;
            int.TryParse(bookTB.Text, out bookQuantity);

            int dvdQuantity;
            int.TryParse(dvdTB.Text, out dvdQuantity);

            priceofBookLabel.Text = selectedBook.Price.ToString("C");
            priceofDVDLabel.Text = selectedDVD.Price.ToString("C");

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            if (Session["Cart"] == null)
            {
                if (bookTB.Text != "" && dvdTB.Text == "")
                {
                    Product selectedBook = ProductList[bookDDL.SelectedIndex];
                    CartObject book = new CartObject(int.Parse(bookTB.Text), selectedBook);
                    cart.Add(book);

                    HttpContext.Current.Session["Cart"] = cart;

                    confrimMessage.Text = selectedBook.Title + " has been added ";
                }
                else if (dvdTB.Text != "" && bookTB.Text == "")
                {
                    Product selectedDVD = ProductList[dvdDDL.SelectedIndex + 5];
                    CartObject dvd = new CartObject(int.Parse(dvdTB.Text), selectedDVD);
                    cart.Add(dvd);

                    confrimMessage.Text = selectedDVD.Title + " has been added ";

                    HttpContext.Current.Session["Cart"] = cart;

                }
                else if (dvdTB.Text != "" && bookTB.Text != "")
                {
                    Product selectedBook = ProductList[bookDDL.SelectedIndex];
                    CartObject book = new CartObject(int.Parse(bookTB.Text), selectedBook);
                    cart.Add(book);

                    Product selectedDVD = ProductList[dvdDDL.SelectedIndex + 5];
                    CartObject dvd = new CartObject(int.Parse(dvdTB.Text), selectedDVD);
                    cart.Add(dvd);

                    confrimMessage.Text = selectedBook.Title + " and " + selectedDVD.Title + " has been added ";


                    HttpContext.Current.Session["Cart"] = cart;
                }
                else
                    MessageLbl.Text = "One of the Quantities must be more than 0. Otherwise, click Exit.";
            }
            else
            {
                if(bookTB.Text != "" && dvdTB.Text == "")
                {
                    Product selectedBook = ProductList[bookDDL.SelectedIndex];
                    EditCart(int.Parse(bookTB.Text), selectedBook);
                    confrimMessage.Text = selectedBook.Title + " has been added ";

                }
                else if (dvdTB.Text != "" && bookTB.Text == "")
                {
                    Product selectedDVD = ProductList[dvdDDL.SelectedIndex + 5];
                    EditCart(int.Parse(dvdTB.Text), selectedDVD);
                    confrimMessage.Text = selectedDVD.Title + " has been added ";

                }
                else if(dvdTB.Text != "" && bookTB.Text != "")
                {
                    Product selectedBook = ProductList[bookDDL.SelectedIndex];
                    Product selectedDVD = ProductList[dvdDDL.SelectedIndex + 5];

                    EditCart(int.Parse(bookTB.Text), selectedBook);
                    EditCart(int.Parse(dvdTB.Text), selectedDVD);

                    MessageLbl.Text = selectedBook.Title + " and " + selectedDVD.Title + " have been added ";

                }
                else
                    MessageLbl.Text = "One of the Quantities must be mroe than 0. Otherwise, click Exit.";
            }
        }

        public void EditCart(int quantity, Product obj)
        {
            CartObject addedItem = new CartObject(quantity, obj);
            List<CartObject> revisedCart = new List<CartObject>();
            revisedCart = (List<CartObject>)Session["Cart"];
            revisedCart.Add(addedItem);
            HttpContext.Current.Session["Cart"] = revisedCart;
        }

        protected void checkoutButton_Click(object sender, EventArgs e)
        {
            if (Session["Cart"] == null)
            {
                MessageLbl.Text = "One of the Quantities must be mroe than 0. Otherwise, click Exit.";
            }
            else
            {
                Server.Transfer("Checkout.aspx");
            }
        }

        protected void exitButton_Click(object sender, EventArgs e)
        {
            Server.Transfer("ExitPage.aspx");
        }
    }
}