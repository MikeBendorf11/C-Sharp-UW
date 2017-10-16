using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class bin
    {
        public const int cansPerBin = 3;
        public int cans;
        public string flavor; 

        public bin(string flavor){
            cans = cansPerBin;
            this.flavor = flavor;
        }

    }
}
