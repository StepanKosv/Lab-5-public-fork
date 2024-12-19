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
    public partial class InputElements2dMenu : Form
    {
        public decimal[,] arr2d;
        IEnumerator<(int i, int j)> positions;
        public InputElements2dMenu(int x, int y)
        {
            InitializeComponent();
            arr2d = new decimal[x, y];
            positions = Positions(x, y);
            positions.MoveNext();
        }

        private void InputButtonClick(object sender, EventArgs e)
        {
            positions.MoveNext();
        }
        IEnumerator<(int i, int j)> Positions(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    this.label1.Text = $"input element on position {i+1}, {j+1} from -1000 to 1000";
                    yield return (i, j);
                    this.arr2d[i, j] = this.numericUpDown1.Value;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
