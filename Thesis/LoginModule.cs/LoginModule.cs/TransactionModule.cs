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
            check(); 
            textBox6.Visible = true;
            label25.Visible = true;
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
                tbSearchItem.Text = (read["col_productcode"].ToString());
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
            else if (tbAmount.Text == ""  || tbAmount.Text == ".")
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
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
           
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                command2.CommandText = "insert into tbl_damage(col_transactionid,col_orderid,col_reason,col_staticquantity,col_status) " +
                    "values ((Select col_transactionid from tbl_transaction where col_transactioncode='" + textBox8.Text + "')," +
                    "(Select col_orderid from tbl_order where col_orderid = '" + textBox2.Text + "'),'" + textBox9.Text + "','"+textBox6.Text+"','pending-refund')";

                command2.ExecuteScalar();
                conn.Close();
                MessageBox.Show("Product successfully added to the pending process for refund");
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox9.Clear();
                textBox10.Clear();
                comboBox1.Text = "";
                materialListView4.Items.Clear();
                textBox8.Clear();
                materialListView3.Items.Clear();
        }
        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Change")
            {
                inserttopending();
            }
            else if(comboBox1.SelectedItem=="Refund"){
            int a, b;
            bool isAValid = int.TryParse(textBox5.Text, out a);
            bool isBValid = int.TryParse(textBox6.Text, out b);

            if (isAValid && isBValid)
            {
                if (a >= b)
                {
                inserttopending();
                }
                else if (a < b) 
                {
                    MessageBox.Show("The item you are returning is more than the item you bought","Message");
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
            if (comboBox1.SelectedItem == "Change")
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();

                string query = "insert into tbl_damage(col_transactionid,col_orderid,col_reason,col_status) " +
                    "values ((Select col_transactionid from tbl_transaction where col_transactioncode='" + textBox8.Text + "')," +
                    "(Select col_orderid from tbl_order where col_orderid = '" + textBox2.Text + "'),'" + textBox9.Text + "','pending-change')";
                command2.CommandText = query;
                command2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Product successfully added to the pending process for change item");
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox9.Clear();
                textBox10.Clear();
                comboBox1.Text = "";
                materialListView4.Items.Clear();
                textBox8.Clear();
                materialListView3.Items.Clear();
            }
            else if (comboBox1.SelectedItem == "Refund")
            {
                textBox6.Visible = true;
                label25.Visible = true;
                updatespecifiedorder();
            }
            else 
            {
                MessageBox.Show("Unable to return item /n Return item as?");
            }

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
            DialogResult dialog = MessageBox.Show( "Are You sure you want to Cancel the Transaction?", "Message", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                materialListView1.Items.Clear();
                materialListView2.Items.Clear();
                labelTotalSales.Text = "0.00";
                tbAmount.Text = "0.00";
                labelChange.Text = "0.00";

                TransactionDelete();
            }
            TransactionModule a = new TransactionModule(label17.Text);
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
                InsertOrder();
                viewOrder();
            }
        }
        private void btnRemovefromCart_Click(object sender, EventArgs e)
        {
            remove();
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
                "where t.col_transactioncode = '" + textBox8.Text + "'";
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
        public void printtransid() 
        {
            int data = 0;
            ListViewItem list = materialListView3.SelectedItems[data];
            String id = list.SubItems[1].Text;
            textBox8.Text = id.ToString();
            printorders();
        }
        private void materialListView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            printtransid();
        }
        public void printorderdetails() 
        {
            int data = 0;
            ListViewItem list = materialListView4.SelectedItems[data];
            String id = list.SubItems[0].Text;
            textBox2.Text = id.ToString();
            
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
        private void check() 
        {
            if (comboBox1.SelectedItem== "Change")
            {
                textBox6.Visible = false;
                label25.Visible = false;
            }
            else if (comboBox1.SelectedItem == "Refund")
            {
                textBox6.Visible = true;
                label25.Visible = true;
            }
        }
     
        private void materialListView4_SelectedIndexChanged(object sender, EventArgs e)
        {

            printorderdetails();
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            TransactionDelete();
            Login a = new Login();
            a.Show();
            this.Hide();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
        public void SubtractQuantityForDamage() 
        {

            int a, b;
            bool isAValid = int.TryParse(textBox5.Text, out a);
            bool isBValid = int.TryParse(textBox6.Text, out b);

            if (isAValid && isBValid)
            {
                textBox10.Text = (a - b).ToString();
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
            check();
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

            for (int i = 0; i < materialListView1.Items.Count; i++)
            {
                // Not sure what/why these two are here 
                startX += i;
                startY += ii++;

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
        
    }
}
