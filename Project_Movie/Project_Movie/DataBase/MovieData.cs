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
        public String Genre;
        public String Actors;
        public String Type;
        public String Country;
        public String Production;
        public String Rated;
        public String Runtime;
        public String Writer;
        public String Plot;
        public String ImdbID;
        public String ImdbRating;
        public String ImdbVotes;
        public String Poster;

        public List<Ratings> Ratings;

        public MovieData(String Response, String error, String Title, String Year, String Metascore, String Genre, String Actors, String Type, String Country, String Production, String Rated, String Runtime, String Writer, String Plot, String ImdbID, String ImdbRating, String ImdbVotes, String Poster)
        {
            this.Response = Response;
            this.error = error;
            this.Title = Title;
            this.Year = Year;
            this.Metascore = Metascore;
            this.Genre = Genre;
            this.Actors = Actors;
            this.Type = Type;
            this.Country = Country;
            this.Production = Production;
            this.Rated = Rated;
            this.Runtime = Runtime;
            this.Writer = Writer;
            this.Plot = Plot;
            this.ImdbID = ImdbID;
            this.ImdbRating = ImdbRating;
            this.ImdbVotes = ImdbVotes;
            this.Poster = Poster;
        }

    }
}
