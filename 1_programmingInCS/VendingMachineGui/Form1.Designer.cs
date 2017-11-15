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
            this.PriceLabel = new System.Windows.Forms.Label();
            this.InsertLabel = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.returnBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lmnImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regImgBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.DenomGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.Title.Location = new System.Drawing.Point(43, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(224, 22);
            this.Title.TabIndex = 0;
            this.Title.Text = "SODA VENDING MACHINE";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(24, 10);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(106, 13);
            this.PriceLabel.TabIndex = 1;
            this.PriceLabel.Text = "Please insert:   $0.35";
            // 
            // InsertLabel
            // 
            this.InsertLabel.AutoSize = true;
            this.InsertLabel.Location = new System.Drawing.Point(24, 23);
            this.InsertLabel.Name = "InsertLabel";
            this.InsertLabel.Size = new System.Drawing.Size(107, 13);
            this.InsertLabel.TabIndex = 2;
            this.InsertLabel.Text = "Inserted so far: $0.00";
            // 
            // lmnImgBox
            // 
            this.lmnImgBox.Image = global::VendingMachineGui.Properties.Resources.lemon;
            this.lmnImgBox.Location = new System.Drawing.Point(234, 58);
            this.lmnImgBox.Name = "lmnImgBox";
            this.lmnImgBox.Size = new System.Drawing.Size(46, 68);
            this.lmnImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lmnImgBox.TabIndex = 5;
            this.lmnImgBox.TabStop = false;
            // 
            // orgImgBox
            // 
            this.orgImgBox.Image = global::VendingMachineGui.Properties.Resources.orange;
            this.orgImgBox.Location = new System.Drawing.Point(130, 58);
            this.orgImgBox.Name = "orgImgBox";
            this.orgImgBox.Size = new System.Drawing.Size(46, 68);
            this.orgImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orgImgBox.TabIndex = 4;
            this.orgImgBox.TabStop = false;
            // 
            // regImgBox
            // 
            this.regImgBox.Image = global::VendingMachineGui.Properties.Resources.regular;
            this.regImgBox.Location = new System.Drawing.Point(26, 59);
            this.regImgBox.Name = "regImgBox";
            this.regImgBox.Size = new System.Drawing.Size(46, 68);
            this.regImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.regImgBox.TabIndex = 3;
            this.regImgBox.TabStop = false;
            // 
            // ejectReg
            // 
            this.ejectReg.Enabled = false;
            this.ejectReg.Location = new System.Drawing.Point(13, 133);
            this.ejectReg.Name = "ejectReg";
            this.ejectReg.Size = new System.Drawing.Size(75, 23);
            this.ejectReg.TabIndex = 6;
            this.ejectReg.Text = "Eject";
            this.ejectReg.UseVisualStyleBackColor = true;
            this.ejectReg.Click += new System.EventHandler(this.ejectReg_Click);
            // 
            // ejectOrg
            // 
            this.ejectOrg.Enabled = false;
            this.ejectOrg.Location = new System.Drawing.Point(115, 132);
            this.ejectOrg.Name = "ejectOrg";
            this.ejectOrg.Size = new System.Drawing.Size(75, 23);
            this.ejectOrg.TabIndex = 7;
            this.ejectOrg.Text = "Eject";
            this.ejectOrg.UseVisualStyleBackColor = true;
            this.ejectOrg.Click += new System.EventHandler(this.ejectOrg_Click);
            // 
            // ejectLmn
            // 
            this.ejectLmn.Enabled = false;
            this.ejectLmn.Location = new System.Drawing.Point(217, 131);
            this.ejectLmn.Name = "ejectLmn";
            this.ejectLmn.Size = new System.Drawing.Size(75, 23);
            this.ejectLmn.TabIndex = 8;
            this.ejectLmn.Text = "Eject";
            this.ejectLmn.UseVisualStyleBackColor = true;
            this.ejectLmn.Click += new System.EventHandler(this.ejectLmn_Click);
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
            this.panel1.Location = new System.Drawing.Point(11, 12);
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
            this.DenomGroupBox.Location = new System.Drawing.Point(12, 192);
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
            this.InsHalfdollar.Click += new System.EventHandler(this.InsHalfdollar_Click);
            // 
            // InsQuarter
            // 
            this.InsQuarter.Location = new System.Drawing.Point(163, 20);
            this.InsQuarter.Name = "InsQuarter";
            this.InsQuarter.Size = new System.Drawing.Size(60, 23);
            this.InsQuarter.TabIndex = 2;
            this.InsQuarter.Text = "Quarter";
            this.InsQuarter.UseVisualStyleBackColor = true;
            this.InsQuarter.Click += new System.EventHandler(this.InsQuarter_Click);
            // 
            // InsDime
            // 
            this.InsDime.Location = new System.Drawing.Point(87, 20);
            this.InsDime.Name = "InsDime";
            this.InsDime.Size = new System.Drawing.Size(60, 23);
            this.InsDime.TabIndex = 1;
            this.InsDime.Text = "Dime";
            this.InsDime.UseVisualStyleBackColor = true;
            this.InsDime.Click += new System.EventHandler(this.InsDime_Click);
            // 
            // InsNickel
            // 
            this.InsNickel.Location = new System.Drawing.Point(11, 20);
            this.InsNickel.Name = "InsNickel";
            this.InsNickel.Size = new System.Drawing.Size(60, 23);
            this.InsNickel.TabIndex = 0;
            this.InsNickel.Text = "Nickel";
            this.InsNickel.UseVisualStyleBackColor = true;
            this.InsNickel.Click += new System.EventHandler(this.InsNickel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.returnBttn);
            this.panel2.Controls.Add(this.PriceLabel);
            this.panel2.Controls.Add(this.InsertLabel);
            this.panel2.Location = new System.Drawing.Point(39, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 48);
            this.panel2.TabIndex = 11;
            // 
            // returnBttn
            // 
            this.returnBttn.Location = new System.Drawing.Point(149, 13);
            this.returnBttn.Name = "returnBttn";
            this.returnBttn.Size = new System.Drawing.Size(75, 23);
            this.returnBttn.TabIndex = 3;
            this.returnBttn.Text = "Return";
            this.returnBttn.UseVisualStyleBackColor = true;
            this.returnBttn.Click += new System.EventHandler(this.returnBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 346);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DenomGroupBox);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(351, 384);
            this.MinimumSize = new System.Drawing.Size(351, 384);
            this.Name = "Form1";
            this.Text = "Soda 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.lmnImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regImgBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DenomGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label InsertLabel;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button returnBttn;
    }
}

