namespace VendingMachineGui
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
            this.Title = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelInsert = new System.Windows.Forms.Label();
            this.lmnImgBox = new System.Windows.Forms.PictureBox();
            this.orgImgBox = new System.Windows.Forms.PictureBox();
            this.regImgBox = new System.Windows.Forms.PictureBox();
            this.ejectReg = new System.Windows.Forms.Button();
            this.ejectOrg = new System.Windows.Forms.Button();
            this.ejectLmn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DenomGroupBox = new System.Windows.Forms.GroupBox();
            this.InsHalfdollar = new System.Windows.Forms.Button();
            this.InsQuarter = new System.Windows.Forms.Button();
            this.InsDime = new System.Windows.Forms.Button();
            this.InsNickel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lmnImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regImgBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.DenomGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(48, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(224, 22);
            this.Title.TabIndex = 0;
            this.Title.Text = "SODA VENDING MACHINE";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(66, 268);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(73, 13);
            this.LabelPrice.TabIndex = 1;
            this.LabelPrice.Text = "Please insert: ";
            // 
            // LabelInsert
            // 
            this.LabelInsert.AutoSize = true;
            this.LabelInsert.Location = new System.Drawing.Point(66, 292);
            this.LabelInsert.Name = "LabelInsert";
            this.LabelInsert.Size = new System.Drawing.Size(77, 13);
            this.LabelInsert.TabIndex = 2;
            this.LabelInsert.Text = "Inserted so far:";
            // 
            // lmnImgBox
            // 
            this.lmnImgBox.Image = global::VendingMachineGui.Properties.Resources.lemon;
            this.lmnImgBox.Location = new System.Drawing.Point(234, 47);
            this.lmnImgBox.Name = "lmnImgBox";
            this.lmnImgBox.Size = new System.Drawing.Size(46, 68);
            this.lmnImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lmnImgBox.TabIndex = 5;
            this.lmnImgBox.TabStop = false;
            // 
            // orgImgBox
            // 
            this.orgImgBox.Image = global::VendingMachineGui.Properties.Resources.orange;
            this.orgImgBox.Location = new System.Drawing.Point(130, 47);
            this.orgImgBox.Name = "orgImgBox";
            this.orgImgBox.Size = new System.Drawing.Size(46, 68);
            this.orgImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orgImgBox.TabIndex = 4;
            this.orgImgBox.TabStop = false;
            // 
            // regImgBox
            // 
            this.regImgBox.Image = global::VendingMachineGui.Properties.Resources.regular;
            this.regImgBox.Location = new System.Drawing.Point(26, 48);
            this.regImgBox.Name = "regImgBox";
            this.regImgBox.Size = new System.Drawing.Size(46, 68);
            this.regImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.regImgBox.TabIndex = 3;
            this.regImgBox.TabStop = false;
            // 
            // ejectReg
            // 
            this.ejectReg.Enabled = false;
            this.ejectReg.Location = new System.Drawing.Point(13, 122);
            this.ejectReg.Name = "ejectReg";
            this.ejectReg.Size = new System.Drawing.Size(75, 23);
            this.ejectReg.TabIndex = 6;
            this.ejectReg.Text = "Eject";
            this.ejectReg.UseVisualStyleBackColor = true;
            // 
            // ejectOrg
            // 
            this.ejectOrg.Enabled = false;
            this.ejectOrg.Location = new System.Drawing.Point(115, 121);
            this.ejectOrg.Name = "ejectOrg";
            this.ejectOrg.Size = new System.Drawing.Size(75, 23);
            this.ejectOrg.TabIndex = 7;
            this.ejectOrg.Text = "Eject";
            this.ejectOrg.UseVisualStyleBackColor = true;
            // 
            // ejectLmn
            // 
            this.ejectLmn.Enabled = false;
            this.ejectLmn.Location = new System.Drawing.Point(217, 120);
            this.ejectLmn.Name = "ejectLmn";
            this.ejectLmn.Size = new System.Drawing.Size(75, 23);
            this.ejectLmn.TabIndex = 8;
            this.ejectLmn.Text = "Eject";
            this.ejectLmn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.regImgBox);
            this.panel1.Controls.Add(this.ejectLmn);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.ejectOrg);
            this.panel1.Controls.Add(this.orgImgBox);
            this.panel1.Controls.Add(this.ejectReg);
            this.panel1.Controls.Add(this.lmnImgBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 164);
            this.panel1.TabIndex = 9;
            // 
            // DenomGroupBox
            // 
            this.DenomGroupBox.Controls.Add(this.InsHalfdollar);
            this.DenomGroupBox.Controls.Add(this.InsQuarter);
            this.DenomGroupBox.Controls.Add(this.InsDime);
            this.DenomGroupBox.Controls.Add(this.InsNickel);
            this.DenomGroupBox.Location = new System.Drawing.Point(12, 183);
            this.DenomGroupBox.Name = "DenomGroupBox";
            this.DenomGroupBox.Size = new System.Drawing.Size(311, 54);
            this.DenomGroupBox.TabIndex = 10;
            this.DenomGroupBox.TabStop = false;
            this.DenomGroupBox.Text = "Denominations";
            // 
            // InsHalfdollar
            // 
            this.InsHalfdollar.Location = new System.Drawing.Point(239, 20);
            this.InsHalfdollar.Name = "InsHalfdollar";
            this.InsHalfdollar.Size = new System.Drawing.Size(60, 23);
            this.InsHalfdollar.TabIndex = 3;
            this.InsHalfdollar.Text = "Halfdollar";
            this.InsHalfdollar.UseVisualStyleBackColor = true;
            // 
            // InsQuarter
            // 
            this.InsQuarter.Location = new System.Drawing.Point(163, 20);
            this.InsQuarter.Name = "InsQuarter";
            this.InsQuarter.Size = new System.Drawing.Size(60, 23);
            this.InsQuarter.TabIndex = 2;
            this.InsQuarter.Text = "Quarter";
            this.InsQuarter.UseVisualStyleBackColor = true;
            // 
            // InsDime
            // 
            this.InsDime.Location = new System.Drawing.Point(87, 20);
            this.InsDime.Name = "InsDime";
            this.InsDime.Size = new System.Drawing.Size(60, 23);
            this.InsDime.TabIndex = 1;
            this.InsDime.Text = "Dime";
            this.InsDime.UseVisualStyleBackColor = true;
            // 
            // InsNickel
            // 
            this.InsNickel.Location = new System.Drawing.Point(11, 20);
            this.InsNickel.Name = "InsNickel";
            this.InsNickel.Size = new System.Drawing.Size(60, 23);
            this.InsNickel.TabIndex = 0;
            this.InsNickel.Text = "Nickel";
            this.InsNickel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 346);
            this.Controls.Add(this.DenomGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelInsert);
            this.Controls.Add(this.LabelPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lmnImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regImgBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DenomGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelInsert;
        private System.Windows.Forms.PictureBox regImgBox;
        private System.Windows.Forms.PictureBox orgImgBox;
        private System.Windows.Forms.PictureBox lmnImgBox;
        private System.Windows.Forms.Button ejectReg;
        private System.Windows.Forms.Button ejectOrg;
        private System.Windows.Forms.Button ejectLmn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox DenomGroupBox;
        private System.Windows.Forms.Button InsHalfdollar;
        private System.Windows.Forms.Button InsQuarter;
        private System.Windows.Forms.Button InsDime;
        private System.Windows.Forms.Button InsNickel;
    }
}

