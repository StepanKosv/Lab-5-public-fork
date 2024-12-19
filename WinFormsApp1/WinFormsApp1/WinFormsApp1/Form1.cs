using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Create2dClick(object sender, EventArgs e)
        {
            Array2dCreate array2DCreate = new Array2dCreate();
            var res = array2DCreate.ShowDialog();
            if (res == DialogResult.OK)
            {
                Program.arr2d = array2DCreate.newArr2d;
                Program.isArr2dCreated = true;
            }
        }

        private void DeleteColumnsClick(object sender, EventArgs e)
        {
            DeleteColumns deleteColumns = new DeleteColumns();
            DialogResult res = deleteColumns.ShowDialog();
            if (res == DialogResult.OK)
            {
                Program.arr2d = deleteColumns.newArr2d;
            }
            else if (res != DialogResult.Cancel)
            {
                MessageBox.Show("something went wrong");
            }

        }

        private void ShowArr2dButton_Click(object sender, EventArgs e)
        {
            if (Program.isArr2dCreated)
            {
                StringBuilder sb = new StringBuilder("");
                for (int i = 0; i < Program.arr2d.GetLength(0); i++)
                {
                    for (int j = 0; j < Program.arr2d.GetLength(1); j++)
                    {
                        sb.Append(Program.arr2d[i, j]);
                        sb.Append(",\t");
                    }
                    sb.Append(";\n");
                }
                MessageBox.Show(sb.ToString());
            }
            else
            {
                MessageBox.Show("not created");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateJaggedArr createJaggedArr = new CreateJaggedArr();
            DialogResult result = createJaggedArr.ShowDialog();
            if (result == DialogResult.OK)
            {
                Program.isJaggedCreated = true;
                Program.jaggedArr = createJaggedArr.newarr;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Program.isJaggedCreated)
            {
                MessageBox.Show("not created");
                return;
            }
            string s = String.Join(
                ";\n",
                ListMethods.Select(
                    Program.jaggedArr,
                    (a, i) => String.Join(",\t", a)
                )
            );
            MessageBox.Show(s);
        }

        private void addFirstButton_Click(object sender, EventArgs e)
        {
            if (!Program.isJaggedCreated)
            {
                MessageBox.Show("error: please create array");
                return;
            }
            CreateString createString = new CreateString(0);
            DialogResult result = createString.ShowDialog();
            if (result == DialogResult.OK)
            {
                Program.jaggedArr = ListMethods.Contact(
                    new decimal[][] { createString.newstring },
                    Program.jaggedArr
                );
            }
        }

        private void showString_Click(object sender, EventArgs e)
        {
            if (!Program.isStrProcessed)
            {
                MessageBox.Show("string dont exist, pleale input string");
            }
            else
            {
                MessageBox.Show($"string:\n{Program.str}");
            }
        }

        private void processedString_Click(object sender, EventArgs e)
        {
            if (!Program.isStrProcessed)
            {
                MessageBox.Show("string dont exist, pleale input string");
            }
            else
            {
                MessageBox.Show($"processed string:\n{Program.processedsStr}");
            }
        }

        private void inputString_Click(object sender, EventArgs e)
        {
            InputString inputString = new InputString();
            DialogResult res = inputString.ShowDialog();
            if (res == DialogResult.OK)
            {
                Program.str = inputString.newstr;
                Program.processedsStr = Regex.Replace(Program.str, @"(\w|\s|,|;|:)+",(a) => reverse1(a.Value));
                Program.isStrProcessed = true;
            }
        }
        string reverse1(string str)
        {
            var arr = ListMethods.Select(
                    Regex.Matches(str, @"\w+").ToArray(),
                    (a, i) =>
                    {
                        var t = a.Value.ToArray();
                        Array.Reverse(t);
                        return String.Concat(t);
                    }
            );

            Array.Sort(
                arr,
                new MyComp()
            );
            //Array.Reverse(arr);

            int i = 0;
            return Regex.Replace(
                str,
                @"\w+",
                (match) => { i++; return arr[i - 1]; }
            );
        }
    }
    class MyComp : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            
            return x.Length.CompareTo(y.Length);
        }
    }
}
