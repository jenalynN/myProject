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
    public partial class NewBrandPartnerAccount : MaterialSkin.Controls.MaterialForm
    {
        public NewBrandPartnerAccount()
        {
            InitializeComponent();
            getmax();
        }
        public void getmax()
        {
                MySqlConnection con = new MySqlConnection(ConnectionString.myConnection);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select MAX(col_useraccountsid) as maxID from tbl_useraccounts";
                MySqlDataReader basa = cmd.ExecuteReader();
                while (basa.Read())
                {
                    string maxid = basa["maxID"].ToString();

                    int plus1 = Int32.Parse(maxid);
                    int total = plus1 + 1;
                    labelTransactionCode.Text =""+ total;
                }
                con.Close();
    
        }
        public void addnewbrandpartneraccount() 
        {

            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            if (label1.Text == "")
            {
                MessageBox.Show("Complete the Form");
            }
            else
            {
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                command2.CommandText = "insert into tbl_useraccounts (col_usertypeid,col_user, col_password, col_lastname, col_firstname, col_middlename,col_address,col_gender,col_contactnum,col_status) " +
                    "values  ((SELECT col_usertypeid from tbl_usertype where col_userrole='Brandpartner'),'" + textBox9.Text + "','" + textBox11.Text + "','" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + comboBox1.SelectedItem + "','" + textBox6.Text + "','unarchived')";
                command2.ExecuteScalar();
                conn.Close();
            }
        
        }
        public void adddetails() 
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
            if (label1.Text == "")
            {
                MessageBox.Show("Complete the Form");
            }
            else
            {
                conn.Open();
                MySqlCommand command2 = conn.CreateCommand();
                command2.CommandText = "insert into tbl_brandpartner(col_useraccountsid, col_brandname, col_brandaddress, col_brandcontactnum) " +
                    "values  ('" + labelTransactionCode.Text + "','" + textBox4.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
                command2.ExecuteScalar();
                conn.Close();
            }
        
        
        }
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            addnewbrandpartneraccount();
            adddetails();
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }
    }
}
