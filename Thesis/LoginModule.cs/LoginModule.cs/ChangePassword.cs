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
namespace LoginModule.cs
{
    public partial class ChangePassword : MaterialSkin.Controls.MaterialForm
    {
        string myConnection = "Server=localhost;Database=db_poshconceptstorefinal;Uid=root;Password="; 
        public ChangePassword(string cashier)
        {
            InitializeComponent();
            tbuseraccountid.Text = cashier;
            viewUsername();
        }
        public void viewUsername()
        {

            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select col_user from tbl_useraccounts where col_useraccountsid = '" + tbuseraccountid.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();


            while (read.Read())
            {
                tbusername.Text = read["col_user"].ToString();
            }
            conn.Close();
        }
        public void Update()
        {
            MySqlConnection conn2 =new MySqlConnection(myConnection);
            
            MySqlCommand command2 = conn2.CreateCommand();

            conn2.Open();
            string query = "UPDATE tbl_useraccounts SET " +
            "col_password= '" + tbconfirmnewpass.Text + "'" +
            "WHERE col_useraccountsid='" + tbuseraccountid.Text + "'";
            command2.CommandText = query;
            command2.ExecuteScalar();
            MessageBox.Show("oks");
            conn2.Close();

            this.Hide();


        }

        public void checkPassword()
        {
            if (tbnewpass.Text == tbconfirmnewpass.Text)
            {
                MySqlConnection conn = new MySqlConnection(myConnection);
                MySqlCommand Command2 = conn.CreateCommand();
                Command2.Connection = conn;
                conn.Open();
                Command2.CommandText = "select * from tbl_useraccounts where col_user = '" + tbusername.Text + "' and col_password= '" + tboldpass.Text + "' and col_status='unarchived'";
                MySqlDataReader read2 = Command2.ExecuteReader();
                int count2 = 0;
                while (read2.Read())
                {
                    count2++;

                }
                conn.Close();
                if (count2 >= 1)
                {
                    MySqlCommand copro5 = new MySqlCommand();
                    conn.Open();
                    copro5.Connection = conn;

                    copro5.CommandText = "select * from tbl_useraccounts where col_user = '" +
                    tbusername.Text + "' and col_password= '" + tboldpass.Text + "' and col_useraccountsid= '" +
                    tbuseraccountid.Text + "' and col_usertypeid='2'";


                    MySqlDataReader copro2 = copro5.ExecuteReader();
                    while (copro2.Read())
                    {
                        string userid = (copro2["col_useraccountsid"].ToString());
                        string user = (copro2["col_user"].ToString());
                        string pass = (copro2["col_password"].ToString());

                        if (userid == tbuseraccountid.Text && user == tbusername.Text && pass == tboldpass.Text)
                        {
                            Update();
                        }


                    }

                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
            else
            {
                MessageBox.Show("Password does not match");
            }
        }
        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            checkPassword();
        }

            
}
}