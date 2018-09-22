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
    public partial class Form5 :MetroForm
    {
        string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password="; 
        public Form5()
        {
            InitializeComponent();
            view();
        }
        public void delete()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "delete from department where id = '" + metroTextBox2.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();
        }
        public void print() 
        {
            int data = 0;
            ListViewItem list = listView1.SelectedItems[data];
            String id = list.SubItems[0].Text;
            metroTextBox2.Text = id.ToString();
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from department where Id = '" + metroTextBox2.Text + "'";
            command.CommandText = query;
            MySqlDataReader read1 = command.ExecuteReader();

            while (read1.Read())
            {
                metroTextBox2.Text = read1["Id"].ToString();
                

            }
            conn.Close();
        
        }
        public void view()
        {
            {
                MySqlConnection conn = new MySqlConnection(myConnection);
                listView1.Items.Clear();
                conn.Close();


                conn.Open();
                MySqlCommand command = conn.CreateCommand();

                string query = "select * from department";
                command.CommandText = query;

                MySqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem items = new ListViewItem(read["Id"].ToString());
                    items.SubItems.Add(read["DepartmentName"].ToString());
               


                    listView1.Items.Add(items);
                    listView1.FullRowSelect = true;
                }
                conn.Close();
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {
            AddDept a = new AddDept();
            a.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AddDept a = new AddDept();
            a.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            print();
        }

        private void Form5_MouseClick(object sender, MouseEventArgs e)
        {
            print();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            delete();
            view();
            metroTextBox2.Text = "";
        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {
            delete();
            view();
            metroTextBox2.Text = "";
        }
    }
}
