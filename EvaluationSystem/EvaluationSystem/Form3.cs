using MetroFramework.Forms;
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

namespace EvaluationSystem
{
    public partial class Form3 : MetroForm
    {
        string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password="; 
        public Form3()
        {
            InitializeComponent();
            view2();
           
        }
        private void view2()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            listView1.Items.Clear();
            conn.Close();


            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query1 = "select * from sched";
            command.CommandText = query1;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {

                ListViewItem items = new ListViewItem(read["schedid"].ToString());
                items.SubItems.Add(read["Subject"].ToString());
                items.SubItems.Add(read["Room"].ToString());
                items.SubItems.Add(read["TimeStart"].ToString());
                items.SubItems.Add(read["TimeEnd"].ToString());
                items.SubItems.Add(read["Instructor"].ToString());
                
               

                listView1.Items.Add(items);
                listView1.FullRowSelect = true;
            }
            conn.Close();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                filter_data.Text = item.SubItems[0].Text;
                Reports a = new Reports(filter_data.Text);
                a.Show();
                this.Hide();

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Question a = new Question();
            a.Show();
            this.Hide();

        }
    }
}
