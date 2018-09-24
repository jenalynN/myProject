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
            databrandpartneraccountarchived();
            dataCashierAccountUnarchived();
            dataCashierAccountArchived();
        }
        public void databrandpartneraccountarchived() 
        {
            materialListView6.Items.Clear();
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

            conn.Open();        
            MySqlCommand command = conn.CreateCommand();

            string query = "select * from tbl_brandpartner b " +
                "inner join tbl_useraccounts u " +
                "on b.col_useraccountsid = u.col_useraccountsid " +
                "inner join tbl_usertype t " +
                "on t.col_usertypeid = u.col_usertypeid " +
                "where u.col_status='archived' and t.col_usertypeid=3";
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
                items.SubItems.Add(read["col_middlename"].ToString()); ;
                items.SubItems.Add(read["col_address"].ToString());
                //items.SubItems.Add(read["col_dateofbirth"].ToString());
                items.SubItems.Add(read["col_gender"].ToString());
                items.SubItems.Add(read["col_contactnum"].ToString());



                materialListView6.Items.Add(items);
                materialListView6.FullRowSelect = true;
            }
            conn.Close();
        
        }
        public void printunarchivedproduct()
        {
            int data = 0;
            ListViewItem list = materialListView1.SelectedItems[data];
            String id = list.SubItems[0].Text;
            label6.Text = id.ToString();
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

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
        public void printarchivedproduct()
        {
            int data = 0;
            ListViewItem list = materialListView2.SelectedItems[data];
            String id = list.SubItems[0].Text;
            label9.Text = id.ToString();
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from tbl_product p " +
                "inner join tbl_brandpartner b " +
                "on p.col_useraccountsid = b.col_useraccountsid " +
                "inner join tbl_category c " +
                "on c.col_categoryid = p.col_categoryid " +
                "where p.col_productid = '" + label9.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            conn.Close();
        }
        public void unarchiveproduct() 
        {
        
        }
        public void countunarchiveditems()
        {

            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

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

            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

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
            materialListView3.Items.Clear();
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

            conn.Close();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query = "select * from tbl_brandpartner b " +
                "inner join tbl_useraccounts u " +
                "on b.col_useraccountsid = u.col_useraccountsid " +
                "inner join tbl_usertype t " +
                "on t.col_usertypeid = u.col_usertypeid " +
                "where u.col_status='unarchived' and t.col_usertypeid=3";
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
                //items.SubItems.Add(read["col_dateofbirth"].ToString());
                items.SubItems.Add(read["col_gender"].ToString());
                items.SubItems.Add(read["col_contactnum"].ToString());



                materialListView3.Items.Add(items);
                materialListView3.FullRowSelect = true;
            }
            conn.Close();

        
        }
        public void dataCashierAccountUnarchived()
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from tbl_useraccounts u " +
                "inner join tbl_usertype t " +
                "on t.col_usertypeid = u.col_usertypeid " +
                "where u.col_status='unarchived' and t.col_usertypeid=2";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem items = new ListViewItem(read["col_useraccountsid"].ToString());
                items.SubItems.Add(read["col_user"].ToString());
                items.SubItems.Add(read["col_password"].ToString());
                items.SubItems.Add(read["col_lastname"].ToString());
                items.SubItems.Add(read["col_firstname"].ToString());
                items.SubItems.Add(read["col_middlename"].ToString()); ;
                items.SubItems.Add(read["col_address"].ToString());
                //items.SubItems.Add(read["col_dateofbirth"].ToString());
                items.SubItems.Add(read["col_gender"].ToString());
                items.SubItems.Add(read["col_contactnum"].ToString());

                materialListView5.Items.Add(items);
                materialListView5.FullRowSelect = true;
            }
            conn.Close();
        }

        public void dataCashierAccountArchived()
        {
            materialListView4.Items.Clear();
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from tbl_useraccounts u " +
                "inner join tbl_usertype t " +
                "on t.col_usertypeid = u.col_usertypeid " +
                "where u.col_status='archived' and t.col_usertypeid=2";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem items = new ListViewItem(read["col_useraccountsid"].ToString());
                items.SubItems.Add(read["col_user"].ToString());
                items.SubItems.Add(read["col_password"].ToString());
                items.SubItems.Add(read["col_lastname"].ToString());
                items.SubItems.Add(read["col_firstname"].ToString());
                items.SubItems.Add(read["col_middlename"].ToString()); ;
                items.SubItems.Add(read["col_address"].ToString());
                //items.SubItems.Add(read["col_dateofbirth"].ToString());
                items.SubItems.Add(read["col_gender"].ToString());
                items.SubItems.Add(read["col_contactnum"].ToString());

                materialListView4.Items.Add(items);
                materialListView4.FullRowSelect = true;
            }
            conn.Close();
        }

        public void dataproductunarchived()
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from tbl_product P " +
                "INNER JOIN tbl_brandpartner B ON P.col_useraccountsid = B.col_useraccountsid " +
                "INNER JOIN tbl_category C ON C.col_categoryid = P.col_categoryid " +
                "where P.col_status='unarchived'";

            command.CommandText = query;


            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {

                ListViewItem items = new ListViewItem(read["col_productid"].ToString());
                items.SubItems.Add(read["col_productcode"].ToString());
                items.SubItems.Add(read["col_productname"].ToString());
                items.SubItems.Add(read["col_brandname"].ToString());
                items.SubItems.Add(read["col_categoryname"].ToString());
                items.SubItems.Add(read["col_productprice"].ToString());

                materialListView1.Items.Add(items);
                materialListView1.FullRowSelect = true;
            }
            conn.Close();


        }
        public void dataproductarchived()
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            materialListView2.Items.Clear();
            conn.Close();
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from tbl_product P " +
                "INNER JOIN tbl_brandpartner B ON P.col_useraccountsid = B.col_useraccountsid " +
                "INNER JOIN tbl_category C ON C.col_categoryid = P.col_categoryid " +
                "where P.col_status='archived'";
            //string query = "select * from tbl_product where col_status='archived'";
            command.CommandText = query;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem items = new ListViewItem(read["col_productid"].ToString());


                items.SubItems.Add(read["col_productcode"].ToString());
                items.SubItems.Add(read["col_productname"].ToString());
                items.SubItems.Add(read["col_brandname"].ToString());
                items.SubItems.Add(read["col_categoryname"].ToString());
                items.SubItems.Add(read["col_productprice"].ToString());

                materialListView2.Items.Add(items);
                materialListView2.FullRowSelect = true;
            }
            conn.Close();

        }
        public void searchunarchived()
        {
            string search = "col_productcode";
            string searchby = null;
            try {
                searchby = comboBox1.SelectedItem.ToString();
            }
            catch (Exception e) { //MessageBox.Show(e.ToString());  
            }

            if (searchby != null)
                {
                    if (searchby == "Product Code")
                    {
                        search = "col_productcode";
                    }
                    else if (searchby == "Product Brand")
                    {
                        search = "col_brandname";
                    }
                    else if (searchby == "Product Name")
                    {
                        search = "col_productname";
                    }
                    else if (searchby == "Category")
                    {
                        search = "col_categoryname";
                    }
                }

            string query = "select * from tbl_product P " +
                "INNER JOIN tbl_brandpartner B ON P.col_useraccountsid = B.col_useraccountsid " +
                "INNER JOIN tbl_category C ON C.col_categoryid = P.col_categoryid " +
                "where P.col_productcode like  '" + textBox1.Text + "%' and P.col_status='unarchived'";

            if (searchby != null)
            {
                query = "select * from tbl_product P " +
                "INNER JOIN tbl_brandpartner B ON P.col_useraccountsid = B.col_useraccountsid " +
                "INNER JOIN tbl_category C ON C.col_categoryid = P.col_categoryid " +
                "where " + search + " like  '" + textBox1.Text + "%' and P.col_status='unarchived'";
            }

            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            materialListView1.Items.Clear();
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.CommandText = query;
            MySqlDataReader read = command2.ExecuteReader();
            while (read.Read())
            {
                ListViewItem items = new ListViewItem(read["col_productid"].ToString());
                items.SubItems.Add(read["col_productcode"].ToString());
                items.SubItems.Add(read["col_productname"].ToString());
                items.SubItems.Add(read["col_brandname"].ToString());
                items.SubItems.Add(read["col_categoryname"].ToString());
                items.SubItems.Add(read["col_productprice"].ToString());
                materialListView1.Items.Add(items);
                materialListView1.FullRowSelect = true;
            }
            conn.Close();
        }

        public void searcharchived()
        {
            string search = "col_productcode";
            string searchby = null;
            try
            {
                searchby = comboBox3.SelectedItem.ToString();
            }
            catch (Exception e)
            { //MessageBox.Show(e.ToString());  
            }

            if (searchby != null)
            {
                if (searchby == "Product Code")
                {
                    search = "col_productcode";
                }
                else if (searchby == "Product Brand")
                {
                    search = "col_brandname";
                }
                else if (searchby == "Product Name")
                {
                    search = "col_productname";
                }
                else if (searchby == "Category")
                {
                    search = "col_categoryname";
                }
            }

            string query = "select * from tbl_product P " +
                "INNER JOIN tbl_brandpartner B ON P.col_useraccountsid = B.col_useraccountsid " +
                "INNER JOIN tbl_category C ON C.col_categoryid = P.col_categoryid " +
                "where P.col_productcode like  '" + textBox2.Text + "%' and P.col_status='archived'";

            if (searchby != null)
            {
                query = "select * from tbl_product P " +
                "INNER JOIN tbl_brandpartner B ON P.col_useraccountsid = B.col_useraccountsid " +
                "INNER JOIN tbl_category C ON C.col_categoryid = P.col_categoryid " +
                "where " + search + " like  '" + textBox2.Text + "%' and P.col_status='archived'";
            }

            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            materialListView2.Items.Clear();
            conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.CommandText = query;
            MySqlDataReader read = command2.ExecuteReader();
            while (read.Read())
            {
                ListViewItem items = new ListViewItem(read["col_productid"].ToString());
                items.SubItems.Add(read["col_productcode"].ToString());
                items.SubItems.Add(read["col_productname"].ToString());
                items.SubItems.Add(read["col_brandname"].ToString());
                items.SubItems.Add(read["col_categoryname"].ToString());
                items.SubItems.Add(read["col_productprice"].ToString());
                materialListView2.Items.Add(items);
                materialListView2.FullRowSelect = true;
            }
            conn.Close();
        }
        public void searchunarchivedbp()
        {
            string search = "b.col_brandname";
            string searchby = null;
            try
            {
                searchby = comboBox5.SelectedItem.ToString();
            }
            catch (Exception e)
            { //MessageBox.Show(e.ToString());  
            }

            if (searchby != null)
            {
                if (searchby == "Brandname")
                {
                    search = "b.col_brandname";
                }
                else if (searchby == "Lastname")
                {
                    search = "u.col_lastname";
                }
                else if (searchby == "Firstname")
                {
                    search = "u.col_firstname";
                }
                else if (searchby == "Username")
                {
                    search = "u.col_user";
                }


                string query = "select * from tbl_brandpartner b " +
                    "inner join tbl_useraccounts u " +
                    "on b.col_useraccountsid = u.col_useraccountsid " +
                    "inner join tbl_usertype t " +
                    "on t.col_usertypeid = u.col_usertypeid " +
                    "where b.col_brandname like '" + textBox3.Text + "%' and u.col_status='unarchived' and t.col_usertypeid=3";

                if (searchby != null)
                {
                    query = "select * from tbl_brandpartner b " +
                   "inner join tbl_useraccounts u " +
                   "on b.col_useraccountsid = u.col_useraccountsid " +
                   "inner join tbl_usertype t " +
                   "on t.col_usertypeid = u.col_usertypeid " +
                    "where " + search + " like  '" + textBox3.Text + "%'and u.col_status='unarchived' and t.col_usertypeid=3";
                }
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                materialListView3.Items.Clear();
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                command2.CommandText = query;
                MySqlDataReader read = command2.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem items = new ListViewItem(read["col_useraccountsid"].ToString());

                    items.SubItems.Add(read["col_brandname"].ToString());
                    items.SubItems.Add(read["col_user"].ToString());
                    items.SubItems.Add(read["col_password"].ToString());
                    items.SubItems.Add(read["col_lastname"].ToString());
                    items.SubItems.Add(read["col_firstname"].ToString());
                    items.SubItems.Add(read["col_middlename"].ToString()); ;
                    items.SubItems.Add(read["col_address"].ToString());
                    //items.SubItems.Add(read["col_dateofbirth"].ToString());
                    items.SubItems.Add(read["col_gender"].ToString());
                    items.SubItems.Add(read["col_contactnum"].ToString());

                    materialListView3.Items.Add(items);
                    materialListView3.FullRowSelect = true;
                }
                conn.Close();
            }
        }

        public void searcharchivedbp()
        {
            string search = "b.col_brandname";
            string searchby = null;
            try
            {
                searchby = comboBox6.SelectedItem.ToString();
            }
            catch (Exception e)
            { //MessageBox.Show(e.ToString());  
            }

            if (searchby != null)
            {
                if (searchby == "Brandname")
                {
                    search = "b.col_brandname";
                }
                else if (searchby == "Lastname")
                {
                    search = "u.col_lastname";
                }
                else if (searchby == "Firstname")
                {
                    search = "u.col_firstname";
                }
                else if (searchby == "Username")
                {
                    search = "u.col_user";
                }


                string query = "select * from tbl_brandpartner b " +
                    "inner join tbl_useraccounts u " +
                    "on b.col_useraccountsid = u.col_useraccountsid " +
                    "inner join tbl_usertype t " +
                    "on t.col_usertypeid = u.col_usertypeid " +
                    "where b.col_brandname like '" + textBox4.Text + "%' and col_status='archived' and col_usertypeid=3";

                if (searchby != null)
                {
                    query = "select * from tbl_brandpartner b " +
                   "inner join tbl_useraccounts u " +
                   "on b.col_useraccountsid = u.col_useraccountsid " +
                   "inner join tbl_usertype t " +
                   "on t.col_usertypeid = u.col_usertypeid " +
                    "where " + search + " like  '" + textBox4.Text + "%'and col_status='archived' and col_usertypeid=3";
                }
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                materialListView6.Items.Clear();
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                command2.CommandText = query;
                MySqlDataReader read = command2.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem items = new ListViewItem(read["col_useraccountsid"].ToString());

                    items.SubItems.Add(read["col_user"].ToString());
                    items.SubItems.Add(read["col_password"].ToString());
                    items.SubItems.Add(read["col_lastname"].ToString());
                    items.SubItems.Add(read["col_firstname"].ToString());
                    items.SubItems.Add(read["col_middlename"].ToString()); ;
                    items.SubItems.Add(read["col_address"].ToString());
                    //items.SubItems.Add(read["col_dateofbirth"].ToString());
                    items.SubItems.Add(read["col_gender"].ToString());
                    items.SubItems.Add(read["col_contactnum"].ToString());

                    materialListView6.Items.Add(items);
                    materialListView6.FullRowSelect = true;
                }
                conn.Close();
            }
        }
        public void searchunarchivedcashier()
        {
            string search = "u.col_lastname";
            string searchby = null;
            try
            {
                searchby = comboBox8.SelectedItem.ToString();
            }
            catch (Exception e)
            { //MessageBox.Show(e.ToString());  
            }

            if (searchby != null)
            {
                if (searchby == "Lastname")
                {
                    search = "col_lastname";
                }
                else if (searchby == "Firstname")
                {
                    search = "col_firstname";
                }
                else if (searchby == "Username")
                {
                    search = "col_user";
                }

                string query = "select * from tbl_useraccounts  " +
                    "where col_lastname like '" + textBox7.Text + "%' and col_status='unarchived' and col_usertypeid=2";

                if (searchby != null)
                {
                    query = "select * from tbl_useraccounts " +
                    "where " + search + " like  '" + textBox7.Text + "%'and col_status='unarchived' and col_usertypeid=2";
                }
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                materialListView5.Items.Clear();
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                command2.CommandText = query;
                MySqlDataReader read = command2.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem items = new ListViewItem(read["col_useraccountsid"].ToString());

                    items.SubItems.Add(read["col_user"].ToString());
                    items.SubItems.Add(read["col_password"].ToString());
                    items.SubItems.Add(read["col_lastname"].ToString());
                    items.SubItems.Add(read["col_firstname"].ToString());
                    items.SubItems.Add(read["col_middlename"].ToString()); ;
                    items.SubItems.Add(read["col_address"].ToString());
                    //items.SubItems.Add(read["col_dateofbirth"].ToString());
                    items.SubItems.Add(read["col_gender"].ToString());
                    items.SubItems.Add(read["col_contactnum"].ToString());

                    materialListView5.Items.Add(items);
                    materialListView5.FullRowSelect = true;
                }
                conn.Close();
            }
        }
        public void searcharchivedcashier()
        {
            string search = "u.col_lastname";
            string searchby = null;
            try
            {
                searchby = comboBox4.SelectedItem.ToString();
            }
            catch (Exception e)
            { //MessageBox.Show(e.ToString());  
            }

            if (searchby != null)
            {
                if (searchby == "Lastname")
                {
                    search = "col_lastname";
                }
                else if (searchby == "Firstname")
                {
                    search = "col_firstname";
                }
                else if (searchby == "Username")
                {
                    search = "col_user";
                }

                string query = "select * from tbl_useraccounts  " +
                    "where col_lastname like '" + textBox6.Text + "%' and col_status='archived' and col_usertypeid=2";

                if (searchby != null)
                {
                    query = "select * from tbl_useraccounts " +
                    "where " + search + " like  '" + textBox6.Text + "%'and col_status='archived' and col_usertypeid=2";
                }
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                materialListView4.Items.Clear();
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                command2.CommandText = query;
                MySqlDataReader read = command2.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem items = new ListViewItem(read["col_useraccountsid"].ToString());

                    items.SubItems.Add(read["col_user"].ToString());
                    items.SubItems.Add(read["col_password"].ToString());
                    items.SubItems.Add(read["col_lastname"].ToString());
                    items.SubItems.Add(read["col_firstname"].ToString());
                    items.SubItems.Add(read["col_middlename"].ToString()); ;
                    items.SubItems.Add(read["col_address"].ToString());
                    //items.SubItems.Add(read["col_dateofbirth"].ToString());
                    items.SubItems.Add(read["col_gender"].ToString());
                    items.SubItems.Add(read["col_contactnum"].ToString());

                    materialListView4.Items.Add(items);
                    materialListView4.FullRowSelect = true;
                }
                conn.Close();
            }
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Close();
        }
        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            //searchunarchived();
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "UPDATE tbl_product p SET " +
            "col_status = 'archived' " +
            "where p.col_productid = '" + label6.Text + "'";
            command.CommandText = query;
            command.ExecuteScalar();
            conn.Close();

            materialListView1.Items.Clear();
            materialListView2.Items.Clear();

            dataproductunarchived();
            dataproductarchived();
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
            this.Hide();
        
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
        private void materialRaisedButton1_Click_2(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
            NewBrandPartnerAccount a = new NewBrandPartnerAccount();
            a.Show();
            this.Hide();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void materialListView2_DoubleClick(object sender, EventArgs e)
        {
            printarchivedproduct();
        }

        private void materialFlatButton20_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "UPDATE tbl_product p SET " +
            "col_status = 'unarchived' " +
            "where p.col_productid = '" + label9.Text + "'";
            command.CommandText = query;
            command.ExecuteScalar();
            conn.Close();

            materialListView1.Items.Clear();
            materialListView2.Items.Clear();

            dataproductunarchived();
            dataproductarchived();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            searchunarchived();
        }

		private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            searchunarchived();
            
        }

        private void materialFlatButton23_Click(object sender, EventArgs e)
        {
            if (label15.Text != "SI")
            {
                ViewBrandPartnerInfo a = new ViewBrandPartnerInfo(label15.Text);
                a.Show();
                this.Hide();
            }
        }
        public void printbrandpartnerunarchived() 
        {
            int data = 0;
            ListViewItem list = materialListView3.SelectedItems[data];
            String id = list.SubItems[0].Text;
            label15.Text = id.ToString();
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
          
            conn.Close();
        }
        public void printbrandpartnerarchived()
        {
            int data = 0;
            ListViewItem list = materialListView6.SelectedItems[data];
            String id = list.SubItems[0].Text;
            label21.Text = id.ToString();
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            conn.Close();
        }
        private void materialListView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            printbrandpartnerunarchived();
        }
		public void archivedbrandpartner()
        {
		    MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "UPDATE tbl_useraccounts SET " +
            "col_status = 'archived'" +
            "WHERE col_useraccountsid='" + label15.Text + "'";
            command.CommandText = query;
            command.ExecuteScalar();
            conn.Close();
        }
		private void materialFlatButton9_Click(object sender, EventArgs e)
        {
            archivedbrandpartner();
            materialListView6.Items.Clear();
            materialListView3.Items.Clear();
            databrandpartneraccountunarchived();
            databrandpartneraccountarchived();
        }

        private void materialListView6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            printbrandpartnerarchived();
        }

        private void materialFlatButton15_Click(object sender, EventArgs e)
        {
            NewCashier a = new NewCashier();
            a.Show();
            this.Hide();
        }
        private void materialFlatButton17_Click(object sender, EventArgs e)
        {
            if (label40.Text != "SI")
            {
                ViewCashierInfo a = new ViewCashierInfo(label40.Text);
                a.Show();
                this.Hide();
            }
        }

        private void materialListView5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (materialListView5.SelectedItems.Count > 0)
            {
                ListViewItem item = materialListView5.SelectedItems[0];
                label40.Text = item.SubItems[0].Text;
            }
        }

        private void materialListView4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (materialListView4.SelectedItems.Count > 0)
            {
                ListViewItem item = materialListView4.SelectedItems[0];
                label33.Text = item.SubItems[0].Text;
            }
        }

        private void materialFlatButton16_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "UPDATE tbl_useraccounts SET " +
            "col_status = 'archived' " +
            "WHERE col_useraccountsid='" + label40.Text + "'";
            command.CommandText = query;
            command.ExecuteScalar();
            conn.Close();

            materialListView4.Items.Clear();
            materialListView5.Items.Clear();

            dataCashierAccountUnarchived();
            dataCashierAccountArchived();
        }

        private void materialFlatButton13_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "UPDATE tbl_useraccounts SET " +
            "col_status = 'unarchived' " +
            "WHERE col_useraccountsid='" + label33.Text + "'";
            command.CommandText = query;
            command.ExecuteScalar();
            conn.Close();

            materialListView4.Items.Clear();
            materialListView5.Items.Clear();

            dataCashierAccountUnarchived();
            dataCashierAccountArchived();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            searcharchived();
        }

        private void materialListView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            searchunarchivedbp();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialListView6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            searchunarchivedbp();
        }

        private void materialFlatButton10_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "UPDATE tbl_useraccounts SET " +
            "col_status = 'unarchived' " +
            "where col_useraccountsid = '" + label21.Text + "'";
            command.CommandText = query;
            command.ExecuteScalar();
            conn.Close();

            materialListView6.Items.Clear();
            materialListView3.Items.Clear();

            databrandpartneraccountunarchived();
            databrandpartneraccountarchived();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            searchunarchivedcashier();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            searcharchivedcashier();
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
