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
    public partial class AddSched :MetroForm
    {
        string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password="; 
        public AddSched()
        {
            InitializeComponent();
            viewSubject();
            viewIns();
            viewRoom();
            
        }
        public void tanan()
        {
            metroTextBox1.Text = (metroComboBox1.Text + " " + metroComboBox2.Text + " " + metroComboBox3.Text + " " + dateTimePicker1.Text + " " + dateTimePicker2.Text);
        }
        private void viewSubject()
         {
        MySqlConnection conn = new MySqlConnection(myConnection);
        metroComboBox1.Items.Clear();
        conn.Close();

        conn.Open();
        MySqlCommand command = conn.CreateCommand();
        string query = "select * from subjects";
        command.CommandText = query;
        MySqlDataReader read = command.ExecuteReader();

        while (read.Read())
        {
            metroComboBox1.Items.Add(read["SubjectName"].ToString());
        }
        conn.Close();
         }
        private void viewIns()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
           metroComboBox3.Items.Clear();
            conn.Close();

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from instructor";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                metroComboBox3.Items.Add(read["instructorname"].ToString());
            }
            conn.Close();
        }
        public void delete()
        {
            if (metroComboBox1.Text == "")
            {
                MessageBox.Show("Select a subject you wanna delete");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(myConnection);
                conn.Close();
                conn.Open();


                MySqlCommand command2 = conn.CreateCommand();

                command2.CommandText = "delete from subjects where SubjectName= '" + metroComboBox1.Text + "'";
                command2.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");

                conn.Close();
                viewSubject();
            }
        }
        public void delete1()
        {
            if (metroComboBox2.Text == "")
            {
                MessageBox.Show("Select a room you wanna delete");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(myConnection);
                conn.Close();
                conn.Open();


                MySqlCommand command2 = conn.CreateCommand();

                command2.CommandText = "delete from room where room= '" + metroComboBox2.Text + "'";
                command2.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");

                conn.Close();
                viewSubject();
            }
        }
           public void add()
        {

            if (metroComboBox1.Text == "" ||metroComboBox2.Text==""||metroComboBox3.Text=="")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else if (metroComboBox1.Text != "")
            {
             
                     
                MySqlConnection conn = new MySqlConnection(myConnection);
                conn.Close();
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select * from sched where TimeStart = '" + dateTimePicker1.Text + "' and TimeEnd = '" + dateTimePicker2.Text + "'";
                MySqlDataReader read = command.ExecuteReader();

                int count = 0;
                while (read.Read())
                {
                    count++;
                }
                if (count >= 1)
                {
                    MessageBox.Show("The schedule is already taken. Please try another one.");


                    conn.Close();
                }
                
                else
                {
                    conn.Close();
                    conn.Open();
                    MySqlCommand command2 = conn.CreateCommand();

                    command2.CommandText = "insert into sched (Subject,Room,TimeStart,TimeEnd,Instructor,complete) values ('" + metroComboBox1.Text + "','" + metroComboBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + metroComboBox3.Text + "','" + metroTextBox1.Text+"')";
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Schedule successfully added");
                    conn.Close();

                    metroComboBox1.Text = "";
                    metroComboBox2.Text = "";
                    metroComboBox3.Text = "";

                    Form2 a = new Form2();

                    a.Show();
                    this.Hide();

                }
                conn.Close();
            }
        }
        private void viewRoom()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            metroComboBox2.Items.Clear();
            conn.Close();

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from room";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                metroComboBox2.Items.Add(read["Room"].ToString());
            }
            conn.Close();
        }
        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddRoom a = new AddRoom();
            a.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text == dateTimePicker2.Text)
            {
                MessageBox.Show("Starting time and end is the same");
            }
            else
            {
            add();
            }
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddSubject a = new AddSubject();
            a.Show();
            this.Hide();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddSched_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            delete1();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void metroComboBox1_TextChanged(object sender, EventArgs e)
        {
            tanan();
        }

        private void metroComboBox2_TextChanged(object sender, EventArgs e)
        {
            tanan();
        }

        private void metroComboBox3_TextChanged(object sender, EventArgs e)
        {
            tanan();
        }
    }
}
