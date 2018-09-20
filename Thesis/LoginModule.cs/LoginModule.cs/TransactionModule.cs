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
    public partial class TransactionModule : MaterialSkin.Controls.MaterialForm
    {

        public TransactionModule(string cashier)
        {
            InitializeComponent();
            label17.Text = cashier;
            displayDate();
            TransactionOutput();
            TodaysSales();
        }
        public void displayDate()
        {

            timer1.Start();
            label2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            label7.Text = DateTime.Now.ToLongTimeString();

        }
        public void TransactionDelete()
        {

            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            MySqlCommand command = conn.CreateCommand();

            conn.Open();
            command.CommandText = "Delete from tbl_order where col_orderstatus='unfinished'";
            command.ExecuteScalar();
            conn.Close();

            MySqlConnection conn2 = new MySqlConnection(ConnectionString.myConnection);
            MySqlCommand command2 = conn2.CreateCommand();

            conn.Open();
            command.CommandText = "Delete from tbl_transaction where col_transactioncode='" + labelTransactionCode.Text + "'";
            command.ExecuteScalar();
            conn.Close();

        }
        public void printitemdetails()
        {
            int data = 0;
            ListViewItem list = materialListView2.SelectedItems[data];
            String id = list.SubItems[0].Text;
            tbProductCode.Text = id.ToString();
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select P.col_productid,P.col_productcode, P.col_productname ," +
                "B.col_brandname,  C.col_categoryname,  P.col_productprice from tbl_product P " +
                "LEFT JOIN tbl_brandpartner B ON B.col_useraccountsid = P.col_useraccountsid " +
                "LEFT JOIN tbl_category C ON C.col_categoryid = P.col_categoryid " +
                "where P.col_status='unarchived' and P.col_productcode='" + tbProductCode.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {

                ListViewItem items = new ListViewItem(read["col_productid"].ToString());
                tbProductCode.Text = (read["col_productcode"].ToString());
                tbProductName.Text = (read["col_productname"].ToString());
                tbBrand.Text = (read["col_brandname"].ToString());
                tbCategory.Text = (read["col_categoryname"].ToString());

                tbPrice.Text = (read["col_productprice"].ToString());
            }
            conn.Close();

        }
        public void printorderid()
        {
            int data = 0;
            ListViewItem list = materialListView1.SelectedItems[data];
            String id = list.SubItems[0].Text;
            tbOrderId.Text = id.ToString();
        }
        public void searchProduct()
        {

            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            materialListView2.Items.Clear();
            conn.Open();
            string query1 = "select * from tbl_product  where col_productcode like  '" + tbSearchItem.Text + "%'  and col_status='unarchived'";

            MySqlCommand command2 = conn.CreateCommand();
            command2.CommandText = query1;
            MySqlDataReader read = command2.ExecuteReader();
            while (read.Read())
            {
                ListViewItem items = new ListViewItem(read["col_productcode"].ToString());
                items.SubItems.Add(read["col_productname"].ToString());
                materialListView2.Items.Add(items);
                materialListView2.FullRowSelect = true;
            }
            conn.Close();
        }

        public void Change()
        {
            if (!string.IsNullOrWhiteSpace(tbAmount.Text))
            {
                double money = Double.Parse(tbAmount.Text);
                double total = Double.Parse(labelTotalSales.Text);
                labelChange.Text = (money - total).ToString();
            }
        }
        public void TodaysSales()
        {

            MySqlConnection con = new MySqlConnection(ConnectionString.myConnection);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select SUM(col_totalprice) as price from tbl_transaction where col_dateofpurchase='" + label2.Text + "'";
            MySqlDataReader basa = cmd.ExecuteReader();
            while (basa.Read())
            {
                label5.Text = basa["price"].ToString();

            }
            con.Close();


        }
        public void TransactionOutput()
        {
            MySqlConnection con = new MySqlConnection(ConnectionString.myConnection);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select MAX(col_transactionid) as ayD from tbl_transaction";
            MySqlDataReader basa = cmd.ExecuteReader();
            while (basa.Read())
            {
                string ayd = basa["ayD"].ToString();
                int plus1 = Int32.Parse(ayd);
                int total = plus1 + 1;
                labelTransactionCode.Text = "PCS0" + total;
            }
            con.Close();
            InsertTransaction();
        }




        public void InsertOrder()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();
                if (tbProductCode.Text == "" || tbProductName.Text == "")
                {
                    MessageBox.Show("Please select an item you wish to add");
                }
                else
                {
                    MySqlCommand command2 = conn.CreateCommand();

                    string query = "insert into tbl_order(col_transactionid,col_productid,col_quantitybought,col_subtotal,col_orderstatus) " +
                        "values ((Select col_transactionid from tbl_transaction where col_transactioncode ='" + labelTransactionCode.Text + "'), " +
                        "(Select col_productid from tbl_product where col_productcode='" + tbProductCode.Text + "'),'" + tbQuantity.Text + "','" +
                        tbSubtotal.Text + "','unfinished')";
                    command2.CommandText = query;
                    command2.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(query);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);

            }

        }
        public void InsertTransaction()
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            if (label1.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else
            {
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                command2.CommandText = "insert into tbl_transaction(col_transactioncode,col_useraccountsid,col_totalprice,col_dateofpurchase) values ('" + labelTransactionCode.Text + "','" + label17.Text + "','" + labelTotalSales.Text + "',now())";
                command2.ExecuteScalar();
                conn.Close();
            }

        }

        public void InsertTransactionTotalAmount()
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

            if (tbAmount.Text == "")
            {
                MessageBox.Show("Please enter tender amount");
            }
            else
            {

                double TotalSales = Double.Parse(labelTotalSales.Text);
                double tenderAmount = Double.Parse(tbAmount.Text);
                double change = Double.Parse(labelChange.Text);

                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                string query = "UPDATE tbl_transaction SET " +
                    "col_totalprice= " + TotalSales +
                    " WHERE col_transactioncode='" + labelTransactionCode.Text + "'";
                command2.CommandText = query;
                command2.ExecuteScalar();
                conn.Close();
            }

        }

        public void viewOrder()
        {

            materialListView1.Items.Clear();
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "Select * from tbl_order o "+
                "inner join tbl_transaction t " +
                "  on t.col_transactionid = o.col_transactionid "+
                "inner join tbl_product p " +
                "on o.col_productid = p.col_productid " +
                "inner join tbl_brandpartner b " +
                "on p.col_useraccountsid = b.col_useraccountsid " +
                "inner join tbl_category c " +
                "on c.col_categoryid = p.col_categoryid " +
                "where t.col_transactioncode = '" + labelTransactionCode.Text + "' and o.col_orderstatus='unfinished'";

            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ListViewItem items = new ListViewItem(read["col_orderid"].ToString());
                items.SubItems.Add(read["col_productcode"].ToString());
                items.SubItems.Add(read["col_productname"].ToString());
                items.SubItems.Add(read["col_brandname"].ToString());
                items.SubItems.Add(read["col_categoryname"].ToString());
                items.SubItems.Add(read["col_productprice"].ToString());
                items.SubItems.Add(read["col_quantitybought"].ToString());
                items.SubItems.Add(read["col_subtotal"].ToString());
                materialListView1.Items.Add(items);
            }
            conn.Close();
            //MessageBox.Show(query);

            subtotal();
            total();

            materialListView2.Items.Clear();

            tbSubtotal.Clear();
            tbSearchItem.Clear();
            tbQuantity.Clear();
            tbPrice.Clear();
            tbOrderId.Clear();
            tbProductName.Clear();
            tbProductCode.Clear();
            tbBrand.Clear();
            tbCategory.Clear();

        }
        public void remove()
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            MySqlCommand command = conn.CreateCommand();
            conn.Close();
            conn.Open();
            if (tbOrderId.Text == "")
            {
                MessageBox.Show("Please select an item from the item list");
            }
            else
            {
                conn.Close();
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                command2.CommandText = "UPDATE tbl_order SET " +
                    "col_orderstatus='void'" +
                    " WHERE col_orderid='" + tbOrderId.Text + "'";
                command2.ExecuteScalar();
                conn.Close();
            }
            viewOrder();
        }
        public void subtotal()
        {
            try
            {
                double itemsold = Double.Parse(tbQuantity.Text);
                double price = Double.Parse(tbPrice.Text);
                tbSubtotal.Text = (price * itemsold).ToString();
            }
            catch (Exception e)
            {

            }
        }
        public void total()
        {
            float value = 0;

            for (int i = 0; i < materialListView1.Items.Count; i++)
            {
                value += float.Parse(materialListView1.Items[i].SubItems[7].Text);
            }

            labelTotalSales.Text = Convert.ToString(value);

        }
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToString("yyyy-MM-dd");
            timer1.Start();
        }
        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text == "" || tbProductCode.Text == "" || tbBrand.Text == "" || tbCategory.Text == "" || tbPrice.Text == "")
            {
                MessageBox.Show("Please complete the form");
            }
            else
            {
                InsertOrder();
                viewOrder();
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchItem.Text == "")
            {
                materialListView2.Items.Clear();
            }
            else
            {
                searchProduct();
            }
        }
        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            remove();
            total();
            viewOrder();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Change();
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            TransactionDelete();
            Login a = new Login();
            a.Show();
            this.Hide();
        }
        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            subtotal();
        }
        private void materialListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            printorderid();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            InsertTransactionTotalAmount();
            if (tbAmount.Text == "")
            {


            }
            else
            {
                MessageBox.Show("Thank You Come AGAIN!!!");
                Login a = new Login();
                a.Show();
                this.Hide();

            }

        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            ChangePassword a = new ChangePassword(label17.Text);
            a.Show();
        }

        private void materialDivider2_Click(object sender, EventArgs e)
        {

        }

        private void TransactionModule_Load(object sender, EventArgs e)
        {

        }

        private void materialListView2_DoubleClick(object sender, MouseEventArgs e)
        {
            printitemdetails();
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            InsertOrder();
            viewOrder();
        }

        private void btnRemovefromCart_Click(object sender, EventArgs e)
        {
            remove();
        }

        private void materialFlatButton4_Click_1(object sender, EventArgs e)
        {

        }
        public void searchtransaction()
        {

            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            materialListView3.Items.Clear();
            conn.Open();
            string query1 = "select * from tbl_transaction where col_transactioncode like  '" + textBox1.Text + "%'";

            MySqlCommand command2 = conn.CreateCommand();
            command2.CommandText = query1;
            MySqlDataReader read = command2.ExecuteReader();
            while (read.Read())
            {
                ListViewItem items = new ListViewItem(read["col_transactionid"].ToString());
                items.SubItems.Add(read["col_transactioncode"].ToString());
                var dt = DateTime.Parse(read["col_dateofpurchase"].ToString());
                items.SubItems.Add(dt.ToString("yyyy-MM-dd"));
                materialListView3.Items.Add(items);
                materialListView3.FullRowSelect = true;
            }
            conn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                materialListView3.Items.Clear();
            }
            else
            {
                searchtransaction();
            }
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {

        }

    }
}
