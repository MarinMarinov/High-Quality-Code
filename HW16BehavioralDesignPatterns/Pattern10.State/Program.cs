using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern10.State
{
    class Program
    {
        static void Main()
        {
            Player forrest = new Player("Forrest Gump");
            forrest.Show();
            forrest.Run();

            forrest.DrinkAlcohol(10);
            forrest.Run();

            forrest.EatSpinach(40);
            forrest.Run();

            forrest.EatSpinach(40);

            forrest.EatSpinach(100);
            forrest.Run();
        }
    }
}
