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
    public partial class NewCategory : MaterialSkin.Controls.MaterialForm
    {
        public NewCategory()
        {
            InitializeComponent();
            viewbrand();
        }
        public void viewbrand()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                cbBrandP.Items.Clear();

                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                string query = "select col_brandname from tbl_brandpartner";
                command.CommandText = query;
                MySqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    cbBrandP.Items.Add(read["col_brandname"].ToString());
                }
                conn.Close();
            }
            catch (Exception e) 
            {
                MessageBox.Show("No connection to host");
            }
        }
        public void addcategory()
        {
            try
            { 
                MySqlConnection conn = new MySqlConnection(ConnectionString.myConnection);
                if (tbcatname.Text == "" || cbBrandP.Text == "")
                {
                    MessageBox.Show("Please Complete the Form");
                }
                else
                {
                    conn.Open();
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "select * from tbl_category where col_categoryname = '" + tbcatname.Text + "' ";
                    MySqlDataReader read = command.ExecuteReader();

                    int count = 0;
                    while (read.Read())
                    {
                        count++;
                    }
                    conn.Close();

                    if (count >= 1)
                    {
                        MessageBox.Show("Category already exist.");
                    }
                    else
                    {
                        conn.Open();
                        MySqlCommand command2 = conn.CreateCommand();
                        command2.CommandText = "insert into tbl_category (col_useraccountsid, col_categoryname) " +
                                    "values((Select col_useraccountsid from tbl_brandpartner where col_brandname= '" + cbBrandP.Text + "' limit 1),'" +
                                    tbcatname.Text + "')";
                        command2.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Successfully Added!");
                        Mainframe a = new Mainframe();
                        a.Show();
                        this.Close(); 
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No connection to host");
            }
        }

        private void btAddCat_Click(object sender, EventArgs e)
        {
            addcategory();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            new Mainframe().Show();
            this.Hide();
        }
    }
}
