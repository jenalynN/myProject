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
    public partial class ViewProductInfo : MaterialSkin.Controls.MaterialForm
    {

        string myConnection = "Server=localhost;Database=db_poshconceptstorefinal;Uid=root;Password="; 
        public ViewProductInfo(string materialSingleLineTextField5)
        {
            InitializeComponent();
            label4.Text = materialSingleLineTextField5;
            printdata();
        }
        public void printdata() 
        {
            MySqlConnection conn = new MySqlConnection(myConnection);

            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            string query = "select * from tbl_product where col_productid = '" + label4.Text + "'";
            command.CommandText = query;
            MySqlDataReader read = command.ExecuteReader();


            while (read.Read())
            {
                label4.Text = read["col_productid"].ToString();
                textBox1.Text = read["col_productcode"].ToString();
                comboBox1.Text = read["p.col_useraccountsid "].ToString();
                comboBox2.Text = read["col_categoryid"].ToString();
                textBox2.Text = read["col_productprice"].ToString();
                textBox4.Text = read["col_status"].ToString();

            }
            conn.Close();
        
        }
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.Show();
            this.Hide();
        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            Mainframe a = new Mainframe();
            a.ShowDialog();
            this.Hide();
        }
    }
}
