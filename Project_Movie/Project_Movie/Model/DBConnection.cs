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
        private MySqlCommand cmd = new MySqlCommand();

        public static int userID { get; set; }

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
        }

        public void ConnectionOpen()
        {
            connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                ConnectionError cError = new ConnectionError(ex);
                cError.ShowDialog();
            }
        }

        private void ConnectionClose()
        {
            if (connection != null)
                connection.Close();
        }

        public DataTable GetMovies()
        {
            ConnectionOpen();
            cmd.Parameters.Clear();
            cmd.Connection = connection;
            cmd.CommandText = $"SELECT * FROM watchList WHERE userID = @userID;";
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.ExecuteNonQuery();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            ConnectionClose();
            return table;
        }

        public bool AddMovie(String title, String type, String year, String length, String rating, String rated, String genre, String ImdbID)
        {
            if (FilterMovie(ImdbID))
                return true;
            else
            {
                AddMovieAnyway(title, type, year, length, rating, rated, genre, ImdbID);
                return false;
            }
        }
        
        public void AddMovieAnyway(String title, String type, String year, String length, String rating, String rated, String genre, String ImdbID) 
        {
            ConnectionOpen();
            cmd.Parameters.Clear();
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
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.ExecuteNonQuery();
            ConnectionClose();
        }

        public void DeleteMovie(String title)
        {
            ConnectionOpen();
            cmd.Parameters.Clear();
            cmd.Connection = connection;
            cmd.CommandText = $"DELETE FROM watchList WHERE movieTitle = @movieTitle AND userID = @userID;";
            cmd.Parameters.AddWithValue("@movieTitle", title);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.ExecuteNonQuery();
            ConnectionClose();
        }

        private bool FilterMovie(String ImdbID)//checks if it already is in watchlist
        {
            ConnectionOpen();
            cmd.Parameters.Clear();
            cmd.Connection = connection;
            DataTable table = new DataTable();
            cmd.CommandText = $"SELECT * FROM watchList WHERE userID = @userID AND movieImdbID = @movieParam;";
            cmd.Parameters.AddWithValue("@movieParam", ImdbID);
            cmd.Parameters.AddWithValue("@userID", userID);
            MySqlDataReader myReader = cmd.ExecuteReader();
            table.Load(myReader);
            ConnectionClose();
            myReader.Close();
            if (table.Rows.Count >= 1)
                return true;
            else
                return false;    
        }

        public DataTable FilterMovie(String parameter, String text)
        {
            ConnectionOpen();
            cmd.Parameters.Clear();
            cmd.Connection = connection;
            DataTable table = new DataTable();
            cmd.CommandText = $"SELECT * FROM watchList WHERE movie{parameter} LIKE @movieParam AND userID = " + userID + ";";
            cmd.Parameters.AddWithValue("@movieParam", "%" + text + "%");
            MySqlDataReader myReader = cmd.ExecuteReader();
            table.Load(myReader);
            ConnectionClose();
            myReader.Close();
            return table;
        }

        public void RegisterUser(String login, String password, String userName, String userSurname, String userAge, String userSex, String userCountry)
        {
            ConnectionOpen();
            cmd.Parameters.Clear();
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
            ConnectionClose();
        }

        public bool Login(String login, String password)
        {
            ConnectionOpen();
            cmd.Parameters.Clear();
            cmd.Connection = connection;
            DataTable table = new DataTable();
            cmd.CommandText = $"SELECT * FROM users WHERE login = @login AND password = @password;";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            MySqlDataReader myReader = cmd.ExecuteReader();
            table.Load(myReader);
            ConnectionClose();
            myReader.Close();
            if (table.Rows.Count >= 1)
                return true;
            else
                return false;
        }

        public void setUserID()
        {
            ConnectionOpen();
            cmd.Parameters.Clear();
            cmd.Connection = connection;
            DataTable table = new DataTable();
            cmd.CommandText = $"SELECT * FROM users WHERE login = @login;";
            cmd.Parameters.AddWithValue("@login", loginForm.username);
            var dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                userID = dr.GetInt32(0);
            }
            dr.Close();
            ConnectionClose();
        }

        public bool CheckUsernameDuplicate(String username)
        {
            ConnectionOpen();
            cmd.Parameters.Clear();
            cmd.Connection = connection;
            DataTable table = new DataTable();
            cmd.CommandText = $"SELECT * FROM users WHERE login = @login;";
            cmd.Parameters.AddWithValue("@login", username);
            MySqlDataReader myReader = cmd.ExecuteReader();
            table.Load(myReader);
            ConnectionClose();
            myReader.Close();
            if (table.Rows.Count >= 1)
                return true;
            else
                return false;
        }

        public DataTable GetUserData()
        {
            ConnectionOpen();
            cmd.Parameters.Clear();
            cmd.Connection = connection;
            cmd.CommandText = $"SELECT * FROM users WHERE userID = @userID;";
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.ExecuteNonQuery();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            ConnectionClose();
            return table;
        }

        public void EditInfo(String login, String userName, String userSurname, String userAge, String userSex, String userCountry)
        {
            ConnectionOpen();
            cmd.Parameters.Clear();
            cmd.Connection = connection;
            cmd.CommandText = $"UPDATE users SET login = @login, userName = @userName, userSurname = @userSurname, userAge = @userAge, userSex = @userSex, userCountry = @userCountry WHERE userID = @userID;";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@userSurname", userSurname);
            cmd.Parameters.AddWithValue("@userAge", userAge);
            cmd.Parameters.AddWithValue("@userSex", userSex);
            cmd.Parameters.AddWithValue("@userCountry", userCountry);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.ExecuteNonQuery();
            ConnectionClose();
        }

        public bool CheckOldPassword(String oldPassword)
        {
            ConnectionOpen();
            cmd.Parameters.Clear();
            cmd.Connection = connection;
            DataTable table = new DataTable();
            cmd.CommandText = $"SELECT * FROM users WHERE userID = @userID AND password = @password;";
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@password", oldPassword);
            MySqlDataReader myReader = cmd.ExecuteReader();
            table.Load(myReader);
            ConnectionClose();
            myReader.Close();
            if (table.Rows.Count >= 1)
                return true;
            else
                return false;
        }

        public void EditPassword(String newPassword)
        {
            ConnectionOpen();
            cmd.Parameters.Clear();
            cmd.Connection = connection;
            cmd.CommandText = $"UPDATE users SET password = @password WHERE userID = @userID;";
            cmd.Parameters.AddWithValue("@password", newPassword);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.ExecuteNonQuery();
            ConnectionClose();
        }

        public void DeleteProfile()
        {
            ConnectionOpen();
            cmd.Parameters.Clear();
            cmd.Connection = connection;
            cmd.CommandText = $"DELETE FROM users WHERE userID = @userID;";
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.ExecuteNonQuery();
            ConnectionClose();
        }
    }
}