using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    public class A
    {
        public void s1()
        {
            Console.WriteLine("A::s1");
            v1();
        }

        protected virtual void v1()
        {
            Console.WriteLine("A::v1");
            s3();
        }

        public void s2()
        {
            Console.WriteLine("A::s2");
            s1();
        }

        protected void s3()
        {
            Console.WriteLine("A::s3");
        }
    }
}