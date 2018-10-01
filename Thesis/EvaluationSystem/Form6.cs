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
    public partial class Form6 : MetroForm
    {
        string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password="; 
        public Form6()
        {
            InitializeComponent();
            view();
        }
        private void view1()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            listView1.Items.Clear();
            conn.Close();


            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query1 = "select * from instructor where last like'" + metroTextBox1.Text + "%'";
            command.CommandText = query1;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {

                ListViewItem items = new ListViewItem(read["id"].ToString());
                items.SubItems.Add(read["last"].ToString());
                items.SubItems.Add(read["first"].ToString());
                items.SubItems.Add(read["middle"].ToString());
                items.SubItems.Add(read["department"].ToString());



                listView1.Items.Add(items);
                listView1.FullRowSelect = true;
            }
            conn.Close();

        }
            public void delete() 
        
        {
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "delete from instructor where id = '" + metroTextBox2.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();
            view();
            metroTextBox2.Text = "";
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
            string query = "select * from instructor where id = '" + metroTextBox2.Text + "'";
            command.CommandText = query;
            MySqlDataReader read1 = command.ExecuteReader();

            while (read1.Read())
            {
                metroTextBox2.Text = read1["id"].ToString();


            }
            conn.Close();
        }
        public void view()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            listView1.Items.Clear();
            conn.Close();


            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query = "select * from instructor";
            command.CommandText = query;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem items = new ListViewItem(read["id"].ToString());
                items.SubItems.Add(read["last"].ToString());
                items.SubItems.Add(read["first"].ToString());
                items.SubItems.Add(read["middle"].ToString());
                items.SubItems.Add(read["department"].ToString());
              

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
                InstructorInformation a = new InstructorInformation(filter_data.Text);
                a.Show();
                this.Hide();

            }
        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {
            AddIns a = new AddIns();
            a.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AddIns a = new AddIns();
            a.Show();
            this.Hide();
        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {
            Question a = new Question();
            a.Show();
                this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Question a = new Question();
            a.Show();
            this.Hide();
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            this.Hide();
        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            this.Hide();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            print();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            view1();
        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }
    }
}
