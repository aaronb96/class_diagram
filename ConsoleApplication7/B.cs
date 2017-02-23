using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    public class B : A
    {
        protected void s4()
        {
            Console.WriteLine("B::s4");
            v1();
        }

        public void s5()
        {
            Console.WriteLine("B::s5");
            s3();
        }

        protected void s3()
        {
            Console.WriteLine("B::s3");
        }

        public virtual void v2()
        {
            Console.WriteLine("B::v2");
            v1();
        }

        protected virtual void v1()
        {
            Console.WriteLine("B::v1");
            s5();
        }
    }
}