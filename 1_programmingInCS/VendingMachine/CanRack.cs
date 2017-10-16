using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine;
using System.Diagnostics;

namespace VendingMachine
{
    class CanRack
    {
        const int binsPerRack = 3;
        static string [] flavors = { "Fanta", "Sprite", "Coca-Cola" };
        bin[] rackBin = new bin[binsPerRack];

        // Constructor for a can rack. The rack starts out full 
        public CanRack()
        {
            for (int i = 0; i < binsPerRack; i++)
            {
                rackBin[i] = new bin(flavors[i]);
                Debug.WriteLine("Added a bin of {0} cans of {1}"
                    ,rackBin[i].cans ,rackBin[i].flavor, 0);
            }             
        }

        //  This method adds a can of the specified flavor to the rack.   
        public void AddACanOf(string FlavorOfCanToBeAdded) {
            for (int i = 0; i < binsPerRack; i++)
            {
                if ((rackBin[i].flavor).Equals(FlavorOfCanToBeAdded))
                {
                    if (rackBin[i].cans < bin.cansPerBin)
                    {
                        rackBin[i].cans++;
                        Debug.WriteLine("Added a can of {0}", rackBin[i].flavor, 0);
                    }
                }
                else
                    Debug.WriteLine("The {0} bin is already full", rackBin[i].flavor, 0);
            }
        }

        //  This method will remove a can of the specified flavor from the rack. 
        public void RemoveACanOf(string FlavorOfCanToBeRemoved) {
            for (int i = 0; i < binsPerRack; i++)
            {
                if ((rackBin[i].flavor).Equals(FlavorOfCanToBeRemoved))
                {
                    if (rackBin[i].cans > 0)
                    {
                        rackBin[i].cans--;
                        Debug.WriteLine("Removed a can of {0}", rackBin[i].flavor, 0);
                    }
                }
                else
                    Debug.WriteLine("The are no more cans left in the {0} bin "
                        , rackBin[i].flavor, 0);
            }
        }

        //  This method will fill the can rack. 
        public void FillTheCanRack() { }

        //  This public void will empty the rack of a given flavor. 
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied) { }

        // OPTIONAL – returns true if the rack is full of a specified flavor 
        // false otherwise 
        public Boolean IsFull(string FlavorOfBinToCheck) { return true; }

        // OPTIONAL – return true if the rack is empty of a specified flavor 
        // false otherwise  
        public Boolean IsEmpty(string FlavorOfBinToCheck) { return true; }

    } //end Can_Rack 
}
