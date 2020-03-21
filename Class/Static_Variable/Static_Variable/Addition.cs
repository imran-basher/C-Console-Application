using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Variable
{
    class Addition
    {
       public static int a;
       public static int b;

        public void add()
        {
            a = 20;
            b = 10;
            Console.WriteLine("Addition : {0}", a + b);
        }

        public void sub()
        {
            Console.WriteLine("Subtraction : {0}", a - b);
        }

        
    }
}

