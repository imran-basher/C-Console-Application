using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nothing
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int startTime = Environment.TickCount;
            // The code fragment to be tested
            for (int i = 0; i < 10000000; i++)
            {
                sum++;
             
            }
            int endTime = Environment.TickCount;
            Console.WriteLine("\nThe time elapsed is {0} sec.",
            (endTime - startTime) / 1000.0);


            //Console.WriteLine("Imran.");

            //Console.WriteLine("Before using constructor.");
            //Console.ReadLine();

            //Constract c;             // declare object

            //Console.WriteLine("Creating object.");
            //Console.ReadLine();

            //c = new Constract();    // Creating / instantiate object..
            //Console.WriteLine("After Creating / instantiate  object. ");

           /*
            Console.WriteLine(" Machine Name : {0}",Environment.MachineName);

            Console.WriteLine(" OS Version : {0}",Environment.OSVersion );

            Console.WriteLine(" Sytem Directory : {0}", Environment.SystemDirectory);

            Console.WriteLine(" User Domain Name : {0}",Environment.UserDomainName);

            Console.WriteLine(" User Name : {0}",Environment.UserName);

            Console.WriteLine(" Version : {0}", Environment.Version);

            Console.WriteLine("  : {0}");

            Console.WriteLine("  : {0}");

            Console.WriteLine("  : {0}");


            Console.WriteLine("  : {0}");


            Console.WriteLine("  : {0}");


            Console.WriteLine("  : {0}");
            */

            //Console.WriteLine(" Get Environment Variable : ");

            //IDictionary environmentVariable = Environment.GetEnvironmentVariables();
                 
            //foreach(DictionaryEntry de in environmentVariable)
            //{
            //    Console.WriteLine("  {0} = {1}", de.Key, de.Value);
            //}

            Console.ReadLine();

        }
    }
}
