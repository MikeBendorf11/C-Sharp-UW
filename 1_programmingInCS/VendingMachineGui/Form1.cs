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
        CanRack theRack = new CanRack();
        CoinBox myBox = new CoinBox();
        CoinBox VendingBox = new CoinBox(new List<Coin> {
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME),
                new Coin(Coin.Denomination.NICKEL), new Coin(Coin.Denomination.QUARTER),
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME) });

        public Form1()
        {
            InitializeComponent();
        }

        //Adding Coins
        private void InsNickel_Click(object sender, EventArgs e)
        { checkInputMoney(Coin.Denomination.NICKEL); }
        private void InsDime_Click(object sender, EventArgs e)
        { checkInputMoney(Coin.Denomination.DIME); }
        private void InsQuarter_Click(object sender, EventArgs e)
        { checkInputMoney(Coin.Denomination.QUARTER); }
        private void InsHalfdollar_Click(object sender, EventArgs e)
        { checkInputMoney(Coin.Denomination.HALFDOLLAR); }

        void checkInputMoney(Coin.Denomination Adenom)
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
        private void ejectReg_Click(object sender, EventArgs e)
        { attemptRemove(Flavor.REGULAR); }

        private void ejectOrg_Click(object sender, EventArgs e)
        { attemptRemove(Flavor.ORANGE); }

        private void ejectLmn_Click(object sender, EventArgs e)
        { attemptRemove(Flavor.LEMON); }

        void attemptRemove(Flavor flv)
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

        void toggleInsBttn()
        {
            if (InsNickel.Enabled)
                InsNickel.Enabled = InsDime.Enabled =
                    InsQuarter.Enabled = InsHalfdollar.Enabled = false;
            else
                InsNickel.Enabled = InsDime.Enabled =
                    InsQuarter.Enabled = InsHalfdollar.Enabled = true;
        }
        void toggleEjectBttn()
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
