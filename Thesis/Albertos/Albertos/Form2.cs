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
    public partial class Form2 : Form
    {
        string myConnection = "Server=localhost;Database= dbpizza ;Uid=root;Password=";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
            
            int b = 75;
            ListViewItem item = new ListViewItem(button1.Text);
            item.SubItems.Add(button14.Text);
            item.SubItems.Add(Convert.ToString(b));
            LVCustomer.Items.Add(item);

            Quantity form = new Quantity();
            form.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //int a = Convert.ToInt32(textBox1.Text);
            //int b = 115;
            //int c = a * b;
            //ListViewItem item = new ListViewItem(button1.Text);
            //item.SubItems.Add(button14.Text);
            //item.SubItems.Add(Convert.ToString(b));
            //item.SubItems.Add(textBox1.Text);
            //item.SubItems.Add(Convert.ToString(c));
            //LVCustomer.Items.Add(item);
        }
    }
}
