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
    public partial class DeleteEnrollSubject : MetroForm
    {
        string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password="; 
        public DeleteEnrollSubject()
        {
            InitializeComponent();
            view4();
            metroComboBox1.Text = "None";
        }
        public void view4()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            listView1.Items.Clear();
            conn.Close();


            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query1 = "select * from dbenroll";
            command.CommandText = query1;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {

                ListViewItem items = new ListViewItem(read["Id"].ToString());
                items.SubItems.Add(read["Userid"].ToString());
                items.SubItems.Add(read["LastName"].ToString());
                items.SubItems.Add(read["FirstName"].ToString());

                items.SubItems.Add(read["MiddleName"].ToString());

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
        public void view3()
        {
            if (metroComboBox1.SelectedItem == "Lastname")
            { 
                view(); 
            }
            else if (metroComboBox1.SelectedItem == "Student Id No.") 
            { 
                view1();
            }
            else if(metroComboBox1.SelectedItem == "None")
            {
            metroTextBox2.Text ="Enter keywords here";
                view4();
            }
        

        }
        private void view()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            listView1.Items.Clear();
            conn.Close();


            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query1 = "select * from dbenroll where LastName like'" + metroTextBox2.Text + "%'";
            command.CommandText = query1;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {

                ListViewItem items = new ListViewItem(read["Id"].ToString());
                items.SubItems.Add(read["Userid"].ToString());
                items.SubItems.Add(read["LastName"].ToString());
                items.SubItems.Add(read["FirstName"].ToString());

                items.SubItems.Add(read["MiddleName"].ToString());

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
        public void view1()
        {  MySqlConnection conn = new MySqlConnection(myConnection);
            listView1.Items.Clear();
            conn.Close();


            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query1 = "select * from dbenroll where Userid like'" + metroTextBox2.Text + "%'";
            command.CommandText = query1;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {

                ListViewItem items = new ListViewItem(read["Id"].ToString());
                items.SubItems.Add(read["Userid"].ToString());
                items.SubItems.Add(read["LastName"].ToString());
                items.SubItems.Add(read["FirstName"].ToString());

                items.SubItems.Add(read["MiddleName"].ToString());

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
        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            metroTextBox2.Text = "";
            view3();
          
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            view3();
        }
    }
}
