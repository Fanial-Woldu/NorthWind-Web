namespace NorthWindProject2024.Models
{
    //Woldu, Fanial K
    public class Categories
    {
        private int categoryId = -1;
        private string categoryName = "N/A";
        private string description = "N/A";
        private string picture = "N/A";

        public int CategoryId
        {
            get { return this.categoryId; }
            set { this.categoryId = value; }
        }

        public string CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public string Picture
        {
            get { return this.picture; }
            set { this.picture = value; }
        }

        public Categories()
        {

        }

        public Categories(int categoryId, string categoryName, string description, string picture)
        {
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
            this.Description = description;
            this.Picture = picture;
        }
    }
}
