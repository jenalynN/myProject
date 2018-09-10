using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albertos
{
    public partial class review : Form
    {
        //Print print;
      //  List
        public review()
        {
            InitializeComponent();
        }

        private void review_Load(object sender, EventArgs e)
        {
            recieptBindingSource1.DataSource = new List<Reciept>();
            Reciept obj;
            for (int x = 0; x < tempdata.pizzaname.Count;x++) {
                obj = new Reciept()
                {
                    pizzaName=tempdata.pizzaname[x],
                    size=tempdata.size[x],
                    price =tempdata.price[x],
                    quantity =tempdata.quantity[x],
                    total = tempdata.total[x],
                   totalPrice = tempdata.totalPrice,
                   change = tempdata.change,
                    Cash_Received = tempdata.cashReceived
                };

                recieptBindingSource1.Add(obj);
                recieptBindingSource1.MoveLast();
            
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    for (int x = 0; x < tempdata.pizzaname.Count; x++)
        //    {
        //        print = new Print(recieptBindingSource1.DataSource as List<Reciept>,tempdata.pizzaname[x],tempdata.size[x],tempdata.price[x],tempdata.quantity[x],tempdata.total[x]);
               
        //    }
        //    print.ShowDialog();
        //}
    }
}
