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

        string myConnection = "Server=localhost;Database=db_poshconceptstorefinal;Uid=root;Password="; 
        public TransactionModule(string cashier)
        {
            InitializeComponent();
            displayDate();
            TransactionOutput();
            textBox3.Text = cashier;

        }
      
        public void displayDate() 
        {

            timer1.Start();
            label6.Text = DateTime.Now.ToLongDateString();
            label7.Text = DateTime.Now.ToLongTimeString();
        
        }
        public void printitemdetails() 
        {
            int data = 0;
            ListViewItem list = materialListView2.SelectedItems[data];
            String id = list.SubItems[0].Text;
            textBox4.Text = id.ToString();
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select P.col_productid,P.col_productcode, P.col_productname ," +
                "B.col_brandname,  C.col_categoryname,  P.col_productprice from tbl_product P " +
                "LEFT JOIN tbl_brandpartner B ON B.col_useraccountsid = P.col_useraccountsid " +
                "LEFT JOIN tbl_category C ON C.col_categoryid = P.col_categoryid " +
                "where P.col_status='unarchived' and P.col_productcode='" + textBox4.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {

                ListViewItem items = new ListViewItem(read["col_productid"].ToString());
                textBox4.Text = (read["col_productcode"].ToString());
                textBox10.Text = (read["col_productname"].ToString());
                textBox6.Text=(read["col_brandname"].ToString());
                textBox7.Text=(read["col_categoryname"].ToString());

                textBox8.Text=(read["col_productprice"].ToString());
            }
            conn.Close();
            conn.Close();
        
        }
        public void searchProduct() 
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            materialListView2.Items.Clear();
            conn.Open();
            string query1 = "select * from tbl_product  where col_productcode like  '" + textBox3.Text + "%'  and col_status='unarchived'";

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
            
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                double money = Double.Parse(textBox2.Text);
                double total = Double.Parse(label2.Text);
                label3.Text = (money - total).ToString();
            }
        }public void TransactionOutput()
        {
            MySqlConnection connection = new MySqlConnection(myConnection);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from tbl_transaction";
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                MySqlConnection con = new MySqlConnection(myConnection);
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
                    label15.Text = "PCS01" + total;
                }


                con.Close();
            }




        }
        public void InsertOrder() 
        {
                MySqlConnection conn = new MySqlConnection(myConnection);
                MySqlConnection conn2 = new MySqlConnection(myConnection);
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
                    command2.CommandText = "insert into tbl_order(col_transactionid,col_productid,col_quantitybought,col_subtotal,col_status) values ((SELECT col_transactionid from tbl_transaction where col_transactionid='" + label15.Text + "'),(SELECT col_productid from tbl_product where col_productname='" + textBox4.Text +"'),'" + textBox1.Text + "','" + textBox10.Text +"','unfinished')";
                    command2.ExecuteScalar();
                    conn.Close();
                }
        }
        public void InsertTransaction()
        {
            {
                MySqlConnection conn = new MySqlConnection(myConnection);
                MySqlConnection conn2 = new MySqlConnection(myConnection);
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
                    command2.CommandText = "insert into tbl_transaction(col_transactioncode,col_dateofpurchase) values ('" + label15.Text + "',now())";
                    command2.ExecuteScalar();
                    conn.Close();
                }
            }
        }
        public void clear()  
        {
            textBox3.Clear();
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            searchProduct();
        
        }
        public void remove() 
        {

            for (int i = materialListView1.Items.Count - 1; i >= 0; i--)
            {
                if (materialListView1.Items[i].Selected)
                {
                    materialListView1.Items[i].Remove();
                }
            }
        }
        public void subtotal() 
        {
            double itemsold = Double.Parse(textBox1.Text);
            double price = Double.Parse(textBox8.Text);
            textBox9.Text = (price * itemsold).ToString();
        }
        public void total()
        {
            float value = 0;

            for (int i = 0; i < materialListView1.Items.Count; i++)
            {
                value += float.Parse(materialListView1.Items[i].SubItems[6].Text);
            }

           label2.Text = Convert.ToString(value);
        
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
                this.Close();
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label7.Text = DateTime.Now.ToLongTimeString();
            label6.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            InsertTransaction();
            if (textBox1.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" )
            {
                MessageBox.Show("Please complete the form");
            }
            else 
            {
                InsertOrder();
                InsertTransaction();
                subtotal();
                total();
                clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                materialListView2.Items.Clear();
            }
            else
            {
                searchProduct();
            }
        }

        private void materialListView2_DoubleClick(object sender, EventArgs e)
        {
            printitemdetails();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            remove();

            total();
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
    }
}
