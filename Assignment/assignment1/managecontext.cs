using assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class DataContext
    {
        private static DataContext _instance;
        public List<Customers> Customer { get; set; }
        public List<Products> Product { get; set; }
        public List<Orders> Order { get; set; }
        public List<Order_Details> OrderDetail { get; set; }
        public List<Employees> Employee { get; set; }
        public List<Categories> Category { get; set; }

        private DataContext()
        {
            // Initialize in-memory collections with sample data
            Customer = new List<Customers>
            {
                new Customers { CustomerID = 1, CompanyName = "ABC ", ContactName = "Andies", ContactTitle = "Manager", Address = "123 PHU NHUAN", Phone = "1234567890" },
                // Add more sample data
            };
            Product = new List<Products>
            {
                new Products { ProductID = 2, ProductName = "Laptop", CategoryID = 2, UnitPrice = 9999, UnitsInStock = 50 },
                // Add more sample data
            };
            Order = new List<Orders>();
            OrderDetail = new List<Order_Details>();
            Employee = new List<Employees>
            {
                new Employees { EmployeeID = 3, Name = "van A", UserName = "abc", Password = "admin", JobTitle = "job" },
                // Add more sample data
            };
            Category = new List<Categories>
            {
                new Categories { CategoryID = 4, CategoryName = "oil", Description =  "oliu" },
                // Add more sample data
            };
        }

        public static DataContext Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataContext();
                return _instance;
            }
        }
    }
}