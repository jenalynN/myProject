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
    public partial class Form4 : Form
    {
        //OnCall oc = new OnCall(); 
      
       // MessageBox.Show(IdOrder);
         public static int idOrderNum;
        string myConnection = "Server=localhost;Database= dbpizza ;Uid=root;Password=";
        public Form4()
        {
            InitializeComponent();
        }

        private void LVCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            viewConfirmOrder();

          
        }


        public void viewConfirmOrder()
        {
            listViewCus.Items.Clear();


            MySqlConnection conn1 = new MySqlConnection(myConnection);
            conn1.Close();
            conn1.Open();
            MySqlCommand view = conn1.CreateCommand();
            view.Connection = conn1;
            view.CommandText = "SELECT pizza_name, pizza_size, pizza_price, count(pizza_id) as 'pizza', sum(pizza_price) as'total'from tb_order o inner join tb_pizzalist p on p.id=o.pizza_id where order_id= '"+ idOrderNum+"' group by pizza_name";
            MySqlDataReader reader = view.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem list = new ListViewItem(reader["pizza_name"].ToString());
                list.SubItems.Add(reader["pizza_size"].ToString());
                list.SubItems.Add(reader["pizza_price"].ToString());
                list.SubItems.Add(reader["pizza"].ToString());
                list.SubItems.Add(reader["total"].ToString());

                listViewCus.Items.Add(list);

            }

            conn1.Close();

             MySqlConnection conn = new MySqlConnection(myConnection);
            conn.Close();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            view.Connection = conn;
            view.CommandText = "SELECT sum(pizza_price) as'total'from tb_order o inner join tb_pizzalist p on p.id=o.pizza_id where order_id= '"+ idOrderNum+"'";
            MySqlDataReader read = view.ExecuteReader();
            while (read.Read())
            {
                totalamount.Text = (read["total"].ToString());

            }

            conn.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void receicedmoney_MouseEnter(object sender, EventArgs e)
        {

        }

        private void receicedmoney_TextChanged(object sender, EventArgs e)
        {
          
                string a = receicedmoney.Text;
                string b = totalamount.Text;
                double num1, num2, total;
                Double.TryParse(a, out num1);
                Double.TryParse(b, out num2);
           

                if (num1 >= num2)
                {

                    total = num1 - num2;
                    label7.Text = total.ToString();
                    this.label7.ForeColor = System.Drawing.Color.Black;
                    label8.Visible = true;

                }
                else
                {
                    label7.Text = "Invalid";
                    label8.Visible = false;
                    this.label7.ForeColor = System.Drawing.Color.Red;
                }
         
            }

        private void totalamount_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempdata.pizzaname = new List<string>();
            tempdata.size = new List<string>();
            tempdata.price = new List<string>();
            tempdata.quantity = new List<string>();
            tempdata.total = new List<string>();
            tempdata.totalPrice = totalamount.Text;
            tempdata.change = label7.Text;
            tempdata.cashReceived = receicedmoney.Text;
            foreach (ListViewItem l in listViewCus.Items)
            {
                tempdata.pizzaname.Add(l.Text);
                tempdata.size.Add(l.SubItems[1].Text);
                tempdata.price.Add(l.SubItems[2].Text);
                tempdata.quantity.Add(l.SubItems[3].Text);
                tempdata.total.Add(l.SubItems[4].Text);
            }
            var f = new review();
            f.Show();


        }

         
            }




        
    
    }

