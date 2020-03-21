using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Searching for a string within Another String

            string book = "Introduction to c# book.";
            int index = book.IndexOf("c#");
            Console.WriteLine(index);
            index = book.IndexOf("duc");
            Console.WriteLine(index);
            index = book.IndexOf("INTRO");
            Console.WriteLine(index);

            index = book.IndexOf("o", 15); // finding 'o' after 15th index.
            Console.WriteLine(index);

            index = book.LastIndexOf("c#",17);
            Console.WriteLine(index);

            // Finding all occurrences of a substring 

            Console.WriteLine("\n\n--> Finding all occurrences of a substring :: \n"); 
            string quote = "The main intend of the \"Intro c#\" book is to introduce the c# programming to newbies";
            string keyword = "c#";

            index = quote.IndexOf(keyword);

            while(index != -1)
            {
                Console.WriteLine("{0} found at index {1}", keyword, index);

                index = quote.IndexOf(keyword, index+1);
            }


            // Extracting a portion of a string :: 

            Console.WriteLine("\n\n--> Extracting a portion of a string ::  \n");

            string  path = "F:\\anni\\holud 1\\Poni\\Imran.jpg";
            index = path.IndexOf("Imran");
            Console.WriteLine(index);
            string fileName = path.Substring(21,5);
            Console.WriteLine("File Name = " +fileName);

            // Extracting a Fill Name and File Extention 

            Console.WriteLine("\n\n--> Extracting a Fill Name and File Extention\n");

            index = path.LastIndexOf("\\");
            fileName = path.Substring(index + 1);
            Console.WriteLine("File Name : " + fileName);

            // Split the string by a separetor 
            Console.WriteLine("\n\n--> Split the string by a separetor.\n");

            string listOfBeers = "Amstel, Heineken, Tuborg,Becks";

            char[] separator = new char[] {' ', ',', '.' };
            string[] beersArr = listOfBeers.Split(separator);

            foreach(string beer in beersArr)
            {
                if(beer != "")
                {
                    Console.WriteLine(beer);
                }
            }
                Console.ReadLine();
        }
    }
}
