namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            create2dButton = new Button();
            deleteColumnsButton = new Button();
            ShowArr2dButton = new Button();
            button1 = new Button();
            button2 = new Button();
            addFirstButton = new Button();
            inputString = new Button();
            showString = new Button();
            processedString = new Button();
            SuspendLayout();
            // 
            // create2dButton
            // 
            create2dButton.Location = new Point(23, 89);
            create2dButton.Name = "create2dButton";
            create2dButton.Size = new Size(351, 58);
            create2dButton.TabIndex = 0;
            create2dButton.Text = "create new 2d array";
            create2dButton.UseVisualStyleBackColor = true;
            create2dButton.Click += Create2dClick;
            // 
            // deleteColumnsButton
            // 
            deleteColumnsButton.Location = new Point(23, 170);
            deleteColumnsButton.Name = "deleteColumnsButton";
            deleteColumnsButton.Size = new Size(351, 58);
            deleteColumnsButton.TabIndex = 2;
            deleteColumnsButton.Text = "delete chosen columns";
            deleteColumnsButton.UseVisualStyleBackColor = true;
            deleteColumnsButton.Click += DeleteColumnsClick;
            // 
            // ShowArr2dButton
            // 
            ShowArr2dButton.Location = new Point(23, 12);
            ShowArr2dButton.Name = "ShowArr2dButton";
            ShowArr2dButton.Size = new Size(351, 58);
            ShowArr2dButton.TabIndex = 3;
            ShowArr2dButton.Text = "show 2d array";
            ShowArr2dButton.UseVisualStyleBackColor = true;
            ShowArr2dButton.Click += ShowArr2dButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(583, 12);
            button1.Name = "button1";
            button1.Size = new Size(359, 58);
            button1.TabIndex = 4;
            button1.Text = "show jagged array";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(583, 89);
            button2.Name = "button2";
            button2.Size = new Size(364, 58);
            button2.TabIndex = 5;
            button2.Text = "create new jagged array";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // addFirstButton
            // 
            addFirstButton.Location = new Point(583, 170);
            addFirstButton.Name = "addFirstButton";
            addFirstButton.Size = new Size(345, 58);
            addFirstButton.TabIndex = 6;
            addFirstButton.Text = "add string at start";
            addFirstButton.UseVisualStyleBackColor = true;
            addFirstButton.Click += addFirstButton_Click;
            // 
            // inputString
            // 
            inputString.Location = new Point(300, 453);
            inputString.Name = "inputString";
            inputString.Size = new Size(345, 58);
            inputString.TabIndex = 7;
            inputString.Text = "input string";
            inputString.UseVisualStyleBackColor = true;
            inputString.Click += inputString_Click;
            // 
            // showString
            // 
            showString.Location = new Point(300, 293);
            showString.Name = "showString";
            showString.Size = new Size(345, 58);
            showString.TabIndex = 8;
            showString.Text = "show input string";
            showString.UseVisualStyleBackColor = true;
            showString.Click += showString_Click;
            // 
            // processedString
            // 
            processedString.Location = new Point(300, 376);
            processedString.Name = "processedString";
            processedString.Size = new Size(345, 58);
            processedString.TabIndex = 9;
            processedString.Text = "show processed string";
            processedString.UseVisualStyleBackColor = true;
            processedString.Click += processedString_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 565);
            Controls.Add(processedString);
            Controls.Add(showString);
            Controls.Add(inputString);
            Controls.Add(addFirstButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ShowArr2dButton);
            Controls.Add(deleteColumnsButton);
            Controls.Add(create2dButton);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Главное меню";
            ResumeLayout(false);
        }

        #endregion

        private Button create2dButton;
        private Button deleteColumnsButton;
        private Button ShowArr2dButton;
        private Button button1;
        private Button button2;
        private Button addFirstButton;
        private Button inputString;
        private Button showString;
        private Button processedString;
    }
}
