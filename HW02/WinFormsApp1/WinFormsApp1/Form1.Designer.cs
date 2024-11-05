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
            groupBox1 = new GroupBox();
            ClassCtextBox = new TextBox();
            ClassBtextBox = new TextBox();
            ClassAtextBox = new TextBox();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            Totallbl = new Label();
            ClassClbl = new Label();
            ClassBlbl = new Label();
            ClassAlbl = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ClassCtextBox);
            groupBox1.Controls.Add(ClassBtextBox);
            groupBox1.Controls.Add(ClassAtextBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(57, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 235);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tickets Sold";
            // 
            // ClassCtextBox
            // 
            ClassCtextBox.Location = new Point(100, 182);
            ClassCtextBox.Name = "ClassCtextBox";
            ClassCtextBox.Size = new Size(152, 23);
            ClassCtextBox.TabIndex = 6;
            // 
            // ClassBtextBox
            // 
            ClassBtextBox.Location = new Point(100, 137);
            ClassBtextBox.Name = "ClassBtextBox";
            ClassBtextBox.Size = new Size(152, 23);
            ClassBtextBox.TabIndex = 5;
            // 
            // ClassAtextBox
            // 
            ClassAtextBox.Location = new Point(100, 91);
            ClassAtextBox.Name = "ClassAtextBox";
            ClassAtextBox.Size = new Size(152, 23);
            ClassAtextBox.TabIndex = 4;
            // 
            // label8
            // 
            label8.Location = new Point(29, 31);
            label8.Name = "label8";
            label8.Size = new Size(257, 30);
            label8.TabIndex = 3;
            label8.Text = "Enter the number of tickets sold for each class seats.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 185);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Class C:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 140);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Class B:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 94);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Class A:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Totallbl);
            groupBox2.Controls.Add(ClassClbl);
            groupBox2.Controls.Add(ClassBlbl);
            groupBox2.Controls.Add(ClassAlbl);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(410, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(292, 235);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Revenue Generated";
            // 
            // Totallbl
            // 
            Totallbl.BorderStyle = BorderStyle.Fixed3D;
            Totallbl.Location = new Point(86, 184);
            Totallbl.Name = "Totallbl";
            Totallbl.Size = new Size(187, 23);
            Totallbl.TabIndex = 8;
            // 
            // ClassClbl
            // 
            ClassClbl.BorderStyle = BorderStyle.Fixed3D;
            ClassClbl.Location = new Point(86, 139);
            ClassClbl.Name = "ClassClbl";
            ClassClbl.Size = new Size(187, 23);
            ClassClbl.TabIndex = 7;
            // 
            // ClassBlbl
            // 
            ClassBlbl.BorderStyle = BorderStyle.Fixed3D;
            ClassBlbl.Location = new Point(86, 93);
            ClassBlbl.Name = "ClassBlbl";
            ClassBlbl.Size = new Size(187, 23);
            ClassBlbl.TabIndex = 6;
            // 
            // ClassAlbl
            // 
            ClassAlbl.BorderStyle = BorderStyle.Fixed3D;
            ClassAlbl.Location = new Point(86, 46);
            ClassAlbl.Name = "ClassAlbl";
            ClassAlbl.Size = new Size(187, 23);
            ClassAlbl.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 140);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 3;
            label6.Text = "Class C:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 185);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 4;
            label7.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 46);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Class A:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 94);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "Class B:";
            // 
            // button1
            // 
            button1.Location = new Point(100, 319);
            button1.Name = "button1";
            button1.Size = new Size(120, 78);
            button1.TabIndex = 2;
            button1.Text = "Calculate Revenue";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(319, 319);
            button2.Name = "button2";
            button2.Size = new Size(120, 78);
            button2.TabIndex = 3;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(526, 319);
            button3.Name = "button3";
            button3.Size = new Size(120, 78);
            button3.TabIndex = 4;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Stadium Seating";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label8;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox ClassCtextBox;
        private TextBox ClassBtextBox;
        private TextBox ClassAtextBox;
        private Label Totallbl;
        private Label ClassClbl;
        private Label ClassBlbl;
        private Label ClassAlbl;
    }
}
