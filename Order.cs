namespace NorthWindProject2024.Models
{
    //Code Writen By Logan Krupa
    public class Order
    {
        private int orderId = -1;
        private string customerId = "n/a";
        private int employeeId = -1;
        private string orderDate = "n/a";
        private string requiredDate = "n/a";
        private string shippedDate = "n/a";
        private int shipVia = -1;
        private Double freight = -1;
        private string shipName = "n/a";
        private string shipAddress = "n/a";
        private string shipCity = "n/a";
        private string shipRegion = "n/a";
        private string shipPostalCode = "n/a";
        private string shipCountry = "n/a";

        public int OrderId 
        {
            get { return orderId; } 
            set { orderId = value; } 
        } 

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public string RequiredDate
        {
            get { return requiredDate; }
            set { requiredDate = value; }
        }

        public string ShippedDate
        {
            get { return shippedDate; }
            set { shippedDate = value; }
        }

        public int ShipVia
        {
            get { return shipVia; }
            set { shipVia = value; }
        }

        public Double Freight
        {
            get { return freight; }
            set { freight = value; }
        }

        public string ShipName
        {
            get { return shipName; }
            set { shipName = value; }
        }

        public string ShipAddress
        {
            get { return shipAddress; }
            set { shipAddress = value; }
        }

        public string ShipCity
        {
            get { return shipCity; }
            set { shipCity = value; }
        }

        public string ShipRegion
        {
            get { return shipRegion; }
            set { shipRegion = value; }
        }
        public string ShipPostalCode
        {
            get { return shipPostalCode; }
            set { shipPostalCode = value; }
        }

        public string ShipCountry
        {
            get { return shipCountry; }
            set { shipCountry = value; }
        }


        public Order()
        {



        }


        public Order(int aOrderId, string aCustormerId, int aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, int aShipVia, Double aFreight, string aShipName, string aShipAddress, string aShipCity, string aShipRegion, string aShipPostalCode, string aShipCountry)
        {
            this.OrderId = aOrderId;
            this.CustomerId = aCustormerId;
            this.EmployeeId = aEmployeeId;
            this.OrderDate = aOrderDate;
            this.RequiredDate = aRequiredDate;
            this.ShippedDate = aShippedDate;
            this.ShipVia = aShipVia;
            this.Freight = aFreight;
            this.ShipName = aShipName;
            this.ShipAddress = aShipAddress;
            this.ShipCity = aShipCity;
            this.ShipRegion = aShipRegion;
            this.ShipPostalCode = aShipPostalCode;
            this.ShipCountry = aShipCountry;

        }
        /*
        public override string ToString()
        {
            string msg = "";
            msg = msg + "OrderId" + this.OrderId + "<br />"; 
            msg = msg + "CustomerId" + this.CustomerId;
            msg = msg + "EmployeeId" + this.EmployeeId + "<br />";
            msg = msg + "OrderDate" + this.OrderDate + "<br />";
            msg = msg + "RequireDate" + this.RequiredDate + "<br />";
            msg = msg + "ShippedDate" + this.ShippedDate + "<br />";
            msg = msg + "ShipVia" + this.ShipVia + "<br />";
            msg = msg + "Freigth" + this.Freight + "<br />";
            msg = msg + "ShipName" + this.ShipName + "<br />";
            msg = msg + "ShipAddress" + this.ShipAddress + "<br />";
            msg = msg + "ShipCity" + this.ShipCity + "<br />";
            msg = msg + "ShipRegion" + this.ShipRegion + "<br />";
            msg = msg + "ShipPostalCode" + this.ShipPostalCode + "<br />";
            msg = msg + "ShipCountry" + this.ShipCountry + "<br />";
            return msg;

            
        }*/


    }
}
