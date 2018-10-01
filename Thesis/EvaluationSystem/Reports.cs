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
    public partial class Reports : MetroForm
    {
        string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password="; 
        public Reports(string filter_data)
        {
            InitializeComponent();
            Count ();
          
            print();
            metroTextBox4.Text = filter_data;
           
           
        }
        public void print()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from sched where schedid = '" + metroTextBox4.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                metroTextBox4.Text = read["schedid"].ToString();
        

            }
            conn.Close();
        }
        private void view2()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            listView1.Items.Clear();
            conn.Close();


            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query1 = "select * from reports where id like'" + metroTextBox4.Text + "%'";
            command.CommandText = query1;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                ListViewItem items = new ListViewItem(read["id"].ToString());
                items.SubItems.Add(read["enrollid"].ToString());
                items.SubItems.Add(read["studentid"].ToString());
               
                items.SubItems.Add(read["last"].ToString());
                items.SubItems.Add(read["first"].ToString());
                items.SubItems.Add(read["middle"].ToString());
                items.SubItems.Add(read["subject"].ToString());
                items.SubItems.Add(read["room"].ToString());
                items.SubItems.Add(read["start"].ToString());
                items.SubItems.Add(read["end"].ToString());
                items.SubItems.Add(read["instructorname"].ToString());
                items.SubItems.Add(read["dept"].ToString());
                items.SubItems.Add(read["ans1"].ToString());
                items.SubItems.Add(read["ans2"].ToString());
                items.SubItems.Add(read["ans3"].ToString());
                items.SubItems.Add(read["ans4"].ToString());
                items.SubItems.Add(read["ans5"].ToString());
                items.SubItems.Add(read["ans6"].ToString());
                items.SubItems.Add(read["ans7"].ToString());
                items.SubItems.Add(read["ans8"].ToString());
                items.SubItems.Add(read["ans9"].ToString());
                items.SubItems.Add(read["ans10"].ToString());
                items.SubItems.Add(read["ans11"].ToString());
                items.SubItems.Add(read["ans12"].ToString());
                items.SubItems.Add(read["ans13"].ToString());
                items.SubItems.Add(read["ans14"].ToString());
                items.SubItems.Add(read["ans15"].ToString());
                items.SubItems.Add(read["ans16"].ToString());
                items.SubItems.Add(read["ans17"].ToString());
                items.SubItems.Add(read["ans18"].ToString());
                items.SubItems.Add(read["ans19"].ToString());
                items.SubItems.Add(read["ans20"].ToString());
                items.SubItems.Add(read["ans21"].ToString());
                items.SubItems.Add(read["ans22"].ToString());
                items.SubItems.Add(read["ans23"].ToString());
                items.SubItems.Add(read["ans24"].ToString());
                items.SubItems.Add(read["ans25"].ToString());
                items.SubItems.Add(read["ans26"].ToString());
                items.SubItems.Add(read["asn27"].ToString());
                items.SubItems.Add(read["ans28"].ToString());
                items.SubItems.Add(read["ans29"].ToString());
                items.SubItems.Add(read["ans30"].ToString());
                items.SubItems.Add(read["ans31"].ToString());
                items.SubItems.Add(read["ans32"].ToString());
                items.SubItems.Add(read["ans33"].ToString());
                items.SubItems.Add(read["ans34"].ToString());
                items.SubItems.Add(read["ans35"].ToString());
                items.SubItems.Add(read["ans36"].ToString());
                items.SubItems.Add(read["ans37"].ToString());
                items.SubItems.Add(read["com"].ToString());
                items.SubItems.Add(read["ave"].ToString());
                items.SubItems.Add(read["schedid"].ToString());
                listView1.Items.Add(items);
                listView1.FullRowSelect = true;
            }
            conn.Close();

        }
        public void totalavg()
        {
            
            MySqlConnection conn = new MySqlConnection(myConnection);
            metroComboBox1.Items.Clear();
            conn.Close();

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select sum(ave) as total from reports where search='" + metroComboBox1.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                metroTextBox3.Text = read["total"].ToString();
            }
            conn.Close();
        }
        private void view3()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            listView1.Items.Clear();
            conn.Close();


            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query1 = "select * from reports where search like'" + metroComboBox1.Text + "%'";
            command.CommandText = query1;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {

                ListViewItem items = new ListViewItem(read["id"].ToString());
                items.SubItems.Add(read["enrollid"].ToString());
                items.SubItems.Add(read["studentid"].ToString());
                items.SubItems.Add(read["last"].ToString());
                items.SubItems.Add(read["first"].ToString());
                items.SubItems.Add(read["middle"].ToString());
                items.SubItems.Add(read["subject"].ToString());
                items.SubItems.Add(read["room"].ToString());
                items.SubItems.Add(read["start"].ToString());
                items.SubItems.Add(read["end"].ToString());
                items.SubItems.Add(read["instructorname"].ToString());
                items.SubItems.Add(read["dept"].ToString());
                items.SubItems.Add(read["ans1"].ToString());
                items.SubItems.Add(read["ans2"].ToString());
                items.SubItems.Add(read["ans3"].ToString());
                items.SubItems.Add(read["ans4"].ToString());
                items.SubItems.Add(read["ans5"].ToString());
                items.SubItems.Add(read["ans6"].ToString());
                items.SubItems.Add(read["ans7"].ToString());
                items.SubItems.Add(read["ans8"].ToString());
                items.SubItems.Add(read["ans9"].ToString());
                items.SubItems.Add(read["ans10"].ToString());
                items.SubItems.Add(read["ans11"].ToString());
                items.SubItems.Add(read["ans12"].ToString());
                items.SubItems.Add(read["ans13"].ToString());
                items.SubItems.Add(read["ans14"].ToString());
                items.SubItems.Add(read["ans15"].ToString());
                items.SubItems.Add(read["ans16"].ToString());
                items.SubItems.Add(read["ans17"].ToString());
                items.SubItems.Add(read["ans18"].ToString());
                items.SubItems.Add(read["ans19"].ToString());
                items.SubItems.Add(read["ans20"].ToString());
                items.SubItems.Add(read["ans21"].ToString());
                items.SubItems.Add(read["ans22"].ToString());
                items.SubItems.Add(read["ans23"].ToString());
                items.SubItems.Add(read["ans24"].ToString());
                items.SubItems.Add(read["ans25"].ToString());
                items.SubItems.Add(read["ans26"].ToString());
                items.SubItems.Add(read["asn27"].ToString());
                items.SubItems.Add(read["ans28"].ToString());
                items.SubItems.Add(read["ans29"].ToString());
                items.SubItems.Add(read["ans30"].ToString());
                items.SubItems.Add(read["ans31"].ToString());
                items.SubItems.Add(read["ans32"].ToString());
                items.SubItems.Add(read["ans33"].ToString());
                items.SubItems.Add(read["ans34"].ToString());
                items.SubItems.Add(read["ans35"].ToString());
                items.SubItems.Add(read["ans36"].ToString());
                items.SubItems.Add(read["ans37"].ToString());
                items.SubItems.Add(read["com"].ToString());
                items.SubItems.Add(read["ave"].ToString());


                listView1.Items.Add(items);
                listView1.FullRowSelect = true;
            }
            conn.Close();

        }
     
         public void Count()
         {
             MySqlConnection conn = new MySqlConnection(myConnection);
             metroComboBox1.Items.Clear();
             conn.Close();

             conn.Open();
             MySqlCommand command = conn.CreateCommand();
             string query = "select count(id) as no from reports where search='" + metroComboBox1.SelectedItem+"'";
             command.CommandText = query;
             MySqlDataReader read = command.ExecuteReader();

             while (read.Read())
             {
                 metroTextBox2.Text = read["no"].ToString();
              }
             conn.Close();
         }
        private void view()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            listView1.Items.Clear();
            conn.Close();


            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query1 = "select * from reports";
            command.CommandText = query1;

            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {

                ListViewItem items = new ListViewItem(read["id"].ToString());
                items.SubItems.Add(read["enrollid"].ToString());
                items.SubItems.Add(read["studentid"].ToString());
                items.SubItems.Add(read["last"].ToString());

                items.SubItems.Add(read["first"].ToString());

                items.SubItems.Add(read["middle"].ToString());
                items.SubItems.Add(read["subject"].ToString());
                items.SubItems.Add(read["room"].ToString());
                items.SubItems.Add(read["start"].ToString());
                items.SubItems.Add(read["end"].ToString());
                items.SubItems.Add(read["instructorname"].ToString());
                items.SubItems.Add(read["dept"].ToString());
                items.SubItems.Add(read["ans1"].ToString());
                items.SubItems.Add(read["ans2"].ToString());
                items.SubItems.Add(read["ans3"].ToString());
                items.SubItems.Add(read["ans4"].ToString());
                items.SubItems.Add(read["ans5"].ToString());
                items.SubItems.Add(read["ans6"].ToString());
                items.SubItems.Add(read["ans7"].ToString());
                items.SubItems.Add(read["ans8"].ToString());
                items.SubItems.Add(read["ans9"].ToString());
                items.SubItems.Add(read["ans10"].ToString());
                items.SubItems.Add(read["ans11"].ToString());
                items.SubItems.Add(read["ans12"].ToString());
                items.SubItems.Add(read["ans13"].ToString());
                items.SubItems.Add(read["ans14"].ToString());
                items.SubItems.Add(read["ans15"].ToString());
                items.SubItems.Add(read["ans16"].ToString());
                items.SubItems.Add(read["ans17"].ToString());
                items.SubItems.Add(read["ans18"].ToString());
                items.SubItems.Add(read["ans19"].ToString());
                items.SubItems.Add(read["ans20"].ToString());
                items.SubItems.Add(read["ans21"].ToString());
                items.SubItems.Add(read["ans22"].ToString());
                items.SubItems.Add(read["ans23"].ToString());
                items.SubItems.Add(read["ans24"].ToString());
                items.SubItems.Add(read["ans25"].ToString());
                items.SubItems.Add(read["ans26"].ToString());
                items.SubItems.Add(read["asn27"].ToString());
                items.SubItems.Add(read["ans28"].ToString());
                items.SubItems.Add(read["ans29"].ToString());
                items.SubItems.Add(read["ans30"].ToString());
                items.SubItems.Add(read["ans31"].ToString());
                items.SubItems.Add(read["ans32"].ToString());
                items.SubItems.Add(read["ans33"].ToString());
                items.SubItems.Add(read["ans34"].ToString());
                items.SubItems.Add(read["ans35"].ToString());
                items.SubItems.Add(read["ans36"].ToString());
                items.SubItems.Add(read["ans37"].ToString());
                items.SubItems.Add(read["com"].ToString());
                items.SubItems.Add(read["ave"].ToString());
               


                listView1.Items.Add(items);
                listView1.FullRowSelect = true;
            }
            conn.Close();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Count();
            totalavg();
            view2();
     
            
          
           
            
           
            
        }

        private void metroComboBox1_TextChanged(object sender, EventArgs e)
        {

            
           
        }
    }
}
