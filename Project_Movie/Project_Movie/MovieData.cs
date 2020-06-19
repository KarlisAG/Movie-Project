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

        public String Title;
        public String Year;
        public String Metascore;
        public String Rated;
        public String Genre;
        public String Actors;
        public String Type;
        public String Country;
        public String Production;
        public String Runtime;
        public String Writer;
        public String Plot;
        public String ImdbID;
        public String ImdbRating;
        public String ImdbVotes;
        public String Poster;

        public List<Ratings> Ratings;

        public MovieData(String Response, String error)
        {
            this.Response = Response;
            this.error = error;
        }

    }
}
