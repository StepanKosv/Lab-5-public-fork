namespace WinFormsApp1
{
    partial class DeleteColumns
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            firstColumn = new NumericUpDown();
            lastColumn = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)firstColumn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lastColumn).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 178);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 0;
            button1.Text = "delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // firstColumn
            // 
            firstColumn.Location = new Point(12, 98);
            firstColumn.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            firstColumn.Name = "firstColumn";
            firstColumn.Size = new Size(300, 47);
            firstColumn.TabIndex = 1;
            firstColumn.Value = new decimal(new int[] { 1, 0, 0, 0 });
            firstColumn.ValueChanged += firstColumn_ValueChanged;
            // 
            // lastColumn
            // 
            lastColumn.Location = new Point(389, 98);
            lastColumn.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            lastColumn.Name = "lastColumn";
            lastColumn.Size = new Size(300, 47);
            lastColumn.TabIndex = 2;
            lastColumn.Value = new decimal(new int[] { 1, 0, 0, 0 });
            lastColumn.ValueChanged += lastColumn_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(263, 41);
            label1.TabIndex = 3;
            label1.Text = "first column (from)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 23);
            label2.Name = "label2";
            label2.Size = new Size(224, 41);
            label2.TabIndex = 4;
            label2.Text = "last column (to)";
            // 
            // DeleteColumns
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastColumn);
            Controls.Add(firstColumn);
            Controls.Add(button1);
            Name = "DeleteColumns";
            Text = "Delete Columns";
            Load += DeleteColumns_Load;
            ((System.ComponentModel.ISupportInitialize)firstColumn).EndInit();
            ((System.ComponentModel.ISupportInitialize)lastColumn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private NumericUpDown firstColumn;
        private NumericUpDown lastColumn;
        private Label label1;
        private Label label2;
    }
}