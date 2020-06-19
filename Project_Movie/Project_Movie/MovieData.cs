using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Movie
{
    class MovieData
    {
        public String Response;
        public String error;

        public MovieData(String Response, String error)
        {
            this.Response = Response;
            this.error = error;
        }

    }
}
