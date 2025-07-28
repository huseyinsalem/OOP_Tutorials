using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practice
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerNo { get; set; }
    }


    public class GercekCustomer:Customer 
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Tc { get; set; }
    }


    public class TüzelCustomer:Customer
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
