using System;

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
