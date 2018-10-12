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

        public void initializeListviewHeaderStyle()
        {
            materialListView1.HeaderStyle = ColumnHeaderStyle.Clickable;
            materialListView10.HeaderStyle = ColumnHeaderStyle.Clickable;
            materialListView11.HeaderStyle = ColumnHeaderStyle.Clickable;
            materialListView13.HeaderStyle = ColumnHeaderStyle.Clickable;
            materialListView2.HeaderStyle = ColumnHeaderStyle.Clickable;
            materialListView3.HeaderStyle = ColumnHeaderStyle.Clickable;
            materialListView4.HeaderStyle = ColumnHeaderStyle.Clickable;
            materialListView5.HeaderStyle = ColumnHeaderStyle.Clickable;
            materialListView6.HeaderStyle = ColumnHeaderStyle.Clickable;
        }

        public void launch() 
        {
            initializeListviewHeaderStyle();
            viewdamageid();
            viewfinishdamage();
            dataproductunarchived();
            dataproductarchived();
            databrandpartneraccountunarchived();
            databrandpartneraccountarchived();
            dataCashierAccountUnarchived();
            dataCashierAccountArchived();
            viewlogs();
            countunarchiveditems();
            countarchiveditems();
            countunarchivedcash();
            countarchivedcash();
            countunarchivedbp();
            countarchivedbp();
        }
        public void countunarchivedbp() 
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

                conn.Open();
                MySqlCommand command = conn.CreateCommand();

                MySqlCommand command2 = conn.CreateCommand();
                command.Connection = conn;
                command.CommandText = "select COUNT(col_useraccountsid) AS '" + "countubp" + "' from tbl_useraccounts where col_usertypeid='3' AND col_status='unarchived'";


                MySqlDataReader read = command.ExecuteReader();


                while (read.Read())
                {
                    label19.Text = read["countubp"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            { 
                MessageBox.Show("Lost connection to the host");  
            }
        }
        public void countarchivedbp()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

                conn.Open();
                MySqlCommand command = conn.CreateCommand();

                MySqlCommand command2 = conn.CreateCommand();
                command.Connection = conn;
                command.CommandText = "select COUNT(col_useraccountsid) AS '" + "countabp" + "' from tbl_useraccounts where col_usertypeid='3' AND col_status='archived'";


                MySqlDataReader read = command.ExecuteReader();


                while (read.Read())
                {
                    label25.Text = read["countabp"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host");
            }
        }
        public void countunarchivedcash()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

                conn.Open();
                MySqlCommand command = conn.CreateCommand();

                MySqlCommand command2 = conn.CreateCommand();
                command.Connection = conn;
                command.CommandText = "select COUNT(col_useraccountsid) AS '" + "countuc" + "' from tbl_useraccounts where col_usertypeid='2' AND col_status='unarchived'";


                MySqlDataReader read = command.ExecuteReader();


                while (read.Read())
                {
                    label44.Text = read["countuc"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host");
            }
        }
        public void countarchivedcash()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

                conn.Open();
                MySqlCommand command = conn.CreateCommand();

                MySqlCommand command2 = conn.CreateCommand();
                command.Connection = conn;
                command.CommandText = "select COUNT(col_useraccountsid) AS '" + "count" + "' from tbl_useraccounts where col_usertypeid='2' AND col_status='archived'";


                MySqlDataReader read = command.ExecuteReader();


                while (read.Read())
                {
                    label37.Text = read["count"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host"); 
            }
        }
        public void viewlogs()
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                materialListView10.Items.Clear();
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                string query = "Select * from tbl_logs";
                command2.CommandText = query;
                MySqlDataReader read = command2.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem items = new ListViewItem(read["col_logid"].ToString());
                    items.SubItems.Add(read["col_activity"].ToString());
                    items.SubItems.Add(read["col_dateofactivity"].ToString());
                    materialListView10.Items.Add(items);
                    materialListView10.FullRowSelect = true;
                }
                conn.Close();

            }
            catch (Exception e) 
            {
                MessageBox.Show("No connection to the host");
            }
        }
        public void recountbp()
        {
            countunarchivedbp();
            countarchivedbp();
        }
        public void recountcash()
        {
            countarchivedcash();
            countunarchivedcash();
        }
        public void databrandpartneraccountarchived() 
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host"); 
            }
        
        }

       


        public void printunarchivedproduct()
        {
            try
            {
                int data = 0;
                ListViewItem list = materialListView1.SelectedItems[data];
                String id = list.SubItems[0].Text;
                label6.Text = id.ToString();
                materialListView1.Columns[0].Width = 0;
            }
            catch (Exception e) 
            {
                MessageBox.Show("Select only one record below");
            }
            try
            {
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
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host");   
            }

        }
        public void printarchivedproduct()
        {
            try
            {
                if (materialListView2.SelectedItems.Count > 0)
                {
                    int data = 0;
                    ListViewItem list = materialListView2.SelectedItems[data];
                    String id = list.SubItems[0].Text;
                    label9.Text = id.ToString();
                }
                else
                {
                    defaultFaultSelectID();
                }
                
            }
            catch (Exception e)
            {
                //MessageBox.Show("Select only one record below");
            }
            try
            {
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
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host");   
            }
        }
        public void unarchiveproduct() 
        {
        
        }
        public void countunarchiveditems()
        {
            try
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
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host"); 
            }
        }
        public void countarchiveditems()
        {
            try
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
                    label13.Text = read["items"].ToString();
                }
                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("No connection to the host"); 
                
            }
        }

        public void databrandpartneraccountunarchived()
        { 
            try
            {
                materialListView3.Items.Clear();
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

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
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host"); 
            }

        
        }
        public void dataCashierAccountUnarchived()
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host"); 
            }
        }

        public void dataCashierAccountArchived()
        {
            materialListView4.Items.Clear();
            try
            {
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
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host"); 
            }
        }

        public void dataproductunarchived()
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host");   
            }


        }
        public void dataproductarchived()
        {
            try
            {
                materialListView2.Items.Clear();
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
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
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host");  
            }

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

            try
            {
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
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host"); 
            }
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

            try
            {
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
            catch (Exception)
            {
                MessageBox.Show("No connection to the host"); 
                
            }
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
                try
                {
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
                catch
                {
                    MessageBox.Show("No connection to the host"); 
                }
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
                    "where b.col_brandname like '" + textBox4.Text + "%' and col_status='archived' and u.col_usertypeid=3";

                if (searchby != null)
                {
                    query = "select * from tbl_brandpartner b " +
                   "inner join tbl_useraccounts u " +
                   "on b.col_useraccountsid = u.col_useraccountsid " +
                   "inner join tbl_usertype t " +
                   "on t.col_usertypeid = u.col_usertypeid " +
                    "where " + search + " like  '" + textBox4.Text + "%'and col_status='archived' and u.col_usertypeid=3";
                }
                try
                {
                    MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                    materialListView6.Items.Clear();
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

                        materialListView6.Items.Add(items);
                        materialListView6.FullRowSelect = true;
                    }
                    conn.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("No connection to the host"); 
                    
                }            }
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
                try
                {
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
                catch (Exception)
                {
                    MessageBox.Show("No connection to the host"); 
                    
                }            }
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
                try
                {
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
                catch (Exception)
                {
                    MessageBox.Show("No connection to the host"); 
                    
                }            }
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
            if (label6.Text == "SI")
            {
                MessageBox.Show("Select a record below");
            }
            else
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                    conn.Open();
                    MySqlCommand command = conn.CreateCommand();
                    string query = "UPDATE tbl_product p SET " +
                    "col_status = 'archived' " +
                    "where p.col_productid = '" + label6.Text + "'";
                    command.CommandText = query;
                    command.ExecuteScalar();
                    conn.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("No connection to the host");

                }

                materialListView1.Items.Clear();
                materialListView2.Items.Clear();

                dataproductunarchived();
                dataproductarchived();
                defaultFaultSelectID();
            }
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
                MessageBox.Show("Select a record below");
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
            else
            {
                defaultFaultSelectID();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
            searchunarchived();
        }
        private void materialRaisedButton1_Click_2(object sender, EventArgs e)
        {
          
                DialogResult dialog = MessageBox.Show( "Are You sure you want to Log-out?", "Message", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Login a = new Login();
                    a.Show();
                    this.Hide();
                }
        }

        private void materialFlatButton7_Click(object sender, EventArgs e)
        {
            NewBrandPartnerAccount a = new NewBrandPartnerAccount();
            a.Show();
            this.Hide();
        }
        
        private void materialListView2_DoubleClick(object sender, EventArgs e)
        {
            printarchivedproduct();
        }

        private void materialFlatButton20_Click(object sender, EventArgs e)
        {
            if (label9.Text == "SI")
            {
                MessageBox.Show("Select a record below");
            }
            else
	        {
                try
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
                }
                catch (Exception)
                {
                    MessageBox.Show("No connection to the host");

                }

                materialListView1.Items.Clear();
                materialListView2.Items.Clear();

                dataproductunarchived();
                dataproductarchived();
                defaultFaultSelectID();
            }
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
            else
            {
                MessageBox.Show("Select a record below");
            }
        }
        public void printbrandpartnerunarchived() 
        {
            if (materialListView3.SelectedItems.Count > 0)
            {
                int data = 0;
                ListViewItem list = materialListView3.SelectedItems[data];
                String id = list.SubItems[0].Text;
                label15.Text = id.ToString();
            }
            else
            {
                defaultFaultSelectID();
            }
        }
        public void printbrandpartnerarchived()
        {
            if (materialListView6.SelectedItems.Count > 0)
            {
                int data = 0;
                ListViewItem list = materialListView6.SelectedItems[data];
                String id = list.SubItems[0].Text;
                label21.Text = id.ToString();
            }
            else
            {
                defaultFaultSelectID();
            }
        }
        private void materialListView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            printbrandpartnerunarchived();
        }
		public void archivedbrandpartner()
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("No connection to the host"); 
                
            }
        }
		private void materialFlatButton9_Click(object sender, EventArgs e)
        {
            if (label15.Text != "SI")
            {
                archivedbrandpartner();
                materialListView6.Items.Clear();
                materialListView3.Items.Clear();
                databrandpartneraccountunarchived();
                databrandpartneraccountarchived();
                recountbp();
                defaultFaultSelectID();
            }
            else
            {
                MessageBox.Show("Select a record below");
            }
            
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
            else 
            {
                MessageBox.Show("Select a record below");
            }
        }

        private void printcashieridunarchived()
        {
            if (materialListView5.SelectedItems.Count > 0)
            {
                ListViewItem item = materialListView5.SelectedItems[0];
                label40.Text = item.SubItems[0].Text;
            }
            else
            {
                defaultFaultSelectID();
            }
        }

        private void materialListView5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            printcashieridunarchived();
        }

        private void printcashieridarchived()
        {
            if (materialListView4.SelectedItems.Count > 0)
            {
                ListViewItem item = materialListView4.SelectedItems[0];
                label33.Text = item.SubItems[0].Text;
            }
            else
            {
                defaultFaultSelectID();
            }
        }

        private void materialListView4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            printcashieridarchived();
        }

        private void materialFlatButton16_Click(object sender, EventArgs e)
        {
            if (label40.Text != "SI")
            {
                try
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
                }
                catch (Exception)
                {

                    MessageBox.Show("No connection to the host");
                }

                materialListView4.Items.Clear();
                materialListView5.Items.Clear();
                recountcash();
                dataCashierAccountUnarchived();
                dataCashierAccountArchived();
                defaultFaultSelectID();
            }
            else
            {
                MessageBox.Show("Select a record below");
            }
            
        }

        private void materialFlatButton13_Click(object sender, EventArgs e)
        {
            if (label33.Text != "SI")
            {
                try
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
                }
                catch (Exception)
                {
                    MessageBox.Show("No connection to the host");

                }

                materialListView4.Items.Clear();
                materialListView5.Items.Clear();

                dataCashierAccountUnarchived();
                dataCashierAccountArchived();

                recountcash();
                defaultFaultSelectID();
            }
            else
            {
                MessageBox.Show("Select a Record below.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
            searcharchived();
        }

        private void materialListView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            printbrandpartnerunarchived();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
            searchunarchivedbp();
        }

        private void materialListView6_SelectedIndexChanged(object sender, EventArgs e)
        {
            printbrandpartnerarchived();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
            searcharchivedbp();
        }

        private void materialFlatButton10_Click(object sender, EventArgs e)
        {
            if (label21.Text != "SI")
            {
                try
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
                }
                catch (Exception)
                {
                    MessageBox.Show("No connection to the host");

                }

                materialListView6.Items.Clear();
                materialListView3.Items.Clear();

                databrandpartneraccountunarchived();
                databrandpartneraccountarchived();
                recountbp();
                defaultFaultSelectID();

            }
            else
            {
                MessageBox.Show("Select a record below.");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
            searchunarchivedcashier();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
            searcharchivedcashier();
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

        private void materialFlatButton19_Click(object sender, EventArgs e)
        {
            NewCategory a = new NewCategory();
            a.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
        }

        private void disableConfirmDamage()
        {
            if (label3.Text != "0" || label3.Text != "")
            {
                groupBox6.Enabled = true;
            }
            else
            {
                groupBox6.Enabled = false;
            }
        }

        private void viewdamageid()
        {
            try
            {
                int count = 0;
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                materialListView11.Items.Clear();
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                string query = "SELECT count(*) as count FROM tbl_damage d " +
                            "inner join tbl_order o " +
                            "on d.col_orderid = o.col_orderid " +
                            "inner join tbl_transaction t " +
                            "on t.col_transactionid = o.col_transactionid " +
                            "inner join tbl_product p " + 
                            "on p.col_productid = o.col_productid " +
                            "where d.col_status='pending-change' OR d.col_status='pending-refund'";
                command.CommandText = query;
                MySqlDataReader read = command.ExecuteReader();
                read.Read();
                count = int.Parse(read[0].ToString());
                conn.Close();
                 
                if (count > 0)
                {
                    
                    conn.Open();
                    command = conn.CreateCommand();
                    query = "SELECT * FROM tbl_damage d " +
                                "inner join tbl_order o " +
                                "on d.col_orderid = o.col_orderid " +
                                "inner join tbl_transaction t " +
                                "on t.col_transactionid = o.col_transactionid " +
                                "inner join tbl_product p " +
                                "on p.col_productid = o.col_productid " +
                                "where d.col_status='pending-change' OR d.col_status='pending-refund'";
                    command.CommandText = query;
                    read = command.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem items = new ListViewItem(read["col_damageitemid"].ToString());

                    items.SubItems.Add(read["col_orderid"].ToString());
                        items.SubItems.Add(read["col_transactioncode"].ToString());
                    items.SubItems.Add(read["col_productcode"].ToString());
                    items.SubItems.Add(read["col_productname"].ToString());
                    //items.SubItems.Add(read["col_staticquantity"].ToString());
                    //items.SubItems.Add(read["col_reason"].ToString());
                    items.SubItems.Add(read["col_status"].ToString()); 

                    materialListView11.Items.Add(items);
                    materialListView11.FullRowSelect = true;
                }
                conn.Close();
                    groupBox6.Enabled = true;

            }
                else
                {
                    groupBox6.Enabled = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host"); 
            }
        }
        private void printdamageid()
        {
            try
            {
                if (materialListView11.SelectedItems.Count > 0)
                {
                    int data = 0;
                    ListViewItem list = materialListView11.SelectedItems[data];
                    String id = list.SubItems[0].Text;
                    lblTransactionCode.Text = list.SubItems[2].Text;

                    label3.Text = id.ToString();
                    disableConfirmDamage();

                }
                else
                {
                    defaultFaultSelectID();

                }
                
            }
            catch (Exception e)
            {
                //MessageBox.Show("Select only one damage product");
            }
            try
            {
                
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                string query = "SELECT * FROM tbl_damage d " +
                         "inner join tbl_order o " +
                         "on d.col_orderid = o.col_orderid " +
                         "inner join tbl_product p " +
                         "on p.col_productid = o.col_productid where col_damageitemid='" + label3.Text + "'";
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                command2.CommandText = query;
                MySqlDataReader read = command2.ExecuteReader();
                while (read.Read())
                {
                    label18.Text = read["col_orderid"].ToString();
                    label24.Text = read["col_staticquantity"].ToString();
                    label30.Text = read["col_status"].ToString();
                    label36.Text = read["col_productcode"].ToString();
                    label42.Text = read["col_quantitybought"].ToString();
                    label46.Text = read["col_productprice"].ToString();
                    label11.Text = read["col_subtotal"].ToString();


                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host");

            }
        }
        public void viewfinishdamage()
        {
             try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                materialListView13.Items.Clear();
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                string query = "SELECT * FROM tbl_damage d " +
                            "inner join tbl_order o " +
                            "on d.col_orderid = o.col_orderid " +
                            "inner join tbl_product p " + 
                            "on p.col_productid = o.col_productid where d.col_status='Changed' OR d.col_status='Refunded' ";
                command.CommandText = query;
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem items = new ListViewItem(read["col_damageitemid"].ToString());

                    items.SubItems.Add(read["col_orderid"].ToString());
                    //items.SubItems.Add(read["col_transactionid"].ToString());
                    items.SubItems.Add(read["col_productcode"].ToString());
                    items.SubItems.Add(read["col_productname"].ToString());
                    //items.SubItems.Add(read["col_staticquantity"].ToString());
                    //items.SubItems.Add(read["col_reason"].ToString());
                    items.SubItems.Add(read["col_status"].ToString()); 

                    materialListView13.Items.Add(items);
                    materialListView13.FullRowSelect = true;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No connection to the host" +e); 
            }
        
        
        }
        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to confirm", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (label30.Text == "pending-change")
                    {
                        MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                        conn.Open();
                        MySqlCommand command3 = conn.CreateCommand();
                        command3.CommandText = "UPDATE tbl_damage SET col_status='Changed' where col_damageitemid='" + label3.Text + "'";
                        command3.ExecuteScalar();
                        viewfinishdamage();
                        viewdamageid();
                        MessageBox.Show("Successfully Confirmed");
                        conn.Close();
                    }
                    else if (label30.Text == "pending-refund")
                    {
                        double returnPrice = 0;
                        MySqlConnection conn2 = new MySqlConnection(ConnectionString.myConnection);
                        conn2.Open();
                        MySqlCommand command4 = conn2.CreateCommand();
                        command4.CommandText = "UPDATE tbl_damage SET col_status='Refunded' where col_damageitemid='" + label3.Text + "'";
                        command4.ExecuteScalar();
                        conn2.Close();

                        conn2.Open();
                        MySqlCommand command = conn2.CreateCommand();
                        string query = "(Select SUM(`col_subtotal`) from tbl_order o " +
                        "inner join tbl_transaction t " +
                        "on t.col_transactionid = o.col_transactionid " +
                        "where t.col_transactioncode = '" + lblTransactionCode.Text +
                        "' and o.col_orderstatus='Sales') ";
                        command.CommandText = query;
                        MySqlDataReader read = command.ExecuteReader();
                        read.Read();
                        returnPrice = double.Parse(read[0].ToString());
                        conn2.Close();

                        conn2.Open();
                        command4 = conn2.CreateCommand();
                        command4.CommandText = "UPDATE tbl_transaction SET " +
                        "col_totalprice= " + returnPrice +
                        " where col_transactioncode ='" + lblTransactionCode.Text + "'";
                        command4.ExecuteScalar();
                        conn2.Close();



                        viewdamageid();
                        viewfinishdamage();
                        MessageBox.Show("Successfully Confirmed");

                        clearDamage();

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    clearDamage();
                } 
                
            }
            catch (Exception a)
            {
                MessageBox.Show("No connection to the host" + a);
            }
        
        }
        private void clearDamage()
        {
            label3.Text = "";
            label18.Text = "";
            label24.Text = "";
            label30.Text = "";
            label36.Text = "";
            label42.Text = "";
            label46.Text = "";

            groupBox6.Enabled = false;
        }

        private void materialListView11_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            printdamageid();
        }
		
		private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            new viewAdminAccount().Show();
            this.Hide();
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (label30.Text == "pending-change")
                    {
                        MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                        conn.Open();
                        MySqlCommand command3 = conn.CreateCommand();
                        command3.CommandText = "UPDATE tbl_damage SET col_status='change-cancelled' where col_damageitemid='" + label3.Text + "'";
                        command3.ExecuteScalar();
                        viewfinishdamage();
                        viewdamageid();
                        MessageBox.Show("Successfully Cancelled");
                        conn.Close();
                        
                    }
                    else if (label30.Text == "pending-refund")
                    {
                        double price = 0;
                        int qty = 0;
                        qty = int.Parse(label42.Text) + int.Parse(label24.Text);
                        price = (double.Parse(label46.Text) * int.Parse(label24.Text)) + double.Parse(label11.Text);

                        MySqlConnection conn2 = new MySqlConnection(ConnectionString.myConnection);
                        conn2.Open();
                        MySqlCommand command4 = conn2.CreateCommand();
                        command4.CommandText = "UPDATE tbl_damage SET col_status='refund-cancelled' where col_damageitemid='" + label3.Text + "'";
                        command4.ExecuteScalar();
                        conn2.Close();

                        conn2.Open();
                        command4 = conn2.CreateCommand();
                        command4.CommandText = "UPDATE tbl_order SET " +
                            "col_quantitybought='" + qty + "'" +
                            " WHERE col_orderid='" + label18.Text + "'";

                        command4.ExecuteScalar();
                        conn2.Close();

                        conn2.Open();
                        MySqlCommand command3 = conn2.CreateCommand();
                        command3.CommandText = "UPDATE tbl_order SET " +
                            "col_subtotal='" + price + "'" +
                            " WHERE col_orderid='" + label18.Text + "'";

                        command3.ExecuteScalar();
                        conn2.Close();

                        viewdamageid();
                        viewfinishdamage();
                        MessageBox.Show("Successfully Cancelled");
                        clearDamage();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    clearDamage();
                }
            }
            catch (Exception a) 
            {
                MessageBox.Show("No connection to the host"+a); 
            }
            }

        private void materialListView2_MouseClick(object sender, MouseEventArgs e)
        {
            printarchivedproduct();
        }
        
        private void defaultFaultSelectID()
        {
            materialListView1.SelectedIndices.Clear();
            materialListView10.SelectedIndices.Clear();
            materialListView11.SelectedIndices.Clear();
            materialListView13.SelectedIndices.Clear();
            materialListView2.SelectedIndices.Clear();
            materialListView3.SelectedIndices.Clear();
            materialListView4.SelectedIndices.Clear();
            materialListView5.SelectedIndices.Clear();
            materialListView6.SelectedIndices.Clear();
            
            label6.Text = "SI";
            label9.Text = "SI";
            clearDamage();

            label15.Text = "SI";
            label21.Text = "SI";

            label40.Text = "SI";
            label33.Text = "SI";

            

        }

        private void outsideListview_Click(object sender, EventArgs e)
        {
            defaultFaultSelectID();
        }

        private void genericTabControl_SelectedTabIndexChanged(object sender, EventArgs e)
        {
            defaultFaultSelectID();
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (materialListView1.SelectedItems.Count > 0)
            {
                ListViewItem item = materialListView1.SelectedItems[0];
                label6.Text = item.SubItems[0].Text;
                
            }
            else
            {
                defaultFaultSelectID();
            }
        }

        private void listviewHeader_Click(object sender, ColumnClickEventArgs e)
        {
            defaultFaultSelectID();
        }

        private void materialListView11_SelectedIndexChanged(object sender, EventArgs e)
        {
            printdamageid();
        }

        private void materialListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            printarchivedproduct();
        }

        private void materialListView5_SelectedIndexChanged(object sender, EventArgs e)
        {
            printcashieridunarchived();
        }

        private void materialListView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            printcashieridarchived();
        }
    }
}
