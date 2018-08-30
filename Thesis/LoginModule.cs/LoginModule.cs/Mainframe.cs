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
    public partial class Mainframe : MaterialSkin.Controls.MaterialForm
    {

        string myConnection = "Server=localhost;Database=db_poshconceptstorefinal;Uid=root;Password="; 
        public Mainframe()
        {
            InitializeComponent();
            launch();
        }
        public void launch() 
        {
            dataproductunarchived();
            dataproductarchived();
            countunarchiveditems();
            countarchiveditems();
            databrandpartneraccountunarchived();
        }
        public void printunarchivedproduct()
        {
            int data = 0;
            ListViewItem list = materialListView1.SelectedItems[data];
            String id = list.SubItems[0].Text;
            label6.Text = id.ToString();
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from tbl_product p " +
                "inner join tbl_brandpartner b " +
                "on p.col_useraccountsid = b.col_useraccountsid " +
                "inner join tbl_category c " +
                "on c.col_categoryid = p.col_categoryid " +
                "where p.col_productid = '" + label6.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            conn.Close();

        }
        public void countunarchiveditems()
        {

            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            MySqlCommand command2 = conn.CreateCommand();
            command.Connection = conn;
            command.CommandText = "select COUNT(col_productid) AS '" + "items" + "' from tbl_product where col_status='unarchived'";


            MySqlDataReader read = command.ExecuteReader();


            while (read.Read())
            {
              label1.Text = read["items"].ToString();
            }
        }
        public void countarchiveditems()
        {

            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            MySqlCommand command2 = conn.CreateCommand();
            command.Connection = conn;
            command.CommandText = "select COUNT(col_productid) AS '" + "items" + "' from tbl_product where col_status='archived'";


            MySqlDataReader read = command.ExecuteReader();


            while (read.Read())
            {
                label13.Text =  read["items"].ToString();
            }
        }
        public void databrandpartneraccountunarchived()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Close();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query = "select * from tbl_brandpartner b " +
                "inner join tbl_useraccounts u " +
                "on b.col_useraccountsid = u.col_useraccountsid " +
                "where u.col_status='unarchived'";
            command.CommandText = query;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem items = new ListViewItem(read["col_useraccountsid"].ToString());

                items.SubItems.Add(read["col_brandname"].ToString());
                items.SubItems.Add(read["col_user"].ToString());
                items.SubItems.Add(read["col_password"].ToString());
                items.SubItems.Add(read["col_lastname"].ToString());
                items.SubItems.Add(read["col_firstname"].ToString());   
                items.SubItems.Add(read["col_middlename"].ToString());;
                items.SubItems.Add(read["col_address"].ToString());
                items.SubItems.Add(read["col_dateofbirth"].ToString());
                items.SubItems.Add(read["col_gender"].ToString());
                items.SubItems.Add(read["col_contactnum"].ToString());



                materialListView3.Items.Add(items);
                materialListView3.FullRowSelect = true;
            }
            conn.Close();

        
        }
        public void dataproductunarchived() 
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select P.col_productid,P.col_productcode, B.col_brandname,  C.col_categoryname,  P.col_productprice " +
                "from tbl_product P " +
                "LEFT JOIN tbl_brandpartner B ON P.col_useraccountsid = B.col_useraccountsid " +
                "LEFT JOIN tbl_category C ON C.col_categoryid = P.col_categoryid " +
                "where P.col_status='unarchived'";

            command.CommandText = query;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem items = new ListViewItem(read["col_productid"].ToString());

                items.SubItems.Add(read["col_brandname"].ToString());
                items.SubItems.Add(read["col_categoryname"].ToString());

                items.SubItems.Add(read["col_productcode"].ToString());
                items.SubItems.Add(read["col_productprice"].ToString());

              

                materialListView1.Items.Add(items);
                materialListView1.FullRowSelect = true;
            }
            conn.Close();
        
        
        }
        public void dataproductarchived()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Close();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query = "select * from tbl_product where col_status='archived'";
            command.CommandText = query;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem items = new ListViewItem(read["col_productid"].ToString());

                items.SubItems.Add(read["col_brandid"].ToString());
                items.SubItems.Add(read["col_productcode"].ToString());
                items.SubItems.Add(read["col_productquantity"].ToString());
                items.SubItems.Add(read["col_productprice"].ToString());



                materialListView2.Items.Add(items);
                materialListView2.FullRowSelect = true;
            }
            conn.Close();


        }
        public void searchunarchived() 
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            materialListView1.Items.Clear();
            conn.Open();
            string query1 = "select * from tbl_product  where col_productcode like  '" + textBox1.Text + "%'  and col_status='unarchived'";

            MySqlCommand command2 = conn.CreateCommand();
            command2.CommandText = query1;
            MySqlDataReader read = command2.ExecuteReader();
            while (read.Read())
            {

                ListViewItem items = new ListViewItem(read["col_productid"].ToString());
                items.SubItems.Add(read["col_brandid"].ToString());
                items.SubItems.Add(read["col_productcode"].ToString());
                items.SubItems.Add(read["col_productquantity"].ToString());
                items.SubItems.Add(read["col_productprice"].ToString());

              
                materialListView1.Items.Add(items);
                materialListView1.FullRowSelect = true;
            }
            conn.Close();
        
        }
        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


  
        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Mainframe_Load(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Close();
        }

        private void materialTabSelector4_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {

        }

        private void materialContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            searchunarchived();
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            NewProduct a = new NewProduct();
            a.Show();
            this.Close();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            
            NewProduct a = new NewProduct();
            a.Show();
            this.Close();
        
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (label6.Text == "SI") 
            {
                DialogSelectRecordBelow a = new DialogSelectRecordBelow();
                a.Show();
            
            }
            else
            {
                ViewProductInfo a = new ViewProductInfo(label6.Text);
                a.Show();
                this.Hide();
            }
        
        }

        private void materialListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (materialListView1.SelectedItems.Count > 0)
            {
                ListViewItem item = materialListView1.SelectedItems[0];
                label6.Text = item.SubItems[0].Text;
               

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchunarchived();
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }


        private void materialFlatButton6_Click_1(object sender, EventArgs e)
        {
            if (label6.Text == "SI")
            {
                DialogSelectRecordBelow a = new DialogSelectRecordBelow();
                a.Show();

            }
            else
            {
                ViewProductStockInfo a = new ViewProductStockInfo(label6.Text);
                a.Show();
                this.Hide();
            }
        }

        private void groupBox28_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
