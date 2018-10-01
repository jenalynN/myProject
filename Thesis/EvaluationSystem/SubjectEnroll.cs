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
    public partial class SubjectEnroll : MetroForm
    {
           string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password=";
           public SubjectEnroll(string filter_data)
        {
            InitializeComponent();
            metroTextBox1.Text = filter_data;

            printname();
            view();
        }
        private void view() 
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

        }
        private void printname() 
        {
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from users where userid = '" + metroTextBox1.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                
                metroTextBox2.Text = read["lastname"].ToString();
                metroTextBox3.Text = read["middlename"].ToString();
                metroTextBox10.Text = read["firstname"].ToString();
        


            }
            conn.Close();
        }
        public void Add()
        { DialogResult dr = MessageBox.Show("Are you sure you want to enroll?", "Confirmation", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
           if ( metroTextBox2.Text == "" || metroTextBox3.Text == "" || metroTextBox4.Text == ""
                || metroTextBox5.Text == "" || metroTextBox7.Text == "" || metroTextBox8.Text == "" || metroTextBox9.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else if ( metroTextBox2.Text != "" || metroTextBox3.Text != "" || metroTextBox4.Text != ""
                || metroTextBox5.Text != "" || metroTextBox7.Text != "" || metroTextBox8.Text != "" || metroTextBox9.Text=="")
            {
                MySqlConnection conn = new MySqlConnection(myConnection);
              
                    conn.Open();
                    MySqlCommand command2 = conn.CreateCommand();

                 
                    command2.CommandText = "insert into dbenroll(userid,LastName,FirstName,MiddleName,Subject,Room,TimeStart,TimeEnd,Instructor) values ( '" +metroTextBox1.Text+"','" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroTextBox10.Text + "','" + metroTextBox4.Text + "','" + metroTextBox5.Text + "','" + metroTextBox6.Text + "','" + metroTextBox7.Text + "','" + metroTextBox8.Text + "' )";
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Enrolled Successfully");
                    conn.Close();

               

                }
                
                }
                else if(dr == DialogResult.No)
                {
                return;
                }
        }
           

        

        private void print()
    {
        int data = 0;
        ListViewItem list = listView1.SelectedItems[data];
        String id = list.SubItems[0].Text;
        metroTextBox9.Text = id.ToString();
        MySqlConnection conn = new MySqlConnection(myConnection);

        conn.Open();
        MySqlCommand command = conn.CreateCommand();
        string query = "select * from sched where schedid = '" + metroTextBox9.Text + "'";
        command.CommandText = query;
        MySqlDataReader read = command.ExecuteReader();

        while (read.Read())
        {
            metroTextBox9.Text = read["schedid"].ToString();
            metroTextBox4.Text = read["Subject"].ToString();
            metroTextBox5.Text = read["Room"].ToString();
            metroTextBox6.Text = read["TimeStart"].ToString();
            metroTextBox7.Text = read["TimeEnd"].ToString();
            metroTextBox8.Text = read["Instructor"].ToString();


        }
        conn.Close();
    }
        private void SubjectEnroll_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            print();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
