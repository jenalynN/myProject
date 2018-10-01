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
using MetroFramework.Forms;
namespace EvaluationSystem
{
    public partial class StudentInformation : MetroForm
    {
        string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password="; 
        public StudentInformation(string filter_data)
        {
            InitializeComponent();
            metroTextBox1.Text = filter_data;

          //  print1();
            print();
            viewlvl();
            viewCourse();
            
            view();
            
        
        }
        private void edit() 
        {
        

                DialogResult dr = MessageBox.Show("Are you sure you want to edit students information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection(myConnection);

                    conn.Open();
                    MySqlCommand command = conn.CreateCommand();
                    string query0 = "select * from users where userid = '" + metroTextBox1.Text + "'";
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
                        string query1 = "update users set firstname= '" + metroTextBox2.Text + "',lastname= '" + metroTextBox4.Text + "',middlename= '" + metroTextBox3.Text + "',course= '" + metroComboBox1.Text + "',yearlvl= '" + metroComboBox2.Text + "',contactno= '" + metroTextBox5.Text + "',dob= '" + dateTimePicker1.Text + "',address= '" + metroTextBox6.Text + "'where userid='" + metroTextBox1.Text + "' ";
                        //"update data set  firstname = '" + textBox1.Text + "' , lastname = '" + textBox2.Text + "' , user = '" + textBox3.Text + "' , pass = '" + textBox4.Text + "' where id = '" + textBox5.Text + "' ";
                        command2.CommandText = query1;
                        command2.ExecuteNonQuery();
                        MessageBox.Show("Succesfuly Edited", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        view();
                        this.Hide();

                    }
                    else if (count > 1)
                    {
                        MessageBox.Show("Name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }

                    conn.Close();
                }
                else if (dr == DialogResult.No)
                {
                    return;
                }
            
        
        }
        private void viewCourse()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            metroComboBox2.Items.Clear();
            conn.Close();

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from course";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                metroComboBox2.Items.Add(read["Course"].ToString());
            }
            conn.Close();
        }
        private void viewlvl()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            metroComboBox1.Items.Clear();
            conn.Close();

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from yearlvl";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                metroComboBox1.Items.Add(read["yearlvl"].ToString());
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

            string query1 = "select * from dbenroll where Userid like'" + metroTextBox1.Text + "%'";
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
            string query = "select * from users where userid = '" + metroTextBox1.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                metroTextBox1.Text = read["userid"].ToString();
                metroTextBox2.Text = read["lastname"].ToString();
                metroTextBox3.Text = read["firstname"].ToString();
                metroTextBox4.Text = read["middlename"].ToString();
                metroTextBox5.Text = read["contactno"].ToString();
                metroTextBox6.Text = read["address"].ToString();
                metroComboBox1.Text = read["course"].ToString();
                metroComboBox2.Text = read["yearlvl"].ToString();
                metroTextBox8.Text = read["course"].ToString();
                metroTextBox9.Text = read["yearlvl"].ToString();
                dateTimePicker1.Text = read["dob"].ToString();

            }
            conn.Close();
        }
      
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            filter_data.Text = metroTextBox1.Text;
            SubjectEnroll a = new SubjectEnroll(filter_data.Text);
            a.Show();
            this.Hide();
        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

            filter_data.Text = metroTextBox1.Text;
            SubjectEnroll a = new SubjectEnroll(filter_data.Text);
          
            a.Show();
            this.Hide();
        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            view();
        }

      
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void metroCheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
           
           
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
            {
                metroTextBox2.Enabled = true;

                metroTextBox4.Enabled = true;
                metroTextBox3.Enabled = true;
                metroTextBox5.Enabled = true;
                metroTextBox6.Enabled = true;
                dateTimePicker1.Enabled = true;
                metroComboBox1.Enabled = true;
                metroComboBox1.Visible = true;
                metroComboBox2.Enabled = true;
                metroComboBox2.Visible = true;
                metroTextBox8.Visible = false;
                metroTextBox9.Visible = false;
                pictureBox9.Enabled = true;
                metroLabel20.Enabled = true;
            }
            else
            {
                metroTextBox8.Visible = true;
                metroTextBox9.Visible = true;
                metroComboBox1.Visible = false;
                metroComboBox2.Visible = false ;
                metroTextBox2.Enabled = false;
                metroTextBox4.Enabled = false;
                metroTextBox3.Enabled = false;
                metroTextBox5.Enabled = false;
                metroTextBox6.Enabled = false;
                dateTimePicker1.Enabled = false;
                metroComboBox1.Enabled = false;
                metroComboBox2.Enabled = false; 
                pictureBox9.Enabled = false;
                metroLabel20.Enabled = false;

            }
        }

        private void metroLabel20_Click(object sender, EventArgs e)
        {
            edit();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            edit();
           
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            
        }

        private void listView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
       
        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {
            DeleteEnrollSubject a = new DeleteEnrollSubject();
            a.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DeleteEnrollSubject a = new DeleteEnrollSubject();
            a.Show();
            this.Hide();
        }
    }
}

