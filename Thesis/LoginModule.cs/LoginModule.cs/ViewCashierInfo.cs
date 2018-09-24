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
    public partial class ViewCashierInfo : MaterialSkin.Controls.MaterialForm
    {
        public ViewCashierInfo(string label40)
        {
            InitializeComponent();
            labelCashierId.Text = label40;
            printCashierdetails();
        }
        public void printCashierdetails() 
        {

            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from tbl_useraccounts u " +
                "where u.col_useraccountsid = '" + labelCashierId.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();


            read.Read();
            textBox1.Text = read["col_firstname"].ToString();
            textBox2.Text = read["col_middlename"].ToString();
            textBox3.Text = read["col_lastname"].ToString();
            //dateTimePicker1.Value = Convert.ToDateTime(read["col_dateofbirth"].ToString());
            comboBox1.Text = read["col_gender"].ToString();
            textBox5.Text = read["col_address"].ToString();
            textBox6.Text = read["col_contactnum"].ToString();
            textBox9.Text = read["col_user"].ToString();
            textBox10.Text = read["col_password"].ToString();
            
            conn.Close();

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }

        public void update()
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "UPDATE tbl_useraccounts SET " +
            "col_firstname = '" + textBox1.Text + "', " +
            "col_middlename = '" + textBox2.Text + "', " +
            "col_lastname = '" + textBox3.Text + "', " +
            //"col_dateofbirth = '" + dateTimePicker1.Text + "', " +
            "col_gender = '" + comboBox1.SelectedItem.ToString() + "', " +
            "col_address = '" + textBox5.Text + "', " +
            "col_contactnum = '" + textBox6.Text + "', " +
            "col_user = '" + textBox9.Text + "', " +
            "col_password = '" + textBox10.Text + "' " +
            "WHERE col_useraccountsid='" + labelCashierId.Text + "'";
            command.CommandText = query;
            command.ExecuteScalar();
            conn.Close();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox9.Text) ||
                string.IsNullOrWhiteSpace(textBox11.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please don't leave any blank field(s).");
            }
            else if (textBox10.Text != textBox11.Text)
            {
                MessageBox.Show("Password does not match the confirm password.");
            }
            else
            {
                update();
                Mainframe a = new Mainframe();
                a.Show();
                this.Hide();
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
