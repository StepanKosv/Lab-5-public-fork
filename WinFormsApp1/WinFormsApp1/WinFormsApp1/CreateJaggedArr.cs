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
    public partial class CreateJaggedArr : Form
    {
        public decimal[][] newarr { get; private set; }
        public CreateJaggedArr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int strc = (int)Math.Round(this.numericUpDown1.Value);
            newarr = new decimal[strc][];
            bool isSucces = true;
            for (int i = 0; i < strc; i++)
            {
                CreateString createString = new CreateString(i);
                DialogResult res = createString.ShowDialog();
                if (res == DialogResult.OK)
                {
                    newarr[i] = createString.newstring;
                }
                else
                {
                    MessageBox.Show("input was canceled");
                    isSucces = false;
                    break;
                }
            }
            if (isSucces)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
