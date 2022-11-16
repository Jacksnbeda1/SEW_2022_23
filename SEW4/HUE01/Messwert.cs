using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace HUE01
{
    internal class Messwert
    {
        private float messwert;
        private DateTime time;

        public Messwert(float messwert, DateTime time)
        {
            this.messwert = messwert;
            this.time = time;
        }

        public float Messwert1
        {
            get { return messwert; }
            set { this.messwert = value; }
            
        }
        
        
    }
}
