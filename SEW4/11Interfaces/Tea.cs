using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Interfaces
{
    internal class Tea : IHotDrink
    {
        public string Flavour { get; set; }

        public Tea (string flavour)
        {
            Flavour = flavour;
            Degree = 100;
        }
        public int Degree { get; set; }

        public void cool()
        {
            Degree -= 1;
        }

        public override string ToString()
        {
            return "Tea: " + Flavour;
        }
    }
}
