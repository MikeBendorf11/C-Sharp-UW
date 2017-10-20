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

        private int regular = EMPTYBIN;
        private int orange = EMPTYBIN;
        private int lemon = EMPTYBIN;

        private const int DUMMYARGUMENT = 0;
       
        // Constructor 
        public CanRack()
        {
            FillTheCanRack();
        }
        
        //USING ENUMS
        //add can
        public void AddACanOf(Flavor FlavorOfCanToAdd)
        {          
            AddACanOf(FlavorOfCanToAdd.ToString());
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
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
            Debug.WriteLine("adding a can of {0} flavored soda to the rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
            if (FlavorOfCanToBeAdded == "REGULAR") regular++;
            else if (FlavorOfCanToBeAdded == "ORANGE") orange++;
            else if (FlavorOfCanToBeAdded == "LEMON") lemon++;
            else Debug.WriteLine("Error: attempt to add an unknown flavor {0} to the rack", FlavorOfCanToBeAdded, DUMMYARGUMENT);
        }

        //  This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();
            Debug.WriteLine("removing a can of {0} flavored soda from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);
            if (FlavorOfCanToBeRemoved == "REGULAR") regular--;
            else if (FlavorOfCanToBeRemoved == "ORANGE") orange--;
            else if (FlavorOfCanToBeRemoved == "LEMON") lemon--;
            else Debug.WriteLine("Error: attempt to remove an unknown flavor {0} from the rack", FlavorOfCanToBeRemoved, DUMMYARGUMENT);

        }

        //  This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            regular = BINSIZE;
            orange = BINSIZE;
            lemon = BINSIZE;
        }

        //  This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();
            Debug.WriteLine("Emptying can rack of flavor {0}", FlavorOfBinToBeEmptied, DUMMYARGUMENT);
            if (FlavorOfBinToBeEmptied == "REGULAR") regular = EMPTYBIN;
            else if (FlavorOfBinToBeEmptied == "ORANGE") orange = EMPTYBIN;
            else if (FlavorOfBinToBeEmptied == "LEMON") lemon = EMPTYBIN;
            else Debug.WriteLine("Error: attempt to empty rack of unknown flavor {0}", FlavorOfBinToBeEmptied, DUMMYARGUMENT);
        }

        //returns true if the rack is full of a specified 
        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Boolean result = false;
            Debug.WriteLine("Checking if can rack is full of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == "REGULAR") result = regular == BINSIZE;
            else if (FlavorOfBinToCheck == "ORANGE") result = orange == BINSIZE;
            else if (FlavorOfBinToCheck == "LEMON") result = lemon == BINSIZE;
            else Debug.WriteLine("Error: attempt to check status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;

        }

        //return true if the rack is empty of a specified flavor
        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Boolean result = false;
            Console.WriteLine("Checking if can rack is empty of flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            if (FlavorOfBinToCheck == "REGULAR") result = regular == EMPTYBIN;
            else if (FlavorOfBinToCheck == "ORANGE") result = orange == EMPTYBIN;
            else if (FlavorOfBinToCheck == "LEMON") result = lemon == EMPTYBIN;
            else Debug.WriteLine("Error: attempt to check rack status of unknown flavor {0}", FlavorOfBinToCheck, DUMMYARGUMENT);
            return result;
        }

    } //end Can_Rack

}
