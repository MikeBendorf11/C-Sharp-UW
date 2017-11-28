using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VendingMachineGui
{
    partial class FormNotesChild
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
            this.textBoxChild = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxChild
            // 
            this.textBoxChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxChild.Location = new System.Drawing.Point(-3, -2);
            this.textBoxChild.Multiline = true;
            this.textBoxChild.Name = "textBoxChild";
            this.textBoxChild.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChild.Size = new System.Drawing.Size(218, 160);
            this.textBoxChild.TabIndex = 0;
            // 
            // FormNotesChild
            // 
            this.ClientSize = new System.Drawing.Size(213, 155);
            this.Controls.Add(this.textBoxChild);
            this.Name = "FormNotesChild";
            this.Text = "New Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxChild;
        
        public String Notes
        {
            set { this.textBoxChild.Text = value; }
            get { return textBoxChild.Text; }
        }
    }
}
