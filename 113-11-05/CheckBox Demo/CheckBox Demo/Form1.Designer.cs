namespace CheckBox_Demo
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft JhengHei UI", 20F);
            radioButton1.Location = new Point(56, 46);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 39);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "漢堡";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft JhengHei UI", 20F);
            radioButton2.Location = new Point(56, 136);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 39);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "牛排";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft JhengHei UI", 20F);
            radioButton3.Location = new Point(56, 91);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(87, 39);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "炸雞";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Microsoft JhengHei UI", 20F);
            radioButton4.Location = new Point(56, 181);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(87, 39);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "比薩";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Location = new Point(50, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(214, 261);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "主餐";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Location = new Point(291, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(214, 261);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "飲料";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Microsoft JhengHei UI", 20F);
            radioButton5.Location = new Point(53, 66);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(87, 39);
            radioButton5.TabIndex = 5;
            radioButton5.TabStop = true;
            radioButton5.Text = "可樂";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Microsoft JhengHei UI", 20F);
            radioButton6.Location = new Point(53, 111);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(87, 39);
            radioButton6.TabIndex = 6;
            radioButton6.TabStop = true;
            radioButton6.Text = "雪碧";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("Microsoft JhengHei UI", 20F);
            radioButton7.Location = new Point(53, 156);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(114, 39);
            radioButton7.TabIndex = 7;
            radioButton7.TabStop = true;
            radioButton7.Text = "冰咖啡";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
    }
}
