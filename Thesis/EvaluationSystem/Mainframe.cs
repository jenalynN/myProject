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
    public partial class Mainframe :MetroForm
    {
        string myConnection = "Server=127.0.0.1;Database=evaluationsystem;Uid=root;Password="; 
        public Mainframe()
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

            string query1 = "select * from users where Lastname like'" + metroTextBox1.Text + "%'";
            command.CommandText = query1;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {

                ListViewItem items = new ListViewItem(read["userid"].ToString());
                items.SubItems.Add(read["lastname"].ToString());
                items.SubItems.Add(read["firstname"].ToString());
                items.SubItems.Add(read["middlename"].ToString());
                items.SubItems.Add(read["contactno"].ToString());
                items.SubItems.Add(read["yearlvl"].ToString());
                items.SubItems.Add(read["course"].ToString());
                items.SubItems.Add(read["address"].ToString());



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
            string query = "delete from users where userid = '" + metroTextBox2.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();
        }
        public void view()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            listView1.Items.Clear();
            conn.Close();


            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query = "select * from users" ;
            command.CommandText = query;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem items = new ListViewItem(read["userid"].ToString());
                items.SubItems.Add(read["lastname"].ToString());
                items.SubItems.Add(read["firstname"].ToString());
                items.SubItems.Add(read["middlename"].ToString());
                items.SubItems.Add(read["contactno"].ToString());
                items.SubItems.Add(read["yearlvl"].ToString());
                items.SubItems.Add(read["course"].ToString());
                items.SubItems.Add(read["address"].ToString());
                items.SubItems.Add(read["dob"].ToString());
             

                listView1.Items.Add(items);
                listView1.FullRowSelect = true;
            }
            conn.Close();

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
                string query = "select * from users where userid = '" + metroTextBox2.Text + "'";
                command.CommandText = query;
                MySqlDataReader read1 = command.ExecuteReader();

                while (read1.Read())
                {
                    metroTextBox2.Text = read1["userid"].ToString();
                    

                }
                conn.Close();
            }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            print();
        }
        private void listView1_MouseClick(object sender, EventArgs e)
        {
            print();
        }
        private void metroLabel13_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }
           private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                filter_data.Text = item.SubItems[0].Text;
                StudentInformation a = new StudentInformation(filter_data.Text);
                a.Show();
                this.Hide();

            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            question.Show();
            this.Hide();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            
        }
       

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Question question = new Question();
            question.Show();
            this.Hide();
        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            question.Show();
            this.Hide();
        }

      

        private void metroLabel18_Click(object sender, EventArgs e)
        {
            RegisterForm a = new RegisterForm();
            a.Show();
            this.Hide();
        }

    

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            RegisterForm a = new RegisterForm();
            a.Show();
            this.Hide();
        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {
            delete();
            view();
            metroTextBox2.Text = "";
            metroTextBox2.Enabled = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            delete();
            view();
            metroTextBox2.Text = "";
            metroTextBox2.Enabled = false;
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

        private void Mainframe_Load(object sender, EventArgs e)
        {

        }

  
  

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {
            Form6  a = new Form6();
            a.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            this.Hide();
        }

        private void metroLabel11_Click_1(object sender, EventArgs e)
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
            Form5 a = new Form5();
            a.Show();
            this.Hide();
        }

        private void metroLabel13_Click_1(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void f(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            view1();
        }

        
    }
}
