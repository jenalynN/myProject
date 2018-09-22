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
    public partial class AddIns : MetroForm
    {

        string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password="; 
        public AddIns()
        {
            InitializeComponent();
            a();
            viewDepartment();
        }
        private void add()
        {

            if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox3.Text == "" || metroTextBox4.Text == ""||metroComboBox2.Text =="")
            {
                MessageBox.Show("Please Complete the Form");
            }

            else if (metroTextBox1.Text != "" || metroTextBox2.Text != "" || metroTextBox3.Text != "" || metroTextBox4.Text != ""|| metroComboBox2.Text!="")
            {
                MySqlConnection conn = new MySqlConnection(myConnection);
                conn.Close();
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select * from instructor where instructorname= '" + metroTextBox4.Text + "'";
                
                MySqlDataReader read = command.ExecuteReader();

                int count = 0;
                while (read.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("It seem that the instructor name you want isn't available. Please try another one.");


                    conn.Close();
                }
                else if (count > 1)
                {
                    MessageBox.Show("It seem that the instructor name you want isn't available. Please try another one.'");
                   
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    MySqlCommand command2 = conn.CreateCommand();

                    command2.CommandText = "insert into instructor (instructorname,last,first,department,middle) values ( '" + metroTextBox4.Text + "','" + metroTextBox3.Text + "','" + metroTextBox2.Text + "','" + metroComboBox2.Text + "','" + metroTextBox1.Text + "')";
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully");
                    conn.Close();
                    Form6 a = new Form6();
                    a.Show();
                    this.Hide();
                    metroTextBox1.Text = "";
                    metroTextBox2.Text = "";
                    metroTextBox3.Text = "";
                    metroTextBox4.Text = "";
                    metroComboBox2.Text = "";
                }
                conn.Close();
            }


        }
        private void viewDepartment()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            metroComboBox2.Items.Clear();
            conn.Close();

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from department";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                metroComboBox2.Items.Add(read["DepartmentName"].ToString());
            }
            conn.Close();
        }
        public void a() 
        {

            metroTextBox4.Text = metroTextBox3.Text + ", " + metroTextBox2.Text +" " + metroTextBox1.Text;
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            add();
          
        }

        private void AddIns_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            a();
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            a();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            a();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
            this.Hide();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
