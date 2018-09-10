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
    public partial class Home : Form
    {
        string myConnection = "Server=localhost;Database= dbpizza ;Uid=root;Password=";
        public Home()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            buttonPizza.BackColor = Color.FromArgb(249, 254, 110);
            buttonaddOrder.BackColor = Color.Silver;
            OnCall frm = new OnCall();
            frm.Show();
          

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void buttonaddPizza_Click(object sender, EventArgs e)
        {
           
            buttonaddOrder.BackColor = Color.FromArgb(249, 254, 110);
            buttonPizza.BackColor = Color.Silver;
            Pizza frm = new Pizza();
            frm.Show();

        }

        //private void buttonUpdate_Click(object sender, EventArgs e)
        //{
        //    buttonaddPizza.BackColor = Color.FromArgb(249, 254, 110);
        //    buttonaddOrder.BackColor = Color.FromArgb(249, 254, 110);
        //    buttonUpdate.BackColor = Color.Silver;
        //    UpdatePizza frm = new UpdatePizza();
        //    frm.Show();

        //}

        private void button1_Click_2(object sender, EventArgs e)
        {
            buttonaddOrder.BackColor = Color.FromArgb(249, 254, 110);
            buttonPizza.BackColor = Color.FromArgb(249, 254, 110);
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
