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
        

        //##
        private Dictionary<Flavor, int> rack = new Dictionary
            <Flavor, int>();
        // Constructor 
        public CanRack()
        {
            FillTheCanRack();
        }

        //add can
        public void AddACanOf(Flavor FlavorOfCanToAdd)
        {
            if (!IsFull(FlavorOfCanToAdd))
            {
                Debug.WriteLine("adding a can of {0} soda to the rack"
                    , FlavorOfCanToAdd, DUMMYARGUMENT);
                rack[FlavorOfCanToAdd]++;
            }
            else
                Debug.WriteLine("The {0} bin is full"
                    , FlavorOfCanToAdd, DUMMYARGUMENT);
        }

        //remove can
        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            if (!IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine("removing a can of {0} soda from the rack"
               , FlavorOfCanToBeRemoved, DUMMYARGUMENT);
                rack[FlavorOfCanToBeRemoved]--;
            }
            else
                Debug.WriteLine("The {0] bin is empty"
                    , FlavorOfCanToBeRemoved, DUMMYARGUMENT);
        }

        //empty bin
        public void EmptyCanRackOf(Flavor FlavorOfBinToBeEmptied)
        {
            if (!IsEmpty(FlavorOfBinToBeEmptied))
            {
                Debug.WriteLine("Emptying the {0} bin",
                FlavorOfBinToBeEmptied, DUMMYARGUMENT);
                rack[FlavorOfBinToBeEmptied] = EMPTYBIN;
            }
            else
                Debug.WriteLine("The {0} bis is empty already"
                    , FlavorOfBinToBeEmptied, DUMMYARGUMENT);
        }

        //Is bin Full
        public Boolean IsFull(Flavor FlavorOfBinToCheck)
        {
            Debug.WriteLine("?? Checking if the {0} bin is full"
                 , FlavorOfBinToCheck, DUMMYARGUMENT);
            if (rack[FlavorOfBinToCheck] == BINSIZE)
                return true;
            else
                return false;
        }
        //is bin empty
        public Boolean IsEmpty(Flavor FlavorOfBinToCheck)
        {
            Debug.WriteLine("?? Checking if there is a {0} can"
                 , FlavorOfBinToCheck, DUMMYARGUMENT);
            if (rack[FlavorOfBinToCheck] == EMPTYBIN)
                return true;
            else
                return false;
        }

        //adds a can of the specified flavor to the rack.  
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
            if (validStr(FlavorOfCanToBeAdded))
                AddACanOf(FlavorOps.ToFlavor(FlavorOfCanToBeAdded));
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();
            if (validStr(FlavorOfCanToBeRemoved))
                RemoveACanOf(FlavorOps.ToFlavor(FlavorOfCanToBeRemoved));
        }

        public void DisplayCanRack()
        {
            Debug.WriteLine("Displaying the can rack");
            foreach (Flavor flv in FlavorOps.AllFlavors)
                Debug.Write(flv + ": " + rack[flv] + " /");
            Debug.WriteLine("");
        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            foreach (Flavor flv in FlavorOps.AllFlavors)
                rack.Add(flv, BINSIZE);
        }

        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();
            if (validStr(FlavorOfBinToBeEmptied))
                EmptyCanRackOf(FlavorOps.ToFlavor(FlavorOfBinToBeEmptied));
        }

        //returns true if the rack is full of a specified 
        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            if (validStr(FlavorOfBinToCheck))
                return IsFull(FlavorOps.ToFlavor(FlavorOfBinToCheck));
            else //returns false if str is invalid, exeption?
                return false;
        }

        //return true if the rack is empty of a specified flavor
        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            if (validStr(FlavorOfBinToCheck))
                return IsEmpty(FlavorOps.ToFlavor(FlavorOfBinToCheck));
            else //returns false if str is invalid, , exception?
                return false;
        }

        public static Boolean validStr(string input)
        {
            foreach (Flavor flv in FlavorOps.AllFlavors)
                if (flv.ToString() == input)
                    return true;
            /*## Change to 'debug' and 'return false'
             to stop forcing exception hadling on every
             string method*/
            throw new VendBadFlavorException(string.Format(
                "{0} Flavor not found", input));    
        }

    } //end Can_Rack

}
