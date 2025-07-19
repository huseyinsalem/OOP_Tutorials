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




            Console.Read();
        }
    }
}
