﻿namespace Load_Event
{
    partial class Form1
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
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(15, 12);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(103, 16);
            this.outputDescriptionLabel.TabIndex = 5;
            this.outputDescriptionLabel.Text = "南美洲的國家";
            // 
            // countriesListBox
            // 
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.ItemHeight = 12;
            this.countriesListBox.Location = new System.Drawing.Point(43, 37);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(171, 88);
            this.countriesListBox.TabIndex = 4;
            this.countriesListBox.SelectedIndexChanged += new System.EventHandler(this.countriesListBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(90, 139);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 21);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 174);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.countriesListBox);
            this.Name = "Form1";
            this.Text = "南美洲";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}
