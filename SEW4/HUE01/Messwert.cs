using System;
using System.Collections.Generic;
using System.Text;

namespace HUE01
{
    class Messwert
    {
        private List<string> mwList = new List<string>();

        public Messwert()
        {

        }
        public List<string> MWList
        {
            get { return mwList; }
            set { mwList = value; }
        }
    }
}
