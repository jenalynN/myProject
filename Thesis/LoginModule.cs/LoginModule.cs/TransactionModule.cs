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

        public TransactionModule(string id)
        {
            InitializeComponent();
            label17.Text = id;
            displayDate();
            TransactionOutput();
            TodaysSales();
            textBox6.Visible = true;
            label25.Visible = true;
            viewcashier();
        }
        public void viewcashier()
        {
            try { 
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select col_user from tbl_useraccounts where col_useraccountsid='" + label17.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                label3.Text = (read["col_user"].ToString());
            }
            conn.Close();
        }
            catch (Exception e)
            {
                MessageBox.Show("No connection to host");
            
        }}
        public void logaddtocart() 
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();
                string a = "Useraccountsid: " + label17.Text.ToString() + " added  item " + tbProductCode.Text.ToString() + " to the cart in the Transaction Code" + labelTransactionCode.Text.ToString();

                MySqlCommand command2 = conn.CreateCommand();

                    string query = "insert into tbl_logs(col_activity,col_dateofactivity)" +
                        "values ('" + a + "',now())";
                    command2.CommandText = query;
                    command2.ExecuteNonQuery();
                    conn.Close();
                    //MessageBox.Show(query);
            }
            catch (Exception e)
            {
                MessageBox.Show("No connection to host");

            }
        
        
        }
        public void logvoidfromcart()
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();
                string a = "Useraccountsid: " + label17.Text.ToString() + " voided item " + tbProductCode.Text.ToString() + "from the cart in the Transaction Code" + labelTransactionCode.Text.ToString();

                MySqlCommand command2 = conn.CreateCommand();

                string query = "insert into tbl_logs(col_activity,col_dateofactivity)" +
                    "values ('" + a + "',now())";
                command2.CommandText = query;
                command2.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show(query);
            }
            catch (Exception e)
            {
                MessageBox.Show("No Connection to host");

            }
        }
        public void logpurchase() 
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();
                string a = "Useraccountsid: " + label17.Text.ToString() + " added a new transaction " + labelTransactionCode.Text.ToString();

                MySqlCommand command2 = conn.CreateCommand();

                string query = "insert into tbl_logs(col_activity,col_dateofactivity)" +
                    "values ('" + a + "',now())";
                command2.CommandText = query;
                command2.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show(query);
            }
            catch (Exception e)
            {
                MessageBox.Show("No Connection to host");

            }
        }
        public void logcancel() 
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();
                string a = "Useraccountsid: " + label17.Text.ToString() + " cancel transaction " + labelTransactionCode.Text.ToString();

                MySqlCommand command2 = conn.CreateCommand();

                string query = "insert into tbl_logs(col_activity,col_dateofactivity)" +
                    "values ('" + a + "',now())";
                command2.CommandText = query;
                command2.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show(query);
            }
            catch (Exception e)
            {
                MessageBox.Show("No Connection to host");

            }
        

        }
        public void logreturn()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();
                string a = "Useraccountsid: " + label17.Text.ToString() + " returned item  " + tbProductCode.Text.ToString();

                MySqlCommand command2 = conn.CreateCommand();

                string query = "insert into tbl_logs(col_activity,col_dateofactivity)" +
                    "values ('" + a + "',now())";
                command2.CommandText = query;
                command2.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show(query);
            }
            catch (Exception e)
            {
                MessageBox.Show("No Connection to host");

            }
        }
        public void displayDate()
        {

            timer1.Start();
            label2.Text = DateTime.Now.ToString("yyyy-MM-dd");

            label16.Text = DateTime.Now.ToString("yyy-MM-dd");
            label19.Text = DateTime.Now.ToLongTimeString();
            label7.Text = DateTime.Now.ToLongTimeString();

        }
        public void TransactionDelete()
        {
            try
            {

                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                MySqlCommand command = conn.CreateCommand();

                conn.Open();
                command.CommandText = "Delete from tbl_transaction where col_transactioncode='" + labelTransactionCode.Text + "'";
                command.ExecuteScalar();
                conn.Close();
            }
            catch (Exception e) 
            {
                MessageBox.Show("No connection to host");
            }
        }
        public void printitemdetails()
        {
            try
            {
                if (materialListView2.SelectedItems.Count > 0)
                {
                    int data = 0;
                    ListViewItem list = materialListView2.SelectedItems[data];
                    String id = list.SubItems[0].Text;
                    tbProductCode.Text = id.ToString();
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Select only one Product at a time");

            }
            try
            {
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
                    tbSearchItem.Text = (read["col_productcode"].ToString());
                    tbProductName.Text = (read["col_productname"].ToString());
                    tbBrand.Text = (read["col_brandname"].ToString());
                    tbCategory.Text = (read["col_categoryname"].ToString());
                    tbPrice.Text = (read["col_productprice"].ToString());
                }
                conn.Close();
            }
            catch (Exception e) 
            {
                MessageBox.Show("No Connection to host");
            }
            
        }
        public void printorderid()
        {
            try
            {
                if (materialListView1.SelectedItems.Count > 0)
                {
                    int data = 0;
                    ListViewItem list = materialListView1.SelectedItems[data];
                    String id = list.SubItems[0].Text;
                    tbOrderId.Text = id.ToString();
                }
                
            }
            catch (Exception e) 
            {
                MessageBox.Show("Select only one product");
            }
        }

        public void searchProduct()
        {
            try
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
            catch (Exception e) 
            {
                MessageBox.Show("No Connection to host");
            }
        }
        public void Change()
        {
            double Num;
            if (!string.IsNullOrWhiteSpace(tbAmount.Text) && double.TryParse(tbAmount.Text, out Num))
            {
                double money = Double.Parse(tbAmount.Text);
                double total = Double.Parse(labelTotalSales.Text);
                labelChange.Text = (money - total).ToString();
            }
        }
        public void TodaysSales()
        {
            try
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
            catch (Exception e) { MessageBox.Show("No connection to host"); }
        }
        public void TransactionOutput()
        {
            try
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
            catch (Exception e) 
            {
                MessageBox.Show("No connection to host");
            }
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

                    string query = "insert into tbl_order(col_transactionid,col_productid,col_staticprice,col_quantitybought,col_subtotal,col_orderstatus) " +
                        "values ((Select col_transactionid from tbl_transaction where col_transactioncode ='" + labelTransactionCode.Text + "'), " +
                        "(Select col_productid from tbl_product where col_productcode='" + tbProductCode.Text + "'),'"+tbPrice.Text+"','" + tbQuantity.Text + "','" +
                        tbSubtotal.Text + "','unfinished')";
                    command2.CommandText = query;
                    command2.ExecuteNonQuery();
                    conn.Close();
                    //MessageBox.Show(query);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No Connection to host");

            }
        }
        public void InsertTransaction()
        {
            try
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
            catch (Exception e) 
            {
                MessageBox.Show("No connection to host");
            }
        }
        public void InsertTransactionTotalAmount()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                if (labelTotalSales.Text == "0.00")
                {
                    MessageBox.Show("Please select an item.");
                }
                else if (materialListView1.Items.Count == 0)
                {
                    MessageBox.Show("Please select an item.");
                }
                else if (string.IsNullOrWhiteSpace(tbAmount.Text))
                {
                    MessageBox.Show("Please enter tender amount.");
                }
                //else if (int.Parse(tbAmount.Text) == 0)
                //{
                //    MessageBox.Show("Tender should be greater than 0.");
                //}
                else if (tbAmount.Text == "" || tbAmount.Text == ".")
                {
                    MessageBox.Show("Please enter tender amount.");
                }
                else if (double.Parse(tbAmount.Text) < double.Parse(labelTotalSales.Text))
                {
                    MessageBox.Show("Insufficient Tender amount.");
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

                    conn.Open();
                    MySqlCommand command3 = conn.CreateCommand();
                    string query2 = "UPDATE tbl_order SET " +
                        "col_orderstatus='Sales' Where col_transactionid = (SELECT col_transactionid from tbl_transaction where col_transactioncode = '" + labelTransactionCode.Text + "')";
                    // MessageBox.Show(query2);
                    command3.CommandText = query2;
                    command3.ExecuteScalar();
                    conn.Close();




                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 400, 800);
                    printPreviewDialog1.Size = new System.Drawing.Size(400, 800);
                    printPreviewDialog1.ShowDialog();

                    MessageBox.Show("Transaction Saved!");



                    TransactionModule a = new TransactionModule(label17.Text);
                    a.Show();
                    this.Hide();

                    materialListView1.Items.Clear();
                    materialListView2.Items.Clear();
                    labelTotalSales.Text = "0.00";
                    tbAmount.Text = "0.00";
                    labelChange.Text = "0.00";

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No connection to host");
            }
           
        }
        public void viewOrder()
        {
            try
            {
                materialListView1.Items.Clear();
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);

                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                string query = "Select * from tbl_order o " +
                    "inner join tbl_transaction t " +
                    "  on t.col_transactionid = o.col_transactionid " +
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
            catch (Exception e) 
            {
                MessageBox.Show("No connection");
            }
        }
        public void remove()
        {
            try
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
            catch (Exception e) 
            {
                MessageBox.Show("No connection to host");
            }
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
            label16.Text = DateTime.Now.ToString("yyy-MM-dd");
            label19.Text = DateTime.Now.ToLongTimeString();
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

            new DataHandling().alphanumericTrap_TextChanged(sender, e);
            if (tbSearchItem.Text == "")
            {
                materialListView2.Items.Clear();
            }
            else
            {
                searchProduct();
            }
        }
        private void updatespecifiedorder()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                command2.CommandText = "insert into tbl_damage(col_transactionid,col_orderid,col_reason,col_staticquantity,col_status) " +
                    "values ((Select col_transactionid from tbl_transaction where col_transactioncode='" + textBox8.Text + "')," +
                    "(Select col_orderid from tbl_order where col_orderid = '" +
                    textBox2.Text + "'),'" +
                    textBox9.Text + "','" +
                    textBox6.Text +
                    "','pending-refund')";

                command2.ExecuteScalar();
                conn.Close();
                conn.Open();
                MySqlCommand command3 = conn.CreateCommand();
                command3.CommandText = "UPDATE tbl_order SET " +
                    "col_subtotal='" + textBox12.Text + "'" +
                    " WHERE col_orderid='" + textBox2.Text + "'";

                command3.ExecuteScalar();
                conn.Close();
                conn.Open();
                MySqlCommand command4 = conn.CreateCommand();
                command4.CommandText = "UPDATE tbl_order SET " +
                    "col_quantitybought='" + textBox10.Text + "'" +
                    " WHERE col_orderid='" + textBox2.Text + "'";

                command4.ExecuteScalar();
                conn.Close();
                MessageBox.Show("Product successfully added to the pending process for refund");

                clearAllControl();
            }
            catch (Exception e) 
            {
                MessageBox.Show("no connection to host");
            }
        }
        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") 
            {
                MessageBox.Show("Please select between Change or Refund");
            
            }
            else if (comboBox1.SelectedItem == "Change")
            {
                inserttopending();
            }
            else if (comboBox1.SelectedItem == "Refund")
            {
                int a, b;
                bool isAValid = int.TryParse(textBox5.Text, out a);
                bool isBValid = int.TryParse(textBox6.Text, out b);

                if (isAValid && isBValid)
                {
                    if (b == 0) 
                    {
                        MessageBox.Show("The item you are returning should not be zero","Message");
                    }
                    else if (a < b)
                    {
                        MessageBox.Show("The item you are returning is more than the item you bought", "Message");
                    }
                    else if (a >= b)
                    {
                        inserttopending();
                    }
                }
                else
                {
                    MessageBox.Show("Unable to return items");

                }
            }
            
        }
        private void inserttopending()
        {
            try
            {
                if (textBox8.Text != "")
                {
                    if (comboBox1.SelectedItem == "Change")
                    {
                        logreturn();
                        MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                        conn.Open();
                        MySqlCommand command2 = conn.CreateCommand();

                        string query = "insert into tbl_damage(col_transactionid,col_orderid,col_reason,col_staticquantity,col_status) " +
                            "values ((Select col_transactionid from tbl_transaction where col_transactioncode='" + textBox8.Text + "')," +
                        "(Select col_orderid from tbl_order where col_orderid = '" + textBox2.Text + "'),'" +
                        textBox9.Text + "','" +
                        textBox6.Text +
                        "', 'pending-change' )";
                        command2.CommandText = query;
                        command2.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Product successfully added to the pending process for change item");
                        clearAllControl();
                    }
                    else if (comboBox1.SelectedItem == "Refund")
                    {
                        textBox6.Visible = true;
                        label25.Visible = true;
                        logreturn();
                        updatespecifiedorder();
                    }
                    else
                    {
                        MessageBox.Show("Unable to return item /n Return item as?");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No connection to host");
            }
        
        }
        private void clearAllControl()
        {
            textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                    comboBox1.Text = "";
                    textBox12.Clear();
                    textBox11.Clear();
                    materialListView4.Items.Clear();
                    textBox8.Clear();
                    materialListView3.Items.Clear();
             
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAmount.Text))
            {
                tbAmount.Text = "0.00";
                labelChange.Text = "0.00";
            }
            //else if (System.Text.RegularExpressions.Regex.IsMatch(tbAmount.Text, "(\\..*\\.)|[^\\d+\\.\\d+]|[^\\.\\d+]"))
            //{
            //    //MessageBox.Show("Please enter only numbers.");
            //    new DataHandling().decimalNumberTrap_KeyPress(sender, e);
            //}
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tbAmount.Text, "\\d+"))
                {
                    Change();
                }
            }
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
            // Login a = new Login();
            // a.Show();
            //this.Hide();
            try {
                if (materialListView1.Items.Count == 0)
                {
                    MessageBox.Show("You haven't ordered yet");
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Are You sure you want to Cancel the Transaction?", "Message", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        logcancel();
                        materialListView1.Items.Clear();
                        materialListView2.Items.Clear();
                        labelTotalSales.Text = "0.00";
                        tbAmount.Text = "0.00";
                        labelChange.Text = "0.00";
                        TransactionDelete();
                        TransactionModule a = new TransactionModule(label17.Text);
                    }
                }
                }catch(Exception a)
            {
                MessageBox.Show("No connection to host");
                
            }
        }
        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().numbersOnlyTrap_TextChanged(sender, e);
            subtotal();
        }
        private void materialListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            printorderid();
        }
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            logpurchase();
            InsertTransactionTotalAmount();   
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
            //tbQuantity.Text = "1";
            printitemdetails();
            
        }
        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbQuantity.Text))
            {
                MessageBox.Show("Please enter quantity.");
            }
            else if (int.Parse(tbQuantity.Text) == 0)
            {
                MessageBox.Show("Quantity should be greater than 0.");
            }
            else
            {
                logaddtocart();
                InsertOrder();
                viewOrder();
                
            }
        }
        private void btnRemovefromCart_Click(object sender, EventArgs e)
        {
            logvoidfromcart();
            remove();
        }
        public void searchtransaction()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                materialListView3.Items.Clear();
                conn.Open();
                string query1 = "select * from tbl_transaction t " +
                "inner join tbl_order o on t.col_transactionid = o.col_transactionid " +
                "where o.col_orderstatus='Sales' " +
                "AND o.col_quantitybought  > 0 " +
                "AND t.col_transactioncode like  '" + textBox1.Text + "%' GROUP BY col_transactioncode";

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
            catch(Exception e)
    {
    MessageBox.Show("No connection to host");
    }}
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().alphanumericTrap_TextChanged(sender, e);
            if (textBox1.Text == "")
            {
                materialListView3.Items.Clear();
            }
            else
            {
                searchtransaction();
            }
        }
        public void printorders()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();

                materialListView4.Items.Clear();
                MySqlCommand command = conn.CreateCommand();
                string query = "Select * from tbl_order o " +
                    "inner join tbl_transaction t " +
                    "  on t.col_transactionid = o.col_transactionid " +
                    "inner join tbl_product p " +
                    "on o.col_productid = p.col_productid " +
                    "inner join tbl_brandpartner b " +
                    "on p.col_useraccountsid = b.col_useraccountsid " +
                    "inner join tbl_category c " +
                    "on c.col_categoryid = p.col_categoryid " +
                    "where t.col_transactioncode = '" + textBox8.Text + "' and o.col_orderstatus='Sales' " +
                    "and o.col_quantitybought > 0 ";
                command.CommandText = query;
                MySqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {

                    ListViewItem items = new ListViewItem(read["col_orderid"].ToString());
                    items.SubItems.Add(read["col_productcode"].ToString());
                    items.SubItems.Add(read["col_productname"].ToString());
                    items.SubItems.Add(read["col_brandname"].ToString());
                    items.SubItems.Add(read["col_categoryname"].ToString());
                    items.SubItems.Add(read["col_staticprice"].ToString());
                    items.SubItems.Add(read["col_quantitybought"].ToString());
                    items.SubItems.Add(read["col_subtotal"].ToString());
                    materialListView4.Items.Add(items);
                    materialListView4.FullRowSelect = true;
                }

                conn.Close();
            }
        catch(Exception e)
    {
    MessageBox.Show("No Connection to host");
    }}
        public void printtransid() 
        {
            try
            {
                int data = 0;
                ListViewItem list = materialListView3.SelectedItems[data];
                String id = list.SubItems[1].Text;
                textBox8.Text = id.ToString();
                textBox1.Text = id.ToString();
                printorders();
            }
            catch (Exception E) 
            {
                MessageBox.Show("Select only one transaction");
            }
        }
        private void materialListView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            printtransid();
        }
        public void printorderdetails()
        {

            int data = 0;
            try
            {
                if (materialListView4.SelectedItems.Count > 0)
                {
                    ListViewItem list = materialListView4.SelectedItems[data];
                    String id = list.SubItems[0].Text;
                    textBox2.Text = id.ToString();
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Select only one order");
            }

            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();

                MySqlCommand command = conn.CreateCommand();
                string query = "Select * from tbl_order o " +
                    "inner join tbl_transaction t " +
                    "  on t.col_transactionid = o.col_transactionid " +
                    "inner join tbl_product p " +
                    "on o.col_productid = p.col_productid " +
                    "inner join tbl_brandpartner b " +
                    "on p.col_useraccountsid = b.col_useraccountsid " +
                    "inner join tbl_category c " +
                    "on c.col_categoryid = p.col_categoryid " +
                    "where o.col_orderid= '" + textBox2.Text + "'";
                command.CommandText = query;
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    textBox3.Text = read["col_productname"].ToString();
                    textBox4.Text = read["col_productcode"].ToString();
                    textBox5.Text = read["col_quantitybought"].ToString();
                    textBox7.Text = read["col_staticprice"].ToString();
                }
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("No connection to hoste");

            }
        }
        private void materialListView4_SelectedIndexChanged(object sender, EventArgs e)
        {

            printorderdetails();
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
                DialogResult dialog = MessageBox.Show( "Are You sure you want to Log-out?", "Message", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    TransactionDelete();
                    Login a = new Login();
                    a.Show();
                    this.Hide();
                }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
        public void SubtractQuantityForDamage() 
        {

            int a, b,c,d;
            bool isAValid = int.TryParse(textBox5.Text, out a);
            bool isBValid = int.TryParse(textBox6.Text, out b);
            bool isCValid = int.TryParse(textBox7.Text, out c);
            bool isDValid = int.TryParse(textBox12.Text, out d);

            if (isAValid && isBValid)
            {
                textBox10.Text = (a - b).ToString();
                textBox11.Text = (c * b).ToString();
                textBox12.Text = ((a - b) * c).ToString();
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().numbersOnlyTrap_TextChanged(sender, e);
            SubtractQuantityForDamage();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            new DataHandling().namingTrap_TextChanged(sender, e);
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            new DataHandling().decimalNumberTrap_KeyPress(sender, e);
        }

        private void materialListView4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            printorderdetails();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialListView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int ii = 1;
            int startX, startY, Offset, offsetHead;
            //int total = 0;
            startX = 10;
            
            Offset = 0;
            offsetHead = 20;
            e.Graphics.DrawString(" \t\tPosh Concept Store", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 10, 20);
            offsetHead += 20;
            e.Graphics.DrawString(" \t\t#40 Salinas Drive ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 10, 20 + offsetHead);
            offsetHead += 20;
            e.Graphics.DrawString(" \t\tLahug Cebu City ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 10, 20 + offsetHead);
            offsetHead += 20;
            e.Graphics.DrawString(" \t\tCebu 6000 ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 10, 20 + offsetHead);
            offsetHead += 20;
            e.Graphics.DrawString(" ===================================== ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 10, 20 + offsetHead);
            offsetHead += 20;
            e.Graphics.DrawString(" " + label2.Text + " " + label7.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 10, 20 + offsetHead);
            offsetHead += 20;
            e.Graphics.DrawString(" Sales Invoice No." + labelTransactionCode.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 10, 20 + offsetHead);
            offsetHead += 20;
            e.Graphics.DrawString(" Cashier ID: " + label17.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 10, 20 + offsetHead);
            offsetHead += 20;
            e.Graphics.DrawString(" ===================================== ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 10, 20 + offsetHead);
            offsetHead += 20;
            e.Graphics.DrawString(" " +
                "ProdCode" + "\t" +
                "Price" + "\t" +
                "Qty" + "\t" +
                "Sub total"
              , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 10, 20 + offsetHead);

            startY = offsetHead + 40;
            startX = 10;
            for (int i = 0; i < materialListView1.Items.Count; i++)
            {
                // Not sure what/why these two are here 
                //startX += i;
                //startY += ii++;

                // Draw the row details for ? receipt 
                e.Graphics.DrawString(" " + 
                    materialListView1.Items[i].SubItems[2].Text + "\t\t" +
                    materialListView1.Items[i].SubItems[5].Text + "\t" +
                    materialListView1.Items[i].SubItems[6].Text + "\t" +
                    materialListView1.Items[i].SubItems[7].Text
                  , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, startX, startY + Offset);

                // Move the next print position 'down the page' ie, y axis increases from top to bottom
                Offset = Offset + 20;

                //total += int.Parse(materialListView1.Items[i].SubItems[2].Text.ToString());

        }
                Offset += 20;
                e.Graphics.DrawString(" =================================== ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, startX, startY + Offset);
                Offset += 20;
                e.Graphics.DrawString(" \t\t\tTotal:\t" +
                    labelTotalSales.Text + "\t", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, startX, startY + Offset);
                Offset += 20;
                e.Graphics.DrawString(" \t\tTender Amount:\t" +
                    tbAmount.Text + "\t", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, startX, startY + Offset);
                Offset += 20;
                e.Graphics.DrawString(" \t\t\tChange:\t" +
                    labelChange.Text + "\t", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, startX, startY + Offset);
    }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            clearAllControl();
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearAllControl();
            materialListView1.Items.Clear();
            materialListView2.Items.Clear();
            labelTotalSales.Text = "0.00";
            tbAmount.Text = "0.00";
            labelChange.Text = "0.00";
            tbQuantity.Text = "";
            tbSearchItem.Text = "";
        }
        
    }
}
