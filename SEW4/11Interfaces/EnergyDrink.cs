using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Interfaces
{
    internal class EnergyDrink : IHasCaffeine
    {
        public string Name { get; set; }
        public float Caffeine { get; set; }

        public EnergyDrink(string name)
        {
            Name = name;
            Caffeine = 250;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
