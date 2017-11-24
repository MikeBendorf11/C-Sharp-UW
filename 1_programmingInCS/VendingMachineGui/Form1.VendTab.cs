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
using System.Diagnostics;


namespace VendingMachineGui
{
    //EVENTS FOR THE VENDTAB
    public partial class Form1 : Form
    {
        private void buttonNotes_Click(object sender, EventArgs e)
        {
            FormNotes formNotesObj = new FormNotes();
            formNotesObj.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            groupBoxCansInfo.Visible = false;
            groupBoxCoinInfo.Visible = false;
            groupBoxAccessService.Visible = true;
        }

        private void buttonAccessService_Click(object sender, EventArgs e)
        {
            if (textBoxAccessPass.Text == "p")
            {
                groupBoxCansInfo.Visible = true;
                groupBoxCoinInfo.Visible = true;
                groupBoxAccessService.Visible = false;
            }
            textBoxAccessPass.Text = "";
        }

        private void TabControlMain_Click(object sender, EventArgs e)
        {
            updateVendPage();
        }

        private void VendTabEvents(object sender, EventArgs e)
        {
            if (sender as Button == ButtonRefillCans)
            {
                theRack.FillTheCanRack();
                updateVendPage();
            }
            else if (sender as Button == ButtonEmptyCoins)
            {
                VendingBox.Withdraw(VendingBox.ValueOf);
                updateVendPage();
            }
            else Debug.WriteLine("Event at VendTab not implemented");
        }

        void updateVendPage()
        {

            int flvCount = 0, columnCount = 1, coinCount = 0;
            int CanRows = 4;
            foreach (Flavor flv in FlavorOps.AllFlavors)
            {

                listViewCans.Items[flvCount].SubItems[columnCount].Text =
                     "0" + theRack[flv].ToString();
                flvCount++;
            }

            foreach (Coin.Denomination denom in Coin.AllDenominations)
            {
                if (denom == Coin.Denomination.SLUG) continue;

                string[] rowContent =
                    {
                        "",//skipped with coLumnCount
                        VendingBox.coinCount(denom).ToString(),
                        string.Format($"{Coin.ValueOfCoin(denom):c}"),
                        string.Format($"{VendingBox.coinCount(denom)*Coin.ValueOfCoin(denom):c}")
                    };

                for (; columnCount < CanRows; columnCount++)
                {
                    listViewCoins.Items[coinCount].SubItems[columnCount].Text =
                        rowContent[columnCount];
                }
                //go to next coin first column
                columnCount = 1;
                coinCount++;
            }
        }
    }
}
