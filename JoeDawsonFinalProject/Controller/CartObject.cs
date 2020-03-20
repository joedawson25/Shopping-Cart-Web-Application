using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoeDawsonFinalProject.Controller
{
    public class CartObject
    {
        int _quantity;
        Product _obj;

        public CartObject(int quantity, Product prod)
        {
            Quantity = quantity;
            OBJ = prod;
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public Product OBJ
        {
            get
            {
                return _obj;
            }
            set
            {
                _obj = value;
            }
        }
            
    }
}