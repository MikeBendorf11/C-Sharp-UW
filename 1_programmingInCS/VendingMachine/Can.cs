using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVendingMachine
{
    // public enum Flavor { REGULAR, ORANGE, LEMON }
    class Can
    {
       
        public readonly Flavor TheFlavor;

        public Can()
        {
            TheFlavor = Flavor.REGULAR;
        }

        public Can(Flavor AFlavor)
        {
            TheFlavor = AFlavor;
        }
    }
}

