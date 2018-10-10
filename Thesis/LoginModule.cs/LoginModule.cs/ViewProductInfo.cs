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
    public partial class ViewProductInfo : MaterialSkin.Controls.MaterialForm
    {

        //string myConnection = "Server=localhost;Database=db_poshconceptstorefinal;Uid=root;Password="; 
        public ViewProductInfo(string materialSingleLineTextField5)
        {
            InitializeComponent();
            label4.Text = materialSingleLineTextField5;
            printdata();
        }
        public void printdata()
        {
            try
            {

                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                //string query = "select * from tbl_product where col_productid = '" + label4.Text + "'";
                string query = "select * from tbl_product p " +
                    "inner join tbl_brandpartner b " +
                    "on p.col_useraccountsid = b.col_useraccountsid " +
                    "inner join tbl_category c " +
                    "on c.col_categoryid = p.col_categoryid " +
                    "where p.col_productid = '" + label4.Text + "'";
                command.CommandText = query;
                MySqlDataReader read = command.ExecuteReader();


                //while (read.Read())
                read.Read();
                label4.Text = read["col_productid"].ToString();
                textBox1.Text = read["col_productcode"].ToString();
                txtProductName.Text = read["col_productname"].ToString();
                lblBrandId.Text = read["col_useraccountsid"].ToString();
                lblCategoryId.Text = read["col_categoryid"].ToString();
                comboBox1.Text = read["col_brandname"].ToString();
                comboBox2.Text = read["col_categoryname"].ToString();
                textBox2.Text = read["col_productprice"].ToString();
                textBox4.Text = read["col_status"].ToString();

                conn.Close();

                conn.Open();

                query = "select * from tbl_brandpartner p ";
                command.CommandText = query;
                read = command.ExecuteReader();
                while (read.Read())
                {
                    comboBox1.Items.Add(read["col_brandname"].ToString());
                }
                conn.Close();

                conn.Open();

                query = "select * from tbl_category c " +
                "inner join tbl_brandpartner b " +
                "on c.col_useraccountsid = b.col_useraccountsid " +
                "where b.col_useraccountsid = '" + lblBrandId.Text + "'";
                command.CommandText = query;
                read = command.ExecuteReader();
                while (read.Read())
                {
                    comboBox2.Items.Add(read["col_categoryname"].ToString());
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No connection to host");
            }

        }

        public void update()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                string query = "UPDATE tbl_product SET " +
                "col_productcode = '" + textBox1.Text + "', " +
                "col_productname = '" + txtProductName.Text + "', " +
                "col_productprice = round(" + textBox2.Text + ",2), " +
                "col_useraccountsid = '" + lblBrandId.Text + "', " +
                "col_categoryid = '" + lblCategoryId.Text + "' " +
                "WHERE col_productid='" + label4.Text + "'";
                command.CommandText = query;
                command.ExecuteScalar();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No connection to host");
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            double b;
            bool isBValid = double.TryParse(textBox2.Text, out b);
            if (string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please don't leave any blank field(s).");
            }
            else if (textBox2.Text == ".")
            {
                MessageBox.Show("Invalid Price value.");
            }
            else if (b <= 0)
            {
                MessageBox.Show("Price should be greater than 0");
            }
            else
            {
                update();
                Mainframe a = new Mainframe();
                a.Show();
                this.Hide();
            }
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.ShowDialog();
            this.Hide();
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                string query = "select * from tbl_brandpartner b " +
                    "where col_brandname = '" + comboBox1.Text + "'";
                command.CommandText = query;
                MySqlDataReader read = command.ExecuteReader();
                read.Read();
                lblBrandId.Text = read["col_useraccountsid"].ToString();
                conn.Close();
                comboBox2.Text = "";
                comboBox2.Items.Clear();

                conn.Open();

                query = "select * from tbl_category c " +
                "inner join tbl_brandpartner b " +
                "on c.col_useraccountsid = b.col_useraccountsid " +
                "where b.col_useraccountsid = '" + lblBrandId.Text + "'";
                command.CommandText = query;
                read = command.ExecuteReader();
                while (read.Read())
                {
                    comboBox2.Items.Add(read["col_categoryname"].ToString());
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No connection to host");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                string query = "select * from tbl_category b " +
                    "where col_categoryname = '" + comboBox2.Text + "'";
                command.CommandText = query;
                MySqlDataReader read = command.ExecuteReader();
                read.Read();
                lblCategoryId.Text = read["col_categoryid"].ToString();
                conn.Close();
            }
            catch (MySqlException )
            {
                MessageBox.Show("No connection to host");
            }
        }
        

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            new DataHandling().decimalNumberTrap_KeyPress(sender, e);
        }
    }
}
