using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practice
{
    public interface IPaymentMethod
    {
        public void Ode(double Tutar);
    }



    public class NakitOdeme : IPaymentMethod
    {
        public void Ode(double Tutar)
        {
            Console.WriteLine("Nakit ile ödendi: " + Tutar + "TL");
        }
    }



    public class KartOdeme : IPaymentMethod
    {
        public void Ode(double Tutar)
        {
            Console.WriteLine("Kredi kartı ile ödendi: " + Tutar + "TL");
        }
    }






    public class QrKodlaOdeme : IPaymentMethod
    {
        public void Ode(double Tutar)
        {
            Console.WriteLine("QR kodla ödendi: " + Tutar + "TL");
        }
    }
}

