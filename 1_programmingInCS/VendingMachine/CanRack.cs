using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MyVendingMachine
{
    //  This class will represent a can storage rack of the vending machine.  
    class CanRack
    {
        private const int EMPTYBIN = 0;
        private const int BINSIZE = 3;
        private const int DUMMYARGUMENT = 0;
        private int[] rack = new int[Enum.GetValues(typeof(Flavor)).Length];
        private string[] theflavors = Enum.GetNames(typeof(Flavor));
        
        // Constructor 
        public CanRack()
        {
            FillTheCanRack();
        }

        //USING ENUMS
        //add can
        public void AddACanOf(Flavor FlavorOfCanToAdd)
        {
            Debug.WriteLine("adding a can of {0} flavored soda to the rack", FlavorOfCanToAdd, DUMMYARGUMENT);
            rack[(int)FlavorOfCanToAdd]++;
        }
        //remove can
        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            RemoveACanOf(FlavorOfCanToBeRemoved.ToString());
        }
        //empty bin
        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            EmptyCanRackOf(FlavorOfBinToBeEmptied.ToString());
        }
        //Is bin Full
        public Boolean IsFull(Flavor FlavorOfBinToCheck)
        {
            return IsFull(FlavorOfBinToCheck.ToString());
        }
        //is bin empty
        public Boolean IsEmpty(Flavor FlavorOfBinToCheck)
        {
            return IsEmpty(FlavorOfBinToCheck.ToString());
        }

        // USING CONST AND INT
        //adds a can of the specified flavor to the rack.  
        /*###
         RemoveCan(String) method is ready to be used by RemoveCan(enum)
         I wanted to try the reverse AddCan(enum) to support 
         * the AddCam(String) and see which turns out to be simpler
         */
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
            foreach (string flavorName in Enum.GetNames(typeof(Flavor)))
            {
                if(flavorName.Equals(FlavorOfCanToBeAdded))
                    
                    AddACanOf((Flavor)Enum.Parse(typeof(Flavor), flavorName));
            }
            //missing testing this method and a prove for bellow
            Debug.WriteLine("Error: attempt to add an unknown flavor {0} to the rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();
            int flavorCount = 0;

            Debug.WriteLine("removing a can of {0} flavored soda from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
            
            while (flavorCount < theflavors.Length) 
            {
                if (theflavors[flavorCount].Equals(FlavorOfCanToBeRemoved))
                {
                    rack[flavorCount]--;
                    break;
                }
                flavorCount++;
            }
            
            if (flavorCount == theflavors.Length)
                Debug.WriteLine("Error: attempt to remove an unknown flavor {0} from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);

        }

        public void DisplayCanRack()
        {
            Debug.WriteLine("Displaying the can rack");
            for (int i = 0; i < theflavors.Length; i++)
                Console.WriteLine(theflavors[i] + ": " + rack[i]);
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            foreach (int flavorValue in Enum.GetValues(typeof(Flavor)))
                rack[flavorValue] = BINSIZE;
        }

        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();
            Debug.WriteLine("Emptying can rack of flavor {0}", FlavorOfBinToBeEmptied, DUMMYARGUMENT);
            Debug.WriteLine("Error: attempt to empty rack of unknown flavor {0}", FlavorOfBinToBeEmptied, DUMMYARGUMENT);
        }

        //returns true if the rack is full of a specified 
        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is full of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            Debug.WriteLine("Error: attempt to check status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;

        }

        //return true if the rack is empty of a specified flavor
        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Boolean result = false;
            Console.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;
        }

    } //end Can_Rack

}
