using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DVDApp
{
    class DB
    {
        public static string CONNSTRING;

        public List<DVD> GetDVDs()
        {
            CONNSTRING = "Server=" + Properties.Settings.Default.severaddress + ";Database=" + Properties.Settings.Default.Database + ";Uid=" + Properties.Settings.Default.username + ";Pwd=" + Properties.Settings.Default.password + ";";
            // Would have used a String.Format however kept throwing an exception out
            List<DVD> dvds = new List<DVD>();
            bool checkconn = true;
            MySqlConnection conn = new MySqlConnection(CONNSTRING);
            while (checkconn)
            {
                {
                    try
                    {
                        conn.Open();
                        checkconn = false;
                    }
                    catch (MySql.Data.MySqlClient.MySqlException)
                    {
                        EditConfiguration fm = new EditConfiguration();
                        fm.ShowDialog();
                        CONNSTRING = "Server=" + Properties.Settings.Default.severaddress + ";Database=" + Properties.Settings.Default.Database + ";Uid=" + Properties.Settings.Default.username + ";Pwd=" + Properties.Settings.Default.password + ";";
                        conn = new MySqlConnection(CONNSTRING);
                    }
                }
            }
            string command = "SELECT ID, Name, Genre, Rating, Maturity_Level FROM DVD";

            using (MySqlCommand cmd = new MySqlCommand(command, conn))
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int id = rdr.GetInt32(0);
                    string name = rdr.GetString(1);
                    string genre = rdr.GetString(2);
                    int rating = rdr.GetInt32(3);
                    string maturityRating = rdr.GetString(4);
                    dvds.Add(new DVD(id, name, genre, rating, maturityRating));
                }
                conn.Close();
            }

            return dvds;
        }

        public static int AddDVD(DVD dvd)
        {
            using (MySqlConnection conn = new MySqlConnection(CONNSTRING))
            {
                int rows = 0;
                conn.Open();
                string sql = "insert into dvd(ID,Name,Genre,Rating,Maturity_Level) " + "values(@ID,@Name,@Genre,@Rating,@Maturity_Level)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("ID", dvd.ID);
                    cmd.Parameters.AddWithValue("Name", dvd.Name);
                    cmd.Parameters.AddWithValue("Genre", dvd.Genre);
                    cmd.Parameters.AddWithValue("Rating", dvd.Rating);
                    cmd.Parameters.AddWithValue("Maturity_Level", dvd.MaturityLevel);
                    rows = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                conn.Close();
                return rows;
            }
        }

        public static int UpdateDVD(DVD dvd)
        {
            int rows = 0;
            using (MySqlConnection conn = new MySqlConnection(CONNSTRING))
            {
                conn.Open();
                string sql = "UPDATE dvd SET Name =@dName, Genre =@dGenre, Rating =@dRating, Maturity_Level = @dLevel WHERE ID =@dID";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("dID", dvd.ID);
                    cmd.Parameters.AddWithValue("dName", dvd.Name);
                    cmd.Parameters.AddWithValue("dGenre", dvd.Genre);
                    cmd.Parameters.AddWithValue("dRating", dvd.Rating);
                    cmd.Parameters.AddWithValue("dLevel", dvd.MaturityLevel);
                    rows = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                conn.Close();
                return rows;
            }
        }

        public static void DeleteDVD(DVD dvd)
        {
            using (MySqlConnection conn = new MySqlConnection(CONNSTRING))
            {
                conn.Open();
                string sql = String.Format("DELETE FROM dvd WHERE id = {0}", dvd.ID.ToString());
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
    }
}