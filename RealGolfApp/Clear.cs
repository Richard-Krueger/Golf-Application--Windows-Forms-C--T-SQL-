using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealGolfApp
{
    public static class Clear
    {
        public static void ClearAllBoxes(Form form)
        {
            foreach (Control c in form.Controls)
            {
                var textBox = c as TextBox;
                var comboBox = c as ComboBox;

                if (textBox != null)
                {
                    textBox.Clear();
                }
                if (comboBox != null)
                {
                    comboBox.SelectedIndex = -1;
                }
            }
        }
    }
}
