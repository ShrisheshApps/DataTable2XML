﻿namespace DataTable2XML
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
            this.GetDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetDataButton
            // 
            this.GetDataButton.BackColor = System.Drawing.Color.Olive;
            this.GetDataButton.Location = new System.Drawing.Point(346, 192);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(99, 33);
            this.GetDataButton.TabIndex = 0;
            this.GetDataButton.Text = "Get Data";
            this.GetDataButton.UseVisualStyleBackColor = false;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(469, 249);
            this.Controls.Add(this.GetDataButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetDataButton;
    }
}

