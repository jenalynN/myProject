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
    public partial class Pizza : Form
    {
        string myConnection = "Server=localhost;Database= dbpizza ;Uid=root;Password=";
        public Pizza()
        {
            InitializeComponent();
            view();
            //comboBoxPsize.SelectedItem = "SELECT";
            
        }

        public void view()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            conn.Open();

            MySqlCommand view = conn.CreateCommand();
            view.Connection = conn;
            view.CommandText = "Select * from tb_pizzalist";
            MySqlDataReader reader = view.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem list = new ListViewItem(reader["id"].ToString());
                list.SubItems.Add(reader["pizza_name"].ToString());
                list.SubItems.Add(reader["pizza_size"].ToString());
                list.SubItems.Add(reader["pizza_price"].ToString());

                listViewPizza.Items.Add(list);
            }
            conn.Close();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(myConnection);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO tb_pizzalist(pizza_name,pizza_size,pizza_price) VALUES ('" + textBoxPname.Text + "','" + comboBoxPsize.Text + "','" + textBoxPprice.Text + "')";
            cmd.ExecuteNonQuery();


            textBoxPname.Clear();
            comboBoxPsize.Text = ("-SELECT-");
            textBoxPprice.Clear();

            listViewPizza.Items.Clear();
            view();
            conn.Close();
        }

        private void Pizza_Load(object sender, EventArgs e)
        {
            comboBoxPsize.Text = ("-SELECT-");
        }

        private void listViewPizza_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(myConnection);


            foreach (ListViewItem item in listViewPizza.SelectedItems)
            {
                textBox2.Text = item.SubItems[0].Text;
                textBoxPname.Text = item.SubItems[1].Text;
                comboBoxPsize.Text = item.SubItems[2].Text;
                textBoxPprice.Text = item.SubItems[3].Text;

            }
            MySqlConnection connec = new MySqlConnection(myConnection);

            connec.Close();

            connec.Open();
            MySqlCommand view = connec.CreateCommand();
            view.Connection = connec;
            view.CommandText = "select * from tb_pizzalist where pizza_name = '" + textBox2.Text + "' ";
            MySqlDataReader reader = view.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["id"].ToString();
                textBox2.Text = id;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from tb_pizzalist where id = '" + textBox2.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();
            int count = 0;
            while (read.Read())
            {
                count++;
            }
            if (count == 1)
            {

                conn.Close();
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                string query1 = "UPDATE tb_pizzalist SET pizza_name = '" + textBoxPname.Text + "' , pizza_size = '" + comboBoxPsize.Text + "' , pizza_price = '" + textBoxPprice.Text + "' where id = '" + textBox2.Text + "' ";
                command2.CommandText = query1;
                command2.ExecuteNonQuery();

                textBoxPname.Clear();
                comboBoxPsize.Text = ("-SELECT-");
                textBoxPprice.Clear();


                listViewPizza.Items.Clear();
                view();
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conec = new MySqlConnection(myConnection);
            conec.Open();

            MySqlCommand cmd = conec.CreateCommand();
            cmd.Connection = conec;
            cmd.CommandText = "DELETE from tb_pizzalist where id = '" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();


            textBoxPname.Clear();
            comboBoxPsize.Text = ("-SELECT-");
            textBoxPprice.Clear();

            listViewPizza.Items.Clear();
            view();
            conec.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsSymbol(e.KeyChar) || Char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || Char.IsSeparator(e.KeyChar);
        }

        private void textBoxPprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsSymbol(e.KeyChar) || Char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || Char.IsSeparator(e.KeyChar);
        }
    }
}
