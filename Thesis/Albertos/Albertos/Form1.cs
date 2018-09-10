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

namespace Albertos
{
    public partial class Form1 : Form
    {
        string myConnection = "Server=localhost;Database= dbpizza ;Uid=root;Password=";
        public Form1()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            {
                MySqlConnection connection = new MySqlConnection(myConnection);
                connection.Open();
                MySqlCommand Command = connection.CreateCommand();

                Command.Connection = connection;
                Command.CommandText = "select * from login where username = '" + tbusername.Text + "' and password = '" + tbpassword.Text + "'";

                 MySqlDataReader read = Command.ExecuteReader();
            int count1 = 0;
            while (read.Read())
            {
                 count1++;

            }
            connection.Close();
            if(count1 == 1)
            {
                MySqlCommand command = new MySqlCommand();
                connection.Open();
                 command.Connection = connection;
                 command.CommandText = "select * from login where username = '" + tbusername.Text + "' and password = '" + tbpassword.Text + "'";
                MySqlDataReader sad = command.ExecuteReader();
                while (sad.Read())
                {
                 string user = (sad["username"].ToString());
                    string pass = (sad["password"].ToString());
                    if (user == tbusername.Text && pass == tbpassword.Text)
                    {
                        MessageBox.Show("Successfully Login");
                        this.Hide();
                       Home form = new Home();
                        form.ShowDialog();
                    }
                }
            }
             else 
            {
                tbusername.Text = "";
                tbpassword.Text = "";
               
                MessageBox.Show(this, "\n\n Incorrect Login, Please Try Again", "Username or Password is:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               connection.Close();
        
}

            }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsSymbol(e.KeyChar) || Char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || Char.IsSeparator(e.KeyChar);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        }
    }
