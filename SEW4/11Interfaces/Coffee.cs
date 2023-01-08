using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Interfaces
{
    internal class Coffee : IHotDrink, IHasCaffeine
    {
        public string Type { get; set; }
        public float Caffeine { get; set; }
        public  Coffee (string type)
        {
            Type = type;
            Degree = 90;
            Caffeine = 100;
        }
        public int Degree { get; set; }

        public void cool()
        {
            Degree -= 1;
        }

        public override string ToString()
        {
            return "Coffee: " + Type;
        }
    }
}
