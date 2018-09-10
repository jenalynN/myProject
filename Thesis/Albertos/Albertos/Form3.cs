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

namespace Albertos
{
    public partial class Form3 : Form
    {
        string myConnection = "Server=localhost;Database= dbpizza ;Uid=root;Password=";
        
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            tbdtp.Text = OnCall.dtp;
            tbpizzid.Text = OnCall.pizzid;
            tbid.Text = OnCall.ayd;
            tbName.Text = OnCall.name;
            tbsize.Text = OnCall.size;
            tbprice.Text = OnCall.price;
            tbquantity.Text = OnCall.quantity;
            tbtotal.Text = OnCall.total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connec = new MySqlConnection(myConnection);
            connec.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connec;
            command.CommandText = "INSERT INTO tb_order (order_id,date_ordered,pizza_id,pizza_quantity,total) values ('" + tbid.Text + "','" + tbdtp.Text + "','"+ tbpizzid.Text + "','" + tbquantity.Text +"','"+ tbtotal.Text + "')";
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Added");

            this.Close();
            

        }
        double x, z;
        double sum;
        private void tbprice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbprice.Text.Length == 0)
                {
                    tbprice.Text = "";
                }
                x = double.Parse(tbprice.Text);
                z = double.Parse(tbquantity.Text);
                sum = x * z;
                tbtotal.Text = sum.ToString() + ".00";

            }
            catch (Exception) {
            }
        }

        private void tbquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbprice.Text.Length == 0)
                {
                    tbprice.Text = "";
                }
                x = double.Parse(tbprice.Text);
                z = double.Parse(tbquantity.Text);
                sum = x * z;
                tbtotal.Text = sum.ToString() + ".00";
            }
            catch (Exception)
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
