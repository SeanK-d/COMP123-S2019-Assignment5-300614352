﻿namespace COMP123_S2019_Assignment5_300614352.Views
{
    partial class StartForm
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
            this.StartFormPictureBox = new System.Windows.Forms.PictureBox();
            this.StartNewOrderButton = new System.Windows.Forms.Button();
            this.OpenSavedOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartFormTitleLabel = new System.Windows.Forms.Label();
            this.StartFormOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartFormPictureBox
            // 
            this.StartFormPictureBox.Location = new System.Drawing.Point(245, 87);
            this.StartFormPictureBox.Name = "StartFormPictureBox";
            this.StartFormPictureBox.Size = new System.Drawing.Size(311, 207);
            this.StartFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.StartFormPictureBox.TabIndex = 3;
            this.StartFormPictureBox.TabStop = false;
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartNewOrderButton.BackColor = System.Drawing.Color.LightGray;
            this.StartNewOrderButton.Location = new System.Drawing.Point(3, 11);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(305, 35);
            this.StartNewOrderButton.TabIndex = 0;
            this.StartNewOrderButton.Text = "Start New Order";
            this.StartNewOrderButton.UseVisualStyleBackColor = false;
            this.StartNewOrderButton.Click += new System.EventHandler(this.StartNewOrderButton_Click);
            // 
            // OpenSavedOrderButton
            // 
            this.OpenSavedOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenSavedOrderButton.BackColor = System.Drawing.Color.LightGray;
            this.OpenSavedOrderButton.Location = new System.Drawing.Point(3, 88);
            this.OpenSavedOrderButton.Name = "OpenSavedOrderButton";
            this.OpenSavedOrderButton.Size = new System.Drawing.Size(305, 35);
            this.OpenSavedOrderButton.TabIndex = 1;
            this.OpenSavedOrderButton.Text = "Open Saved Order";
            this.OpenSavedOrderButton.UseVisualStyleBackColor = false;
            this.OpenSavedOrderButton.Click += new System.EventHandler(this.OpenSavedOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.LightGray;
            this.ExitButton.Location = new System.Drawing.Point(3, 163);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(305, 35);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StartNewOrderButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.OpenSavedOrderButton);
            this.panel1.Location = new System.Drawing.Point(245, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 201);
            this.panel1.TabIndex = 4;
            // 
            // StartFormTitleLabel
            // 
            this.StartFormTitleLabel.AutoSize = true;
            this.StartFormTitleLabel.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartFormTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.StartFormTitleLabel.Location = new System.Drawing.Point(128, 19);
            this.StartFormTitleLabel.Name = "StartFormTitleLabel";
            this.StartFormTitleLabel.Size = new System.Drawing.Size(724, 48);
            this.StartFormTitleLabel.TabIndex = 5;
            this.StartFormTitleLabel.Text = "Get Your Newest Gears at Dollar Computers!";
            this.StartFormTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartFormOpenFileDialog
            // 
            this.StartFormOpenFileDialog.FileName = "openFileDialog1";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.ControlBox = false;
            this.Controls.Add(this.StartFormTitleLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StartFormPictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox StartFormPictureBox;
        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Button OpenSavedOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label StartFormTitleLabel;
        private System.Windows.Forms.OpenFileDialog StartFormOpenFileDialog;
    }
}