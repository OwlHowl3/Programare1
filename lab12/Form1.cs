using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab12
{
    public partial class Form1 : Form
    {
        // Necesita o baza de date access stocata in memoria calculatorului.

        // La click pe buton preia valorile din textbox.

        // defineste un ConnectionString pentru baza de date

        // creeaza un obiect nou pentru conexiune (OleDbConnection)
        // cu setarile din ConnectionString-ul de mai sus

        // Deschide conexiunea

        // Defineste o comanda parametrizata si ataseaza toti parametrii cu valori
        // pentru operatiunea de insert in baza de date

        // executa comanda si inchide conexiunea.


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\movies_tv_series.accdb;" +
                "Persist Security Info=False;";

            // new Connection
            OleDbConnection connection = new OleDbConnection();

            // connection config
            connection.ConnectionString = connectionString;
            connection.Open();
            Console.WriteLine(connection);
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection string
            string connectionString;
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\movies_tv_series.accdb;Persist Security Info=False;";
            
            // new Connection
            OleDbConnection connection;
            connection = new OleDbConnection();

            // connection config
            connection.ConnectionString = connectionString;

            try
            {
                connection.Open();
                MessageBox.Show("Connected to the database");

                OleDbCommand insertCommand;
                insertCommand = new OleDbCommand();
                insertCommand.Connection = connection;

                insertCommand.CommandText = "INSERT INTO tv_series VALUES(?,?,?,?,?,?,?)";

                insertCommand.Parameters.Clear();
                insertCommand.Parameters.AddWithValue("id", textBox1.Text);
                insertCommand.Parameters.AddWithValue("title", textBox2.Text);
                insertCommand.Parameters.AddWithValue("genre", textBox3.Text);
                insertCommand.Parameters.AddWithValue("start_year", textBox4.Text);
                insertCommand.Parameters.AddWithValue("end_year", textBox5.Text);
                insertCommand.Parameters.AddWithValue("rating", textBox6.Text);
                insertCommand.Parameters.AddWithValue("main_cast", textBox7.Text);
                
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("TV series added");
                
                connection.Close();
                MessageBox.Show("Connection closed");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message.ToString());
            }
        }
    }
}
