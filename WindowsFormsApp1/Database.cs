using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Database
    {
        private readonly string dataSource;
        public Database(string dataSource)
        {
            this.dataSource = dataSource;
        }
        public bool InitializeDatabase()
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    string sql_command = "DROP TABLE IF EXISTS users;"
                                + "CREATE TABLE users("
                                + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                                + "login TEXT, "
                                + "password TEXT, "
                                + "name TEXT, "
                                + "surname TEXT);";
                    cmd.CommandText = sql_command;
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return true;
        }
        public int UsersCount()
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    string sql_command = "SELECT count(id) FROM users";
                    cmd.CommandText = sql_command;
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch
            {
                return -1;
            }
            finally
            {
                conn.Dispose();
            }
            return -1;
        }
        public bool ValidUser(string username, string password)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format("SELECT COUNT(*) "
                    + "FROM users "
                    + "where login = '{0}' AND "
                    + "password = '{1}'",
                   username, password);
                    var usersCount = Convert.ToInt32(cmd.ExecuteScalar());
                    return usersCount > 0;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return false;
        }

        public bool CheckLoginUser(string username)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format("SELECT COUNT(*) "
                    + "FROM users "
                    + "where login = '{0}'",
                   username);
                    var usersCount = Convert.ToInt32(cmd.ExecuteScalar());
                    return usersCount > 0;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return false;
        }

        public bool createUser(string username, string password)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);

            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("INSERT INTO users (login, password)"
                + "VALUES ('{0}', '{1}')",
                username, password);
                cmd.ExecuteNonQuery();
                return true;
            }

            return true;
        }
    }
}
