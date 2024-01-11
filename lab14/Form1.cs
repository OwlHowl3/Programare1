using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=127.0.0.1;uid=root;" +
                "pwd=P@rola123;database=music";

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                //MySqlCommand comm = conn.CreateCommand();
                //comm.CommandText = "INSERT INTO songs(artist,name,duration,genres,rating) VALUES(@artist, @name, @duration, @genres, @rating)";
                //comm.Parameters.AddWithValue("@artist", "Kanye West");
                //comm.Parameters.AddWithValue("@name", "I Am a God");
                //comm.Parameters.AddWithValue("@duration", 256);
                //comm.Parameters.AddWithValue("@genres", "rap, hip hop");
                //comm.Parameters.AddWithValue("@rating", 10);
                //comm.ExecuteNonQuery();
                //conn.Close();



                //MySqlCommand comm = conn.CreateCommand();
                //comm.CommandText = "UPDATE songs SET name=@name WHERE id=@id";
                //comm.Parameters.AddWithValue("@id", 2);
                //comm.Parameters.AddWithValue("@name", "Good Morning");
                //comm.ExecuteNonQuery();
                //conn.Close();



                //MySqlCommand comm = conn.CreateCommand();
                //comm.CommandText = "DELETE FROM songs WHERE id = @id";
                //comm.Parameters.AddWithValue("@id", 1);
                //comm.ExecuteNonQuery();
                //conn.Close();

                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "SELECT * FROM songs";
                var reader = comm.ExecuteReader();
                Console.WriteLine(reader);

                while (reader.Read())
                {
                    Console.WriteLine("{0} | {1} | {2}", reader.GetInt32(0), reader.GetString(1),
                            reader.GetString(2));
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
