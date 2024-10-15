namespace Tutorail3_1
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
            label4 = new Label();
            txtDayOfWeek = new TextBox();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            txtYear = new TextBox();
            lblShow = new Label();
            btnShowDate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(73, 48);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 0;
            label1.Text = "星期幾";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(73, 120);
            label2.Name = "label2";
            label2.Size = new Size(82, 41);
            label2.TabIndex = 1;
            label2.Text = "日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(73, 194);
            label3.Name = "label3";
            label3.Size = new Size(82, 41);
            label3.TabIndex = 2;
            label3.Text = "月份";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 24F);
            label4.Location = new Point(73, 262);
            label4.Name = "label4";
            label4.Size = new Size(82, 41);
            label4.TabIndex = 3;
            label4.Text = "年份";
            // 
            // txtDayOfWeek
            // 
            txtDayOfWeek.Font = new Font("Microsoft JhengHei UI", 24F);
            txtDayOfWeek.Location = new Point(241, 41);
            txtDayOfWeek.Name = "txtDayOfWeek";
            txtDayOfWeek.Size = new Size(423, 48);
            txtDayOfWeek.TabIndex = 4;
            // 
            // txtDay
            // 
            txtDay.Font = new Font("Microsoft JhengHei UI", 24F);
            txtDay.Location = new Point(241, 113);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(423, 48);
            txtDay.TabIndex = 5;
            // 
            // txtMonth
            // 
            txtMonth.Font = new Font("Microsoft JhengHei UI", 24F);
            txtMonth.Location = new Point(241, 187);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(423, 48);
            txtMonth.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Microsoft JhengHei UI", 24F);
            txtYear.Location = new Point(241, 259);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(423, 48);
            txtYear.TabIndex = 7;
            // 
            // lblShow
            // 
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.Location = new Point(110, 342);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(529, 63);
            lblShow.TabIndex = 8;
            // 
            // btnShowDate
            // 
            btnShowDate.Location = new Point(110, 423);
            btnShowDate.Name = "btnShowDate";
            btnShowDate.Size = new Size(145, 61);
            btnShowDate.TabIndex = 9;
            btnShowDate.Text = "顯示完整日期";
            btnShowDate.UseVisualStyleBackColor = true;
            btnShowDate.Click += btnShowDate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(317, 423);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 61);
            btnClear.TabIndex = 10;
            btnClear.Text = "清除內容";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(508, 423);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(145, 61);
            btnExit.TabIndex = 11;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnShowDate);
            Controls.Add(lblShow);
            Controls.Add(txtYear);
            Controls.Add(txtMonth);
            Controls.Add(txtDay);
            Controls.Add(txtDayOfWeek);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDayOfWeek;
        private TextBox txtDay;
        private TextBox txtMonth;
        private TextBox txtYear;
        private Label lblShow;
        private Button btnShowDate;
        private Button btnClear;
        private Button btnExit;
    }
}
