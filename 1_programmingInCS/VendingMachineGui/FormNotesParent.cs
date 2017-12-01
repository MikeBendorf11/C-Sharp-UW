using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace VendingMachineGui
{
    public partial class FormNotesParent : Form
    {
        int newNoteCount = 0;
        string pattern = @"\d{3}-\d{3}-\d{3}";
        string found = null;

        public FormNotesParent()
        {
            InitializeComponent();
        }

        private void tsmiOptionsFileNewNote_Click(object sender, EventArgs e)
        {
            FormNotesChild theChildForm = new FormNotesChild();
            theChildForm.MdiParent = this;
            theChildForm.Show();
            theChildForm.Text += "_" + ++newNoteCount;
            tsmiOptionsFileSave.Enabled = true;
        }

        private void tsmiOptionsFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiOptionsFileOpen_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Path.GetFullPath(@"..\..\Notes\");
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FormNotesChild theChildForm = new FormNotesChild();
                theChildForm.MdiParent = this;

                try
                {
                    theChildForm.Notes = File.ReadAllText(openFileDialog1.FileName);
                    tsmiOptionsFindFilenames.Enabled = true;
                    theChildForm.Text = Path.GetFileName(openFileDialog1.FileName);
                    theChildForm.Show();
                    tsmiOptionsFileSave.Enabled = true;
                    Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
                    MatchCollection matches = rgx.Matches(theChildForm.Notes);
                    foreach (Match match in matches)
                        if(!String.IsNullOrEmpty(match.Value))
                            found += match.Value + "\n";

                }
                catch (Exception Ex)
                { MessageBox.Show(Ex.ToString()); }
            }
        }

        private void tsmiOptionsFileSave_Click(object sender, EventArgs e)
        {
            FormNotesChild theChildForm = (FormNotesChild)this.ActiveMdiChild;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Path.GetFullPath(@"..\..\Notes\");
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = theChildForm.Text + ".txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                { File.WriteAllText(saveFileDialog1.FileName, theChildForm.Notes); }
                catch (Exception Ex)
                { MessageBox.Show(Ex.ToString()); }
            }
        }

        private void tsmiOptionsFindFilenames_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matches Found: \n" + found);
        }
    }
}



