using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1.Fasade
{
    class Program
    {
        static void Main()
        {
            // Fasade fs = new Fasade(); // classic way with public Fasade class constructor

            Fasade fs = Fasade.CreateInstance(); // hiding Fasade instance creation, using Simple Factory pattern

            fs.GeneralUserFunctionA();
            fs.GeneralUserFunctionB();
        }
    }
}
