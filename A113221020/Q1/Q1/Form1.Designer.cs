namespace Q1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LEtxtBox = new TextBox();
            WItxtBox = new TextBox();
            UNITtxtBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label4 = new Label();
            lblShow = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 67);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Length of the Field:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 129);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Width of the Field:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 187);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 2;
            label3.Text = "Unit Cost of Fencing:";
            // 
            // LEtxtBox
            // 
            LEtxtBox.Location = new Point(263, 64);
            LEtxtBox.Name = "LEtxtBox";
            LEtxtBox.Size = new Size(164, 23);
            LEtxtBox.TabIndex = 3;
            // 
            // WItxtBox
            // 
            WItxtBox.Location = new Point(263, 126);
            WItxtBox.Name = "WItxtBox";
            WItxtBox.Size = new Size(164, 23);
            WItxtBox.TabIndex = 4;
            // 
            // UNITtxtBox
            // 
            UNITtxtBox.Location = new Point(263, 184);
            UNITtxtBox.Name = "UNITtxtBox";
            UNITtxtBox.Size = new Size(164, 23);
            UNITtxtBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(45, 314);
            button1.Name = "button1";
            button1.Size = new Size(97, 52);
            button1.TabIndex = 6;
            button1.Text = "Area";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(172, 314);
            button2.Name = "button2";
            button2.Size = new Size(97, 52);
            button2.TabIndex = 7;
            button2.Text = "Boundary";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(299, 314);
            button3.Name = "button3";
            button3.Size = new Size(97, 52);
            button3.TabIndex = 8;
            button3.Text = "Cost";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(415, 314);
            button4.Name = "button4";
            button4.Size = new Size(97, 52);
            button4.TabIndex = 9;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(144, 248);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 10;
            // 
            // lblShow
            // 
            lblShow.Font = new Font("Microsoft JhengHei UI", 20F);
            lblShow.Location = new Point(88, 247);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(331, 36);
            lblShow.TabIndex = 11;
            lblShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 434);
            Controls.Add(lblShow);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(UNITtxtBox);
            Controls.Add(WItxtBox);
            Controls.Add(LEtxtBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cost of Fencing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox LEtxtBox;
        private TextBox WItxtBox;
        private TextBox UNITtxtBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label4;
        private Label lblShow;
    }
}
