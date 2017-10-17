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
        static string[] flavors = { "Fanta", "Sprite", "Coca-Cola" };
        bin[] rackBin = new bin[binsPerRack];

        // Constructor for a can rack. The rack starts out full 
        public CanRack()
        {
            for (int i = 0; i < binsPerRack; i++)
            {
                rackBin[i] = new bin(flavors[i]);
                Debug.WriteLine("Added a bin of {0} cans of {1}"
                    , rackBin[i].cans, rackBin[i].flavor, 0);
            }
        }

        //  This method adds a can of the specified flavor to the rack.   
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            if (!IsFull(FlavorOfCanToBeAdded))
                for (int i = 0; i < binsPerRack; i++)
                {
                    if ((rackBin[i].flavor).Equals(FlavorOfCanToBeAdded))
                    {
                        rackBin[i].cans++;
                        Debug.WriteLine("Add: The {0} bin has {1} cans", rackBin[i].flavor,
                            rackBin[i].cans, 0);
                    }
                }
            else
                Debug.WriteLine("Bin is full already");
        }

        //  This method will remove a can of the specified flavor from the rack. 
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            if (!IsEmpty(FlavorOfCanToBeRemoved))
                for (int i = 0; i < binsPerRack; i++)
                {
                    if ((rackBin[i].flavor).Equals(FlavorOfCanToBeRemoved))
                    {
                        rackBin[i].cans--;
                        Debug.WriteLine("Remove: The {0} bin has {1} cans", rackBin[i].flavor,
                            rackBin[i].cans, 0);
                    }
                }
            else
                Debug.WriteLine("Bin is empty already");
        }

        //  This method will fill the can rack. 
        public void FillTheCanRack()
        {
            foreach (string flv in flavors)
                while (!IsFull(flv))
                    AddACanOf(flv);
            Debug.WriteLine("Rack filled");
        }

        //  This public void will empty the rack of a given flavor. 
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            for (int i = 0; i < binsPerRack; i++)
                if ((rackBin[i].flavor).Equals(FlavorOfBinToBeEmptied))
                    while (!IsEmpty(FlavorOfBinToBeEmptied))
                        RemoveACanOf(FlavorOfBinToBeEmptied);
        }

        // OPTIONAL – returns true if the rack is full of a specified flavor 
        // false otherwise 
        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            for (int i = 0; i < binsPerRack; i++)
            {
                if ((rackBin[i].flavor).Equals(FlavorOfBinToCheck))
                {
                    Debug.WriteLine("IsFull?: The {0} bin has {1} cans", rackBin[i].flavor,
                              rackBin[i].cans, 0);
                    if (rackBin[i].cans < bin.cansPerBin)
                        return false;
                    else if (rackBin[i].cans == bin.cansPerBin)
                        return true;
                }
            }
            Debug.WriteLine("IsFull? Error: This rack has no bins, or can overload");
            return false;
        }

        // OPTIONAL – return true if the rack is empty of a specified flavor 
        // false otherwise  
        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            for (int i = 0; i < binsPerRack; i++)
            {
                if ((rackBin[i].flavor).Equals(FlavorOfBinToCheck))
                {
                    Debug.WriteLine("IsEmpty?: The {0} bin has {1} cans", rackBin[i].flavor,
                              rackBin[i].cans, 0);
                    if (rackBin[i].cans == 0)
                        return true;
                    else
                        return false;
                }
            }
            Debug.WriteLine("IsEmpty? Error: This rack has no bins, or can underload");
            return false;
        }

    } //end Can_Rack 
}
