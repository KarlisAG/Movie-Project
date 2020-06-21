using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using MySql.Data.MySqlClient;

namespace Project_Movie
{

    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;

        public DBConnection()
        {
            server = "127.0.0.1";
            database = "movies";
            user = "root";
            password = "Students!Programme";
            port = "3306";
            sslM = "Required";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; " +
                "SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
        }

        public DataTable GetMovies()
        {
            String stm = "SELECT * FROM watchList";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = new MySqlCommand(stm, connection);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;

        }

        public bool AddMovie(String title, String type, String year, String length, String rating, String rated, String genre, String ImdbID)
        {
            if (FilterMovie(ImdbID))
            {
                return true;
            }
            else
            {
                MySqlConnection connection = null;
                try
                {
                    connection = new MySqlConnection(connectionString);
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO watchList (movieTitle, movieType, movieYear, movieLength, movieRating, movieRated, movieGenre, userID, movieImdbID) " +
                                      "VALUES(@movieTitle, @movieType, @movieYear, @movieLength, @movieRating, @movieRated, @movieGenre, @userID, @movieImdbID)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@movieTitle", title);
                    cmd.Parameters.AddWithValue("@movieType", type);
                    cmd.Parameters.AddWithValue("@movieYear", year);
                    cmd.Parameters.AddWithValue("@movieLength", length);
                    cmd.Parameters.AddWithValue("@movieRating", rating);
                    cmd.Parameters.AddWithValue("@movieRated", rated);
                    cmd.Parameters.AddWithValue("@movieGenre", genre);

                    cmd.Parameters.AddWithValue("@movieImdbID", ImdbID);
                    cmd.Parameters.AddWithValue("@userID", 1);
                    cmd.ExecuteNonQuery();

                    return false;

                }
                finally
                {
                    if (connection != null)
                        connection.Close();
                }
            }
        }

        public void DeleteMovie(String title)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                cmd.CommandText = $"DELETE FROM watchList WHERE movieTitle = @movieTitle;";
                cmd.Parameters.AddWithValue("@movieTitle", title);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private bool FilterMovie(String ImdbID)//parbauda vai jau tads eksiste
        {
            MySqlConnection connection = null;
            MySqlDataReader myReader;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                DataTable table = new DataTable();
                myCommand.CommandText = $"SELECT * FROM watchList WHERE movieImdbID = @movieParam;";
                myCommand.Parameters.AddWithValue("@movieParam", ImdbID);
                myReader = myCommand.ExecuteReader();
                table.Load(myReader);

                if (table.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            
        }

        public DataTable FilterMovie(String parameter, String text)
        {
            MySqlConnection connection = null;
            MySqlDataReader myReader;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                DataTable table = new DataTable();
                myCommand.CommandText = $"SELECT * FROM watchList WHERE movie{parameter} = @movieParam;";
                //myCommand.Parameters.AddWithValue("@movieParameter", $"movie{parameter}");
                myCommand.Parameters.AddWithValue("@movieParam", text);
                myReader = myCommand.ExecuteReader();
                table.Load(myReader);

                return table;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}