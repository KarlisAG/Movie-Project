using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Movie
{
    class Ratings
    {
        public String Source;
        public String Value;

        public Ratings(String Source, String Value)
        {
            this.Source = Source;
            this.Value = Value;
        }
    }
}
