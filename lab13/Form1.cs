using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace lab13
{
    public partial class Form1 : Form
    {
        OleDbConnection connection;
        DataSet dataset;
        DataTable carsTable;
        OleDbDataReader reader;
        int currentLine;

        public Form1()
        {
            InitializeComponent();

            connection = new OleDbConnection();
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\db_cars.accdb;" +
                "Persist Security Info=False;";
            
            connection.ConnectionString = connectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.loadData();

            this.currentLine = 0;
            this.showCar();
        }

        private void loadData()
        {
            try
            {
                this.connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = this.connection;
                command.CommandText = "SELECT * FROM cars";

                this.reader = command.ExecuteReader();

                this.carsTable = new DataTable("cars");
                carsTable.Load(reader);

                this.dataset = new DataSet();
                dataset.Tables.Add(carsTable);

                this.connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message.ToString());
            }
        }

        private void showCar()
        {
            textBox1.Text = this.dataset.Tables["cars"].Rows[this.currentLine].ItemArray[0].ToString();
            textBox2.Text = this.dataset.Tables["cars"].Rows[this.currentLine].ItemArray[1].ToString();
            textBox3.Text = this.dataset.Tables["cars"].Rows[this.currentLine].ItemArray[2].ToString();
            textBox4.Text = this.dataset.Tables["cars"].Rows[this.currentLine].ItemArray[3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.currentLine == 0)
            {
                this.currentLine = this.dataset.Tables["cars"].Rows.Count - 1;
            } else
            {
                this.currentLine--;
            }

            this.showCar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.currentLine == this.dataset.Tables["cars"].Rows.Count - 1)
            {
                this.currentLine = 0;
            }
            else
            {
                this.currentLine++;
            }

            this.showCar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.CommandText = "INSERT INTO cars (brand, model, price) VALUES (@brand, @model, @price)";
                command.Connection = this.connection;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@brand", textBox2.Text);
                command.Parameters.AddWithValue("@model", textBox3.Text);
                command.Parameters.AddWithValue("@price", double.Parse(textBox4.Text));

                command.ExecuteNonQuery();

                MessageBox.Show("Car added successfully");

                this.connection.Close();

                this.loadData();
                this.currentLine = this.dataset.Tables["cars"].Rows.Count - 1;
                this.showCar();

            } catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message.ToString());
                this.connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.CommandText = "UPDATE cars SET brand = @b, model = @m, price = @p WHERE id = @id";
                command.Connection = this.connection;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@b", textBox2.Text);
                command.Parameters.AddWithValue("@m", textBox3.Text);
                command.Parameters.AddWithValue("@p", double.Parse(textBox4.Text));

                command.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

                command.ExecuteNonQuery();

                MessageBox.Show("Car updated successfully");

                this.connection.Close();

                this.loadData();
                this.showCar();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error" + exception.Message.ToString());
                this.connection.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.CommandText = "DELETE FROM cars WHERE id = @id";
                command.Connection = this.connection;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

                command.ExecuteNonQuery();

                MessageBox.Show("Car deleted successfully");

                this.connection.Close();

                this.loadData();
                this.currentLine--;
                this.showCar();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message.ToString());
                this.connection.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.CommandText = "SELECT model, price FROM cars WHERE brand = @b";
                command.Connection = this.connection;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@b", textBox5.Text);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    string output = "Cars details";

                    while (reader.Read())
                    {
                        output += "\nModel: " + reader["model"] + "; Price: " + reader["price"] + ";";
                    }
                    label6.Text = output;
                }

                this.connection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error" + exception.Message.ToString());
                this.connection.Close();
            }
        }
    }


}
