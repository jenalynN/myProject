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
using System.Text.RegularExpressions;

namespace LoginModule.cs
{
    public partial class NewProduct : MaterialSkin.Controls.MaterialForm
    {
        public NewProduct()
        {
            InitializeComponent();
            viewcategory();
            viewbrand();
        }
        public void viewcategory()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                comboBox2.Items.Clear();

                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                string query = "select * from tbl_category";
                command.CommandText = query;
                MySqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    comboBox2.Items.Add(read["col_categoryname"].ToString());

                }
                conn.Close();
            }
            catch (Exception e) 
            {
                MessageBox.Show("No connection to host");
            }
        }
        public void viewbrand()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                comboBox1.Items.Clear();

                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                string query = "select * from tbl_brandpartner";
                command.CommandText = query;
                MySqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    comboBox1.Items.Add(read["col_brandname"].ToString());
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No connection to host");
            }
        }

        public void additem()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select * from tbl_product where col_productcode = '" + textBox1.Text + "' ";
                MySqlDataReader read = command.ExecuteReader();

                int count = 0;
                while (read.Read())
                {
                    count++;
                }
                conn.Close();

                if (count >= 1)
                {
                    MessageBox.Show("The product code is already taken, please try another one");
                }
                else
                {
                    conn.Open();
                    MySqlCommand command2 = conn.CreateCommand();
                    command2.CommandText = "insert into tbl_product (col_useraccountsid, col_categoryid, col_productcode, col_productname, col_productprice, col_status) " +
                        "values  ((SELECT col_useraccountsid from tbl_brandpartner where col_brandname='" + comboBox1.Text + "' limit 1)," +
                        "(SELECT col_categoryid from tbl_category c inner join tbl_brandpartner b on c.col_useraccountsid = b.col_useraccountsid where b.col_brandname='" + comboBox1.Text + "' and col_categoryname= '" + comboBox2.Text + "' limit 1),'" +
                        textBox1.Text + "','" +
                        textBox3.Text + "', round(" +
                        textBox2.Text + ",2),'unarchived')";

                    command2.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Successfully Added!");
                    Mainframe a = new Mainframe();
                    a.Show();
                    this.Close();
                }
            
            }
            catch (Exception e) 
            {
                MessageBox.Show("No connection to host");
            }
        }
        
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
                double b;
                bool isBValid = double.TryParse(textBox2.Text, out b);
            if (string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please don't leave any blank field(s).");
            }
            else if (textBox2.Text == ".")
            {
                MessageBox.Show("Invalid Price value.");
            }
            else if(b <= 0)
            {
                MessageBox.Show("Price should be greater than 0");
            }
            else
            {
                additem();
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            
                Mainframe a = new Mainframe();
                a.Show();
                this.Close();
            
        }

        //private void textBox2_TextChanged(object sender, KeyPressEventArgs e)
        //{
        //    new DataHandling().decimalNumberTrap_KeyPress(sender, e);
        //    //if (string.IsNullOrWhiteSpace(textBox2.Text))
        //    //{
        //    //    textBox2.Text = "1.00";
        //    //}
        //    //else if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "(\\..*\\.)|[^\\d+\\.\\d+]|[^\\.\\d+]"))
        //    //{
        //    //    //MessageBox.Show("Please enter only numbers.");
        //    //    textBox2.Text = "1.00";
        //    //}
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Text = "";
                comboBox2.Items.Clear();
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                string query = "select * from tbl_category c " +
                "inner join tbl_brandpartner b " +
                "on c.col_useraccountsid = b.col_useraccountsid " +
                "where b.col_brandname='" + comboBox1.Text + "'";
                command.CommandText = query;
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    comboBox2.Items.Add(read["col_categoryname"].ToString());
                }
                conn.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("No connection to host");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void genericTextBoxTrim_Leave(object sender, EventArgs e)
        {
            new DataHandling().genericTextBoxTrim_Leave(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
