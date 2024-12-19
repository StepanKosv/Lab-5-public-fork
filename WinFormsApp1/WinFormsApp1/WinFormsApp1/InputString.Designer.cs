namespace WinFormsApp1
{
    partial class InputString
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
            textBox1 = new TextBox();
            input = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 28);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "input string";
            textBox1.Size = new Size(744, 47);
            textBox1.TabIndex = 0;
            // 
            // input
            // 
            input.Location = new Point(23, 140);
            input.Name = "input";
            input.Size = new Size(188, 58);
            input.TabIndex = 1;
            input.Text = "input";
            input.UseVisualStyleBackColor = true;
            input.Click += input_Click;
            // 
            // InputString
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(input);
            Controls.Add(textBox1);
            Name = "InputString";
            Text = "InputString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button input;
    }
}