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
    public partial class Form1 : Form
    {
        PurchasePrice thePrice = new PurchasePrice(0.35M);
        decimal inputMoney = 0;
        static CanRack theRack = new CanRack();
        static CoinBox myBox = new CoinBox();
        static CoinBox VendingBox = new CoinBox(new List<Coin> {
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME),
                new Coin(Coin.Denomination.NICKEL), new Coin(Coin.Denomination.QUARTER),
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME) });
        string regAmount = theRack[Flavor.REGULAR].ToString();
        public Form1()
        {
            InitializeComponent();
  
        }

        //VEND TAB CONTROLS
        //Adding Coins
        private void CoinBttns_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == InsNickel)
                incrementBalance(Coin.Denomination.NICKEL);
            else if (b == InsDime)
                incrementBalance(Coin.Denomination.DIME);
            else if (b == InsQuarter)
                incrementBalance(Coin.Denomination.QUARTER);
            else if (b == InsHalfdollar)
                incrementBalance(Coin.Denomination.HALFDOLLAR);
            else Debug.WriteLine("Sender is not a Coin button");
        }

        private void incrementBalance(Coin.Denomination Adenom)
        {
            if (inputMoney < thePrice.PriceDecimal)
            {
                inputMoney += (int)Adenom / 100m;
                myBox.Deposit(new Coin(Adenom));
                InsertLabel.Text = string.Format($"Inserted so far: {inputMoney:c}");
                if (inputMoney >= thePrice.PriceDecimal)
                {
                    toggleInsBttn();
                    PriceLabel.Text = "";
                    InsertLabel.Text = string.Format($"You inserted: {inputMoney:c}");
                    MessageBox.Show("Now select a can of soda");
                    toggleEjectBttn();
                }
            }
        }

        //Removing a can and give change
        private void ejectCans_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == ejectReg)
                attemptRemove(Flavor.REGULAR);
            else if (b == ejectOrg)
                attemptRemove(Flavor.ORANGE);
            else if (b == ejectLmn)
                attemptRemove(Flavor.LEMON);
            else Debug.WriteLine("Sender is not a ejectCan button");

        }
     
        private void attemptRemove(Flavor flv)
        {
            decimal yourChange = inputMoney - thePrice.PriceDecimal;
            if (VendingBox.Withdraw(yourChange))
            {
                if (!theRack.IsEmpty(flv))
                {
                    theRack.RemoveACanOf(flv);       
                    MessageBox.Show($"Enjoy your {flv.ToString()} soda!" +
                        $"\nYour change: {yourChange:c}");
                    myBox.Transfer(VendingBox);
                    inputMoney = 0;
                    toggleEjectBttn();
                    toggleInsBttn();
                    InsertLabel.Text = string.Format($"Inserted so far: {inputMoney:c}");
                    PriceLabel.Text = "Please insert:   $0.35";
                }
                else
                {
                    MessageBox.Show($"Sorry, we are out of {flv}");
                } 
            }
            else
            {
                Debug.WriteLine("Not enough seed coins");
                MessageBox.Show($"Sorry, something went wrong. Please call support.");
            }
        }

        private void toggleInsBttn()
        {
            if (InsNickel.Enabled)
                InsNickel.Enabled = InsDime.Enabled =
                    InsQuarter.Enabled = InsHalfdollar.Enabled = false;
            else
                InsNickel.Enabled = InsDime.Enabled =
                    InsQuarter.Enabled = InsHalfdollar.Enabled = true;
        }
        private void toggleEjectBttn()
        {
            if (ejectLmn.Enabled)
                ejectLmn.Enabled = ejectOrg.Enabled = ejectReg.Enabled = false;
            else
                ejectLmn.Enabled = ejectOrg.Enabled = ejectReg.Enabled = true;
        }

        private void returnBttn_Click(object sender, EventArgs e)
        {
            myBox.Withdraw(inputMoney);
            MessageBox.Show($"Your change: {inputMoney:c}");
            inputMoney = 0;
            InsNickel.Enabled = InsDime.Enabled =
                    InsQuarter.Enabled = InsHalfdollar.Enabled = true;
            ejectLmn.Enabled = ejectOrg.Enabled = ejectReg.Enabled = false;
            PriceLabel.Text = "Please insert:   $0.35";
            InsertLabel.Text = string.Format($"Inserted so far: {inputMoney:c}");
        }

        
    }
}
