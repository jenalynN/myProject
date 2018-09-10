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
    public partial class Reports : Form
    {
        string myConnection = "Server=localhost;Database= dbpizza ;Uid=root;Password=";
        public Reports()
        {
            InitializeComponent();
            view();
        }

        public void view()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            listViewReports.Items.Clear();
            conn.Close();

            conn.Open();
            MySqlCommand view = conn.CreateCommand();
            view.Connection = conn;
            view.CommandText = "SELECT order_id,date_ordered,pizza_name,pizza_size, count(pizza_id) from tb_order o inner join tb_pizzalist p on o.pizza_id = p.id group by p.id";
            MySqlDataReader reader = view.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem list = new ListViewItem(reader["date_ordered"].ToString());
                list.SubItems.Add(reader["pizza_name"].ToString());
                list.SubItems.Add(reader["pizza_size"].ToString());
                list.SubItems.Add(reader["count(pizza_id)"].ToString());
                listViewReports.Items.Add(list);

            }
            conn.Close();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            view();
        }
    }
}
