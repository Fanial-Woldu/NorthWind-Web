namespace NorthWindProject2024.Models
{
    //Apaloo, Jacques-Philipp
    public class Shipper
    {

        private int shipperId = -1;
        private string companyName = "n/a";
        private string phone = "n/a";
   


        public  int ShipperId
        {
            get { return this.shipperId; }
            set { this.shipperId = value; }
        }

        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }


        //constructoers

        public Shipper()
        {
        }

        // Full constructor
        public Shipper(int aShipperId, string aCompanyName, string aPhone)
        {
            this.shipperId = aShipperId;
            this.companyName = aCompanyName;
            this.phone = aPhone;
        }
        public override string ToString()
        {
            string message = "";
            message = message + "Shipper ID" + this.shipperId + "<br />";
            message = message + "Company Name" + this.companyName + "<br />";
            message = message + "Phone" + this.phone + "<br />";
            return message;

        }

    }
}
