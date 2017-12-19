using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingConsoleLibrary;

namespace VendingMachineGui
{
    public partial class Form1 : Form
    {
        FoodLocker theFoodlocker = new FoodLocker();
        private void buttonStock_Click(object sender, EventArgs e)
        {      
            theFoodlocker.Stock();
            object[] snackCollection = new object[theFoodlocker.Size];
            int count = 0;

            foreach(Snack s in theFoodlocker.Store)
                snackCollection[count++] = s.Name;

            listBoxSnacks.Items.AddRange(snackCollection);
        }
        private void listBox_SelectedIndex(object sender, EventArgs e)
        {
            foreach (Snack s in theFoodlocker.Store)
            {
                if (listBoxSnacks.SelectedItem.ToString() == s.Name)
                    textBoxSnackDesc.Text = ((object)s).ToString();    
            }  
        }
    }
}
