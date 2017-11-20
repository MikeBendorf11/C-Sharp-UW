using VendingConsoleLibrary;
using System.Windows.Forms;

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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nickel",
            "1",
            "$0.05",
            "$0.05"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Dime",
            "2",
            "$0.10",
            "$0.20"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Quarter",
            "3",
            "$0.25",
            "$0.75"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "HalfDollar",
            "0",
            "$0.50",
            "$0.00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Regular",
            "03"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Orange",
            "03"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Lemon",
            "03"}, -1);
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
            this.tabVend = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabService = new System.Windows.Forms.TabPage();
            this.groupBoxCoinInfo = new System.Windows.Forms.GroupBox();
            this.listViewCoins = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonEmptyCoins = new System.Windows.Forms.Button();
            this.groupBoxCansInfo = new System.Windows.Forms.GroupBox();
            this.listViewCans = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonRefillCans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lmnImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regImgBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.DenomGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabVend.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabService.SuspendLayout();
            this.groupBoxCoinInfo.SuspendLayout();
            this.groupBoxCansInfo.SuspendLayout();
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
            this.Title.Location = new System.Drawing.Point(43, 7);
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
            this.lmnImgBox.Location = new System.Drawing.Point(234, 53);
            this.lmnImgBox.Name = "lmnImgBox";
            this.lmnImgBox.Size = new System.Drawing.Size(46, 68);
            this.lmnImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lmnImgBox.TabIndex = 5;
            this.lmnImgBox.TabStop = false;
            // 
            // orgImgBox
            // 
            this.orgImgBox.Image = global::VendingMachineGui.Properties.Resources.orange;
            this.orgImgBox.Location = new System.Drawing.Point(130, 53);
            this.orgImgBox.Name = "orgImgBox";
            this.orgImgBox.Size = new System.Drawing.Size(46, 68);
            this.orgImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orgImgBox.TabIndex = 4;
            this.orgImgBox.TabStop = false;
            // 
            // regImgBox
            // 
            this.regImgBox.Image = global::VendingMachineGui.Properties.Resources.regular;
            this.regImgBox.Location = new System.Drawing.Point(26, 54);
            this.regImgBox.Name = "regImgBox";
            this.regImgBox.Size = new System.Drawing.Size(46, 68);
            this.regImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.regImgBox.TabIndex = 3;
            this.regImgBox.TabStop = false;
            // 
            // ejectReg
            // 
            this.ejectReg.Enabled = false;
            this.ejectReg.Location = new System.Drawing.Point(13, 128);
            this.ejectReg.Name = "ejectReg";
            this.ejectReg.Size = new System.Drawing.Size(75, 23);
            this.ejectReg.TabIndex = 6;
            this.ejectReg.Text = "Eject";
            this.ejectReg.UseVisualStyleBackColor = true;
            this.ejectReg.Click += new System.EventHandler(this.ejectCans_Click);
            // 
            // ejectOrg
            // 
            this.ejectOrg.Enabled = false;
            this.ejectOrg.Location = new System.Drawing.Point(115, 127);
            this.ejectOrg.Name = "ejectOrg";
            this.ejectOrg.Size = new System.Drawing.Size(75, 23);
            this.ejectOrg.TabIndex = 7;
            this.ejectOrg.Text = "Eject";
            this.ejectOrg.UseVisualStyleBackColor = true;
            this.ejectOrg.Click += new System.EventHandler(this.ejectCans_Click);
            // 
            // ejectLmn
            // 
            this.ejectLmn.Enabled = false;
            this.ejectLmn.Location = new System.Drawing.Point(217, 126);
            this.ejectLmn.Name = "ejectLmn";
            this.ejectLmn.Size = new System.Drawing.Size(75, 23);
            this.ejectLmn.TabIndex = 8;
            this.ejectLmn.Text = "Eject";
            this.ejectLmn.UseVisualStyleBackColor = true;
            this.ejectLmn.Click += new System.EventHandler(this.ejectCans_Click);
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
            this.panel1.Location = new System.Drawing.Point(8, 6);
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
            this.DenomGroupBox.Location = new System.Drawing.Point(8, 184);
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
            this.InsHalfdollar.Click += new System.EventHandler(this.CoinBttns_Click);
            // 
            // InsQuarter
            // 
            this.InsQuarter.Location = new System.Drawing.Point(163, 20);
            this.InsQuarter.Name = "InsQuarter";
            this.InsQuarter.Size = new System.Drawing.Size(60, 23);
            this.InsQuarter.TabIndex = 2;
            this.InsQuarter.Text = "Quarter";
            this.InsQuarter.UseVisualStyleBackColor = true;
            this.InsQuarter.Click += new System.EventHandler(this.CoinBttns_Click);
            // 
            // InsDime
            // 
            this.InsDime.Location = new System.Drawing.Point(87, 20);
            this.InsDime.Name = "InsDime";
            this.InsDime.Size = new System.Drawing.Size(60, 23);
            this.InsDime.TabIndex = 1;
            this.InsDime.Text = "Dime";
            this.InsDime.UseVisualStyleBackColor = true;
            this.InsDime.Click += new System.EventHandler(this.CoinBttns_Click);
            // 
            // InsNickel
            // 
            this.InsNickel.Location = new System.Drawing.Point(11, 20);
            this.InsNickel.Name = "InsNickel";
            this.InsNickel.Size = new System.Drawing.Size(60, 23);
            this.InsNickel.TabIndex = 0;
            this.InsNickel.Text = "Nickel";
            this.InsNickel.UseVisualStyleBackColor = true;
            this.InsNickel.Click += new System.EventHandler(this.CoinBttns_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.returnBttn);
            this.panel2.Controls.Add(this.PriceLabel);
            this.panel2.Controls.Add(this.InsertLabel);
            this.panel2.Location = new System.Drawing.Point(35, 254);
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
            // tabVend
            // 
            this.tabVend.Controls.Add(this.tabPage1);
            this.tabVend.Controls.Add(this.tabService);
            this.tabVend.Location = new System.Drawing.Point(0, 1);
            this.tabVend.Name = "tabVend";
            this.tabVend.SelectedIndex = 0;
            this.tabVend.Size = new System.Drawing.Size(336, 346);
            this.tabVend.TabIndex = 12;
            this.tabVend.Click += new System.EventHandler(this.VendTabEvents);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.DenomGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(328, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vend";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.groupBoxCoinInfo);
            this.tabService.Controls.Add(this.groupBoxCansInfo);
            this.tabService.Location = new System.Drawing.Point(4, 22);
            this.tabService.Name = "tabService";
            this.tabService.Padding = new System.Windows.Forms.Padding(3);
            this.tabService.Size = new System.Drawing.Size(328, 320);
            this.tabService.TabIndex = 1;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // groupBoxCoinInfo
            // 
            this.groupBoxCoinInfo.BackColor = System.Drawing.Color.DarkGray;
            this.groupBoxCoinInfo.Controls.Add(this.listViewCoins);
            this.groupBoxCoinInfo.Controls.Add(this.ButtonEmptyCoins);
            this.groupBoxCoinInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCoinInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxCoinInfo.Location = new System.Drawing.Point(32, 134);
            this.groupBoxCoinInfo.Name = "groupBoxCoinInfo";
            this.groupBoxCoinInfo.Size = new System.Drawing.Size(252, 165);
            this.groupBoxCoinInfo.TabIndex = 1;
            this.groupBoxCoinInfo.TabStop = false;
            this.groupBoxCoinInfo.Text = "Coins Info";
            // 
            // listViewCoins
            // 
            this.listViewCoins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCoins.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listViewCoins.Location = new System.Drawing.Point(16, 21);
            this.listViewCoins.Name = "listViewCoins";
            this.listViewCoins.Size = new System.Drawing.Size(222, 109);
            this.listViewCoins.TabIndex = 2;
            this.listViewCoins.UseCompatibleStateImageBehavior = false;
            this.listViewCoins.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 61;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Count";
            this.columnHeader4.Width = 44;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Value";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total";
            // 
            // ButtonEmptyCoins
            // 
            this.ButtonEmptyCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEmptyCoins.Location = new System.Drawing.Point(87, 136);
            this.ButtonEmptyCoins.Name = "ButtonEmptyCoins";
            this.ButtonEmptyCoins.Size = new System.Drawing.Size(75, 23);
            this.ButtonEmptyCoins.TabIndex = 1;
            this.ButtonEmptyCoins.Text = "Empty Box";
            this.ButtonEmptyCoins.UseVisualStyleBackColor = true;
            this.ButtonEmptyCoins.Click += new System.EventHandler(VendTabEvents);
            // 
            // groupBoxCansInfo
            // 
            this.groupBoxCansInfo.BackColor = System.Drawing.Color.DarkGray;
            this.groupBoxCansInfo.Controls.Add(this.listViewCans);
            this.groupBoxCansInfo.Controls.Add(this.ButtonRefillCans);
            this.groupBoxCansInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCansInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxCansInfo.Location = new System.Drawing.Point(32, 15);
            this.groupBoxCansInfo.Name = "groupBoxCansInfo";
            this.groupBoxCansInfo.Size = new System.Drawing.Size(252, 113);
            this.groupBoxCansInfo.TabIndex = 0;
            this.groupBoxCansInfo.TabStop = false;
            this.groupBoxCansInfo.Text = "Cans Info";
            // 
            // listViewCans
            // 
            this.listViewCans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewCans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCans.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.listViewCans.Location = new System.Drawing.Point(20, 19);
            this.listViewCans.Name = "listViewCans";
            this.listViewCans.Size = new System.Drawing.Size(129, 85);
            this.listViewCans.TabIndex = 2;
            this.listViewCans.UseCompatibleStateImageBehavior = false;
            this.listViewCans.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Flavor";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            // 
            // ButtonRefillCans
            // 
            this.ButtonRefillCans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRefillCans.Location = new System.Drawing.Point(164, 56);
            this.ButtonRefillCans.Name = "ButtonRefillCans";
            this.ButtonRefillCans.Size = new System.Drawing.Size(75, 23);
            this.ButtonRefillCans.TabIndex = 1;
            this.ButtonRefillCans.Text = "Refill Rack";
            this.ButtonRefillCans.UseVisualStyleBackColor = true;
            this.ButtonRefillCans.Click += new System.EventHandler(VendTabEvents);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 346);
            this.Controls.Add(this.tabVend);
            this.MaximumSize = new System.Drawing.Size(351, 384);
            this.MinimumSize = new System.Drawing.Size(351, 384);
            this.Name = "Form1";
            this.Text = "Soda 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.lmnImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regImgBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DenomGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabVend.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabService.ResumeLayout(false);
            this.groupBoxCoinInfo.ResumeLayout(false);
            this.groupBoxCansInfo.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabVend;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.GroupBox groupBoxCoinInfo;
        private System.Windows.Forms.Button ButtonEmptyCoins;
        private System.Windows.Forms.GroupBox groupBoxCansInfo;
        private System.Windows.Forms.Button ButtonRefillCans;
        private System.Windows.Forms.ListView listViewCoins;
        private System.Windows.Forms.ListView listViewCans;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

