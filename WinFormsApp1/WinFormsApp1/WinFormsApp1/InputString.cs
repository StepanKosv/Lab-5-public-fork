using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class InputString : Form
    {
        public string newstr;
        public InputString()
        {
            InitializeComponent();
        }

        private void input_Click(object sender, EventArgs e)
        {
            newstr = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
