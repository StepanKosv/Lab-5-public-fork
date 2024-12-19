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
    public partial class CreateString : Form
    {
        int ind;
        public decimal[] newstring { get; private set; }
        public CreateString(int _ind)
        {
            InitializeComponent();
            this.stringIndLabel.Text = $"string #{_ind+1}";
            ind = _ind;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int elcount = (int)Math.Round(numericUpDown1.Value);
            bool isSucces = true;
            if (elcount == 0)
            {
                newstring = new decimal[0];
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                InputStringElements inputStringElements = new InputStringElements(ind, elcount);
                DialogResult res = inputStringElements.ShowDialog();
                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("input was canceled");
                    isSucces = false;
                }
                else
                {
                    newstring = inputStringElements.newStr;
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                newstring = new decimal[elcount];
                for (int i = 0; i < elcount; i++)
                {
                    newstring[i] = (decimal)Program.random.Next(-1000,1000);
                }
            }
            else
            {
                isSucces = false;
                MessageBox.Show("please chose input method");
            }
            if (isSucces)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
