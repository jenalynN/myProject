using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginModule.cs
{
    public partial class DialogSelectRecordBelow : MaterialSkin.Controls.MaterialForm
    {
        public DialogSelectRecordBelow()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DialogSelectRecordBelow_Load(object sender, EventArgs e)
        {

        }
    }
}
