using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tutorials
{
    internal class ApplicationManager
    {
        public void BasvuruYap(ICreditManager creditManager)
        {
            creditManager.Hesapla();

        }
    }
}
