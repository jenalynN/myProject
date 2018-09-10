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
    public partial class AddPizza : Form
    {
        string myConnection = "Server=localhost;Database= dbpizza ;Uid=root;Password=";
        public AddPizza()
        {
            InitializeComponent();
        }

        private void AddPizza_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(myConnection);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from tborder";
            MySqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                MySqlConnection con = new MySqlConnection(myConnection);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select MAX(id) as ayD from tb_pizzalist";
                MySqlDataReader basa = cmd.ExecuteReader();
                while (basa.Read())
                {
                    string ayd = basa["ayD"].ToString();
                    int plus1 = Int32.Parse(ayd);
                    int total = plus1 + 1;
                    label5.Text = "" + total;
                    label5.Text = total.ToString();
                }


                con.Close();
            }
            connection.Close();
            if (label1.Text == "")
            {
                label5.Text = "1";
            }
        }
    }
}
