using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoeDawsonFinalProject.Controller
{
    public class Product
    {
        string _type;
        int _productID;
        string _title;
        double _price;

        public Product (string type, int ID, string title, double price)
        {
            _type = type;
            _productID = ID;
            _title = title;
            _price = price;
        }

        public string ProductType
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public int ProductID
        {
            get
            {
                return _productID;
            }
            set
            {
                _productID = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public double DiscountPercentage(int quantity)
        {
            if(quantity < 2)
            {
                return 0;
            }
            else if (quantity >=2 && quantity <=4)
            {
                return .02;
            }
            else
            {
                return .05;
            }
        }


    }
}