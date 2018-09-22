using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EvaluationSystem
{
    public partial class Category : MetroForm
    {
         string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password="; 
        public Category()
        {
            InitializeComponent();
        }
        private void add ()
        {
                
            if (metroTextBox1.Text == "" )
            {
                MessageBox.Show("Please Complete the Form");
            }
            else if (metroTextBox1.Text != "")
            {
                MySqlConnection conn = new MySqlConnection(myConnection);
                conn.Close();
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select * from category where id = '" + metroTextBox1.Text + "'";
                MySqlDataReader read = command.ExecuteReader();

                int count = 0;
                while (read.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("It seems that the category name is already there.");


                    conn.Close();
                }
                else if (count > 1)
                {
                    MessageBox.Show("It seems that the category name is already there.");
                    metroTextBox1.Text = "";
                    
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    MySqlCommand command2 = conn.CreateCommand();

                    command2.CommandText = "insert into category (CategoryName) values ( '" + metroTextBox1.Text + "')";
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully");

                    this.Hide();
                    AddQuestion a = new AddQuestion();
                    a.Show();
                    conn.Close();
                    metroTextBox1.Text = "";
                

                }
                conn.Close();
            }

        }
        
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            add();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AddQuestion a = new AddQuestion();
            a.Show();
                this.Hide();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

    }
}
