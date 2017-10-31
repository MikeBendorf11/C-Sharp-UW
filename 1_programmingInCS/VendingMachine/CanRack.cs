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
        private static string[] theflavors = Enum.GetNames(typeof(Flavor));

        // Constructor 
        public CanRack()
        {
            FillTheCanRack();
        }

        //add can
        public void AddACanOf(Flavor FlavorOfCanToAdd)
        {
            Debug.WriteLine("adding a can of {0} soda to the rack"
                , FlavorOfCanToAdd, DUMMYARGUMENT);
            rack[(int)FlavorOfCanToAdd]++;
        }

        //remove can
        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            Debug.WriteLine("removing a can of {0} soda from the rack"
               , FlavorOfCanToBeRemoved, DUMMYARGUMENT);
            rack[(int)FlavorOfCanToBeRemoved]--;
        }

        //empty bin
        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            Debug.WriteLine("Emptying the {0} bin", 
                FlavorOfBinToBeEmptied, DUMMYARGUMENT);
            rack[(int)FlavorOfBinToBeEmptied] = EMPTYBIN;
        }

        //Is bin Full
        public Boolean IsFull(Flavor FlavorOfBinToCheck)
        {
            Debug.WriteLine("Checking if can rack is full of flavor {0}"
     , FlavorOfBinToCheck, DUMMYARGUMENT);
            if (rack[(int)FlavorOfBinToCheck] == BINSIZE)
                return true;
            else
                return false;
        }
        //is bin empty
        public Boolean IsEmpty(Flavor FlavorOfBinToCheck)
        {
            Debug.WriteLine("Checking if can rack is empty of flavor {0}"
           , FlavorOfBinToCheck, DUMMYARGUMENT);
            if (rack[(int)FlavorOfBinToCheck] == EMPTYBIN)
                return true;
            else
                return false;
        }

        //adds a can of the specified flavor to the rack.  
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
            if (validStr(ref FlavorOfCanToBeAdded))
                AddACanOf((Flavor)Enum.Parse(typeof(Flavor), FlavorOfCanToBeAdded));
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            if (validStr(ref FlavorOfCanToBeRemoved))
                RemoveACanOf((Flavor)Enum.Parse(typeof(Flavor), FlavorOfCanToBeRemoved));
        }

        public void DisplayCanRack()
        {
            for (int i = 0; i < theflavors.Length; i++)
                Debug.WriteLine(theflavors[i] + ": " + rack[i]);
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            foreach (int flavorValue in (Enum.GetValues(typeof(Flavor))))
                rack[flavorValue] = BINSIZE;
        }

        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();
            if(validStr(ref FlavorOfBinToBeEmptied))
                EmptyCanRackOf((Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToBeEmptied));
        }

        //returns true if the rack is full of a specified 
        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            if(validStr(ref FlavorOfBinToCheck))
                return IsFull((Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToCheck));
            else
                return false;
        }

        //return true if the rack is empty of a specified flavor
        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            if (validStr(ref FlavorOfBinToCheck))
                return IsEmpty((Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToCheck));
            else
                return false;
        }

        public static Boolean validStr(ref string input)
        {
            input = input.ToUpper();
            Boolean output = false;
            foreach (string flavorName in theflavors)
            {
                if (flavorName == input)
                    output = true;
            }
            if (!output)
                Debug.WriteLine("Unknown Flavor: {0}", input, DUMMYARGUMENT);
            return output;
        }

    } //end Can_Rack

}
