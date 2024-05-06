namespace NorthWindProject2024.Models
{
    ////Woldu, Fanial K
    public class OrderDetails
    {
        private int orderId = -1;
        private int productId = -1;
        private double unitPrice = Double.MaxValue;
        private int quantity = -1;
        private double discount = 0.0;

        public int OrderId
        {
            get { return this.orderId; }
            set { this.orderId = value; }
        }

        public int ProductId
        {
            get { return this.productId; }
            set { this.productId = value; }
        }

        public double UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public double Discount
        {
            get { return this.discount; }
            set { this.discount = value; }
        }


        //Constructor
        public OrderDetails(int orderId, int productId, double unitPrice, int quantity, double discount)
        {
            this.OrderId = orderId;
            this.ProductId = productId;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
            this.Discount = discount;
        }
    }
}
