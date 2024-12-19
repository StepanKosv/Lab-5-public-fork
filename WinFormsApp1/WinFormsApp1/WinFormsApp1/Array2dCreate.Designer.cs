namespace WinFormsApp1
{
    partial class Array2dCreate
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
            label1 = new Label();
            label2 = new Label();
            createButton = new Button();
            stringsCount = new NumericUpDown();
            columnsCount = new NumericUpDown();
            comboBox1 = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)stringsCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)columnsCount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 50);
            label1.Name = "label1";
            label1.Size = new Size(377, 41);
            label1.TabIndex = 0;
            label1.Text = "strings count from 0 to 100";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 50);
            label2.Name = "label2";
            label2.Size = new Size(401, 41);
            label2.TabIndex = 1;
            label2.Text = "columns count from 0 to 100";
            // 
            // createButton
            // 
            createButton.Location = new Point(95, 344);
            createButton.Name = "createButton";
            createButton.Size = new Size(188, 58);
            createButton.TabIndex = 4;
            createButton.Text = "create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // stringsCount
            // 
            stringsCount.Location = new Point(97, 110);
            stringsCount.Name = "stringsCount";
            stringsCount.Size = new Size(300, 47);
            stringsCount.TabIndex = 5;
            // 
            // columnsCount
            // 
            columnsCount.Location = new Point(488, 110);
            columnsCount.Name = "columnsCount";
            columnsCount.Size = new Size(300, 47);
            columnsCount.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "user input", "random nums" });
            comboBox1.Location = new Point(95, 252);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 49);
            comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 187);
            label3.Name = "label3";
            label3.Size = new Size(200, 41);
            label3.TabIndex = 8;
            label3.Text = "input method";
            // 
            // Array2dCreate
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 450);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(columnsCount);
            Controls.Add(stringsCount);
            Controls.Add(createButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Array2dCreate";
            Text = "Create 2d Array";
            ((System.ComponentModel.ISupportInitialize)stringsCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)columnsCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button createButton;
        private NumericUpDown stringsCount;
        private NumericUpDown columnsCount;
        private ComboBox comboBox1;
        private Label label3;
    }
}