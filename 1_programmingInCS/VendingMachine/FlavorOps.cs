using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MyVendingMachine
{
    public enum Flavor { REGULAR, ORANGE, LEMON }

    public static class FlavorOps
    {
        private static List<Flavor> _allFlavors = new List<Flavor>();
        static FlavorOps()
        {
            
        }
        // method to convert a string value into an enumeral
        public static Flavor ToFlavor(string FlavorName)
        {
            foreach (Flavor flv in _allFlavors)
                if (flv.ToString() == FlavorName)
                    return flv;
            return Flavor.REGULAR;
        }
        // property to return a List<Flavor> of all of the Varieties
        public static List<Flavor> AllFlavors
        {
            get
            {
                return _allFlavors;
            }
        }
    }
}
