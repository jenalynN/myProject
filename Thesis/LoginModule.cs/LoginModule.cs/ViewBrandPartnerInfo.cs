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
    public partial class ViewBrandPartnerInfo : MaterialSkin.Controls.MaterialForm
    {
        private string tempPass;

        public ViewBrandPartnerInfo(string label15)
        {
            InitializeComponent();
            labelBrandpartnerId.Text = label15;
            printbrandpartnerdetails();
        }
        public void printbrandpartnerdetails() 
        {

            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            //string query = "select * from tbl_product where col_productid = '" + label4.Text + "'";
            string query = "select * from tbl_useraccounts u " +
                "inner join tbl_brandpartner b " +
                "on u.col_useraccountsid = b.col_useraccountsid " +
                "where u.col_useraccountsid = '" + labelBrandpartnerId.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();


            //while (read.Read())
            while (read.Read()){
            textBox1.Text = read["col_firstname"].ToString();
            textBox2.Text = read["col_middlename"].ToString();
            textBox3.Text = read["col_lastname"].ToString();
            //dateTimePicker1.Value = Convert.ToDateTime(read["col_dateofbirth"].ToString());
            comboBox1.Text = read["col_gender"].ToString();
            textBox5.Text = read["col_address"].ToString();
            textBox6.Text = read["col_contactnum"].ToString();
            textBox4.Text = read["col_brandname"].ToString();
            textBox7.Text = read["col_brandaddress"].ToString();
            textBox8.Text = read["col_brandcontactnum"].ToString();
            textBox9.Text = read["col_user"].ToString();
            textBox11.Text = read["col_brandemail"].ToString();
            textBox10.Text = read["col_password"].ToString();
            tempPass = textBox10.Text;
            }

            conn.Close();

        }
        public void updateBrandPartnert()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                string query = "UPDATE tbl_useraccounts SET " +
                "col_user = '" + textBox9.Text + "', " +
                "col_password = '" + textBox10.Text + "', " +
                "col_lastname = '" + textBox3.Text + "', " +
                "col_firstname = '" + textBox1.Text + "', " +
                "col_middlename = '" + textBox2.Text + "', " +
                "col_address = '" + textBox5.Text + "', " +
                //"col_dateofbirth = '" + dateTimePicker1.Value + "', " +
                "col_gender = '" + comboBox1.SelectedItem.ToString() + "', " +
                "col_contactnum = '" + textBox6.Text + "' " +
                //"col_brandemail ='" + textBox11.Text+"' "+
                "WHERE col_useraccountsid='" + labelBrandpartnerId.Text + "'";

                command.CommandText = query;
                command.ExecuteScalar();
                conn.Close();

                conn.Open();
                command = conn.CreateCommand();
                query = "UPDATE tbl_brandpartner SET " +
                "col_brandname = '" + textBox4.Text + "', " +
                "col_brandaddress = '" + textBox7.Text + "', " +
                "col_brandcontactnum = '" + textBox8.Text + "', " +
                "col_brandemail ='" + textBox11.Text + "' " +
                "WHERE col_useraccountsid='" + labelBrandpartnerId.Text + "'";
                command.CommandText = query;
                command.ExecuteScalar();
                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("No Connection to Host.");
            }

            MessageBox.Show("Successfully Updated!");
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox9.Text) ||
                (string.IsNullOrWhiteSpace(txtConfirmPass.Text) && txtConfirmPass.Enabled == true) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Please don't leave any blank field(s).");
            }
            else if (textBox10.Text != txtConfirmPass.Text && textBox10.Enabled == true)
            {
                MessageBox.Show("Password does not match the confirm password.");
            }
            else
            {
                updateBrandPartnert();
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            ChangePassword a = new ChangePassword(labelBrandpartnerId.Text);
            a.Show();
            this.Hide();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().numbersOnlyTrap_TextChanged(sender, e);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().numbersOnlyTrap_TextChanged(sender, e);

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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
        }

        private void chkChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChangePassword.Checked == true)
            {
                textBox10.Text = "";
                textBox10.Enabled = true;
                txtConfirmPass.Enabled = true;
            }
            else
            {
                textBox10.Text = tempPass;
                textBox10.Enabled = false;
                txtConfirmPass.Enabled = false;
                txtConfirmPass.Text = "";
            }
        }
    }
}
