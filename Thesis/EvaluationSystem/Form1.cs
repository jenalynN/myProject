using MySql.Data.MySqlClient;
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

namespace EvaluationSystem
{
    public partial class Form1 : MetroForm
    {

        string myConnection = "Server=192.168.1.2;Database=evaluationsystem;Uid=mactanparts    ;Password=admin"; 
        public Form1()
        {
            InitializeComponent();
        }

        public void login()
        {
            MySqlConnection connection = new MySqlConnection(myConnection);
            connection.Open();
            MySqlCommand Command = connection.CreateCommand();

            Command.Connection = connection;
            Command.CommandText = "select * from users where user = '" + metroTextBox1.Text + "' and password = '" + textBox1.Text + "'";

            MySqlDataReader read = Command.ExecuteReader();
            int count1 = 0;
            while (read.Read())
            {
                count1++;

            }
            connection.Close();
            if (count1 == 1)
            {
                MySqlCommand copro3 = new MySqlCommand();
                connection.Open();
                copro3.Connection = connection;
                copro3.CommandText = "select * from users where user = '" + metroTextBox1.Text + "' and password = '" + textBox1.Text + "'";
                MySqlDataReader copro = copro3.ExecuteReader();
                while (copro.Read())
                {
                    string user = (copro["user"].ToString());
                    string pass = (copro["password"].ToString());
                    if (user == metroTextBox1.Text && pass == textBox1.Text)
                    {
                        MessageBox.Show(this, " Successfully Logged in", "Accessed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Hide();
                        Mainframe mainframe = new Mainframe();
                        mainframe.Show();
                    }
                }

            }
            else //if (user == txUsername.Text ||pass == txtPassword.Text)
            {
                metroTextBox1.Text = "";
                textBox1.Text = "";
                //        MessageBox.Show("Incorrect Login, Please Try Again");
                MessageBox.Show(this, "Either username and password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
        private void metroLabel5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {
            RegisterForm a = new RegisterForm();
            a.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
                login();
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            textBox1.PasswordChar = '*';

        }

        private void metroCheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
        }

    }
}

