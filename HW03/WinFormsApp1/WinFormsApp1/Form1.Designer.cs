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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtbacteria = new TextBox();
            txtdays = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(329, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(422, 365);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(372, 66);
            label1.Name = "label1";
            label1.Size = new Size(122, 19);
            label1.TabIndex = 1;
            label1.Text = "Number of days";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(569, 66);
            label2.Name = "label2";
            label2.Size = new Size(144, 19);
            label2.TabIndex = 2;
            label2.Text = "Number of Bacteria";
            // 
            // txtbacteria
            // 
            txtbacteria.Location = new Point(149, 58);
            txtbacteria.Name = "txtbacteria";
            txtbacteria.Size = new Size(125, 27);
            txtbacteria.TabIndex = 3;
            txtbacteria.TextChanged += txtbacteria_TextChanged;
            // 
            // txtdays
            // 
            txtdays.Location = new Point(149, 155);
            txtdays.Name = "txtdays";
            txtdays.Size = new Size(125, 27);
            txtdays.TabIndex = 4;
            txtdays.TextChanged += txtdays_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 61);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 5;
            label3.Text = "輸入起始數量";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 158);
            label4.Name = "label4";
            label4.Size = new Size(99, 19);
            label4.TabIndex = 6;
            label4.Text = "輸入所需天數";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(72, 248);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(162, 95);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "計算";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtdays);
            Controls.Add(txtbacteria);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private TextBox txtbacteria;
        private TextBox txtdays;
        private Label label3;
        private Label label4;
        private Button btnCalculate;
    }
}
