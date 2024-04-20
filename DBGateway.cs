using Microsoft.Data.Sqlite;
using NorthWindProject2024.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//using WebSiteClass2024.Models;

namespace SQLTest
{
    internal class DBGateway
    {

        public List<Product> GetProducts()
        {
            List<Product> listOfProducts = new List<Product>();
            Product aProduct;
                          
            long productId = 0;
            string productName = "n/a";
            long supplierId = 0;
            long categoryId = 0;
            double unitPrice = 999999.99;

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\DATABASES\\Northwind.db");

            //first open connection
            connection.Open();
            //now create a command
            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "select productid, productname, supplierid, categoryid, unitprice from products;";

            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // local variable name = (cast) reader ["database column name"]

                //the conversions are because the C# data types do not match the 
                //SQLite datatypes, they are from different companies

                productId = (long)reader["productId"];
                productName = (string)reader["productName"];
                supplierId = (long)reader["supplierId"];
                categoryId = (long)reader["categoryId"];
                unitPrice = Convert.ToDouble(reader["unitPrice"]);
                /*
                //print out the results 
                Console.WriteLine("ProductId: " + productId);
                Console.WriteLine("productName: " + productName);
                Console.WriteLine("supplierId: " + supplierId);
                Console.WriteLine("categoryId: " + categoryId);
                Console.WriteLine("unitPrice: " + unitPrice);
                Console.WriteLine("\n\n");
                */
                aProduct = new Product();

                aProduct.ProductId = Convert.ToInt32(productId);
                aProduct.ProductName = productName;
                aProduct.SupplierId = Convert.ToInt32(supplierId);
                aProduct.CategoryId = Convert.ToInt32(categoryId);
                aProduct.UnitPrice = unitPrice;

                listOfProducts.Add(aProduct);





            }

            connection.Close();

            return listOfProducts;


        }

        public List<Product> GetProductsById(int aProductId)
        {
            List<Product> listOfProducts = new List<Product>();
            Product aProduct;

            long productId = 0;
            string productName = "n/a";
            long supplierId = 0;
            long categoryId = 0;
            double unitPrice = 999999.99;

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\DATABASES\\Northwind.db");

            //first open connection
            connection.Open();
            //now create a command
            SqliteCommand command = connection.CreateCommand();

            command.Parameters.Add("@productid", SqliteType.Integer).Value = aProductId;

            //third, set up our SAL statment
            //an evil hacker 

            command.CommandText = "select productid, productname, supplierid, categoryid, unitprice from products where productid = " + aProductId + ";";


            //we could go even further and make this whole thing a stored preseger
            //where the database would do anouther check to make sure there was no sql injwction

            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // local variable name = (cast) reader ["database column name"]

                //the conversions are because the C# data types do not match the 
                //SQLite datatypes, they are from different companies

                productId = (long)reader["productId"];
                productName = (string)reader["productName"];
                supplierId = (long)reader["supplierId"];
                categoryId = (long)reader["categoryId"];
                unitPrice = Convert.ToDouble(reader["unitPrice"]);
                /*
                //print out the results 
                Console.WriteLine("ProductId: " + productId);
                Console.WriteLine("productName: " + productName);
                Console.WriteLine("supplierId: " + supplierId);
                Console.WriteLine("categoryId: " + categoryId);
                Console.WriteLine("unitPrice: " + unitPrice);
                Console.WriteLine("\n\n");
                */
                aProduct = new Product();

                aProduct.ProductId = Convert.ToInt32(productId);
                aProduct.ProductName = productName;
                aProduct.SupplierId = Convert.ToInt32(supplierId);
                aProduct.CategoryId = Convert.ToInt32(categoryId);
                aProduct.UnitPrice = unitPrice;

                listOfProducts.Add(aProduct);





            }

            connection.Close();

            return listOfProducts;


        }

        //#################################################################################################################################

        //Woldu, Fanial K
        public List<Categories> GetCategories()
        {
            List<Categories> listOfCategories = new List<Categories>();

            long categoryId = 0;
            string categoryName = "N/A";
            string description = "N/A";


            // Establish the SQLite connection
            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\fania\\OneDrive\\Documents\\SQLLite\\Northwind.db");

            // Open the connection
            connection.Open();

            // Create the command to select category information
            SqliteCommand command = connection.CreateCommand();

            // Set up the SQL statement
            command.CommandText = "SELECT categoryid, categoryname, description FROM categories";

            // Execute the SQL statement and retrieve the data
            SqliteDataReader reader = command.ExecuteReader();

            // Iterate through the data reader
            while (reader.Read())
            {
                // Read the values from the data reader
                categoryId = (long)reader["categoryid"];
                categoryName = (string)reader["categoryname"];
                description = (string)reader["description"];


                // Create a new Category object and add it to the list
                Categories aCategory = new Categories();


                aCategory.CategoryId = Convert.ToInt32(categoryId);
                aCategory.CategoryName = categoryName;
                aCategory.Description = description;



                listOfCategories.Add(aCategory);
            }




            // Close the connection
            connection.Close();

            // Return the list of categories
            return listOfCategories;
        }

        //################################################################################################
        //Logan Krupa
        public List<Employee> GetEmployees()
        {
            List<Employee> listOfEmployees = new List<Employee>();
            Employee aEmployee;


            long employeeId = -1;
            string lastName = "n/a";
            string firstName = "n/a";
            string title = "n/a";
            string titleOfCourtesy = "n/a";
            string birthDate;
            string hireDate;
            string address = "n/a";
            string city = "n/a";
            //string region = "n/a";
            string postalCode = "n/a";
            string country = "n/a";
            string homePhone = "n/a";
            string extension = "n/a";
            //string photo = "n/a";
            string notes = "n/a";
            //string reportsTo = "n/a";


            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\fania\\OneDrive\\Documents\\SQLLite\\Northwind.db");

            //first open connection
            connection.Open();
            //now create a command
            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "select employeeId, lastName, firstName, title, titleOfCourtesy, birthDate, hireDate, address, city, region, postalCode, country, homePhone, extension, notes, reportsTo from employees;";

            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // local variable name = (cast) reader ["database column name"]

                //the conversions are because the C# data types do not match the 
                //SQLite datatypes, they are from different companies

                employeeId = (long)reader["employeeId"];
                lastName = (string)reader["lastName"];
                firstName = (string)reader["firstName"];
                title = (string)reader["title"];
                titleOfCourtesy = (string)reader["titleOfCourtesy"];
                birthDate = (string)reader["birthDate"];
                hireDate = (string)reader["hireDate"];
                address = (string)reader["address"];
                city = (string)reader["city"];
                //region = (string)reader["region"];
                postalCode = (string)reader["postalCode"];
                country = (string)reader["country"];
                homePhone = (string)reader["homePhone"];
                extension = (string)reader["extension"];
                //photo
                notes = (string)reader["notes"];
                //reportsTo = (string)reader["reportsTo"];

                aEmployee = new Employee();

                aEmployee.EmployeeId = Convert.ToInt32(employeeId);
                aEmployee.LastName = lastName;
                aEmployee.FirstName = firstName;
                aEmployee.Title = title;
                aEmployee.TitleOfCourtesy = titleOfCourtesy;
                aEmployee.BirthDate = birthDate;
                aEmployee.HireDate = hireDate;
                aEmployee.Address = address;
                aEmployee.City = city;
                //aEmployee.Region = region;
                aEmployee.PostalCode = postalCode;
                aEmployee.Country = country;
                aEmployee.HomePhone = homePhone;
                aEmployee.Extension = extension;
                aEmployee.Notes = notes;
                //aEmployee.ReportsTo = reportsTo;


                listOfEmployees.Add(aEmployee);






            }

            connection.Close();

            return listOfEmployees;


        }

        //#################################################################################################################################
        //Logan Krupa

        public List<Order> GetOrders()
        {
            List<Order> listOfOrders = new List<Order>();
            Order aOrder;


            long orderId = -1;
            string customerId = "n/a";
            long employeeId = -1;
            string orderDate = "n/a";
            string requiredDate = "n/a";
            string shippedDate = "n/a";
            long shipVia = -1;
            double freight = -1;
            string shipName = "n/a";
            string shipAddress = "n/a";
            string shipCity = "n/a";
            string shipRegion = "n/a";
            string shipPostalCode = "n/a";
            string shipCountry = "n/a";


            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\fania\\OneDrive\\Documents\\SQLLite\\Northwind.db");

            //first open connection
            connection.Open();
            //now create a command
            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "select orderId, customerId, employeeId, orderDate, requiredDate, shippedDate, shipVia, freight, shipName, shipAddress, shipCity, shipRegion, shipPostalCode, shipCountry from orders;";

            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // local variable name = (cast) reader ["database column name"]

                //the conversions are because the C# data types do not match the 
                //SQLite datatypes, they are from different companies

                orderId = (long)reader["orderId"];
                customerId = (string)reader["customerId"];
                employeeId = (long)reader["employeeId"];
                orderDate = (string)reader["orderDate"];
                requiredDate = (string)reader["requiredDate"];
                shippedDate = Convert.ToString(reader["shippedDate"]);
                shipVia = (long)reader["shipVia"];
                freight = Convert.ToDouble(reader["freight"]);
                shipName = (string)reader["shipName"];
                shipAddress = (string)reader["shipAddress"];
                shipCity = (string)reader["shipCity"];
                shipRegion = Convert.ToString(reader["shipRegion"]);
                shipPostalCode = Convert.ToString(reader["shipPostalCode"]);
                shipCountry = (string)reader["shipCountry"];

                aOrder = new Order();

                aOrder.OrderId = Convert.ToInt32(orderId);
                aOrder.CustomerId = customerId;
                aOrder.EmployeeId = Convert.ToInt32(employeeId);
                aOrder.OrderDate = orderDate;
                aOrder.RequiredDate = requiredDate;
                aOrder.ShippedDate = shippedDate;
                aOrder.ShipVia = Convert.ToInt32(shipVia);
                aOrder.Freight = freight;
                aOrder.ShipName = shipName;
                aOrder.ShipAddress = shipAddress;
                aOrder.ShipCity = shipCity;
                aOrder.ShipRegion = shipRegion;
                aOrder.ShipPostalCode = shipPostalCode;
                aOrder.ShipCountry = shipCountry;


                listOfOrders.Add(aOrder);

                //Console.WriteLine("Hello World!2");




            }

            connection.Close();

            return listOfOrders;


        }

        //#################################################################################################################################
        //Logan Krupa

        public List<Customer> GetCustomers()
        {
            List<Customer> listOfCustomers = new List<Customer>();
            Customer aCustomer;


            string customerId = "n/a";
            string companyName = "n/a";
            string contactName = "n/a";
            string contactTitle = "n/a";
            string address = "n/a";
            string city = "n/a";
            string region = "n/a";
            string postalCode = "n/a";
            string country = "n/a";
            string phone = "n/a";
            string fax = "n/a";


            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\fania\\OneDrive\\Documents\\SQLLite\\Northwind.db");

            //first open connection
            connection.Open();
            //now create a command
            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "select customerId, companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax from customers;";

            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // local variable name = (cast) reader ["database column name"]

                //the conversions are because the C# data types do not match the 
                //SQLite datatypes, they are from different companies

                customerId = (string)reader["customerId"];
                companyName = (string)reader["companyName"];
                contactName = (string)reader["contactName"];
                contactTitle = (string)reader["contactTitle"];
                address = (string)reader["address"];
                city = (string)reader["city"];
                region = Convert.ToString(reader["region"]);
                postalCode = Convert.ToString(reader["postalCode"]);
                country = (string)reader["country"];
                phone = (string)reader["phone"];
                fax = Convert.ToString(reader["fax"]);


                aCustomer = new Customer();


                aCustomer.CustomerId = customerId;
                aCustomer.CompanyName = companyName;
                aCustomer.ContactName = contactName;
                aCustomer.ContactTitle = contactTitle;
                aCustomer.Address = address;
                aCustomer.City = city;
                aCustomer.Region = region;
                aCustomer.PostalCode = postalCode;
                aCustomer.Country = country;
                aCustomer.Phone = phone;
                aCustomer.Fax = fax;



                listOfCustomers.Add(aCustomer);

                //Console.WriteLine("Hello World!2");




            }

            connection.Close();

            return listOfCustomers;
        }


        //#################################################################################################################################
        //Woldu, Fanial K
        public List<OrderDetails> GetOrderDetails()
        {
            List<OrderDetails> listOfOrderDetails = new List<OrderDetails>();

            long orderId = 0;
            long productId = 0;
            double unitPrice = 0.0;
            long quantity = 0;
            double discount = 0.0;



            // Create a new SQLite connection
            SqliteConnection connection = new SqliteConnection("Data Source=C:\\DATABASES\\Northwind.db");

            // Open the connection
            connection.Open();

            // Create a SQL command to retrieve order details
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT orderid, productid, unitprice, quantity, discount FROM [order details];";

            // Execute the command and read the results
            SqliteDataReader reader = command.ExecuteReader();

            // Iterate through the results and populate the listOfOrderDetails
            while (reader.Read())
            {


                orderId = (long)reader["orderid"];
                productId = (long)reader["productid"];
                unitPrice = Convert.ToDouble(reader["unitprice"]);
                quantity = (long)reader["quantity"];
                discount = Convert.ToDouble(reader["discount"]);


                OrderDetails aOrderDetail = new OrderDetails(0, 0, 0.0, 0, 0.0);


                aOrderDetail.OrderId = Convert.ToInt32(orderId);
                aOrderDetail.ProductId = Convert.ToInt32(productId);
                aOrderDetail.UnitPrice = unitPrice;
                aOrderDetail.Quantity = Convert.ToInt32(quantity);
                aOrderDetail.Discount = discount;

                listOfOrderDetails.Add(aOrderDetail);
            }

            // Close the connection
            connection.Close();

            return listOfOrderDetails;
        }

        //#################################################################################################################################

        //#################################################################################################################################
        //Logan Krupa

        public List<Supplier> GetSuppliers()
        {
            List<Supplier> listOfSuppliers = new List<Supplier>();
            Supplier aSupplier;

            long supplierId = -1;
            string companeyName = "n/a";
            string contactName = "n/a";
            string contactTtile = "n/a";
            string address = "n/a";
            string city = "n/a";
            string region = "n/a";
            string postalCode = "n/a";
            string country = "n/a";
            string phone = "n/a";
            string fax = "n/a";
            string homePage = "n/a";


            SqliteConnection connection = new SqliteConnection("Data Source=C:\\DATABASES\\Northwind.db");

            //first open connection
            connection.Open();
            //now create a command
            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "select supplierId, companyName, contactName, contactTitle, address, city, region, postalCode, country, phone, fax, homePage from suppliers;";

            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // local variable name = (cast) reader ["database column name"]

                //the conversions are because the C# data types do not match the 
                //SQLite datatypes, they are from different companies



                supplierId = (long)reader["supplierId"];

                companeyName = (string)reader["companyName"];
                contactName = (string)reader["contactName"];
                contactTtile = (string)reader["contactTitle"];
                address = (string)reader["address"];
                city = (string)reader["city"];
                //region = (string)reader["region"];
                postalCode = (string)reader["postalCode"];
                country = (string)reader["country"];
                phone = (string)reader["phone"];
                //fax = (string)reader["fax"];
                //homePage = (string)reader["homePage"];


                aSupplier = new Supplier();


                aSupplier.SupplierId = Convert.ToInt32(supplierId);
                aSupplier.CompanyName = companeyName;
                aSupplier.ContactName = contactName;
                aSupplier.ContactTitle = contactTtile;
                aSupplier.Address = address;
                aSupplier.City = city;
                aSupplier.Region = region;
                aSupplier.PostalCode = postalCode;
                aSupplier.Country = country;
                aSupplier.Phone = phone;
                aSupplier.Fax = fax;
                aSupplier.HomePage = homePage;  



                listOfSuppliers.Add(aSupplier);

                //Console.WriteLine("Hello World!2");




            }

            connection.Close();

            return listOfSuppliers;
        }

        //#################################################################################################################################


        public List<Shipper> GetShippers()
        {
            List<Shipper> listOfShippers = new List<Shipper>();
            Shipper aShipper;

            long shipperId = -1;
            string companyName = "n/a";
            string phone = "n/a";


            SqliteConnection connection = new SqliteConnection("Data Source=C:\\DATABASES\\Northwind.db");

            //first open connection
            connection.Open();
            //now create a command
            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "select shipperId, companyName, phone from shippers;";

            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // local variable name = (cast) reader ["database column name"]

                //the conversions are because the C# data types do not match the 
                //SQLite datatypes, they are from different companies

                shipperId = (long)reader["shipperId"];
                companyName = (string)reader["companyName"];
                phone = (string)reader["phone"];



                aShipper = new Shipper();

                aShipper.ShipperId = Convert.ToInt32(shipperId);
                aShipper.CompanyName = companyName;
                aShipper.Phone = phone;





                listOfShippers.Add(aShipper);

                //Console.WriteLine("Hello World!2");




            }

            connection.Close();

            return listOfShippers;
        }



        //#################################################################################################################################
        /*
        public  List<Categories> insertTest(string aName, string aDesc)
        {

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\DATABASES\\Northwind.db");

            //first open connection
            connection.Open();
            //now create a command
            SqliteCommand command = connection.CreateCommand();



            command.CommandText = "insert into categoeies(categoryName, descrition)values(@catname, @desc);";
            command.Parameters.Add("@catname", SqliteType.Text).Value = aName;
            command.Parameters.Add("@desc", SqliteType.Text).Value = aDesc;

            command.ExecuteNonQuery();

            List<Product> listOfproducts = this.GetProducts();

            return listOfproducts;
        }
        */
        //#################################################################################################################################

        public List<Product> InsertAProduct(string aProductName, int aSupplierId, int aCategoryId, double aUnitPrice) 
        {

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\DATABASES\\Northwind.db");

            //first open connection
            connection.Open();
            //now create a command
            SqliteCommand command = connection.CreateCommand();

            //third, set up our sql statment
            command.CommandText = "insert into products(productname, supplierid, categoryid, unitprice)values(@ProductName, @SupplierId, @CategoryId, @UnitPrice);";

            //command.Parameters.Add("@productName", SqliteType.Text).Value = aProductId;
            command.Parameters.Add("@ProductName", SqliteType.Text).Value = aProductName;
            command.Parameters.Add("@SupplierId", SqliteType.Text).Value = aSupplierId;
            command.Parameters.Add("@CategoryId", SqliteType.Text).Value = aCategoryId;
            command.Parameters.Add("@UnitPrice",SqliteType.Text).Value = aUnitPrice;

            command.ExecuteNonQuery();

            List<Product> listOfproducts = this.GetProducts();

            return listOfproducts;
        }

        public List<Product> UpdateAProduct(int aProductId, string aProductName, int aSupplierId, int aCategoryId, double aUnitPrice) {



            SqliteConnection connection = new SqliteConnection("Data Source=C:\\DATABASES\\Northwind.db");

            //first open connection
            connection.Open();
            //now create a command
            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "update Products set productname = @ProductName, supplierid = @SupplierId, categoryid = @CategoryId, unitprice = @UnitPrice where productid = @ProductId;";
            command.Parameters.Add("@ProductId", SqliteType.Integer).Value = aProductId;

            command.Parameters.Add("@ProductName", SqliteType.Text).Value = aProductName;
            command.Parameters.Add("@SupplierId", SqliteType.Text).Value = aSupplierId;
            command.Parameters.Add("@CategoryId", SqliteType.Text).Value = aCategoryId;
            command.Parameters.Add("@UnitPrice", SqliteType.Text).Value = aUnitPrice;

            command.ExecuteNonQuery();

            List<Product> listOfproducts = this.GetProducts();

            return listOfproducts;


        }

        //#################################################################################################################################
        //Logan Krupa

        

        public List<Order> GetOrdersById(int aOrderId)

        {

            List<Order> listOfOrders = new List<Order>();

            Order aOrder;


            long orderId = -1;

            string customerId = "n/a";

            long employeeId = -1;

            string orderDate = "n/a";

            string requiredDate = "n/a";

            string shippedDate = "n/a";

            long shipVia = -1;

            double freight = -1;

            string shipName = "n/a";

            string shipAddress = "n/a";

            string shipCity = "n/a";

            string shipRegion = "n/a";

            string shipPostalCode = "n/a";

            string shipCountry = "n/a";


            SqliteConnection connection = new SqliteConnection("Data Source=C:\\DATABASES\\Northwind.db");

            //first open connection

            connection.Open();

            //now create a command

            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "select orderId, customerId, employeeId, orderDate, requiredDate, shippedDate, shipVia, freight, shipName, shipAddress, shipCity, shipRegion, shipPostalCode, shipCountry from orders where orderId = " + aOrderId + ";";

            SqliteDataReader reader = command.ExecuteReader();


            while (reader.Read())

            {

                // local variable name = (cast) reader ["database column name"]

                //the conversions are because the C# data types do not match the 

                //SQLite datatypes, they are from different companies

                orderId = (long)reader["orderId"];

                customerId = (string)reader["customerId"];

                employeeId = (long)reader["employeeId"];

                orderDate = Convert.ToString(reader["orderDate"]);

                requiredDate = Convert.ToString(reader["requiredDate"]);

                shippedDate = Convert.ToString(reader["shippedDate"]);

                shipVia = (long)reader["shipVia"];

                freight = Convert.ToDouble(reader["freight"]);

                shipName = (string)reader["shipName"];

                shipAddress = (string)reader["shipAddress"];

                shipCity = (string)reader["shipCity"];

                shipRegion = Convert.ToString(reader["shipRegion"]);

                shipPostalCode = Convert.ToString(reader["shipPostalCode"]);

                shipCountry = (string)reader["shipCountry"];

                aOrder = new Order();

                aOrder.OrderId = Convert.ToInt32(orderId);

                aOrder.CustomerId = customerId;

                aOrder.EmployeeId = Convert.ToInt32(employeeId);

                aOrder.OrderDate = orderDate;

                aOrder.RequiredDate = requiredDate;

                aOrder.ShippedDate = shippedDate;

                aOrder.ShipVia = Convert.ToInt32(shipVia);

                aOrder.Freight = freight;

                aOrder.ShipName = shipName;

                aOrder.ShipAddress = shipAddress;

                aOrder.ShipCity = shipCity;

                aOrder.ShipRegion = shipRegion;

                aOrder.ShipPostalCode = shipPostalCode;

                aOrder.ShipCountry = shipCountry;


                listOfOrders.Add(aOrder);



            }

            connection.Close();

            return listOfOrders;


        }
        

        public List<Employee> GetEmployeesById(int aEmployeeId)

        {

            List<Employee> listOfEmployees = new List<Employee>();

            Employee aEmployee;


            long employeeId = -1;

            string lastName = "n/a";

            string firstName = "n/a";

            string title = "n/a";

            string titleOfCourtesy = "n/a";

            string birthDate;

            string hireDate;

            string address = "n/a";

            string city = "n/a";

            string region = "n/a";

            string postalCode = "n/a";

            string country = "n/a";

            string homePhone = "n/a";

            string extension = "n/a";

            //string photo = "n/a";

            string notes = "n/a";

            string reportsTo = "n/a";


            SqliteConnection connection = new SqliteConnection("Data Source=C:\\DATABASES\\Northwind.db");

            //first open connection

            connection.Open();

            //now create a command

            SqliteCommand command = connection.CreateCommand();

            command.CommandText = "select employeeId, lastName, firstName, title, titleOfCourtesy, birthDate, hireDate, address, city, region, postalCode, country, homePhone, extension, notes, reportsTo from employees where employeeId =" + aEmployeeId + ";";

            string output = command.CommandText.ToString();

            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())

            {

                // local variable name = (cast) reader ["database column name"]

                //the conversions are because the C# data types do not match the 

                //SQLite datatypes, they are from different companies

                employeeId = (long)reader["employeeId"];

                lastName = (string)reader["lastName"];

                firstName = (string)reader["firstName"];

                title = (string)reader["title"];

                titleOfCourtesy = (string)reader["titleOfCourtesy"];

                birthDate = (string)reader["birthDate"];

                hireDate = (string)reader["hireDate"];

                address = (string)reader["address"];

                city = (string)reader["city"];

                region = Convert.ToString(reader["region"]);

                postalCode = (string)reader["postalCode"];

                country = (string)reader["country"];

                homePhone = (string)reader["homePhone"];

                extension = (string)reader["extension"];

                //photo

                notes = (string)reader["notes"];

                reportsTo = Convert.ToString(reader["reportsTo"]);

                aEmployee = new Employee();

                aEmployee.EmployeeId = Convert.ToInt32(employeeId);

                aEmployee.LastName = lastName;

                aEmployee.FirstName = firstName;

                aEmployee.Title = title;

                aEmployee.TitleOfCourtesy = titleOfCourtesy;

                aEmployee.BirthDate = birthDate;

                aEmployee.HireDate = hireDate;

                aEmployee.Address = address;

                aEmployee.City = city;

                aEmployee.Region = region;

                aEmployee.PostalCode = postalCode;

                aEmployee.Country = country;

                aEmployee.HomePhone = homePhone;

                aEmployee.Extension = extension;

                aEmployee.Notes = notes;

                aEmployee.ReportsTo = reportsTo;


                listOfEmployees.Add(aEmployee);




            }

            connection.Close();

            return listOfEmployees;


        }
        


        public List<Order> InsertAOrder(string aCustomerId, string aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, string aShipVia, string aFreight, string aShipName, string aShipAddress, string aShipCity, string aShipRegion, string aShipPostalCode, string aShipCountry)

        {

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\DATABASES\\Northwind.db");

            //first open connection

            connection.Open();

            //now create a command

            SqliteCommand command = connection.CreateCommand();


            command.CommandText = "insert into orders(customerId, employeeId, orderDate, requiredDate, shippedDate, shipVia, freight, shipName, shipAddress, shipCity, shipRegion, shipPostalCode, shipCountry)values(@CustomerId, @EmployeeId, @OrderDate, @RequiredDate, @ShippedDate, @ShipVia, @Freight, @ShipName, @ShipAddress, @ShipCity, @ShipRegion, @ShipPostalCode, @ShipCountry);";

            command.Parameters.Add("@CustomerId", SqliteType.Text).Value = aCustomerId;

            command.Parameters.Add("@EmployeeId", SqliteType.Integer).Value = aEmployeeId;

            command.Parameters.Add("@OrderDate", SqliteType.Text).Value = aOrderDate;

            command.Parameters.Add("@RequiredDate", SqliteType.Text).Value = aRequiredDate;

            command.Parameters.Add("@ShippedDate", SqliteType.Text).Value = aShippedDate;

            command.Parameters.Add("@ShipVia", SqliteType.Integer).Value = aShipVia;

            command.Parameters.Add("@Freight", SqliteType.Text).Value = aFreight;

            command.Parameters.Add("@ShipName", SqliteType.Text).Value = aShipName;

            command.Parameters.Add("@ShipAddress", SqliteType.Text).Value = aShipAddress;

            command.Parameters.Add("@ShipCity", SqliteType.Text).Value = aShipCity;

            command.Parameters.Add("@ShipRegion", SqliteType.Text).Value = aShipRegion;

            command.Parameters.Add("@ShipPostalCode", SqliteType.Text).Value = aShipPostalCode;

            command.Parameters.Add("@ShipCountry", SqliteType.Text).Value = aShipCountry;

            command.ExecuteNonQuery();

            List<Order> ListOfOrders = this.GetOrders();

            return ListOfOrders;

        }


        public List<Order> UpdateAOrder(int aOrderId, string aCustomerId, string aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, string aShipVia, string aFreight, string aShipName, string aShipAddress, string aShipCity, string aShipRegion, string aShipPostalCode, string aShipCountry)

        {


            SqliteConnection connection = new SqliteConnection("Data Source=C:\\DATABASES\\Northwind.db");

            //first open connection

            connection.Open();

            //now create a command

            SqliteCommand command = connection.CreateCommand();


            command.CommandText = "update orders set customerId = @CustomerId, employeeId = @EmployeeId, orderDate = @OrderDate, requiredDate = @RequiredDate, shippedDate = @ShippedDate, shipVia = @ShipVia, freight = @Freight, shipName = @ShipName, shipAddress = @ShipAddress, shipCity = @ShipCity, shipRegion = @ShipRegion, shipPostalCode =  @ShipPostalCode, shipCountry = @ShipCountry where orderId = @OrderId;";

            command.Parameters.Add("@OrderId", SqliteType.Integer).Value = aOrderId;

            command.Parameters.Add("@CustomerId", SqliteType.Text).Value = aCustomerId;

            command.Parameters.Add("@EmployeeId", SqliteType.Text).Value = aEmployeeId;

            command.Parameters.Add("@OrderDate", SqliteType.Text).Value = aOrderDate;

            command.Parameters.Add("@RequiredDate", SqliteType.Text).Value = aRequiredDate;

            command.Parameters.Add("@ShippedDate", SqliteType.Text).Value = aShippedDate;

            command.Parameters.Add("@ShipVia", SqliteType.Text).Value = aShipVia;

            command.Parameters.Add("@Freight", SqliteType.Text).Value = aFreight;

            command.Parameters.Add("@ShipName", SqliteType.Text).Value = aShipName;

            command.Parameters.Add("@ShipAddress", SqliteType.Text).Value = aShipAddress;

            command.Parameters.Add("@ShipCity", SqliteType.Text).Value = aShipCity;

            command.Parameters.Add("@ShipRegion", SqliteType.Text).Value = aShipRegion;

            command.Parameters.Add("@ShipPostalCode", SqliteType.Text).Value = aShipPostalCode;

            command.Parameters.Add("@ShipCountry", SqliteType.Text).Value = aShipCountry;


            command.ExecuteNonQuery();

            List<Order> ListOfOrders = this.GetOrders();

            return ListOfOrders;

        }

        

        //#################################################################################################################################

        //#################################################################################################################################

        //Logan Krupa

        public List<Employee> InsertAEmployee(string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aNotes, string aReportsTo)

        {

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\DATABASES\\Northwind.db");

            //first open connection

            connection.Open();

            //now create a command

            SqliteCommand command = connection.CreateCommand();



            command.CommandText = "insert into employees(lastName, firstName, title, TitleOfCourtesy, birthDate, hireDate, address, city, region, postalCode, country, homePhone, extension, notes, reportsTo)values(@LastName, @FirstName, @Title, @TitleOfCourtesy, @BirthDate, @HireDate, @Address, @City, @Region, @PostalCode, @Country, @HomePhone, @Extension, @Notes, @ReportsTo);";

            command.Parameters.Add("@LastName", SqliteType.Text).Value = aLastName;

            command.Parameters.Add("@FirstName", SqliteType.Text).Value = aFirstName;

            command.Parameters.Add("@Title", SqliteType.Text).Value = aTitle;

            command.Parameters.Add("@TitleOfCourtesy", SqliteType.Text).Value = aTitleOfCourtesy;

            command.Parameters.Add("@BirthDate", SqliteType.Text).Value = aBirthDate;

            command.Parameters.Add("@HireDate", SqliteType.Text).Value = aHireDate;

            command.Parameters.Add("@Address", SqliteType.Text).Value = aAddress;

            command.Parameters.Add("@City", SqliteType.Text).Value = aCity;

            command.Parameters.Add("@Region", SqliteType.Text).Value = aRegion;

            command.Parameters.Add("@PostalCode", SqliteType.Text).Value = aPostalCode;

            command.Parameters.Add("@Country", SqliteType.Text).Value = aCountry;

            command.Parameters.Add("@HomePhone", SqliteType.Text).Value = aHomePhone;

            command.Parameters.Add("@Extension", SqliteType.Text).Value = aExtension;

            command.Parameters.Add("@Notes", SqliteType.Text).Value = aNotes;

            command.Parameters.Add("@ReportsTo", SqliteType.Text).Value = aReportsTo;

            command.ExecuteNonQuery();

            List<Employee> ListOfEmployees = this.GetEmployees();

            return ListOfEmployees;




        }


        public List<Employee> UpdateAEmployee(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aNotes, string aReportsTo)

        {

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\DATABASES\\Northwind.db");

            //first open connection

            connection.Open();

            //now create a command

            SqliteCommand command = connection.CreateCommand();



            command.CommandText = "update employees set lastName = @LastName, firstName = @FirstName, title = @Title, titleOfCourtesy = @TitleOfCourtesy, birthDate = @BirthDate, hireDate = @HireDate, address = @Address, city = @City, region = @Region, postalCode = @PostalCode, country = @Country, homePhone = @HomePhone, extension = @Extension, notes = @Notes, reportsTo = @ReportsTo where employeeId = @EmployeeId;";

            command.Parameters.Add("@EmployeeId", SqliteType.Text).Value = aEmployeeId;

            command.Parameters.Add("@LastName", SqliteType.Text).Value = aLastName;

            command.Parameters.Add("@FirstName", SqliteType.Text).Value = aFirstName;

            command.Parameters.Add("@Title", SqliteType.Text).Value = aTitle;

            command.Parameters.Add("@TitleOfCourtesy", SqliteType.Text).Value = aTitleOfCourtesy;

            command.Parameters.Add("@BirthDate", SqliteType.Text).Value = aBirthDate;

            command.Parameters.Add("@HireDate", SqliteType.Text).Value = aHireDate;

            command.Parameters.Add("@Address", SqliteType.Text).Value = aAddress;

            command.Parameters.Add("@City", SqliteType.Text).Value = aCity;

            command.Parameters.Add("@Region", SqliteType.Text).Value = aRegion;

            command.Parameters.Add("@PostalCode", SqliteType.Text).Value = aPostalCode;

            command.Parameters.Add("@Country", SqliteType.Text).Value = aCountry;

            command.Parameters.Add("@HomePhone", SqliteType.Text).Value = aHomePhone;

            command.Parameters.Add("@Extension", SqliteType.Text).Value = aExtension;

            command.Parameters.Add("@Notes", SqliteType.Text).Value = aNotes;

            command.Parameters.Add("@ReportsTo", SqliteType.Text).Value = aReportsTo;

            //string output = command.CommandText.ToString();


            command.ExecuteNonQuery();

            List<Employee> ListOfEmployees = this.GetEmployees();

            return ListOfEmployees;




        }

        //#################################################################################################################################
        //#################################################################################################################################



        //Fanial W. - InsertAnOrderDetail
        public List<OrderDetails> InsertAnOrderDetail(int aOrderId, int aProductId, double aUnitPrice, int aQuantity, double aDiscount)
        {

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\fania\\OneDrive\\Documents\\SQLLite\\Northwind.db");

            // First try to open the connection
            connection.Open();

            // Second create a command
            SqliteCommand command = connection.CreateCommand();

            // Third, set up our SQL statement
            command.CommandText = "insert into [order details](orderid, productid, unitprice, quantity, discount) values" +
                "(@orderid, @productid, @unitprice, @quantity, @discount);";




            command.Parameters.Add("@orderid", SqliteType.Integer).Value = aOrderId;
            command.Parameters.Add("@productid", SqliteType.Integer).Value = aProductId;
            command.Parameters.Add("@unitprice", SqliteType.Real).Value = aUnitPrice;
            command.Parameters.Add("@quantity", SqliteType.Integer).Value = aQuantity;
            command.Parameters.Add("@discount", SqliteType.Real).Value = aDiscount;


            // Forth run the sql statement
            command.ExecuteNonQuery();

            // Then I return the new List after the insertion
            List<OrderDetails> listOfOrderDetails = this.GetOrderDetails();

            return listOfOrderDetails;


        }




        //Fanial W. - UpdateAnOrderDetail

        public List<OrderDetails> UpdateAnOrderDetail(int aOrderId, int aProductId, double aUnitPrice, int aQuantity, double aDiscount)
        {

            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\fania\\OneDrive\\Documents\\SQLLite\\Northwind.db");

            // First try to open the connection
            connection.Open();

            // Second create a command
            SqliteCommand command = connection.CreateCommand();

            // Third, set up our SQL statement

            command.CommandText = "update [order details] " +
                "set unitPrice=@unitprice, " +
                "quantity = @quantity, " +
                "discount = @discount " +
                "where orderid = @orderid and productid = @productid;";


            command.Parameters.Add("@orderid", SqliteType.Integer).Value = aOrderId;
            command.Parameters.Add("@productid", SqliteType.Integer).Value = aProductId;
            command.Parameters.Add("@unitprice", SqliteType.Real).Value = aUnitPrice;
            command.Parameters.Add("@quantity", SqliteType.Integer).Value = aQuantity;
            command.Parameters.Add("@discount", SqliteType.Real).Value = aDiscount;


            // Forth run the sql statement
            command.ExecuteNonQuery();

            // Then I return the new List after the insertion
            List<OrderDetails> listOfOrderDetails = this.GetOrderDetails();

            return listOfOrderDetails;



        }

        //Fanial W - GetOrderDetailById
        public List<OrderDetails> GetOrderDetailById(int aOrderId, int aProductId)
        {
            List<OrderDetails> listOfOrderDetails = new List<OrderDetails>();

            long orderId = 0;
            long productId = 0;
            double unitPrice = 0.0;
            long quantity = 0;
            double discount = 0.0;



            // Create a new SQLite connection
            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\fania\\OneDrive\\Documents\\SQLLite\\Northwind.db");

            // Open the connection
            connection.Open();

            // Create a SQL command to retrieve order details
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = "select unitprice, quantity, discount from [order details] where orderid = '" + aOrderId + "' and productid = '" + aProductId +  "' ;";

            // Execute the command and read the results
            SqliteDataReader reader = command.ExecuteReader();

            // Iterate through the results and populate the listOfOrderDetails
            while (reader.Read())
            {


                orderId = (long)reader["orderid"];
                productId = (long)reader["productid"];
                unitPrice = Convert.ToDouble(reader["unitprice"]);
                quantity = (long)reader["quantity"];
                discount = Convert.ToDouble(reader["discount"]);


                OrderDetails aOrderDetail = new OrderDetails(0, 0, 0.0, 0, 0.0);


                aOrderDetail.OrderId = Convert.ToInt32(orderId);
                aOrderDetail.ProductId = Convert.ToInt32(productId);
                aOrderDetail.UnitPrice = unitPrice;
                aOrderDetail.Quantity = Convert.ToInt32(quantity);
                aOrderDetail.Discount = discount;

                listOfOrderDetails.Add(aOrderDetail);
            }

            // Close the connection
            connection.Close();

            return listOfOrderDetails;
        }


        //Fanial W - InsertACustomer
        public List<Customer> InsertACustomer(string aCustomerId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax)
        {


            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\fania\\OneDrive\\Documents\\SQLLite\\Northwind.db");

            // First try to open the connection
            connection.Open();

            // Second create a command
            SqliteCommand command = connection.CreateCommand();

            // Third, set up our SQL statement
            command.CommandText = "insert into customers(customerid, companyname, contactname, contacttitle, address, city, region, postalcode, country, phone, fax) " +
                "values(@customerid, @companyname, @contactname, @contacttitle, @address, @city, @region, @postalcode, @country, @phone, @fax);";




            command.Parameters.Add("@customerid", SqliteType.Text).Value = aCustomerId;
            command.Parameters.Add("@companyname", SqliteType.Text).Value = aCompanyName;
            command.Parameters.Add("@contactname", SqliteType.Text).Value = aContactName;
            command.Parameters.Add("@contacttitle", SqliteType.Text).Value = aContactTitle;
            command.Parameters.Add("@address", SqliteType.Text).Value = aAddress;
            command.Parameters.Add("@city", SqliteType.Text).Value = aCity;
            command.Parameters.Add("@region", SqliteType.Text).Value = aRegion;
            command.Parameters.Add("@postalcode", SqliteType.Text).Value = aPostalCode;
            command.Parameters.Add("@country", SqliteType.Text).Value = aCountry;
            command.Parameters.Add("@phone", SqliteType.Text).Value = aPhone;
            command.Parameters.Add("@fax", SqliteType.Text).Value = aFax;


            // Forth run the sql statement
            command.ExecuteNonQuery();

            // Then I return the new List after the insertion
            List<Customer> listOfCustomers = this.GetCustomers();



            return listOfCustomers;

        }


        //Fanial W - UpdateACustomer
        public List<Customer> UpdateACustomer(string aCustomerId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax)
        {


            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\fania\\OneDrive\\Documents\\SQLLite\\Northwind.db");

            // First try to open the connection
            connection.Open();

            // Second create a command
            SqliteCommand command = connection.CreateCommand();

            // Third, set up our SQL statement
            command.CommandText = "update customers " +
                "set companyname=@companyname, " +
                "contactname = @contactname, " +
                "contacttitle = @contacttitle, " +
                "address=@address, " +
                "city=@city, " +
                "region=@region, " +
                "postalcode=@postalcode, " +
                "country=@country, " +
                "phone=@phone, " +
                "fax = @fax " +
                "where customerid = @customerid;";



            command.Parameters.Add("@customerid", SqliteType.Text).Value = aCustomerId;
            command.Parameters.Add("@companyname", SqliteType.Text).Value = aCompanyName;
            command.Parameters.Add("@contactname", SqliteType.Text).Value = aContactName;
            command.Parameters.Add("@contacttitle", SqliteType.Text).Value = aContactTitle;
            command.Parameters.Add("@address", SqliteType.Text).Value = aAddress;
            command.Parameters.Add("@city", SqliteType.Text).Value = aCity;
            command.Parameters.Add("@region", SqliteType.Text).Value = aRegion;
            command.Parameters.Add("@postalcode", SqliteType.Text).Value = aPostalCode;
            command.Parameters.Add("@country", SqliteType.Text).Value = aCountry;
            command.Parameters.Add("@phone", SqliteType.Text).Value = aPhone;
            command.Parameters.Add("@fax", SqliteType.Text).Value = aFax;
            


            // Forth run the sql statement
            command.ExecuteNonQuery();

            // Then I return the new List after the insertion
            List<Customer> listOfCustomers = this.GetCustomers();

            return listOfCustomers;

        }



        //Fanial W - GetCustomerById
        public List<Customer> GetCustomerById(string aCustomerId) {



            List<Customer> listOfCustomers = new List<Customer>();
            Customer aCustomer;


            string customerId = "n/a";
            string companyName = "n/a";
            string contactName = "n/a";
            string contactTitle = "n/a";
            string address = "n/a";
            string city = "n/a";
            string region = "n/a";
            string postalCode = "n/a";
            string country = "n/a";
            string phone = "n/a";
            string fax = "n/a";



            SqliteConnection connection = new SqliteConnection("Data Source=C:\\Users\\fania\\OneDrive\\Documents\\SQLLite\\Northwind.db");

            // First try to open the connection
            connection.Open();

            // Second create a command
            SqliteCommand command = connection.CreateCommand();

           

            //third, set up our SAL statment
            //an evil hacker 

            command.CommandText = "select customerid, companyname, contactname, contacttitle, address, city, region, postalcode, country, phone, fax from customers where customerid = '" + aCustomerId + "';";


            SqliteDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                // local variable name = (cast) reader ["database column name"]

                //the conversions are because the C# data types do not match the 
                //SQLite datatypes, they are from different companies

                customerId = (string)reader["customerid"];
                companyName = (string)reader["companyname"];
                contactName = (string)reader["contactname"];
                contactTitle = (string)reader["contacttitle"];
                address = (string)reader["address"];
                city = (string)reader["city"];
                region = (string)reader["region"];
                postalCode = (string)reader["postalcode"];
                country = (string)reader["country"];
                phone = (string)reader["phone"];
                fax = (string)reader["fax"];


                aCustomer = new Customer();


                aCustomer.CustomerId = customerId;
                aCustomer.CompanyName = companyName;
                aCustomer.ContactName = contactName;
                aCustomer.ContactTitle = contactTitle;
                aCustomer.Address = address;
                aCustomer.City = city;
                aCustomer.Region = region;
                aCustomer.PostalCode = postalCode;
                aCustomer.Country = country;
                aCustomer.Phone = phone;
                aCustomer.Fax = fax;



                listOfCustomers.Add(aCustomer);

                //Console.WriteLine("Hello World!2");




            }

            connection.Close();

            return listOfCustomers;




        }





        //connection.Close();

    }
}
