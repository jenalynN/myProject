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

        string myConnection = "Server=localhost;Database=db_poshandfabconceptstore;Uid=root;Password="; 
        public TransactionModule()
        {
            InitializeComponent();
            displayDate();

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
            string query = "select P.col_productid,P.col_productcode, B.col_brandname,  C.col_categoryname,  P.col_productprice from tbl_product P LEFT JOIN tbl_branduser B ON B.col_brandid = P.col_brandid LEFT JOIN tbl_category C ON C.col_categoryid = P.col_categoryid where P.col_status='unarchived' and P.col_productid='"+textBox4.Text+"'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {

                ListViewItem items = new ListViewItem(read["col_productid"].ToString());
                textBox4.Text = (read["col_productid"].ToString());
                textBox5.Text = (read["col_productcode"].ToString());
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

                ListViewItem items = new ListViewItem(read["col_productid"].ToString());
                items.SubItems.Add(read["col_productcode"].ToString());


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
        }
        public void Insert() 
        {

            string[] row = { textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox1.Text, textBox8.Text, textBox9.Text };
            var listViewItem = new ListViewItem(row);
            materialListView1.Items.Add(listViewItem);
            materialListView1.FullRowSelect = true;
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
            if (textBox1.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" )
            {
                MessageBox.Show("Please complete the form");
            }
            else 
            {
                subtotal();
                Insert();
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
