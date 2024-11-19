namespace Q2
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
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            totalLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(25, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 426);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Pear;
            pictureBox4.Location = new Point(229, 216);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(191, 192);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Orange;
            pictureBox3.Location = new Point(24, 216);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(191, 192);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Apple;
            pictureBox2.Location = new Point(229, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(191, 192);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Banana;
            pictureBox1.Location = new Point(24, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20F);
            label2.Location = new Point(546, 30);
            label2.Name = "label2";
            label2.Size = new Size(187, 35);
            label2.TabIndex = 1;
            label2.Text = "Total Calories";
            // 
            // totalLabel
            // 
            totalLabel.BorderStyle = BorderStyle.FixedSingle;
            totalLabel.CausesValidation = false;
            totalLabel.Location = new Point(520, 85);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(243, 46);
            totalLabel.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(583, 247);
            button1.Name = "button1";
            button1.Size = new Size(113, 60);
            button1.TabIndex = 3;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(583, 339);
            button2.Name = "button2";
            button2.Size = new Size(113, 60);
            button2.TabIndex = 4;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(totalLabel);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Calorie Counter";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label;
        private Label label2;
        private Label totalLabel;
        private Button button1;
        private Button button2;
    }
}
