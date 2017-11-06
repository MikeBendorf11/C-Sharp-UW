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
            foreach (Flavor flv in Enum.GetValues(typeof(Flavor)))
                _allFlavors.Add(flv);
        }

        // method to convert a string value into an enumeral
        public static Flavor ToFlavor(string FlavorName)
        {
            FlavorName = FlavorName.ToUpper();
            foreach (Flavor flv in _allFlavors)
                if (flv.ToString() == FlavorName) return flv;
            Debug.WriteLine("FlvOps: {0} not found", FlavorName, 0);
            return Flavor.REGULAR;
        }

        // property to return a List<Flavor> of all of the Varieties
        public static List<Flavor> AllFlavors
        {
            get { return _allFlavors; }
        }
    }
}
