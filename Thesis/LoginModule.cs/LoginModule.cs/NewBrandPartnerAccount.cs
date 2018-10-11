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
namespace LoginModule.cs
{
    public partial class NewBrandPartnerAccount : MaterialSkin.Controls.MaterialForm
    {
        public NewBrandPartnerAccount()
        {
            InitializeComponent();
            getmax();
        }
        public void getmax()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(ConnectionString.myConnection);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select MAX(col_useraccountsid) as maxID from tbl_useraccounts";
                MySqlDataReader basa = cmd.ExecuteReader();
                while (basa.Read())
                {
                    string maxid = basa["maxID"].ToString();

                    int plus1 = Int32.Parse(maxid);
                    int total = plus1 + 1;
                    labelTransactionCode.Text = "" + total;
                }
                con.Close();
            }
            catch (Exception e) 
            {
                MessageBox.Show("No Connection to the host");
            }
        }
        public void addnewbrandpartneraccount()
        {

            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            if (textBox1.Text == ""||textBox2.Text == ""||textBox3.Text == ""||textBox5.Text == ""||textBox6.Text == ""||textBox12.Text == ""||textBox7.Text == ""||textBox8.Text == ""||textBox9.Text == ""||textBox10.Text == ""||textBox11.Text == ""||comboBox1.Text=="")
            {
                MessageBox.Show("Missing Fields");
            }
           
                else
                {
                    conn.Open();
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "select * from tbl_useraccounts where col_user = '" + textBox9.Text + "' ";
                    MySqlDataReader read = command.ExecuteReader();

                    int count = 0;
                    while (read.Read())
                    {
                        count++;
                    }
                    conn.Close();

                    conn.Open();
                    command = conn.CreateCommand();
                    command.CommandText = "select * from tbl_brandpartner where col_brandname = '" + textBox4.Text + "' ";
                    read = command.ExecuteReader();

                    int countBrand = 0;
                    while (read.Read())
                    {
                        countBrand++;
                    }
                    conn.Close();

                    if (count >= 1)
                    {
                        MessageBox.Show("The username is already taken, please try another one");
                    }
                    else if (countBrand >= 1)
                    {
                        MessageBox.Show("Brandname already exist, please try another one");
                    }
                    else
                    {
                        
                        conn.Open();
                        MySqlCommand command2 = conn.CreateCommand();
                        command2.CommandText = "insert into tbl_useraccounts (col_usertypeid,col_user, col_password, col_lastname, col_firstname, col_middlename,col_address,col_gender,col_contactnum,col_status) " +
                            "values  ((SELECT col_usertypeid from tbl_usertype where col_userrole='Brandpartner'),'" + textBox9.Text + "','" + textBox11.Text + "','" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + comboBox1.SelectedItem + "','" + textBox6.Text + "','unarchived')";
                        command2.ExecuteScalar();
                        conn.Close(); 
                    }
                }

            
        }
        public void adddetails()
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            if (label1.Text == "")
            {
                MessageBox.Show("Complete the Form");
            }
            else
            {

                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select * from tbl_brandpartner where col_brandname = '" + textBox4.Text + "' ";
                MySqlDataReader read = command.ExecuteReader();

                int count = 0;
                while (read.Read())
                {
                    count++;
                }
                conn.Close();

                if (count >= 1)
                {
                    //MessageBox.Show("The brandname is already taken, please try another one");
                }
                else
                {
                    conn.Open();
                    MySqlCommand command2 = conn.CreateCommand();
                    command2.CommandText = "insert into tbl_brandpartner(col_useraccountsid, col_brandname, col_brandaddress, col_brandcontactnum,col_brandemail) " +
                        "values  ('" + labelTransactionCode.Text + "','" + textBox4.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox12.Text + "')";
                    command2.ExecuteScalar();
                    conn.Close();
                    MessageBox.Show("Successfully added");
                    Mainframe a = new Mainframe();
                    a.Show();
                    this.Hide();
                }
            }

        }
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox9.Text) ||
                string.IsNullOrWhiteSpace(textBox11.Text)||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text)||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Please don't leave any blank field(s).");
            }
            else if (textBox10.Text != textBox11.Text)
            {
                MessageBox.Show("Password does not match the confirm password.");
            }
            else
            {
                addnewbrandpartneraccount();
                adddetails();
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().numbersOnlyTrap_TextChanged(sender, e);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().numbersOnlyTrap_TextChanged(sender, e);

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().namingTrap_TextChanged(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().namingTrap_TextChanged(sender, e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().namingTrap_TextChanged(sender, e);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().namingTrap_TextChanged(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().namingTrap_TextChanged(sender, e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().namingTrap_TextChanged(sender, e);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = System.Text.RegularExpressions.Regex.Replace(textboxSender.Text, "[^0-9a-zA-Z,\\.@]|(\\.\\.)|(,,)|(@@)", "");
            textboxSender.SelectionStart = cursorPosition;
        }
    }
}
