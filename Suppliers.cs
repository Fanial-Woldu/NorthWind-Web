namespace NorthWindProject2024.Models
{
    //Apaloo, Jacques-Philipp
    public class Supplier
    {

        private int supplierId = -1;
        private string companyName = "n/a";
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";
        private string homePage = "n/a";

        public int SupplierId
        {
            get { return this.supplierId; }
            set { this.supplierId = value; }
        }

        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        public string ContactName
        {
            get { return this.contactName; }
            set { this.contactName = value; }
        }
        public string ContactTitle
        {
            get { return this.contactTitle; }
            set { this.contactTitle = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }

        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public string Fax
        {
            get { return this.fax; }
            set { this.fax = value; }
        }

        public string HomePage
        {
            get { return this.homePage; }
            set { this.homePage = value; }
        }
        // Empty constructor
        public Supplier()
        {
        }

        // Full constructor
        public Supplier(int supplierId, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax, string homePage)
        {
            this.supplierId = supplierId;
            this.companyName = companyName;
            this.contactName = contactName;
            this.contactTitle = contactTitle;
            this.address = address;
            this.city = city;
            this.region = region;
            this.postalCode = postalCode;
            this.country = country;
            this.phone = phone;
            this.fax = fax;
            this.homePage = homePage;
        }

/*        public override string ToString()
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
