namespace NorthWindProject2024.Models
{
    //Code Writen By Logan Krupa
    public class Employee
    {
        private int employeeId = -1;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private string birthDate; 
        private string hireDate;
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string homePhone = "n/a";
        private string extension = "n/a";
        private string photo = "n/a";
        private string notes = "n/a";
        private string reportsTo = "n/a";
       
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string TitleOfCourtesy
        {
            get { return titleOfCourtesy; }
            set { titleOfCourtesy = value; }
        }
        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        public string HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Region
        {
            get { return region; }
            set { region = value; }
        }
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string HomePhone
        {
            get { return homePhone; }
            set { homePhone = value; }
        }
        public string Extension
        {
            get { return extension; }
            set { extension = value; }
        }
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
        public string ReportsTo
        {
            get { return reportsTo; }
            set { reportsTo = value; }
        }

        public Employee()
        {

        }

        public Employee(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aPhoto, string aNotes, string aReportsTo)
        {
            this.EmployeeId = aEmployeeId;
            this.LastName = aLastName;
            this.FirstName = aFirstName;
            this.Title = aTitle;
            this.TitleOfCourtesy = aTitleOfCourtesy;
            this.BirthDate = aBirthDate;
            this.HireDate = aHireDate;
            this.Address = aAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.HomePhone = aHomePhone;
            this.Extension = aExtension;
            this.Photo = aPhoto;
            this.Notes = aNotes;
            this.ReportsTo = aReportsTo;

        }

        public override string ToString()
        {
            string msg = "";
            msg = msg + "EmployeeId" + this.EmployeeId + "<br />";
            msg = msg + "LastName" + this.LastName + "<br />";
            msg = msg + "FirstName" + this.FirstName + "<br />";
            msg = msg + "Title" + this.Title + "<br />";
            msg = msg + "TitleOfCoutesy" + this.TitleOfCourtesy + "<br />";
            msg = msg + "BirthDate" + this.BirthDate + "<br />";
            msg = msg + "HireDate" + this.HireDate + "<br />";
            msg = msg + "Address" + this.Address + "<br />";
            msg = msg + "City" + this.City + "<br />";
            msg = msg + "Regoin" + this.Region + "<br />";
            msg = msg + "PostalCode" + this.PostalCode + "<br />";
            msg = msg + "Country" + this.Country + "<br />";
            msg = msg + "HomePhone" + this.HomePhone + "<br />";
            msg = msg + "Exension" + this.Extension + "<br />";
            msg = msg + "Photo" + this.Photo + "<br />";
            msg = msg + "Notes" + this.Notes + "<br />";
            msg = msg + "ReportsTo" + this.ReportsTo + "<br />";
            return msg;
        }


    }

}
