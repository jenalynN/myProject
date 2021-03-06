﻿using MetroFramework.Forms;
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
    public partial class AddSubject : MetroForm
    {

        string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password="; 
        public AddSubject()
        {
            InitializeComponent();
        }
        public void add() 
        {
        if (metroTextBox1.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else if (metroTextBox1.Text != "")
            {
                MySqlConnection conn = new MySqlConnection(myConnection);
                conn.Close();
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "select * from course where id = '" + metroTextBox1.Text + "'";
                MySqlDataReader read = command.ExecuteReader();

                int count = 0;
                while (read.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("It seems that the course name is already used. Please try another one.");


                    conn.Close();
                }
                else if (count > 1)
                {
                    MessageBox.Show("It seems that the subject name is already used. Please try another one.'");
                    metroTextBox1.Text = "";
                   
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    MySqlCommand command2 = conn.CreateCommand();

                    command2.CommandText = "insert into subjects (SubjectName) values ( '" + metroTextBox1.Text + "')";
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully");
                    conn.Close();

                    
                    metroTextBox1.Text = "";
                 

                }
                conn.Close();
            }
            
        
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            add();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AddSched a = new AddSched();
            a.Show();
            this.Hide();
        }
    }
}
