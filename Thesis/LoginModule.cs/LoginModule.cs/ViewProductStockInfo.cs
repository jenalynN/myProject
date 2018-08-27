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
    public partial class ViewProductStockInfo : MaterialSkin.Controls.MaterialForm
    {

        string myConnection = "Server=localhost;Database=db_poshandfabconceptstore;Uid=root;Password=";
        public ViewProductStockInfo(string materialSingleLineTextField5)
        {
            InitializeComponent();
            label2.Text = materialSingleLineTextField5;
            viewinfo();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {

            Mainframe a = new Mainframe();
            a.ShowDialog();
            this.Hide();
        }
        public void viewinfo() 
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
                label7.Text = read["col_productcode"].ToString();
                label6.Text = read["col_brandid"].ToString();

            }
            conn.Close();
        
        }
    }
}
