using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVendingMachine
{
    public class VendBadFlavorException : Exception
    {
        public VendBadFlavorException(string s)
            : base(string.Format("Invalid Input {0}", s)){ }
    }
}
