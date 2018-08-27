﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace LoginModule.cs
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        

        string myConnection = "Server=localhost;Database=db_poshandfabconceptstore;Uid=root;Password="; 
        public Login()
        {
            InitializeComponent();
           
            materialRadioButton1.Checked = true;
        }

        public void log()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(myConnection);

                try
                {
                    connection.Open();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Unable to connect to database\n" + "Error\n" + e);
                }
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("You need to login your credentials.");
                }
                else if (materialRadioButton1.Checked == true)
                {
                    MySqlCommand Command = connection.CreateCommand();
                    Command.Connection = connection;
                    Command.CommandText = "select * from tbl_adminuser where col_adminusername = '" +
                        textBox1.Text + "' and col_adminpassword= '" + textBox2.Text + "'";
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
                        copro3.CommandText = "select * from tbl_adminuser where col_adminusername = '" +
                            textBox1.Text + "' and col_adminpassword= '" + textBox2.Text + "'";
                        MySqlDataReader copro = copro3.ExecuteReader();
                        while (copro.Read())
                        {
                            string user = (copro["col_adminusername"].ToString());
                            string pass = (copro["col_adminpassword"].ToString());
                            if (user == textBox1.Text && pass == textBox2.Text)
                            {
                                DialogSuccessfulyLogin a = new DialogSuccessfulyLogin();
                                a.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username & password. ");
                                textBox1.Clear();
                                textBox2.Clear();
                            }
                        }
                    }
                }
                else if (materialRadioButton2.Checked == true && materialRadioButton1.Checked == false)
                {
                    MySqlCommand Command2 = connection.CreateCommand();
                    Command2.Connection = connection;
                    Command2.CommandText = "select * from tbl_cashieruser where col_cashierusername = '" +
                        textBox1.Text + "' and col_cashierpassword= '" + textBox2.Text + "'";
                    MySqlDataReader read2 = Command2.ExecuteReader();
                    int count2 = 0;
                    while (read2.Read())
                    {
                        count2++;

                    }
                    connection.Close();
                    if (count2 >= 1)
                    {
                        MySqlCommand copro5 = new MySqlCommand();
                        connection.Open();
                        copro5.Connection = connection;
                        copro5.CommandText = "select * from tbl_cashieruser where col_cashierusername = '"
                            + textBox1.Text + "' and col_cashierpassword= '"
                            + textBox2.Text + "'";
                        MySqlDataReader copro2 = copro5.ExecuteReader();
                        while (copro2.Read())
                        {
                            string user = (copro2["col_cashierusername"].ToString());
                            string pass = (copro2["col_cashierpassword"].ToString());
                            if (user == textBox1.Text && pass == textBox2.Text)
                            {
                                MessageBox.Show("Successfully Logged in!");
                                TransactionModule a = new TransactionModule();
                                a.Show();
                                this.Hide();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Invalid username & password. ");
                                textBox1.Clear();
                                textBox2.Clear();
                            }
                        }
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to Login \n Error" + ex);

            }
        }
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            log();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            log();
        }
    }
}
