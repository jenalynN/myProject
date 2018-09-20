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
    public partial class NewCashier : MaterialSkin.Controls.MaterialForm
    {
        public NewCashier()
        {
            InitializeComponent();
        }
        public void addnewCashierAccount() 
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
                command2.CommandText = "insert into tbl_useraccounts (col_usertypeid, " +
                    "col_user, " +
                    "col_password, " +
                    "col_lastname, " +
                    "col_firstname, " +
                    "col_middlename, " +
                    "col_address, " +
                    //"col_dateofbirth, " +
                    "col_gender, " +
                    "col_contactnum, " +
                    "col_status) " +
                    "values  ((SELECT col_usertypeid from tbl_usertype where col_userrole='Cashier'),'" +
                    textBox9.Text + "','" +
                    textBox11.Text + "','" +
                    textBox3.Text + "','" +
                    textBox1.Text + "','" +
                    textBox2.Text + "','" +
                    textBox5.Text + "','" +
                    //dateTimePicker1.Text + "','" +
                    comboBox1.SelectedItem.ToString() + "','" +
                    textBox6.Text +
                    "','unarchived')";
                command2.ExecuteScalar();
                conn.Close();
            }        
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            addnewCashierAccount();
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();

        }
    }
}
