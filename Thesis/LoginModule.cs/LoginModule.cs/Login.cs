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
     
        public Login()
        {
            InitializeComponent();
           
            materialRadioButton1.Checked = true;
        }

        public void log()
        {
            try { 
                MySqlConnection connection = new MySqlConnection(ConnectionString.myConnection);
                connection.Open();
                    if (textBox1.Text == "" || textBox2.Text == "")
                   {
                    MessageBox.Show("You need to login your credentials.");
                     }
                   else if (materialRadioButton1.Checked == true)
                  {
                       MySqlCommand Command = connection.CreateCommand();
                        Command.Connection = connection;
                         Command.CommandText = "select * from tbl_useraccounts where col_user = '" +
                         textBox1.Text + "' and col_password= '" + textBox2.Text + "' and col_usertypeid = 1 ";
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
                            copro3.CommandText = "select * from tbl_useraccounts where col_user = '" +
                            textBox1.Text + "' and col_password= '" + textBox2.Text + "' and col_usertypeid = 1 ";
                             MySqlDataReader copro = copro3.ExecuteReader();
                         while (copro.Read())
                            {
                        string user = (copro["col_user"].ToString());
                        string pass = (copro["col_password"].ToString());
                        if (user == textBox1.Text && pass == textBox2.Text)
                        {
                            Mainframe a = new Mainframe();
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
                else
                {
                    MessageBox.Show("Invalid username & password. ");
            
                }}
            else if (materialRadioButton2.Checked == true && materialRadioButton1.Checked == false)
            {
                MySqlCommand Command2 = connection.CreateCommand();
                Command2.Connection = connection;
                Command2.CommandText = "select * from tbl_useraccounts where col_user = '" + textBox1.Text + "' and col_password= '" + textBox2.Text + "' and col_status='unarchived' and col_usertypeid = 2";
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
                    copro5.CommandText = "select * from tbl_useraccounts where col_user = '" +
                    textBox1.Text + "' and col_password= '" + textBox2.Text + "' and col_status='unarchived' and col_usertypeid = 2 "; 
                    MySqlDataReader copro2 = copro5.ExecuteReader();
                    while (copro2.Read())
                    {
                        string userid = (copro2["col_useraccountsid"].ToString());
                        string user = (copro2["col_user"].ToString());
                        string pass = (copro2["col_password"].ToString());
                        if (user == textBox1.Text && pass == textBox2.Text)
                        {
                            TransactionModule a = new TransactionModule(userid);                                
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
                else
                {
                    MessageBox.Show("Invalid username & password. ");
                }
            }    
            }catch(Exception e)
            {
            MessageBox.Show("No connection to the host");
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
        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            log();
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    log();
                }
                catch (Exception elog)
                {
                    MessageBox.Show(elog.ToString());
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
        }
    }
}
