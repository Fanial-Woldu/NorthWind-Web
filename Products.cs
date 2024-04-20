using System;
using System.Collections.Generic;

namespace NorthWindProject2024.Models
{
    //Apaloo, Jacques-Philipp
    public class Product
    {

        private int productId = -1;
        private string productName = "n/a";
        private int supplierId = -1;
        private int categoryId = -1;
        private double unitPrice = Double.MaxValue;
        private int unitsinstock = -1;
        private int unitsonorder = -1;
        private int reorderlevel = -1;
        private double discounted = Double.MaxValue;


        public  int ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }

        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }

        public int SupplierId
        {
            get { return this.supplierId; }
            set { this.supplierId = value; }
        }

        public int CategoryId
        {
            get { return this.categoryId; }
            set { this.categoryId = value; }
        }

        public double UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        public int UnitsInStock
        {
            get { return this.unitsinstock; }
            set { this.unitsinstock = value; }
        }
        public int UnitsOnOrder
        {
            get { return this.unitsonorder; }
            set { this.unitsonorder = value; }
        }

        public int ReorderLevel
        {
            get { return this.reorderlevel; }
            set { this.reorderlevel = value; }
        }

        public double Discounted
        {
            get { return this.discounted; }
            set { this.discounted = value; }
        }




        //constructoers

        public Product()
        {
            //empty constructer, because it has no perameters
            //it may have a lot of code
        }

        public Product(int aProductId, string aProductName, int aSupplierId, int aCategoryId, double aUnitPrice, int aUnitsInStock, int aUnitsOnOrder, 
            int aReorderLevel, double aDiscounted)
        {
            this.ProductId = aProductId;
            this.ProductName = aProductName;
            this.SupplierId = aSupplierId;
            this.CategoryId = aCategoryId;
            this.UnitPrice = aUnitPrice;
            this.unitsinstock = aUnitsInStock;
            this.unitsonorder = aUnitsOnOrder;
            this.reorderlevel= aReorderLevel;
            this.discounted = aDiscounted;
        }
        /*
        public override string ToString()
        {
            string message = "";
            message = message + "ProductId" + this.ProductId + "<br />";
            message = message + "Product Name" + this.ProductName + "<br />";
            message = message + "Supplier ID" + this.SupplierId + "<br />";
            message = message + "CategoryId" + this.CategoryId + "<br />";
            message = message + "Unite Price" + this.UnitPrice + "<br />";
            message = message + "Units In Stock" + this.unitsinstock + "<br />";
            message = message + "Reorder Level" + this.reorderlevel + "<br />";
            message = message + "Discounted" + this.discounted + "<br />";
            return message;

        }*/

    }
}
