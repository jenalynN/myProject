using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginModule.cs
{
    class DataHandling
    {

        public void alphanumericTrap_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = System.Text.RegularExpressions.Regex.Replace(textboxSender.Text, "[^0-9a-zA-Z]", "");
            textboxSender.SelectionStart = cursorPosition;
        }

        public void stringOnly_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = System.Text.RegularExpressions.Regex.Replace(textboxSender.Text, "[^a-zA-Z ]|([ ]{2})", "");
            textboxSender.SelectionStart = cursorPosition;
        }

        public void emailAddressTrap_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = System.Text.RegularExpressions.Regex.Replace(textboxSender.Text, "[^0-9a-zA-Z\\.@]|(\\.\\.)|(@.*@)|(@.*\\..*\\.com)", "");
            textboxSender.SelectionStart = cursorPosition;
            //textboxSender.Text = textboxSender.Text.Remove(textboxSender.Text.Length - 1);
        }
        public void genericTextBoxTrim_Leave(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            textboxSender.Text = textboxSender.Text.Trim();
        }

        public void namingTrap_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = System.Text.RegularExpressions.Regex.Replace(textboxSender.Text, "[^0-9a-zA-Z,\\. ]|(\\.\\.)|(,,)|([ ]{2})", "");
            textboxSender.SelectionStart = cursorPosition;
        }
        public void numbersOnlyTrap_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = System.Text.RegularExpressions.Regex.Replace(textboxSender.Text, "[^0-9]", "");
            textboxSender.SelectionStart = cursorPosition;
        }
        
        public void decimalNumberTrap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
