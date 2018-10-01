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
    public partial class RegisterForm : MetroForm
    {
        string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password="; 
        public RegisterForm()
        {


            InitializeComponent();
            viewCourse();
            
        }
        private void year()
        {
            if (metroComboBox2.Text == ("BSCoE"))
            {

                metroComboBox1.Items.Add("5th Year");
            }
            else if (metroComboBox2.Text != ("BSCoE")) 
            {
                metroComboBox1.Items.Clear();
                metroComboBox1.Items.Add("1st Year");
                metroComboBox1.Items.Add("2nd Year");
                metroComboBox1.Items.Add("3rd Year");
                metroComboBox1.Items.Add("4th Year");
                metroComboBox1.Items.Add("5th Year");
            
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
    
        public void Add()
        {
            if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox3.Text == "" || metroTextBox4.Text == ""
                || metroTextBox5.Text == ""  || metroComboBox1.Text == "" || metroComboBox2.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else if(this.dateTimePicker1.Value.Date==DateTime.Now)
            {
            MessageBox.Show("Cant create account whose age is zero");}
            else if (metroTextBox1.Text != "" || metroTextBox2.Text != "" || metroTextBox3.Text != "" || metroTextBox4.Text != ""
                || metroTextBox5.Text != ""  || metroComboBox1.Text != "" || metroComboBox2.Text != "")
            {
                MySqlConnection conn = new MySqlConnection(myConnection);
                conn.Close();
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select * from users where user = '" + metroTextBox7.Text + "'";
                MySqlDataReader read = command.ExecuteReader();

                int count = 0;
                while (read.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("It seem that the username you want isn't available. Please try another one.");


                    conn.Close();
                }
                else if (count > 1)
                {
                    MessageBox.Show("It seem that the username you want isn't available. Please try another one.'");
                    metroTextBox7.Text = "";
                    metroTextBox7.Focus();
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    MySqlCommand command2 = conn.CreateCommand();

                    command2.CommandText = "insert into users (firstname,middlename,lastname,address,dob,contactno,yearlvl,course,user,password) values ( '" + metroTextBox1.Text + "','" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','"+ metroTextBox5.Text+"','" + dateTimePicker1.Text + "','" + metroTextBox4.Text + "','" + metroComboBox1.Text + "','" + metroComboBox2.Text + "','" + metroTextBox7.Text + "','" + metroTextBox8.Text + "' )";
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully");
                    conn.Close();

                    metroTextBox1.Text = "";
                    metroTextBox2.Text = "";
                    metroTextBox3.Text = "";
                    metroTextBox4.Text = "";
                    metroTextBox5.Text = "";
                    metroTextBox7.Text = "";
                    metroTextBox8.Text = "";
                    metroTextBox9.Text = "";
                    metroComboBox1.Text = "";
                    metroComboBox2.Text = "";
                    Mainframe a = new Mainframe();
                    a.Show();
                    this.Hide();

                }
                conn.Close();
            }

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {
            Mainframe login = new Mainframe();
            login.Show();
            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
           
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton8_Click(object sender, EventArgs e)
        {

            Add();

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AddCourse a = new AddCourse();
            a.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddYear a = new AddYear();
            a.Show();
            this.Hide();
        }

        private void metroTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
            int years = DateTime.Now.Year - dateTimePicker1.Value.Year;
            
            dateTimePicker1.MaxDate = DateTime.Today;
            //date.MaxDate = DateTime.MaxValue;
            if (dateTimePicker1.Value.AddYears(years) > DateTime.Now) years--;
            if (years > 0)
            {
                  MessageBox.Show("Invalid Date.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (years < 0)
            {
                MessageBox.Show("Invalid Date.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            year();
        }
    }
}
