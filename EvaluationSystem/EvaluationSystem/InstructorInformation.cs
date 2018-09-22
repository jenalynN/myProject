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
    public partial class InstructorInformation :MetroForm
    {
        string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password="; 
        public InstructorInformation(string filter_data)
        {
            InitializeComponent();
          
            metroTextBox1.Text=filter_data;
            viewDepartment();

            print();
            view();
            a();
        }public void a() { metroTextBox5.Text = metroTextBox4.Text + ", " + metroTextBox2.Text + " " + metroTextBox3.Text; }
        private void edit()
        {


            DialogResult dr = MessageBox.Show("Are you sure you want to edit students information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MySqlConnection conn = new MySqlConnection(myConnection);

                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                string query0 = "select * from instructor where id = '" + metroTextBox1.Text + "'";
                command.CommandText = query0;
                MySqlDataReader read = command.ExecuteReader();

                int count = 0;
                while (read.Read())
                {
                    count++;
                }

                if (count == 1)
                {
                    conn.Close();
                    conn.Open();
                    MySqlCommand command2 = conn.CreateCommand();
                    string query1 = "update instructor set first= '" + metroTextBox2.Text + "', middle = '" + metroTextBox3.Text + "',last ='" +metroTextBox4.Text+"', department ='" +metroComboBox1.Text+",instructorname ='" +metroTextBox5.Text+"'where userid='" + metroTextBox1.Text + "' ";
                    //"update data set  firstname = '" + textBox1.Text + "' , lastname = '" + textBox2.Text + "' , user = '" + textBox3.Text + "' , pass = '" + textBox4.Text + "' where id = '" + textBox5.Text + "' ";
                    command2.CommandText = query1;
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Succesfuly Edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    view();

                }
                else if (count > 1)
                {
                    MessageBox.Show("Already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                conn.Close();
            }
            else if (dr == DialogResult.No)
            {
                return;
            }


        }
        private void viewDepartment()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            metroComboBox1.Items.Clear();
            conn.Close();

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from department";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                metroComboBox1.Items.Add(read["DepartmentName"].ToString());
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

            string query1 = "select * from dbenroll where Instructor like'" + metroTextBox5.Text + "%'";
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
        public void print()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from instructor where id = '" + metroTextBox1.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                metroTextBox1.Text = read["id"].ToString();
                metroTextBox2.Text = read["last"].ToString();
                metroTextBox3.Text = read["first"].ToString();
                metroTextBox4.Text = read["middle"].ToString();
                metroTextBox5.Text = read["instructorname"].ToString();
                metroTextBox8.Text = read["department"].ToString();
             ;

            }
            conn.Close();
        }
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox1.Checked==true)
            {
                metroComboBox1.Visible = true;
                metroTextBox8.Visible = false;
                metroTextBox2.Enabled = true;
                metroTextBox3.Enabled = true;
                metroTextBox4.Enabled = true;
                pictureBox9.Enabled = true;
                metroLabel20.Enabled = true;
            }
            else if (metroCheckBox1.Checked==false){
                metroComboBox1.Visible = false;
                metroTextBox8.Visible = true;
                metroTextBox2.Enabled = false;
                metroTextBox3.Enabled = false;
                metroTextBox4.Enabled = false;
                pictureBox9.Enabled = false;
                metroLabel20.Enabled = false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
           a.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            view();
        }

        private void metroLabel20_Click(object sender, EventArgs e)
        {
            edit();
            this.Hide();
        }

        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            a();
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            a();
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {
            a();
        }
    }
}
