using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tutorials
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region class ve metotlar
            Product product1 = new Product
            {
                Id = 1,
                CategoryId = 2,
                ProductName = "Table",
                UnitPrice = 500,
                UnitsInStock = 4,
            };
            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 3,
                ProductName = "Chair",
                UnitPrice = 800,
                UnitsInStock = 6,
            };



            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            #endregion



            #region List

            Console.WriteLine("-----------");



            List<string> Name =new List<string> {"Hüseyin","Hasan","Handan","Ali" };
            Console.WriteLine(Name[0]);
            Console.WriteLine(Name[1]);
            Console.WriteLine(Name[2]);
            Console.WriteLine(Name[3]);

            Name.Add("Neşe");
            Console.WriteLine(Name[4]);
            Console.WriteLine(Name[0]);

            #endregion


            #region Customer

            Customer customer1 = new IndividualCustomer 
            {
                Id = 1,
                CustomerNo = "134567890",
                Name = "Hüseyin",
                Surname ="Şalem",
               
            };
            Customer customer2 = new CorporateCustomer
            {
                Id = 2,
                CustomerNo = "9876543210",
                FirmName = "Csharp",
                TaxNo = "?",
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(customer1);
           
            Console.WriteLine(customer1.CustomerNo);

            #endregion




            Console.Read();
        }
    }
}
