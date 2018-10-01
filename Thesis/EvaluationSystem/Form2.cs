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
    public partial class Form2 : MetroForm
    {
        string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password="; 
        public Form2()
        {
            InitializeComponent();
            View();
         
            //
            {
                
            }
        }
        public void delete()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "delete from sched where schedid = '" + metroTextBox2.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();
            View();
        
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
            string query = "select * from sched where schedid = '" + metroTextBox2.Text + "'";
            command.CommandText = query;
            MySqlDataReader read1 = command.ExecuteReader();

            while (read1.Read())
            {
                metroTextBox2.Text = read1["schedid"].ToString();


            }
        }
        public void View()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            listView1.Items.Clear();
            conn.Close();


            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query = "select * from sched";
            command.CommandText = query;

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
            foreach (ListViewItem items in listView1.Items)
            {
                if ((items.SubItems[2].ToString() == "as"))
                {

                    items.BackColor = Color.White;
                }
                else
                {
                    items.BackColor = Color.LightBlue;

                }


            }
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

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel22_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {
            AddSched a = new AddSched();
            a.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
                
            AddSched a = new AddSched();
            a.Show();
            this.Hide();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            print();
            View();
        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }

        private void metroLabel21_Click(object sender, EventArgs e)
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

        private void metroLabel16_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.Show();
            this.Hide();
        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
