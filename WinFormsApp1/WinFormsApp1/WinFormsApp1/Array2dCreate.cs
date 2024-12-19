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
    public partial class Array2dCreate : Form
    {
        public decimal[,] newArr2d { get; private set; }
        public Array2dCreate()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            int x = (int)Math.Round(stringsCount.Value);
            int y = (int)Math.Round(columnsCount.Value);
            bool isSucces = true;
            newArr2d = new decimal[0, 0];
            if (x == 0 || y == 0)
            {
                newArr2d = new decimal[x, y];
            }
            else if(comboBox1.SelectedIndex == 0)
            {
                InputElements2dMenu inpel = new InputElements2dMenu(x, y);
                DialogResult res = inpel.ShowDialog();
                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("input was canceled");
                    isSucces = false;
                }
                else if (res == DialogResult.OK)
                {
                    newArr2d = inpel.arr2d;
                }
                else
                {
                    MessageBox.Show("something went wrong");
                    isSucces = false;
                }
            }
            else if (this.comboBox1.SelectedIndex == 1)
            {
                newArr2d = new decimal[x, y];
                for (int i = 0; i < newArr2d.GetLength(0); i++)
                {
                    for(int j = 0; j < newArr2d.GetLength(1); j++)
                    {
                        newArr2d[i, j] = (decimal)Program.random.Next(-1000,1000);
                    }
                }
            }
            else
            {
                MessageBox.Show("error: please chose input method");
                isSucces = false;
            }
            if (isSucces)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
