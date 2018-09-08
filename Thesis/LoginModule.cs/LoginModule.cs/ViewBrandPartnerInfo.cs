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
            dateTimePicker1.Value = Convert.ToDateTime(read["col_dateofbirth"].ToString());
            comboBox1.Text = read["col_gender"].ToString();
            textBox5.Text = read["col_address"].ToString();
            textBox6.Text = read["col_contactnum"].ToString();
            textBox4.Text = read["col_brandname"].ToString();
            textBox7.Text = read["col_brandaddress"].ToString();
            textBox8.Text = read["col_brandcontactnum"].ToString();
            textBox9.Text = read["col_brandcontactnum"].ToString();

            textBox10.Text = read["col_brandcontactnum"].ToString();
            }

            conn.Close();

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
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
            "col_dateofbirth = '" + dateTimePicker1.Value + "', " +
            "col_gender = '" + comboBox1.SelectedItem.ToString() + "', " +
            "col_contactnum = '" + textBox6.Text + "', " +
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
            "WHERE col_useraccountsid='" + labelBrandpartnerId.Text + "'";
            command.CommandText = query;
            command.ExecuteScalar();
            conn.Close();
        }
    }
}
