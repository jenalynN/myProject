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
using MetroFramework.Forms;

namespace EvaluationSystem
{
    public partial class AddQuestion : MetroForm
    {
        string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password="; 

        public AddQuestion()
        {
            InitializeComponent();
            viewCategorie();
           
        }
        private void add()
        {
            if (metroTextBox1.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else if (metroTextBox1.Text != "")
            {
                MySqlConnection conn = new MySqlConnection(myConnection);
                conn.Close();
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select * from questions where id = '" + metroTextBox1.Text + "'";
                MySqlDataReader read = command.ExecuteReader();

                int count = 0;
                while (read.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("It seem that the username you want isn't available. Please try another one.");


                    conn.Close();
                }
                else if (count > 1)
                {
                    MessageBox.Show("It seem that the username you want isn't available. Please try another one.'");
                    metroTextBox1.Text = "";
                   
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    MySqlCommand command2 = conn.CreateCommand();

                    command2.CommandText = "insert into questions (Category,Question,C1,C2,C3,C4,C5,C6) values ( '" + metroComboBox1.Text + "','" + metroTextBox1.Text + "','" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroTextBox4.Text + "','" + metroTextBox5.Text + "','" + metroTextBox6.Text + "','" + metroTextBox7.Text + "')";
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully");
                    conn.Close();

                    metroComboBox1.Text = "Select a Category";
                    metroTextBox1.Text = "";
                         metroTextBox2.Text = "";
                     metroTextBox3.Text = "";
                     metroTextBox4.Text = "";
                     metroTextBox5.Text = "";
                     metroTextBox6.Text = "";
                     metroTextBox7.Text = "";
                     Mainframe a = new Mainframe();
                     a.Show();
                     this.Hide();

                }
                conn.Close();
            }
        }
        private void delete()
        {

            MySqlConnection conn = new MySqlConnection(myConnection);
            conn.Close();
            conn.Open();
  

            MySqlCommand command2 = conn.CreateCommand();

            command2.CommandText = "delete from Category where CategoryName = '" + metroComboBox1.Text + "'";
            command2.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted");
          
            conn.Close();
            viewCategorie();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            add();
        }
        public void viewCategorie()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            metroComboBox1.Items.Clear();
            conn.Close();

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from Category";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                metroComboBox1.Items.Add(read["CategoryName"].ToString());
            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroComboBox1.Text == "Select a Category")
            {
                MessageBox.Show("Select a Category");
            }
            else
            {
                add();
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Category a = new Category();
            a.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();

        }

         
    }


}
