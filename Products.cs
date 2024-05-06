using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace NorthWindProject2024.Models
{
    //Apaloo, Jacques-Philipp
    public class Product
    {

        private int productId = -1;
        private string productName = "n/a";
        private int supplierId = -1;
        private int categoryId = -1;
        private string quantityPerUnit = "n/a";
        private double unitPrice = Double.MaxValue;
        private string unitsinstock = "n/a";
        private string unitsonorder = "n/a";
        private string reorderlevel = "n/a";
        private string discontinued = "n/a";


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

        public string QuantityPerUnit
        {
            get { return this.quantityPerUnit; }
            set { this.quantityPerUnit = value;}
        }

        public double UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        public string UnitsInStock
        {
            get { return this.unitsinstock; }
            set { this.unitsinstock = value; }
        }
        public string UnitsOnOrder
        {
            get { return this.unitsonorder; }
            set { this.unitsonorder = value; }
        }

        public string ReorderLevel
        {
            get { return this.reorderlevel; }
            set { this.reorderlevel = value; }
        }

        public string Discontinued
        {
            get { return this.discontinued; }
            set { this.discontinued = value; }
        }




        //constructoers

        public Product()
        {
            //empty constructer, because it has no perameters
            //it may have a lot of code
        }

        public Product(int aProductId, string aProductName, int aSupplierId, int aCategoryId, string aQuantityPerUnit, double aUnitPrice, string aUnitsInStock, string aUnitsOnOrder,
            string aReorderLevel, string aDiscontinued)
        {
            this.ProductId = aProductId;
            this.ProductName = aProductName;
            this.SupplierId = aSupplierId;
            this.CategoryId = aCategoryId;
            this.QuantityPerUnit = aQuantityPerUnit;
            this.UnitPrice = aUnitPrice;
            this.unitsinstock = aUnitsInStock;
            this.unitsonorder = aUnitsOnOrder;
            this.reorderlevel= aReorderLevel;
            this.discontinued = aDiscontinued;
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
