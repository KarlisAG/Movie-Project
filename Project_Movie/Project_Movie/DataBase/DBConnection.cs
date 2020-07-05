using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using MySql.Data.MySqlClient;
using Project_Movie.Forms;
using Renci.SshNet.Security.Cryptography;

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
        private static string connectionString;
        private string sslM;
        Logic l = new Logic();

        public String message;
        public static int userID { get; set; }
        public String ussername;

        loginForm loginForm;

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

        public DBConnection(loginForm loginForm) 
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
            this.loginForm = loginForm;
        }

        public DataTable GetMovies()
        {
            //String stm = "SELECT * FROM watchList WHERE userID = " + l.usserID + ";";//userID!!!
            connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;

            cmd.CommandText = $"SELECT * FROM watchList WHERE userID = @userID;";
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.ExecuteNonQuery();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);

            //dataAdapter.SelectCommand = new MySqlCommand(cmd, connection);

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

                    Logic l = new Logic();
                    
                    cmd.Parameters.AddWithValue("@userID", userID);//userID
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

                cmd.CommandText = $"DELETE FROM watchList WHERE movieTitle = @movieTitle AND userID = @userID;";
                cmd.Parameters.AddWithValue("@movieTitle", title);
                cmd.Parameters.AddWithValue("@userID", userID);
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
                myCommand.CommandText = $"SELECT * FROM watchList WHERE movieImdbID = @movieParam AND userID = @userID;";
                myCommand.Parameters.AddWithValue("@movieParam", ImdbID);
                myCommand.Parameters.AddWithValue("@userID", userID);
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
                myCommand.CommandText = $"SELECT * FROM watchList WHERE movie{parameter} LIKE @movieParam AND userID = " + userID + ";";
                myCommand.Parameters.AddWithValue("@movieParam", "%" + text + "%");
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

        public void RegisterUser(String login, String password, String userName, String userSurname, String userAge, String userSex, String userCountry)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO users (login, password, userName, userSurname, userAge, userSex, userCountry) " +
                                  "VALUES(@login, @password, @userName, @userSurname, @userAge, @userSex, @userCountry)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@userSurname", userSurname);
                cmd.Parameters.AddWithValue("@userAge", userAge);
                cmd.Parameters.AddWithValue("@userSex", userSex);
                cmd.Parameters.AddWithValue("@userCountry", userCountry);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public bool Login(String login, String password)
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
                myCommand.CommandText = $"SELECT * FROM users WHERE login = @login AND password = @password;";
                myCommand.Parameters.AddWithValue("@login", login);
                myCommand.Parameters.AddWithValue("@password", password);
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

        public static void setUserID()
        {
            MySqlConnection connection = null;
            //MySqlDataReader myReader;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                DataTable table = new DataTable();
                myCommand.CommandText = $"SELECT * FROM users WHERE login = @login;";
                myCommand.Parameters.AddWithValue("@login", loginForm.username);
                var dr = myCommand.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    userID = dr.GetInt32(0);
                }
                dr.Close();
                
                //myReader = myCommand.ExecuteReader();
                //table.Load(myReader);
                //foreach (DataRow row in table.Rows)
                //{
                //    userID = row.Field<int>(0);
                //}
                //return userID;
            }
            finally
            {
                
                if (connection != null)
                    connection.Close();
            }
        }

        public bool CheckUsernameDuplicate(String username)
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
                myCommand.CommandText = $"SELECT * FROM users WHERE login = @login;";
                myCommand.Parameters.AddWithValue("@login", username);
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
    }
}