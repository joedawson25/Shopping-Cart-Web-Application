using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JoeDawsonFinalProject.Controller;

namespace JoeDawsonFinalProject.Models
{
    public class BuildProducts
    {
        

        public BuildProducts()
        {
            List<Product> prod = new List<Product>();

            Product book1 = new Product("Book", 101, "Big Data: A Revolution That Will Transform How We Live, Work, and Think", 50.55);
            Product book2 = new Product("Book", 102, "Disruptive Possibilities: How Big Data Changes Everything", 65.67);
            Product book3 = new Product("Book", 103, "Data Smart: using Data Science to Transform Information into Insight", 32.78);
            Product book4 = new Product("Book", 104, "Big Data: Principles and best practices of scalagle realtime data systems",90.65 );
            Product book5 = new Product("Book", 105, "Big Data Science and Analytics: A Hands-On Approach", 15.25);
            Product dvd1 = new Product("DVD", 201, "The Grand Tour Season 1", 10.00);
            Product dvd2 = new Product("DVD", 202, "Spectre", 11.99);
            Product dvd3 = new Product("DVD", 203, "Goliath Season 1", 12.99);
            Product dvd4 = new Product("DVD", 204, "The Hunger Games: Mockingjay Part 2", 10.99);
            Product dvd5 = new Product("DVD", 205, "Good Girls Revolt", 11.99);

            prod.Add(book1);
            prod.Add(book2);
            prod.Add(book3);
            prod.Add(book4);
            prod.Add(book5);
            prod.Add(dvd1);
            prod.Add(dvd2);
            prod.Add(dvd3);
            prod.Add(dvd4);
            prod.Add(dvd5);

            HttpContext.Current.Session["AllProducts"] = prod;
        }
    }
}