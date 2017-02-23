using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    public class D : B
    {
        public void s7()
        {
            Console.WriteLine("D::s7");
            s3();
        }

        public void s8()
        {
            Console.WriteLine("D::s8");
            v2();
        }

        protected virtual void v2()
        {
            Console.WriteLine("D::v2");
            s7();
        }
    }
}