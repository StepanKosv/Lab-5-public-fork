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
    public partial class DeleteColumns : Form
    {
        public decimal[,] newArr2d { get; private set; }
        public DeleteColumns()
        {
            InitializeComponent();
        }

        private void DeleteColumns_Load(object sender, EventArgs e)
        {
            if (!Program.isArr2dCreated)
            {
                MessageBox.Show("error: firstly create 2d array");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else if (Program.arr2d.GetLength(1) == 0)
            {
                MessageBox.Show("columns count already 0");
                this.Close();
            }
            else
            {
                this.firstColumn.Minimum = 1;
                this.firstColumn.Maximum = Program.arr2d.GetLength(1);
                this.firstColumn.Value = 1;
                this.lastColumn.Minimum = 1;
                this.lastColumn.Maximum = Program.arr2d.GetLength(1);
                this.lastColumn.Value = 1;
            }
        }

        private void firstColumn_ValueChanged(object sender, EventArgs e)
        {
            this.firstColumn.Value = Math.Round(this.firstColumn.Value);
            this.lastColumn.Value = Math.Max(this.lastColumn.Value, this.firstColumn.Value);
        }

        private void lastColumn_ValueChanged(object sender, EventArgs e)
        {
            this.lastColumn.Value = Math.Round(this.lastColumn.Value);
            this.firstColumn.Value = Math.Min(this.firstColumn.Value, this.lastColumn.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.newArr2d = ListMethods.WithoutColumns(Program.arr2d, (int)this.firstColumn.Value-1, (int)this.lastColumn.Value);
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
