namespace Tutorial2_5
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
            ptxback = new PictureBox();
            ptxfront = new PictureBox();
            btnShowback = new Button();
            btnShowfront = new Button();
            btnexit = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).BeginInit();
            SuspendLayout();
            // 
            // ptxback
            // 
            ptxback.Image = Properties.Resources.Backface_Blue1;
            ptxback.Location = new Point(51, 38);
            ptxback.Name = "ptxback";
            ptxback.Size = new Size(158, 219);
            ptxback.SizeMode = PictureBoxSizeMode.Zoom;
            ptxback.TabIndex = 0;
            ptxback.TabStop = false;
            ptxback.Visible = false;
            // 
            // ptxfront
            // 
            ptxfront.Image = Properties.Resources.Ace_Spades;
            ptxfront.Location = new Point(253, 38);
            ptxfront.Name = "ptxfront";
            ptxfront.Size = new Size(158, 219);
            ptxfront.SizeMode = PictureBoxSizeMode.Zoom;
            ptxfront.TabIndex = 1;
            ptxfront.TabStop = false;
            ptxfront.Visible = false;
            // 
            // btnShowback
            // 
            btnShowback.Location = new Point(61, 294);
            btnShowback.Name = "btnShowback";
            btnShowback.Size = new Size(139, 66);
            btnShowback.TabIndex = 2;
            btnShowback.Text = "背面";
            btnShowback.UseVisualStyleBackColor = true;
            btnShowback.Click += btnShowback_Click;
            // 
            // btnShowfront
            // 
            btnShowfront.Location = new Point(263, 294);
            btnShowfront.Name = "btnShowfront";
            btnShowfront.Size = new Size(139, 66);
            btnShowfront.TabIndex = 3;
            btnShowfront.Text = "正面";
            btnShowfront.UseVisualStyleBackColor = true;
            btnShowfront.Click += btnShowfront_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(51, 394);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(351, 56);
            btnexit.TabIndex = 4;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 481);
            Controls.Add(btnexit);
            Controls.Add(btnShowfront);
            Controls.Add(btnShowback);
            Controls.Add(ptxfront);
            Controls.Add(ptxback);
            Font = new Font("Microsoft JhengHei UI", 16F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxback).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxback;
        private PictureBox ptxfront;
        private Button btnShowback;
        private Button btnShowfront;
        private Button btnexit;
    }
}
