using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1IArticle
{
    internal interface IArticle
    {
        public double Price { get; set; }
        public string Description { get; set; }
    }

}
