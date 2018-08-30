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
    public partial class NewProduct : MaterialSkin.Controls.MaterialForm
    {


        string myConnection = "Server=localhost;Database=db_poshandfabconceptstore;Uid=root;Password=";
        public NewProduct()
        {
            InitializeComponent();
            viewcategory();
            viewbrand();
        }
        public void viewcategory()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            comboBox2.Items.Clear();
            conn.Close();

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
        public void viewbrand() 
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            comboBox1.Items.Clear();
            conn.Close();

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from tbl_branduser";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                comboBox1.Items.Add(read["col_brandname"].ToString());
            }
            conn.Close();
        
        }
        public void additem() 
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            MySqlCommand command = conn.CreateCommand();
            conn.Close();
            conn.Open();
            if (label1.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else
            {
                conn.Close();
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                command2.CommandText = "insert into tbl_product (col_brandid,col_categoryid,col_productcode,col_productprice,col_status) values  ((SELECT col_brandid from tbl_branduser where col_brandname='" + comboBox1.Text + "'),(SELECT col_categoryid from tbl_category where col_categoryname='" + comboBox2.Text + "'),'" + textBox1.Text + "','"+textBox2.Text+ "','unarchived')";
                command2.ExecuteScalar();
                conn.Close();
                MessageBox.Show("Successfully Added!");
                Mainframe a = new Mainframe();
                a.Show();
                this.Close();
            }
        }
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            additem();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Close();
        }
    }
}
