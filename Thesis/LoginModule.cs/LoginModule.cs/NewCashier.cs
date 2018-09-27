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
    public partial class NewCashier : MaterialSkin.Controls.MaterialForm
    {
        public NewCashier()
        {
            InitializeComponent();
        }
        public void addnewCashierAccount() 
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            if (label1.Text == "")
            {
                MessageBox.Show("Complete the Form");
            }
            else
            {
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                command2.CommandText = "insert into tbl_useraccounts (col_usertypeid, " +
                    "col_user, " +
                    "col_password, " +
                    "col_lastname, " +
                    "col_firstname, " +
                    "col_middlename, " +
                    "col_address, " +
                    //"col_dateofbirth, " +
                    "col_gender, " +
                    "col_contactnum, " +
                    "col_status) " +
                    "values  ((SELECT col_usertypeid from tbl_usertype where col_userrole='Cashier'),'" +
                    textBox9.Text + "','" +
                    textBox11.Text + "','" +
                    textBox3.Text + "','" +
                    textBox1.Text + "','" +
                    textBox2.Text + "','" +
                    textBox5.Text + "','" +
                    //dateTimePicker1.Text + "','" +
                    comboBox1.SelectedItem.ToString() + "','" +
                    textBox6.Text +
                    "','unarchived')";
                command2.ExecuteScalar();
                conn.Close();
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
                string.IsNullOrWhiteSpace(textBox6.Text) )
            {
                MessageBox.Show("Please don't leave any blank field(s).");
            }
            else if (textBox10.Text != textBox11.Text)
            {
                MessageBox.Show("Password does not match the confirm password.");
            }
            else
            {
                addnewCashierAccount();
                Mainframe a = new Mainframe();
                a.Show();
                this.Hide();
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().namingTrap_TextChanged(sender, e);
        }
    }
}
