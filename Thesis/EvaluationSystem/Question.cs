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
    public partial class Question : MetroForm
    {
        string myConnection = "Server=localhost;Database=evaluationsystem;Uid=root;Password=";
        public Question()
        {
            InitializeComponent();
            view1();
            view();
            totalave();
            print2();
            print3();

            
           
        }
        public void tanan() {
            metroTextBox51.Text = (metroTextBox12.Text + " " + metroTextBox11.Text + " " + metroTextBox8.Text + " " + metroTextBox9.Text + " " + metroTextBox10.Text);
        }
        public void totalave()
        {
        int c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,c11,c12,c13,c14,c15,c16,c17,c18,c19,c20,c21,c22,c23,c24,c25,c26,c27,c28,c29,c30,c31,c32,c33,c34,c35,c36,c37;
            bool c1a = int.TryParse(metroTextBox13.Text, out c1);
            bool c2a = int.TryParse(metroTextBox14.Text, out c2);
            bool c3a = int.TryParse(metroTextBox15.Text, out c3);
            bool c4a = int.TryParse(metroTextBox16.Text, out c4);
            bool c5a = int.TryParse(metroTextBox17.Text, out c5);
            bool c6a = int.TryParse(metroTextBox18.Text, out c6);
            bool c7a = int.TryParse(metroTextBox19.Text, out c7);
            bool c8a = int.TryParse(metroTextBox20.Text, out c8);
            bool c9a = int.TryParse(metroTextBox21.Text, out c9);
            bool c10a = int.TryParse(metroTextBox22.Text, out c10);
            bool c11a = int.TryParse(metroTextBox23.Text, out c11);
            bool c12a = int.TryParse(metroTextBox24.Text, out c12);
            bool c13a = int.TryParse(metroTextBox25.Text, out c13);
            bool c14a = int.TryParse(metroTextBox26.Text, out c14);
            bool c15a = int.TryParse(metroTextBox27.Text, out c15);
            bool c16a = int.TryParse(metroTextBox28.Text, out c16);
            bool c17a = int.TryParse(metroTextBox29.Text, out c17);
            bool c18a = int.TryParse(metroTextBox30.Text, out c18);
            bool c19a = int.TryParse(metroTextBox31.Text, out c19);
            bool c20a = int.TryParse(metroTextBox32.Text, out c20);
            bool c21a = int.TryParse(metroTextBox33.Text, out c21);
            bool c22a = int.TryParse(metroTextBox34.Text, out c22);
            bool c23a = int.TryParse(metroTextBox35.Text, out c23);
            bool c24a = int.TryParse(metroTextBox36.Text, out c24);
            bool c25a = int.TryParse(metroTextBox37.Text, out c25);
            bool c26a = int.TryParse(metroTextBox38.Text, out c26);
            bool c27a = int.TryParse(metroTextBox39.Text, out c27);
            bool c28a = int.TryParse(metroTextBox40.Text, out c28);
            bool c29a = int.TryParse(metroTextBox41.Text, out c29);
            bool c30a = int.TryParse(metroTextBox42.Text, out c30);
            bool c31a = int.TryParse(metroTextBox43.Text, out c31);
            bool c32a = int.TryParse(metroTextBox44.Text, out c32);
            bool c33a = int.TryParse(metroTextBox45.Text, out c33);
            bool c34a = int.TryParse(metroTextBox46.Text, out c34);
            bool c35a = int.TryParse(metroTextBox47.Text, out c35);
            bool c36a = int.TryParse(metroTextBox48.Text, out c36);
            bool c37a = int.TryParse(metroTextBox49.Text, out c37);


            if (c1a)
            {
                metroTextBox50.Text = (c1+c2+c3+c4+c5+c6+c7+c8+c9+c10+c11+c12+c13+c14+c15+c16+c17+c18+c19+c20+c21+c22+c23+c24+c25+c26+c27+c28+c29+c30+c31+c32+c33+c34+c35+c36+c37).ToString();
            }

            else
            {
                metroTextBox10.Text = "Invalid Input";
            }
        }
        public void finalaverage()
        {
            decimal c1;
            bool c1a = decimal.TryParse(metroTextBox50.Text, out c1);
            if (c1a)
            {
                metroTextBox50.Text = (c1 / 37).ToString();
            }
            else
            {
                metroTextBox50.Text = "Invalid Input";
            }
        }
        public void Add()
        {
          
                MySqlConnection conn = new MySqlConnection(myConnection);
                conn.Close();
                conn.Open();
                
            
                    MySqlCommand command2 = conn.CreateCommand();

                    command2.CommandText = "insert into reports (enrollid,studentid,last,first,middle,subject,room,start,end,instructorname,ans1,ans2,ans3,ans4,ans5,ans6,ans7,ans8,ans9,ans10,ans11,ans12,ans13,ans14,ans15,ans16,ans17,ans18,ans19,ans20,ans21,ans22,ans23,ans24,ans25,ans26,asn27,ans28,ans29,ans30,ans31,ans32,ans33,ans34,ans35,ans36,ans37,com,ave,search) values ( '" + metroTextBox1.Text + "','" + metroTextBox2.Text + "','" + metroTextBox3.Text + "','" + metroTextBox6.Text + "','" + metroTextBox7.Text + "','" + metroTextBox12.Text + "','" + metroTextBox11.Text + "','" + metroTextBox8.Text + "','" + metroTextBox9.Text + "','" + metroTextBox10.Text + "' ,'" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + comboBox6.Text + "','" + comboBox7.Text + "','" + comboBox8.Text + "','" + comboBox9.Text + "','" + comboBox10.Text + "','" + comboBox11.Text + "','" + comboBox12.Text + "','" + comboBox13.Text + "','" + comboBox14.Text + "','" + comboBox15.Text + "','" + comboBox16.Text + "','" + comboBox17.Text + "','" + comboBox18.Text + "','" + comboBox28.Text + "','" + comboBox19.Text + "','" + comboBox20.Text + "','" + comboBox21.Text + "','" + comboBox22.Text + "','" + comboBox23.Text + "','" + comboBox24.Text + "','" + comboBox25.Text + "','" + comboBox26.Text + "','" + comboBox27.Text + "','" + comboBox29.Text + "','" + comboBox30.Text + "','" + comboBox31.Text + "','" + comboBox32.Text + "','" + comboBox33.Text + "','" + comboBox34.Text + "','" + comboBox35.Text + "','" + comboBox36.Text + "','" + comboBox37.Text + "','" + metroTextBox5.Text + "','" + metroTextBox50.Text + "','" + metroTextBox51.Text+"')";
                        command2.ExecuteNonQuery();
                    MessageBox.Show("Evaluated Successfully");
                    conn.Close();

               
                 
                
            
    

        }
        public void print()
        {
            int data = 0;
            ListViewItem list = listView1.SelectedItems[data];
            String id = list.SubItems[0].Text;
            metroTextBox1.Text = id.ToString();
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from dbenroll where Id = '" + metroTextBox1.Text + "'";
            command.CommandText = query;
            MySqlDataReader read1 = command.ExecuteReader();

            while (read1.Read())
            {


                metroTextBox1.Text = read1["Id"].ToString();
                metroTextBox2.Text = read1["UserId"].ToString();

                metroTextBox3.Text = read1["LastName"].ToString();
                metroTextBox6.Text = read1["FirstName"].ToString();
                metroTextBox7.Text = read1["MiddleName"].ToString();
                metroTextBox12.Text = read1["Subject"].ToString();
                metroTextBox11.Text = read1["Room"].ToString(); 
                metroTextBox8.Text = read1["TimeStart"].ToString();
                metroTextBox9.Text = read1["TimeEnd"].ToString();
                metroTextBox10.Text = read1["Instructor"].ToString();

            }
            conn.Close();
        }
        public void scoring1()
        {
            
                if (comboBox1.SelectedItem == ("Never"))
                {
                    metroTextBox13.Text = "1";
                }
                else if (comboBox1.SelectedItem == ("Seldom"))
                {
                    metroTextBox13.Text = "2";
                }
                else if (comboBox1.SelectedItem == ("Sometimes"))
                {
                    metroTextBox13.Text = "3";
                }
                else if (comboBox1.SelectedItem == ("Often"))
                {
                    metroTextBox13.Text = "4";
                }
                else if (comboBox1.SelectedItem == ("Most of the time"))
                {
                    metroTextBox13.Text = "5";
                }
                else if (comboBox1.SelectedItem == ("Always"))
                {
                    metroTextBox13.Text = "6";
                }
            
          
        }
        public void scoring2()
        {

            if (comboBox2.SelectedItem == ("The Worst"))
            {
                metroTextBox14.Text = "1";
            }
            else if (comboBox2.SelectedItem == ("Poor"))
            {
                metroTextBox14.Text = "2";
            }
            else if (comboBox2.SelectedItem == ("Below Average"))
            {
                metroTextBox14.Text = "3";
            }
            else if (comboBox2.SelectedItem == ("Above Average"))
            {
                metroTextBox14.Text = "4";
            }
            else if (comboBox2.SelectedItem == ("Superior"))
            {
                metroTextBox14.Text = "5";
            }
            else if (comboBox2.SelectedItem == ("The Best"))
            {
                metroTextBox14.Text = "6";
            }


        }
        public void scoring3()
        {

            if (comboBox3.SelectedItem == ("Never"))
            {
                metroTextBox15.Text = "1";
            }
            else if (comboBox3.SelectedItem == ("Seldom"))
            {
                metroTextBox15.Text = "2";
            }
            else if (comboBox3.SelectedItem == ("Sometimes"))
            {
                metroTextBox15.Text = "3";
            }
            else if (comboBox3.SelectedItem == ("Often"))
            {
                metroTextBox15.Text = "4";
            }
            else if (comboBox3.SelectedItem == ("Most of the time"))
            {
                metroTextBox15.Text = "5";
            }
            else if (comboBox3.SelectedItem == ("Always"))
            {
                metroTextBox15.Text = "6";
            }


        }
        public void scoring4()
        {

            if (comboBox4.SelectedItem == ("Never"))
            {
                metroTextBox16.Text = "1";
            }
            else if (comboBox4.SelectedItem == ("Seldom"))
            {
                metroTextBox16.Text = "2";
            }
            else if (comboBox4.SelectedItem == ("Sometimes"))
            {
                metroTextBox16.Text = "3";
            }
            else if (comboBox4.SelectedItem == ("Often"))
            {
                metroTextBox16.Text = "4";
            }
            else if (comboBox4.SelectedItem == ("Most of the time"))
            {
                metroTextBox16.Text = "5";
            }
            else if (comboBox4.SelectedItem == ("Always"))
            {
                metroTextBox16.Text = "6";
            }


        }
        public void scoring5()
        {

            if (comboBox5.SelectedItem == ("Never"))
            {
                metroTextBox17.Text = "1";
            }
            else if (comboBox5.SelectedItem == ("Seldom"))
            {
                metroTextBox17.Text = "2";
            }
            else if (comboBox5.SelectedItem == ("Sometimes"))
            {
                metroTextBox17.Text = "3";
            }
            else if (comboBox5.SelectedItem == ("Often"))
            {
                metroTextBox17.Text = "4";
            }
            else if (comboBox5.SelectedItem == ("Most of the time"))
            {
                metroTextBox17.Text = "5";
            }
            else if (comboBox5.SelectedItem == ("Always"))
            {
                metroTextBox17.Text = "6";
            }


        }
        public void scoring6()
        {

            if (comboBox6.SelectedItem == ("Never"))
            {
                metroTextBox18.Text = "1";
            }
            else if (comboBox6.SelectedItem == ("Seldom"))
            {
                metroTextBox18.Text = "2";
            }
            else if (comboBox6.SelectedItem == ("Sometimes"))
            {
                metroTextBox18.Text = "3";
            }
            else if (comboBox6.SelectedItem == ("Often"))
            {
                metroTextBox18.Text = "4";
            }
            else if (comboBox6.SelectedItem == ("Most of the time"))
            {
                metroTextBox18.Text = "5";
            }
            else if (comboBox6.SelectedItem == ("Always"))
            {
                metroTextBox18.Text = "6";
            }


        }
        public void scoring7()
        {

            if (comboBox7.SelectedItem == ("The Worst"))
            {
                metroTextBox19.Text = "1";
            }
            else if (comboBox7.SelectedItem == ("Poor"))
            {
                metroTextBox19.Text = "2";
            }
            else if (comboBox7.SelectedItem == ("Below Average"))
            {
                metroTextBox19.Text = "3";
            }
            else if (comboBox7.SelectedItem == ("Above Average"))
            {
                metroTextBox19.Text = "4";
            }
            else if (comboBox7.SelectedItem == ("Superior"))
            {
                metroTextBox19.Text = "5";
            }
            else if (comboBox7.SelectedItem == ("The Best"))
            {
                metroTextBox19.Text = "6";
            }


        }
        public void scoring8()
        {

            if (comboBox8.SelectedItem == ("Never"))
            {
                metroTextBox20.Text = "1";
            }
            else if (comboBox8.SelectedItem == ("Seldom"))
            {
                metroTextBox20.Text = "2";
            }
            else if (comboBox8.SelectedItem == ("Sometimes"))
            {
                metroTextBox20.Text = "3";
            }
            else if (comboBox8.SelectedItem == ("Often"))
            {
                metroTextBox20.Text = "4";
            }
            else if (comboBox8.SelectedItem == ("Most of the time"))
            {
                metroTextBox20.Text = "5";
            }
            else if (comboBox8.SelectedItem == ("Always"))
            {
                metroTextBox20.Text = "6";
            }


        }
        public void scoring9()
        {

            if (comboBox9.SelectedItem == ("Never"))
            {
                metroTextBox21.Text = "1";
            }
            else if (comboBox9.SelectedItem == ("Seldom"))
            {
                metroTextBox21.Text = "2";
            }
            else if (comboBox9.SelectedItem == ("Sometimes"))
            {
                metroTextBox21.Text = "3";
            }
            else if (comboBox9.SelectedItem == ("Often"))
            {
                metroTextBox21.Text = "4";
            }
            else if (comboBox9.SelectedItem == ("Most of the time"))
            {
                metroTextBox21.Text = "5";
            }
            else if (comboBox9.SelectedItem == ("Always"))
            {
                metroTextBox21.Text = "6";
            }


        }
        public void scoring10()
        {

            if (comboBox10.SelectedItem == ("Never"))
            {
                metroTextBox22.Text = "1";
            }
            else if (comboBox10.SelectedItem == ("Seldom"))
            {
                metroTextBox22.Text = "2";
            }
            else if (comboBox10.SelectedItem == ("Sometimes"))
            {
                metroTextBox22.Text = "3";
            }
            else if (comboBox10.SelectedItem == ("Often"))
            {
                metroTextBox22.Text = "4";
            }
            else if (comboBox10.SelectedItem == ("Most of the time"))
            {
                metroTextBox22.Text = "5";
            }
            else if (comboBox10.SelectedItem == ("Always"))
            {
                metroTextBox22.Text = "6";
            }
        }
        public void scoring11()
        {

            if (comboBox11.SelectedItem == ("Never"))
            {
                metroTextBox23.Text = "1";
            }
            else if (comboBox11.SelectedItem == ("Seldom"))
            {
                metroTextBox23.Text = "2";
            }
            else if (comboBox11.SelectedItem == ("Sometimes"))
            {
                metroTextBox23.Text = "3";
            }
            else if (comboBox11.SelectedItem == ("Often"))
            {
                metroTextBox23.Text = "4";
            }
            else if (comboBox11.SelectedItem == ("Most of the time"))
            {
                metroTextBox23.Text = "5";
            }
            else if (comboBox11.SelectedItem == ("Always"))
            {
                metroTextBox23.Text = "6";
            }
        }
        public void scoring12()
        {

            if (comboBox12.SelectedItem == ("Never"))
            {
                metroTextBox24.Text = "6";
            }
            else if (comboBox12.SelectedItem == ("Seldom"))
            {
                metroTextBox24.Text = "5";
            }
            else if (comboBox12.SelectedItem == ("Sometimes"))
            {
                metroTextBox24.Text = "4";
            }
            else if (comboBox12.SelectedItem == ("Often"))
            {
                metroTextBox24.Text = "3";
            }
            else if (comboBox12.SelectedItem == ("Most of the time"))
            {
                metroTextBox24.Text = "2";
            }
            else if (comboBox12.SelectedItem == ("Always"))
            {
                metroTextBox24.Text = "1";
            }
        }
        public void scoring13()
        {

            if (comboBox13.SelectedItem == ("No Depth and Mastery of the subject"))
            {
                metroTextBox25.Text = "1";
            }
            else if (comboBox13.SelectedItem == ("Poor"))
            {
                metroTextBox25.Text = "2";
            }
            else if (comboBox13.SelectedItem == ("Below Average"))
            {
                metroTextBox25.Text = "3";
            }
            else if (comboBox13.SelectedItem == ("Above Average"))
            {
                metroTextBox25.Text = "4";
            }
            else if (comboBox13.SelectedItem == ("Superior"))
            {
                metroTextBox25.Text = "5";
            }
            else if (comboBox13.SelectedItem == ("Extraordinary Depth and Mastery of the Subject"))
            {
                metroTextBox25.Text = "6";
            }
        }
        public void scoring14()
        {

            if (comboBox14.SelectedItem == ("Never"))
            {
                metroTextBox26.Text = "1";
            }
            else if (comboBox14.SelectedItem == ("Seldom"))
            {
                metroTextBox26.Text = "2";
            }
            else if (comboBox14.SelectedItem == ("Sometimes"))
            {
                metroTextBox26.Text = "3";
            }
            else if (comboBox14.SelectedItem == ("Often"))
            {
                metroTextBox26.Text = "4";
            }
            else if (comboBox14.SelectedItem == ("Most of the time"))
            {
                metroTextBox26.Text = "5";
            }
            else if (comboBox14.SelectedItem == ("Always"))
            {
                metroTextBox26.Text = "6";
            }
        }
        public void scoring15()
        {

            if (comboBox15.SelectedItem == ("Never"))
            {
                metroTextBox27.Text = "1";
            }
            else if (comboBox15.SelectedItem == ("Seldom"))
            {
                metroTextBox27.Text = "2";
            }
            else if (comboBox15.SelectedItem == ("Sometimes"))
            {
                metroTextBox27.Text = "3";
            }
            else if (comboBox15.SelectedItem == ("Often"))
            {
                metroTextBox27.Text = "4";
            }
            else if (comboBox15.SelectedItem == ("Most of the time"))
            {
                metroTextBox27.Text = "5";
            }
            else if (comboBox15.SelectedItem == ("Always"))
            {
                metroTextBox27.Text = "6";
            }
        }
        public void scoring16()
        {

            if (comboBox16.SelectedItem == ("Never"))
            {
                metroTextBox28.Text = "1";
            }
            else if (comboBox16.SelectedItem == ("Seldom"))
            {
                metroTextBox28.Text = "2";
            }
            else if (comboBox16.SelectedItem == ("Sometimes"))
            {
                metroTextBox28.Text = "3";
            }
            else if (comboBox16.SelectedItem == ("Often"))
            {
                metroTextBox28.Text = "4";
            }
            else if (comboBox16.SelectedItem == ("Most of the time"))
            {
                metroTextBox28.Text = "5";
            }
            else if (comboBox16.SelectedItem == ("Always"))
            {
                metroTextBox28.Text = "6";
            }
        }
        public void scoring17()
        {

            if (comboBox17.SelectedItem == ("Never"))
            {
                metroTextBox29.Text = "1";
            }
            else if (comboBox17.SelectedItem == ("Seldom"))
            {
                metroTextBox29.Text = "2";
            }
            else if (comboBox17.SelectedItem == ("Sometimes"))
            {
                metroTextBox29.Text = "3";
            }
            else if (comboBox17.SelectedItem == ("Often"))
            {
                metroTextBox29.Text = "4";
            }
            else if (comboBox17.SelectedItem == ("Most of the time"))
            {
                metroTextBox29.Text = "5";
            }
            else if (comboBox17.SelectedItem == ("Always"))
            {
                metroTextBox29.Text = "6";
            }
        }
        public void scoring18()
        {

            if (comboBox18.SelectedItem == ("Never"))
            {
                metroTextBox30.Text = "1";
            }
            else if (comboBox18.SelectedItem == ("Seldom"))
            {
                metroTextBox30.Text = "2";
            }
            else if (comboBox18.SelectedItem == ("Sometimes"))
            {
                metroTextBox30.Text = "3";
            }
            else if (comboBox18.SelectedItem == ("Often"))
            {
                metroTextBox30.Text = "4";
            }
            else if (comboBox18.SelectedItem == ("Most of the time"))
            {
                metroTextBox30.Text = "5";
            }
            else if (comboBox18.SelectedItem == ("Always"))
            {
                metroTextBox30.Text = "6";
            }
        }
        public void scoring19()
        {

            if (comboBox19.SelectedItem == ("Never"))
            {
                metroTextBox32.Text = "1";
            }
            else if (comboBox19.SelectedItem == ("Seldom"))
            {
                metroTextBox32.Text = "2";
            }
            else if (comboBox19.SelectedItem == ("Sometimes"))
            {
                metroTextBox32.Text = "3";
            }
            else if (comboBox19.SelectedItem == ("Often"))
            {
                metroTextBox32.Text = "4";
            }
            else if (comboBox19.SelectedItem == ("Most of the time"))
            {
                metroTextBox32.Text = "5";
            }
            else if (comboBox19.SelectedItem == ("Always"))
            {
                metroTextBox32.Text = "6";
            }
        }
        public void scoring20()
        {

            if (comboBox20.SelectedItem == ("Never"))
            {
                metroTextBox33.Text = "1";
            }
            else if (comboBox20.SelectedItem == ("Seldom"))
            {
                metroTextBox33.Text = "2";
            }
            else if (comboBox20.SelectedItem == ("Sometimes"))
            {
                metroTextBox33.Text = "3";
            }
            else if (comboBox20.SelectedItem == ("Often"))
            {
                metroTextBox33.Text = "4";
            }
            else if (comboBox20.SelectedItem == ("Most of the time"))
            {
                metroTextBox33.Text = "5";
            }
            else if (comboBox20.SelectedItem == ("Always"))
            {
                metroTextBox33.Text = "6";
            }
        }
        public void scoring21()
        {

            if (comboBox21.SelectedItem == ("Never"))
            {
                metroTextBox34.Text = "1";
            }
            else if (comboBox21.SelectedItem == ("Seldom"))
            {
                metroTextBox34.Text = "2";
            }
            else if (comboBox21.SelectedItem == ("Sometimes"))
            {
                metroTextBox34.Text = "3";
            }
            else if (comboBox21.SelectedItem == ("Often"))
            {
                metroTextBox34.Text = "4";
            }
            else if (comboBox21.SelectedItem == ("Most of the time"))
            {
                metroTextBox34.Text = "5";
            }
            else if (comboBox21.SelectedItem == ("Always"))
            {
                metroTextBox34.Text = "6";
            }
        }
        public void scoring22()
        {

            if (comboBox22.SelectedItem == ("Never"))
            {
                metroTextBox35.Text = "1";
            }
            else if (comboBox22.SelectedItem == ("Seldom"))
            {
                metroTextBox35.Text = "2";
            }
            else if (comboBox22.SelectedItem == ("Sometimes"))
            {
                metroTextBox35.Text = "3";
            }
            else if (comboBox22.SelectedItem == ("Often"))
            {
                metroTextBox35.Text = "4";
            }
            else if (comboBox22.SelectedItem == ("Most of the time"))
            {
                metroTextBox35.Text = "5";
            }
            else if (comboBox22.SelectedItem == ("Always"))
            {
                metroTextBox35.Text = "6";
            }
        }
        public void scoring23()
        {

            if (comboBox23.SelectedItem == ("Never"))
            {
                metroTextBox36.Text = "1";
            }
            else if (comboBox23.SelectedItem == ("Seldom"))
            {
                metroTextBox36.Text = "2";
            }
            else if (comboBox23.SelectedItem == ("Sometimes"))
            {
                metroTextBox36.Text = "3";
            }
            else if (comboBox23.SelectedItem == ("Often"))
            {
                metroTextBox36.Text = "4";
            }
            else if (comboBox23.SelectedItem == ("Most of the time"))
            {
                metroTextBox36.Text = "5";
            }
            else if (comboBox23.SelectedItem == ("Always"))
            {
                metroTextBox36.Text = "6";
            }
        }
        public void scoring24()
        {

            if (comboBox24.SelectedItem == ("Never"))
            {
                metroTextBox37.Text = "1";
            }
            else if (comboBox24.SelectedItem == ("Seldom"))
            {
                metroTextBox37.Text = "2";
            }
            else if (comboBox24.SelectedItem == ("Sometimes"))
            {
                metroTextBox37.Text = "3";
            }
            else if (comboBox24.SelectedItem == ("Often"))
            {
                metroTextBox37.Text = "4";
            }
            else if (comboBox24.SelectedItem == ("Most of the time"))
            {
                metroTextBox37.Text = "5";
            }
            else if (comboBox24.SelectedItem == ("Always"))
            {
                metroTextBox37.Text = "6";
            }
        }
        public void scoring25()
        {

            if (comboBox25.SelectedItem == ("Never"))
            {
                metroTextBox38.Text = "1";
            }
            else if (comboBox25.SelectedItem == ("Seldom"))
            {
                metroTextBox38.Text = "2";
            }
            else if (comboBox25.SelectedItem == ("Sometimes"))
            {
                metroTextBox38.Text = "3";
            }
            else if (comboBox25.SelectedItem == ("Often"))
            {
                metroTextBox38.Text = "4";
            }
            else if (comboBox25.SelectedItem == ("Most of the time"))
            {
                metroTextBox38.Text = "5";
            }
            else if (comboBox25.SelectedItem == ("Always"))
            {
                metroTextBox38.Text = "6";
            }
        }
        public void scoring26()
        {

            if (comboBox26.SelectedItem == ("Never"))
            {
                metroTextBox39.Text = "1";
            }
            else if (comboBox26.SelectedItem == ("Seldom"))
            {
                metroTextBox39.Text = "2";
            }
            else if (comboBox26.SelectedItem == ("Sometimes"))
            {
                metroTextBox39.Text = "3";
            }
            else if (comboBox26.SelectedItem == ("Often"))
            {
                metroTextBox39.Text = "4";
            }
            else if (comboBox26.SelectedItem == ("Most of the time"))
            {
                metroTextBox39.Text = "5";
            }
            else if (comboBox26.SelectedItem == ("Always"))
            {
                metroTextBox39.Text = "6";
            }
        }
        public void scoring27()
        {

            if (comboBox27.SelectedItem == ("Never"))
            {
                metroTextBox40.Text = "1";
            }
            else if (comboBox27.SelectedItem == ("Seldom"))
            {
                metroTextBox40.Text = "2";
            }
            else if (comboBox27.SelectedItem == ("Sometimes"))
            {
                metroTextBox40.Text = "3";
            }
            else if (comboBox27.SelectedItem == ("Often"))
            {
                metroTextBox40.Text = "4";
            }
            else if (comboBox27.SelectedItem == ("Most of the time"))
            {
                metroTextBox40.Text = "5";
            }
            else if (comboBox27.SelectedItem == ("Always"))
            {
                metroTextBox40.Text = "6";
            }
        }
        public void scoring28()
        {

            if (comboBox28.SelectedItem == ("Never"))
            {
                metroTextBox31.Text = "1";
            }
            else if (comboBox28.SelectedItem == ("Seldom"))
            {
                metroTextBox31.Text = "2";
            }
            else if (comboBox28.SelectedItem == ("Sometimes"))
            {
                metroTextBox31.Text = "3";
            }
            else if (comboBox28.SelectedItem == ("Often"))
            {
                metroTextBox31.Text = "4";
            }
            else if (comboBox28.SelectedItem == ("Most of the time"))
            {
                metroTextBox31.Text = "5";
            }
            else if (comboBox28.SelectedItem == ("Always"))
            {
                metroTextBox31.Text = "6";
            }
        }
        public void scoring29()
        {

            if (comboBox29.SelectedItem == ("Never"))
            {
                metroTextBox41.Text = "1";
            }
            else if (comboBox29.SelectedItem == ("Seldom"))
            {
                metroTextBox41.Text = "2";
            }
            else if (comboBox29.SelectedItem == ("Sometimes"))
            {
                metroTextBox41.Text = "3";
            }
            else if (comboBox29.SelectedItem == ("Often"))
            {
                metroTextBox41.Text = "4";
            }
            else if (comboBox29.SelectedItem == ("Most of the time"))
            {
                metroTextBox41.Text = "5";
            }
            else if (comboBox29.SelectedItem == ("Always"))
            {
                metroTextBox41.Text = "6";
            }
        }
        public void scoring30()
        {

            if (comboBox30.SelectedItem == ("Never"))
            {
                metroTextBox49.Text = "1";
            }
            else if (comboBox30.SelectedItem == ("Seldom"))
            {
                metroTextBox49.Text = "2";
            }
            else if (comboBox30.SelectedItem == ("Sometimes"))
            {
                metroTextBox49.Text = "3";
            }
            else if (comboBox30.SelectedItem == ("Often"))
            {
                metroTextBox49.Text = "4";
            }
            else if (comboBox30.SelectedItem == ("Most of the time"))
            {
                metroTextBox49.Text = "5";
            }
            else if (comboBox30.SelectedItem == ("Always"))
            {
                metroTextBox49.Text = "6";
            }
        }
        public void scoring31()
        {

            if (comboBox31.SelectedItem == ("Never"))
            {
                metroTextBox48.Text = "1";
            }
            else if (comboBox31.SelectedItem == ("Seldom"))
            {
                metroTextBox48.Text = "2";
            }
            else if (comboBox31.SelectedItem == ("Sometimes"))
            {
                metroTextBox48.Text = "3";
            }
            else if (comboBox31.SelectedItem == ("Often"))
            {
                metroTextBox48.Text = "4";
            }
            else if (comboBox31.SelectedItem == ("Most of the time"))
            {
                metroTextBox48.Text = "5";
            }
            else if (comboBox31.SelectedItem == ("Always"))
            {
                metroTextBox48.Text = "6";
            }
        }
        public void scoring32()
        {

            if (comboBox32.SelectedItem == ("The Worst"))
            {
                metroTextBox47.Text = "1";
            }
            else if (comboBox32.SelectedItem == ("Poor"))
            {
                metroTextBox47.Text = "2";
            }
            else if (comboBox32.SelectedItem == ("Below Average"))
            {
                metroTextBox47.Text = "3";
            }
            else if (comboBox32.SelectedItem == ("Above Average"))
            {
                metroTextBox47.Text = "4";
            }
            else if (comboBox32.SelectedItem == ("Superior"))
            {
                metroTextBox47.Text = "5";
            }
            else if (comboBox32.SelectedItem == ("The Best"))
            {
                metroTextBox47.Text = "6";
            }
        }
        public void scoring33()
        {

            if (comboBox33.SelectedItem == ("No Depth and Mastery of the Subject"))
            {
                metroTextBox46.Text = "1";
            }
            else if (comboBox33.SelectedItem == ("Poor"))
            {
                metroTextBox46.Text = "2";
            }
            else if (comboBox33.SelectedItem == ("Below Average"))
            {
                metroTextBox46.Text = "3";
            }
            else if (comboBox33.SelectedItem == ("Above Average"))
            {
                metroTextBox46.Text = "4";
            }
            else if (comboBox33.SelectedItem == ("Superior"))
            {
                metroTextBox46.Text = "5";
            }
            else if (comboBox33.SelectedItem == ("Extraordinary Depth and Mastery of the Subject"))
            {
                metroTextBox46.Text = "6";
            }
        }
        public void scoring34()
        {
            
            if (comboBox34.SelectedItem == ("The Worst! Cheating is rampant in class"))
            {
                metroTextBox45.Text = "1";
            }
            else if (comboBox34.SelectedItem == ("Poor"))
            {
                metroTextBox45.Text = "2";
            }
            else if (comboBox34.SelectedItem == ("Below Average"))
            {
                metroTextBox45.Text = "3";
            }
            else if (comboBox34.SelectedItem == ("Above Average"))
            {
                metroTextBox45.Text = "4";
            }
            else if (comboBox34.SelectedItem == ("Superior"))
            {
                metroTextBox45.Text = "5";
            }
            else if (comboBox34.SelectedItem == ("The Best! Each student does his/her own work all the times"))
            {
                metroTextBox45.Text = "6";
            }
        }
        public void scoring35()
        {

            if (comboBox35.SelectedItem == ("Never"))
            {
                metroTextBox44.Text = "1";
            }
            else if (comboBox35.SelectedItem == ("Seldom"))
            {
                metroTextBox44.Text = "2";
            }
            else if (comboBox35.SelectedItem == ("Sometimes"))
            {
                metroTextBox44.Text = "3";
            }
            else if (comboBox35.SelectedItem == ("Often"))
            {
                metroTextBox44.Text = "4";
            }
            else if (comboBox35.SelectedItem == ("Most of the time"))
            {
                metroTextBox44.Text = "5";
            }
            else if (comboBox35.SelectedItem == ("Always"))
            {
                metroTextBox44.Text = "6";
            }
        }
        public void scoring36()
        {

            if (comboBox36.SelectedItem == ("Never"))
            {
                metroTextBox43.Text = "1";
            }
            else if (comboBox36.SelectedItem == ("Seldom"))
            {
                metroTextBox43.Text = "2";
            }
            else if (comboBox36.SelectedItem == ("Sometimes"))
            {
                metroTextBox43.Text = "3";
            }
            else if (comboBox36.SelectedItem == ("Often"))
            {
                metroTextBox43.Text = "4";
            }
            else if (comboBox36.SelectedItem == ("Most of the time"))
            {
                metroTextBox43.Text = "5";
            }
            else if (comboBox36.SelectedItem == ("Always"))
            {
                metroTextBox43.Text = "6";
            }
        }
        public void scoring37()
        {

            if (comboBox37.SelectedItem == ("Never"))
            {
                metroTextBox42.Text = "1";
            }
            else if (comboBox37.SelectedItem == ("Seldom"))
            {
                metroTextBox42.Text = "2";
            }
            else if (comboBox37.SelectedItem == ("Sometimes"))
            {
                metroTextBox42.Text = "3";
            }
            else if (comboBox37.SelectedItem == ("Often"))
            {
                metroTextBox42.Text = "4";
            }
            else if (comboBox37.SelectedItem == ("Most of the time"))
            {
                metroTextBox42.Text = "5";
            }
            else if (comboBox37.SelectedItem == ("Always"))
            {
                metroTextBox42.Text = "6";
            }
        }











        public void print2()
        {
           
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from questions where Id = '1'";
            command.CommandText = query;
            MySqlDataReader read1 = command.ExecuteReader();

            while (read1.Read())
            {


                metroLabel5.Text = read1["1"].ToString();
                metroLabel7.Text = read1["2"].ToString();
                metroLabel8.Text = read1["3"].ToString();
                metroLabel9.Text = read1["4"].ToString();
                metroLabel10.Text = read1["5"].ToString();
                metroLabel11.Text = read1["6"].ToString();
                metroLabel12.Text = read1["7"].ToString();
                metroLabel14.Text = read1["8"].ToString();
                metroLabel15.Text = read1["9"].ToString();
             

            }
            conn.Close();
        }
        public void print3()
        {

            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from questions where Id = '2'";
            command.CommandText = query;
            MySqlDataReader read1 = command.ExecuteReader();

            while (read1.Read())
            {


                metroLabel24.Text = read1["1"].ToString();
                metroLabel23.Text = read1["2"].ToString();
                metroLabel22.Text = read1["3"].ToString();
                metroLabel21.Text = read1["4"].ToString();
                metroLabel20.Text = read1["5"].ToString();
                metroLabel19.Text = read1["6"].ToString();
                metroLabel18.Text = read1["7"].ToString();
                metroLabel17.Text = read1["8"].ToString();
                metroLabel16.Text = read1["9"].ToString();
                metroLabel47.Text = read1["10"].ToString();
                metroLabel45.Text = read1["11"].ToString();
                metroLabel44.Text = read1["12"].ToString();
                metroLabel43.Text = read1["13"].ToString();
                metroLabel42.Text = read1["14"].ToString();
                metroLabel41.Text = read1["15"].ToString();
                metroLabel40.Text = read1["16"].ToString();
                metroLabel39.Text = read1["17"].ToString();
                metroLabel38.Text = read1["18"].ToString();
                metroLabel37.Text = read1["19"].ToString();
                metroLabel48.Text = read1["20"].ToString();
                metroLabel56.Text = read1["21"].ToString();
                metroLabel55.Text = read1["22"].ToString();
                metroLabel54.Text = read1["23"].ToString();
                metroLabel53.Text = read1["24"].ToString();
                metroLabel52.Text = read1["25"].ToString();
                metroLabel51.Text = read1["26"].ToString();
                metroLabel50.Text = read1["27"].ToString();
                metroLabel49.Text = read1["28"].ToString();

            }
            conn.Close();
        }
        private void view1()
        {
            MySqlConnection conn = new MySqlConnection(myConnection);
            listView1.Items.Clear();
            conn.Close();


            conn.Open();
            MySqlCommand command = conn.CreateCommand();

            string query1 = "select * from dbenroll where LastName like'" + metroTextBox4.Text + "%'";
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
        private void view()
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
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("    STI Faculty Evaluation ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 90));
            e.Graphics.DrawString("    Student's Questionnaire(Form S)", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 110));
            e.Graphics.DrawString("    STI ", new Font("Arial", 36, FontStyle.Bold), Brushes.Black, new Point(50, 60));
            e.Graphics.DrawString("    Student's Name: " + metroTextBox2.Text + " " + metroTextBox3.Text + " " + metroTextBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 150));
            e.Graphics.DrawString("    Teacher's Name: " + metroTextBox2.Text + " " + metroTextBox3.Text + " " + metroTextBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 170));
            e.Graphics.DrawString("    Subject: " + metroTextBox2.Text + " Time Start" + metroTextBox3.Text + " Time End" + metroTextBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 190));
            e.Graphics.DrawString("    I. Professional Responsibilities", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 210));
            e.Graphics.DrawString("    1. Does your instructor show interes and enthusiasm in teaching?                       "+comboBox1.Text+"", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 230));
            e.Graphics.DrawString("    2. How do you rate your instructor's patience in guiding you" , new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 250));
            e.Graphics.DrawString("    and your classmates to learn?                                                                                " + comboBox1.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(70, 270));
            e.Graphics.DrawString("    3. Does your instructor maintain professional rapport with                                     " + comboBox2.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 290));
            e.Graphics.DrawString("    his/her colleagues,with your parents,and with the community?", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(70, 310));
            e.Graphics.DrawString("    4. Does your instructor keep an open mind to ideas different                                " + comboBox3.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 330));
            e.Graphics.DrawString("    with his/hers?", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(70, 350));
            e.Graphics.DrawString("    5. Does your instructor maintain a friendly and                                                        " + comboBox3.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 370));
            e.Graphics.DrawString("    respectful relationship?", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(70, 390));
            e.Graphics.DrawString("    6. Does your instructor demonstrate awareness of his/hers limitations?             " + comboBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 410));
            e.Graphics.DrawString("    7. How would you rate your instructor's enthusiasm for learning?                       " + comboBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 430));
            e.Graphics.DrawString("    8. Does your instructor show his/her belief in you as a student by                       " + comboBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 450));
            e.Graphics.DrawString("    implementing activities that help you develop your full potetial?", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(70, 470));
            e.Graphics.DrawString("    9. Does your instructor treat you and your classmates equally and fairly?         " + comboBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 490));
            e.Graphics.DrawString("    II. Instructional Responsibilities", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 510));
            e.Graphics.DrawString("    1. Does your instructor speak with a modulated voice,clear diction,", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 530));
            e.Graphics.DrawString("    pronounciation and articulation                                                                            " + comboBox4.Text , new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(70, 550));
            e.Graphics.DrawString("    2. Does your instructor show effective non- verbal communication", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 570));
            e.Graphics.DrawString("    like facial expressions and gestures?                                                                     " + comboBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(70, 590));
            e.Graphics.DrawString("    3. Does your instructor use badly chosen words such as foul languages, etc?      " + comboBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 610));
            e.Graphics.DrawString("    4. How do you rate your instructor's knowledge of the subject matter?                  " + comboBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 630));
            e.Graphics.DrawString("    5. Is your instructor updated with new developments in his/her area of expertise? " + comboBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 650));
            e.Graphics.DrawString("    6. Does your instructor relate his/her subject to other areas of discipline?        " + comboBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 670));
            e.Graphics.DrawString("    7. Does your instructor respond to discipline problems?                                   " + comboBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 690));
            e.Graphics.DrawString("    8. Does your instructor clearly set appropriate instructions and expectations     ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 710));
            e.Graphics.DrawString("    to the class, and firmly implements such instructions?                                    " + comboBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(70, 730));
            e.Graphics.DrawString("    9. Does your instructor treat you and your classmates equally and fairly?           " + comboBox4.Text + "", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 750));
            e.Graphics.DrawString("    Comments and Suggestions", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 770));
            e.Graphics.DrawString("    " + metroTextBox5.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(50, 790));
            



            Pen black = new Pen(Color.Black, 1);

            //e.Graphics.DrawLine(black, 225, 5, 225, 2000);
            //e.Graphics.DrawRectangle(black, 10, 300, 225, 700);
        }

   
        private void metroLabel13_Click(object sender, EventArgs e)
        {
                DialogResult dr = MessageBox.Show("Are you sure you want to go back? All unsaved data will be lost", "Confirmation", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
                }
                else if(dr == DialogResult.No)
                {
                return;
                }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
    
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                    }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring12();
        }

        private void Question_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel29_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel32_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
            this.Hide();
        }

        private void metroLabel34_Click(object sender, EventArgs e)
        {

            if (metroTextBox8.Text == "" || metroTextBox9.Text == "" || metroTextBox10.Text == "" || metroTextBox11.Text == "" || metroTextBox12.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || comboBox6.Text == "" || comboBox7.Text == "" || comboBox8.Text == "" || comboBox9.Text == "" || comboBox10.Text == "" || comboBox11.Text == "" || comboBox12.Text == "" || comboBox13.Text == "" || comboBox14.Text == "" || comboBox15.Text == "" || comboBox16.Text == "" || comboBox17.Text == "" || comboBox18.Text == "")
            { MessageBox.Show("There are items left blanked"); }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (metroTextBox8.Text == "" || metroTextBox9.Text == "" || metroTextBox10.Text == "" || metroTextBox11.Text == "" || metroTextBox12.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || comboBox6.Text == "" || comboBox7.Text == "" || comboBox8.Text == "" || comboBox9.Text == "" || comboBox10.Text == "" || comboBox11.Text == "" || comboBox12.Text == "" || comboBox13.Text == "" || comboBox14.Text == "" || comboBox15.Text == "" || comboBox16.Text == "" || comboBox17.Text == "" || comboBox18.Text == "")
            { MessageBox.Show("There are items left blanked"); }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
            view1();
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {
            view1();
        }

        private void metroTextBox4_MouseClick(object sender, MouseEventArgs e)
        {
            view1();
        }

        private void metroLabel33_Click(object sender, EventArgs e)
        {
            if (metroTextBox8.Text == "" || metroTextBox9.Text == "" || metroTextBox10.Text == "" || metroTextBox11.Text == "" || metroTextBox12.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || comboBox6.Text == "" || comboBox7.Text == "" || comboBox8.Text == "" || comboBox9.Text == "" || comboBox10.Text == "" || comboBox11.Text == "" || comboBox12.Text == "" || comboBox13.Text == "" || comboBox14.Text == "" || comboBox15.Text == "" || comboBox16.Text == "" || comboBox17.Text == "" || comboBox18.Text == "")
           { MessageBox.Show("There are items left blanked"); }
            else 
            {
                Add();
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            print();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                Add();

            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            metroTextBox3.Text = "";
            metroTextBox6.Text = "";
            metroTextBox7.Text = "";
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            scoring1();
            totalave();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring2();
            totalave();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring3();
            totalave();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring4();
            totalave();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring5();
            totalave();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring6();
            totalave();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring7();
            totalave();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring8();
            totalave();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring9();
            totalave();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring11();
            totalave();
        }

        private void metroTextBox29_Click(object sender, EventArgs e)
        {
        
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring10();
            totalave();
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring13();
            totalave();
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring14();
            totalave();
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring15();
            totalave();
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring16();
            totalave();
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring17();
            totalave();
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring18();
            totalave();
        }

        private void comboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring28();
            totalave();
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring19();
            totalave();
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring20();
            totalave();
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring21();
            totalave();
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring22();
            totalave();
        }

        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring23();
            totalave();
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring24();
            totalave();
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring25();
            totalave();
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring26();
            totalave();
        }

        private void comboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring27();
            totalave();
        }

        private void comboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring29();
            totalave();
        }

        private void comboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring30();
            totalave();
        }

        private void comboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring31();
            totalave();
        }

        private void comboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring32(); totalave();
        }

        private void comboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring33();
                totalave();
        }

        private void comboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring34();
            totalave();
        }

        private void comboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring35();
            totalave();
        }

        private void comboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring36();
            totalave();
        }

        private void comboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoring37();
            totalave();
            finalaverage();
        }

        private void metroTextBox10_TextChanged(object sender, EventArgs e)
        {
            tanan();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

    }
}
