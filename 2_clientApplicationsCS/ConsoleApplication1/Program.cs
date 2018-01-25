using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract public class Program
    {
        public class A
        {
            int a, b;
            public A(int a, int b)
            {
                a = this.a;
                b = this.b;
            }
        }
        static void Main(string[] args)
        {
            A obj = new A(1, 2);
        }
    }
}
