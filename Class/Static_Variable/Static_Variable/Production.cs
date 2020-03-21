using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Variable
{
    class Production
    {
        public void mul()
        {
            Console.WriteLine("Production : {0}", a * b);
        }
        static void Main(string[] args)
        {
             Addition.a = 20;
             Addition.b = 10;

            Addition ab = new Addition();
            ab.add();
            ab.sub();
            Production p = new Production();
            p.mul();

            Console.ReadLine();

        }            
        
    }
}
