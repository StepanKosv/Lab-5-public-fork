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
    public partial class InputStringElements : Form
    {
        int strind;
        int strlen;
        public decimal[] newStr { get; private set; }
        IEnumerator<int> positions;
        public InputStringElements(int _strind, int _strlen)
        {
            InitializeComponent();
            strind = _strind;
            strlen = _strlen;
            newStr = new decimal[strlen];
            positions = Positions(strind, strlen);
            positions.MoveNext();
        }
        IEnumerator<int> Positions(int fixh, int n)
        {
            for (int i = 0; i < n; i++)
            {
                this.label1.Text = $"input element on {fixh + 1}, {i + 1} from -1000 to 1000";
                yield return i;
                newStr[i] = numericUpDown1.Value;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            positions.MoveNext();
        }
    }
}
