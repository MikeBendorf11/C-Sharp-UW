namespace VendingMachineGui
{
    partial class FormNotesParent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptionsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptionsFileNewNote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptionsFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptionsFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOptionsFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptionsFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptionsFindFilenames = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptionsFile,
            this.tsmiOptionsFind});
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(61, 20);
            this.tsmiOptions.Text = "&Options";
            // 
            // tsmiOptionsFile
            // 
            this.tsmiOptionsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptionsFileNewNote,
            this.tsmiOptionsFileOpen,
            this.tsmiOptionsFileSave,
            this.exitToolStripMenuItem,
            this.tsmiOptionsFileExit});
            this.tsmiOptionsFile.Name = "tsmiOptionsFile";
            this.tsmiOptionsFile.Size = new System.Drawing.Size(152, 22);
            this.tsmiOptionsFile.Text = "&File";
            // 
            // tsmiOptionsFileNewNote
            // 
            this.tsmiOptionsFileNewNote.Name = "tsmiOptionsFileNewNote";
            this.tsmiOptionsFileNewNote.ShortcutKeyDisplayString = " ";
            this.tsmiOptionsFileNewNote.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiOptionsFileNewNote.Size = new System.Drawing.Size(152, 22);
            this.tsmiOptionsFileNewNote.Text = "&New Note";
            this.tsmiOptionsFileNewNote.Click += new System.EventHandler(this.tsmiOptionsFileNewNote_Click);
            // 
            // tsmiOptionsFileOpen
            // 
            this.tsmiOptionsFileOpen.Name = "tsmiOptionsFileOpen";
            this.tsmiOptionsFileOpen.ShortcutKeyDisplayString = " ";
            this.tsmiOptionsFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOptionsFileOpen.Size = new System.Drawing.Size(152, 22);
            this.tsmiOptionsFileOpen.Text = "&Open";
            this.tsmiOptionsFileOpen.Click += new System.EventHandler(this.tsmiOptionsFileOpen_Click);
            // 
            // tsmiOptionsFileSave
            // 
            this.tsmiOptionsFileSave.Enabled = false;
            this.tsmiOptionsFileSave.Name = "tsmiOptionsFileSave";
            this.tsmiOptionsFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiOptionsFileSave.Size = new System.Drawing.Size(152, 22);
            this.tsmiOptionsFileSave.Text = "&Save";
            this.tsmiOptionsFileSave.Click += new System.EventHandler(this.tsmiOptionsFileSave_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmiOptionsFileExit
            // 
            this.tsmiOptionsFileExit.Name = "tsmiOptionsFileExit";
            this.tsmiOptionsFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiOptionsFileExit.Size = new System.Drawing.Size(152, 22);
            this.tsmiOptionsFileExit.Text = "E&xit";
            this.tsmiOptionsFileExit.Click += new System.EventHandler(this.tsmiOptionsFileExit_Click);
            // 
            // tsmiOptionsFind
            // 
            this.tsmiOptionsFind.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptionsFindFilenames});
            this.tsmiOptionsFind.Name = "tsmiOptionsFind";
            this.tsmiOptionsFind.Size = new System.Drawing.Size(152, 22);
            this.tsmiOptionsFind.Text = "Fin&d";
            // 
            // tsmiOptionsFindFilenames
            // 
            this.tsmiOptionsFindFilenames.Name = "tsmiOptionsFindFilenames";
            this.tsmiOptionsFindFilenames.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmiOptionsFindFilenames.Size = new System.Drawing.Size(167, 22);
            this.tsmiOptionsFindFilenames.Text = "File&names";
            // 
            // FormNotesParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 346);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNotesParent";
            this.Text = "Notes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptionsFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptionsFileNewNote;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptionsFileOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptionsFileSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptionsFind;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptionsFindFilenames;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptionsFileExit;
    }
}