﻿
namespace BecomeADeveloperTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxUsersString = new System.Windows.Forms.RichTextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelLetter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLEASE ENTER A STRING";
            // 
            // richTextBoxUsersString
            // 
            this.richTextBoxUsersString.Location = new System.Drawing.Point(16, 47);
            this.richTextBoxUsersString.Name = "richTextBoxUsersString";
            this.richTextBoxUsersString.Size = new System.Drawing.Size(772, 225);
            this.richTextBoxUsersString.TabIndex = 1;
            this.richTextBoxUsersString.Text = "";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(254, 301);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(313, 68);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Magic!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelLetter
            // 
            this.labelLetter.AutoSize = true;
            this.labelLetter.Location = new System.Drawing.Point(27, 398);
            this.labelLetter.Name = "labelLetter";
            this.labelLetter.Size = new System.Drawing.Size(199, 17);
            this.labelLetter.TabIndex = 3;
            this.labelLetter.Text = "The letter will appear here ^_^";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.labelLetter);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.richTextBoxUsersString);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxUsersString;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelLetter;
    }
}

