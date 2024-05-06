namespace NorthWindProject2024.Models
{
    //Ogedegbe, Ovo
    public class Customer
    {
        private string customerId = "N/A";
        private string companyName = "N/A";
        private string contactName = "N/A";
        private string contactTitle = "N/A";
        private string address = "N/A";
        private string city = "N/A";
        private string region = "N/A";
        private string postalCode = "N/A";
        private string country = "N/A";
        private string phone = "N/A";
        private string fax = "N/A";

        public string CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }
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


        // Constructor
        public Customer()
        {

        }

        public Customer(string customerId, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax)
        {
            this.CustomerId = customerId;
            this.CompanyName = companyName;
            this.ContactName = contactName;
            this.ContactTitle = contactTitle;
            this.Address = address;
            this.City = city;
            this.Region = region;
            this.PostalCode = postalCode;
            this.Country = country;
            this.Phone = phone;
            this.Fax = fax;
        }
        /*
        public override string ToString()
        {
            string message = "";
            message = message + "Customer Id" + this.CustomerId + "<br />";
            message = message + "Company Name" + this.CompanyName + "<br />";
            message = message + "Contact Name" + this.ContactName + "<br />";
            message = message + "Contact Title" + this.ContactTitle + "<br />";
            message = message + "Address" + this.Address + "<br />";
            message = message + "City" + this.City + "<br />";
            message = message + "Region" + this.Region + "<br />";
            message = message + "Postal Code" + this.PostalCode + "<br />";
            message = message + "Country" + this.Country + "<br />";
            message = message + "Phone" + this.Phone + "<br />";
            message = message + "Fax" + this.Fax + "<br />";
            return message;
        }*/
    }
}
