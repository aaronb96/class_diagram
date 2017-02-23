using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    public class C : B
    {
        public void s6()
        {
            Console.WriteLine("C::s6");
            v1();
        }

        public void s7()
        {
            Console.WriteLine("C::s7");
            v2();
        }
    }
}