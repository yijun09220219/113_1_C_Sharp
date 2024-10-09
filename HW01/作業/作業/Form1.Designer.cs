namespace 作業
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
            pic2 = new PictureBox();
            pic3 = new PictureBox();
            pic4 = new PictureBox();
            pic5 = new PictureBox();
            pic6 = new PictureBox();
            lblTranslation = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic6).BeginInit();
            SuspendLayout();
            // 
            // pic2
            // 
            pic2.Image = Properties.Resources._2_Hearts;
            pic2.Location = new Point(25, 43);
            pic2.Name = "pic2";
            pic2.Size = new Size(127, 175);
            pic2.SizeMode = PictureBoxSizeMode.Zoom;
            pic2.TabIndex = 0;
            pic2.TabStop = false;
            pic2.Click += pic2_Click;
            // 
            // pic3
            // 
            pic3.Image = Properties.Resources._3_Hearts1;
            pic3.Location = new Point(171, 43);
            pic3.Name = "pic3";
            pic3.Size = new Size(127, 175);
            pic3.SizeMode = PictureBoxSizeMode.Zoom;
            pic3.TabIndex = 1;
            pic3.TabStop = false;
            pic3.Click += pic3_Click;
            // 
            // pic4
            // 
            pic4.Image = Properties.Resources._4_Hearts;
            pic4.Location = new Point(322, 43);
            pic4.Name = "pic4";
            pic4.Size = new Size(127, 175);
            pic4.SizeMode = PictureBoxSizeMode.Zoom;
            pic4.TabIndex = 2;
            pic4.TabStop = false;
            pic4.Click += pic4_Click;
            // 
            // pic5
            // 
            pic5.Image = Properties.Resources._5_Hearts;
            pic5.Location = new Point(478, 43);
            pic5.Name = "pic5";
            pic5.Size = new Size(127, 175);
            pic5.SizeMode = PictureBoxSizeMode.Zoom;
            pic5.TabIndex = 3;
            pic5.TabStop = false;
            pic5.Click += pic5_Click;
            // 
            // pic6
            // 
            pic6.Image = Properties.Resources._6_Hearts;
            pic6.Location = new Point(638, 43);
            pic6.Name = "pic6";
            pic6.Size = new Size(127, 175);
            pic6.SizeMode = PictureBoxSizeMode.Zoom;
            pic6.TabIndex = 4;
            pic6.TabStop = false;
            pic6.Click += pic6_Click;
            // 
            // lblTranslation
            // 
            lblTranslation.BorderStyle = BorderStyle.Fixed3D;
            lblTranslation.Font = new Font("Microsoft JhengHei UI", 24F);
            lblTranslation.Location = new Point(171, 263);
            lblTranslation.Name = "lblTranslation";
            lblTranslation.Size = new Size(434, 53);
            lblTranslation.TabIndex = 5;
            lblTranslation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft JhengHei UI", 20F);
            btnExit.Location = new Point(309, 350);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(153, 53);
            btnExit.TabIndex = 6;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(lblTranslation);
            Controls.Add(pic6);
            Controls.Add(pic5);
            Controls.Add(pic4);
            Controls.Add(pic3);
            Controls.Add(pic2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic2;
        private PictureBox pic3;
        private PictureBox pic4;
        private PictureBox pic5;
        private PictureBox pic6;
        private Label lblTranslation;
        private Button btnExit;
    }
}
