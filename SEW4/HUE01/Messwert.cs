using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace HUE01
{
    internal class Messwert
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
        public float mw()
        {
            float f = 0;
            foreach(string number in mwList)
            {
                f += float.Parse(number);

            }
            mwList.Clear();
            return f / 150;
        }
    }
}
