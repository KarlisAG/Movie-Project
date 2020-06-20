using System;
using System.Collections.Generic;
using System.Data;
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

        public void AddMovie(String title, String type, String year, String length, String rating, String rated, String genre)
        {
            MySqlConnection connection = null;//nedrikst duplikatus pievienot!!!!
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO watchList (movieTitle, movieType, movieYear, movieLength, movieRating, movieRated, movieGenre, userID) " +
                                  "VALUES(@movieTitle, @movieType, @movieYear, @movieLength, @movieRating, @movieRated, @movieGenre, @userID)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@movieTitle", $"{title}");
                cmd.Parameters.AddWithValue("@movieType", $"{type}");
                cmd.Parameters.AddWithValue("@movieYear", year);
                cmd.Parameters.AddWithValue("@movieLength", length);
                cmd.Parameters.AddWithValue("@movieRating", rating);
                cmd.Parameters.AddWithValue("@movieRated", rated);
                cmd.Parameters.AddWithValue("@movieGenre", genre);
                cmd.Parameters.AddWithValue("@userID", 1);

                cmd.ExecuteNonQuery();

            }
            finally
            {
                if (connection != null)
                    connection.Close();
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

        public DataTable FilterMovie(String parameter, String text)
        {
            String stm = $"SELECT * FROM watchList WHERE moviet{parameter} = '{text}';";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = new MySqlCommand(stm, connection);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);//uztaisi ka pie delete
            return table;
        }
    }
}