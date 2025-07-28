namespace CS_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Urun1 = new Product {Id = 1, Name = "Ekmek", Price = 15.50, Explanation = "Taze Ekmek"};
            Product Urun2 = new Product {Id = 2, Name = "Süt", Price = 55.89, Explanation = "1 lt Süt" };


            GercekCustomer gercekCustomer = new GercekCustomer
            {
                 Id = 1,
                 Name = "Hüseyin",
                 SurName = "Şalem",
                 Tc = "12345678904",
                 CustomerNo = "11111111111"
            };

            CartManager cart = new CartManager();
            cart.Add(Urun1);
            cart.Add(Urun2);



            double ToplamTutar = Urun1.Price + Urun2.Price;
            Console.WriteLine("Toplam Tutar: " + ToplamTutar + "TL" );



            IPaymentMethod paymentMethod = new KartOdeme();



           



            PaymentManager paymentManager = new PaymentManager();
            paymentManager.OdemeYap(paymentMethod, ToplamTutar);

            Console.WriteLine();

            Console.WriteLine("Ödeme tamamlan'dı iyi günler dileriz");


            
            Console.Read();

        }
    }
}
