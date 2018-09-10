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

namespace Albertos
{
    public partial class OnCall : Form
    {
        string myConnection = "Server=localhost;Database= dbpizza ;Uid=root;Password=";
        static MySqlDataReader dr;
        public OnCall()
        {
            InitializeComponent();
            view();
            
        }
        public static int idNumber;
        public static string dtp = "";
        public static string pizzid = "";
        public static string ayd = "";
        public static string date = "";
        public static string name = "";
        public static string size = "";
        public static string price = "";
        public static string quantity = "";
        public static string total = "";

        public void view()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            LVPizzaList.Items.Clear();
            conn.Close();

            conn.Open();
            MySqlCommand view = conn.CreateCommand();
            view.Connection = conn;
            view.CommandText = "select * from tb_pizzalist";
            MySqlDataReader reader = view.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem list = new ListViewItem(reader["id"].ToString());
                list.SubItems.Add(reader["pizza_name"].ToString());
                list.SubItems.Add(reader["pizza_size"].ToString());
                list.SubItems.Add(reader["pizza_price"].ToString());
                LVPizzaList.Items.Add(list);

            }
            conn.Close();
        }
        public void view2()
        {
            LVCustomer.Items.Clear();
                  
            MySqlConnection conn1 = new MySqlConnection(myConnection);
            conn1.Close();
            conn1.Open();
            MySqlCommand view = conn1.CreateCommand();
            view.Connection = conn1;
            view.CommandText = "SELECT p.id, o.id as 'orderID', pizza_name, pizza_size, pizza_price, count(pizza_id) as 'pizza', sum(pizza_price) as'total'from tb_order o inner join tb_pizzalist p on p.id=o.pizza_id where order_id= '" + tbid.Text + "' group by p.id";
            MySqlDataReader reader = view.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem list = new ListViewItem(reader["orderID"].ToString());
                list.SubItems.Add(reader["pizza_name"].ToString());
                list.SubItems.Add(reader["pizza_size"].ToString());
                list.SubItems.Add(reader["pizza_price"].ToString());
                list.SubItems.Add(reader["pizza"].ToString());
                list.SubItems.Add(reader["total"].ToString());

                LVCustomer.Items.Add(list);

            }
           
            conn1.Close();

        }
        private void Order1_Load(object sender, EventArgs e)
        {
           
            LVCustomer.Items.Clear();
            view2();
            listview1();
            MySqlConnection connection = new MySqlConnection(myConnection);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from tb_order";
            MySqlDataReader read = command.ExecuteReader();
          
            while (read.Read())
            {
                MySqlConnection con = new MySqlConnection(myConnection);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select MAX(order_id) as ayD from tb_order";
                MySqlDataReader basa = cmd.ExecuteReader();
                while (basa.Read())
                {
                    string ayd = basa["ayD"].ToString();
                    int plus1 = Int32.Parse(ayd);
                    int total = plus1 + 1;
                    tbid.Text = "" + total;
                }
                
                
                con.Close();
            }
        
            connection.Close();
            if (tbid.Text == "")
            {
                tbid.Text = "1";
            }
            //System.Drawing.Size s2 = new Size(950,550);
            //this.Size = s2;
        }
        public void listview1()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            LVPizzaList.Items.Clear();
            conn.Close();

            conn.Open();
            MySqlCommand view = conn.CreateCommand();
            view.Connection = conn;
            view.CommandText = "select * from tb_pizzalist";
            MySqlDataReader reader = view.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem list = new ListViewItem(reader["pizza_name"].ToString());
                list.SubItems.Add(reader["pizza_size"].ToString());
                list.SubItems.Add(reader["pizza_price"].ToString());


                LVPizzaList.Items.Add(list);
            }

            conn.Close();
        }
        public void order()
        {
            string variable = "";

            //double sub = 0;
            //double total = 0;


            //sub = Double.Parse(tbtotal.Text);
            //total = Double.Parse(label13.Text);

            //total = total + sub;

            //label13.Text = total.ToString();

            if (rbDineIn.Checked == true)
            {
                variable = "Dine In";
            }
            else if (rbOncall.Checked == true)
            {
                variable = "On Call";
            }
           int orderNo = int.Parse(tbquantity.Text);
           idNumber = int.Parse(tbid.Text);
           
            

            MySqlConnection connec = new MySqlConnection(myConnection);
            connec.Open();
            MySqlCommand command = new MySqlCommand();
            MySqlCommand command2 = new MySqlCommand();
            command.Connection = connec;
            command2.Connection = connec;
          //  command.CommandText = "INSERT INTO tb_order (order_id,date_ordered,cus_name,cus_num,cus_add,pizza_id,pizza_quantity,total,type) values ('" + tbid.Text + "','" + dtpDateOrdered.Text + "','" + tbCName.Text + "','" + tbCoNum.Text + "','" + tbCAddress.Text + "','" + textBoxid.Text + "','" + tbquantity.Text + "', '" + tbtotal.Text + "','" + variable + "')";

           
                for (int i = 0; i < orderNo; i++)
                {
                    command.CommandText = "INSERT INTO tb_order (order_id,date_ordered,cus_name,cus_num,cus_add,pizza_id,type) values ('" + tbid.Text + "','" + dtpDateOrdered.Text + "','" + tbCName.Text + "','" + tbCoNum.Text + "','" + tbCAddress.Text + "','" + textBoxid.Text + "','" + variable + "')";
                    command.ExecuteNonQuery();
                    
                }

            tbName.Clear();
            tbsize.Clear();
            tbprice.Clear();
            tbquantity.Clear();
            tbtotal.Clear();
          //  LVCustomer.Refresh();
            LVPizzaList.Refresh();
            connec.Close();
            view2();     
        }
        public void confirm()
        {

            string variable = "";


            if (rbDineIn.Checked == true)
            {
                variable = "Dine In";
            }
            else if (rbOncall.Checked == true)
            {
                variable = "On Call";
            }


            MySqlConnection connection = new MySqlConnection(myConnection);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT pizza_name, pizza_size, pizza_price, count(pizza_id) as 'pizza', sum(pizza_price) as'total'from tb_order o inner join tb_pizzalist p on p.id=o.pizza_id where order_id= idNumber group by pizza_name";
            command.ExecuteNonQuery();
          //  MessageBox.Show("Transaction Successful");
            


            string cor = "";
            if(rbDineIn.Checked )
            {
               cor = "DineIN";
            }
            else if (rbOncall.Checked )
            {
                cor = "OnCall";
            }

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem list = new ListViewItem(reader["pizza_name"].ToString());
                list.SubItems.Add(reader["pizza_size"].ToString());
                list.SubItems.Add(reader["pizza_price"].ToString());
                list.SubItems.Add(reader["pizza"].ToString());
                list.SubItems.Add(reader["total"].ToString());

                LVCustomer.Items.Add(list);

            }
            connection.Close();
            LVCustomer.Items.Clear();


            tbid.Clear();
            tbName.Clear();
            tbsize.Clear();
            tbprice.Clear();
            tbquantity.Clear();
            tbprice.Clear();
            tbtotal.Clear();
        }
        public void remove()
        {
          
                MySqlConnection connec = new MySqlConnection(myConnection);
                connec.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connec;
                command.CommandText = "Delete from tb_order where id = '" + textBoxpizzaid.Text + "'";
                command.ExecuteNonQuery();
            
              view2();

              //double sub = 0;
              //double total = 0;


              //sub = Double.Parse(tbtotal.Text);
              //total = Double.Parse(label13.Text);

              //total = total - sub;

              //label13.Text = total.ToString();
            

             tbName.Text = "";
             tbsize.Text = "";
             tbprice.Text = "";
             tbquantity.Text = "";
             tbtotal.Text = "";
             

            
        }
        //public void truncate() 
        //{
        //    MySqlConnection con = new MySqlConnection(myConnection);
        //    con.Open();

        //    MySqlCommand cmd = con.CreateCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "TRUNCATE TABLE "
        //}
        
        private void LVPizzaList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(myConnection);

            foreach (ListViewItem item in LVPizzaList.SelectedItems)
            {
                tbName.Text = item.SubItems[0].Text;
                tbsize.Text = item.SubItems[1].Text;
                tbprice.Text = item.SubItems[2].Text;
            }

            MySqlConnection connec = new MySqlConnection(myConnection);

            connec.Close();

            connec.Open();
            MySqlCommand view = connec.CreateCommand();
            view.Connection = connec;
            view.CommandText = "select * from tb_pizzalist where pizza_name = '" + tbName.Text + "'  && pizza_size = '"+tbsize.Text+"' ";
            MySqlDataReader reader = view.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["id"].ToString();
                textBoxid.Text = id;

            }
            panel2.Visible = true;
            

            //Order form = new Order(tbid.Text, textBoxid.Text);

            //form.Show();
            //tbquantity.Enabled = true;
            //pizzid = textBoxid.Text;
            //ayd = tbid.Text;
            //name = tbName.Text;
            //size = tbsize.Text;
            //price = tbprice.Text;
            //quantity = tbquantity.Text;
            //total = tbtotal.Text;
            //dtp = dtpDateOrdered.Text;
            
            //Form3 frm = new Form3();
            //frm.Show();
        }
        double x, z;
        double sum;
        private void tbquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbprice.Text.Length == 0)
                {
                    tbprice.Text = "";
                }
                x = double.Parse(tbprice.Text);
                z = double.Parse(tbquantity.Text);
                sum = x * z;
                tbtotal.Text = sum.ToString() + ".00";
            }
            catch (Exception)
            {
            }
        }

        private void tbprice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbprice.Text.Length == 0)
                {
                    tbprice.Text = "";
                }
                x = double.Parse(tbprice.Text);
                z = double.Parse(tbquantity.Text);
                sum = x * z;
                tbtotal.Text = sum.ToString() + ".00";

            }
            catch (Exception)
            {
            }

        }
        private void btorder_Click(object sender, EventArgs e)
        {
            order();
        }

        private void rbDineIn_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDineIn.Checked == true)
            {
                groupBox1.Visible = false;
                LVPizzaList.Enabled = true;

                
            }
        }
        private void rbOncall_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rbOncall.Checked==true)
            {
                groupBox1.Visible = true;
                LVPizzaList.Enabled = true;
                
            } 
        }

        private void btconfirm_Click(object sender, EventArgs e)
        {
                Form4.idOrderNum = idNumber;

                Form4 form4 = new Form4();
                form4.Show();
                //   confirm();
                //LVCustomer.Items.Clear();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home();
            form.Show();
        }

        private void LVCustomer_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(myConnection);


            foreach (ListViewItem item in LVCustomer.SelectedItems)
            {
                tbName.Text = item.SubItems[0].Text;
                tbsize.Text = item.SubItems[1].Text;
                tbprice.Text = item.SubItems[2].Text;
                tbquantity.Text = item.SubItems[3].Text;
                tbtotal.Text = item.SubItems[4].Text;
            }
            //MySqlConnection connec = new MySqlConnection(myConnection);

            //connec.Close();

            //connec.Open();
            //MySqlCommand view = connec.CreateCommand();
            //view.Connection = connec;
            //view.CommandText = "select * from tborder where order_id = '" + tbid.Text + "'";
            //MySqlDataReader reader = view.ExecuteReader();
            //while (reader.Read())
            //{
            //    string id = reader["id"].ToString();
            //    textBoxpizzaid.Text = id;

            //}
    }

        private void button1_Click(object sender, EventArgs e)
        {
            remove();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            if (rbOncall.Checked == true)
            {
                rbOncall.Checked = false;
            }
            else if (rbDineIn.Checked == true)
            {
                rbDineIn.Checked = false;
            }
            MySqlConnection connec = new MySqlConnection(myConnection);
            connec.Open();

            MySqlCommand cmd = connec.CreateCommand();
            cmd.Connection = connec;
            cmd.CommandText = "Delete from tb_order where order_id = '" + tbid.Text + "'";
            cmd.ExecuteNonQuery();

            view2();
            tbCName.Text = "";
            tbCoNum.Text = "";
            tbCAddress.Text = "";
            tbName.Text = "";
            tbsize.Text = "";
            tbprice.Text = "";
            tbquantity.Text = "";
            tbtotal.Text = "";
            connec.Close();

            OnCall frm = new OnCall();
            frm.Show();
        }

        private void LVCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(myConnection);


            foreach (ListViewItem item in LVCustomer.SelectedItems)
            {
                textBoxpizzaid.Text = item.SubItems[0].Text;
                tbCName.Text = item.SubItems[1].Text;
                tbsize.Text = item.SubItems[2].Text;
                tbprice.Text = item.SubItems[3].Text;
                tbquantity.Text = item.SubItems[4].Text;
                tbtotal.Text = item.SubItems[5].Text;
              
            }
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            view2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            order();
            panel2.Visible = false;
            //if(rbDineIn.Checked==true)
            //{
            //    order();
            //}
            //else if (rbOncall.Checked ==true)
            //{
            //    tbCName.Text = "";
            //    tbCoNum.Text = "";
            //    tbCAddress.Text = "";

            //    MessageBox.Show("Please Fill up field","ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
        }

        private void tbCName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsSymbol(e.KeyChar) || Char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar);
        }

        private void tbCoNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsSymbol(e.KeyChar) || Char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || Char.IsSeparator(e.KeyChar);
            tbCoNum.MaxLength = 11;
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void tbtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbCName_TextChanged(object sender, EventArgs e)
        {

        }
 
        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    e.Graphics.DrawString( ,new Font("verdana",12,FontStyle.Regular),Brushes.Black,new Point(100,100));
        //}
        }
    }
