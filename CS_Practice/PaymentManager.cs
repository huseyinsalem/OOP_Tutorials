using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practice
{
    public class PaymentManager
    {
        public void OdemeYap(IPaymentMethod paymentMethod , double Tutar)
        {
            paymentMethod.Ode(Tutar);
        }
    }
}
