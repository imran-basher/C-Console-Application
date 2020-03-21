using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            System.String greeting = "Alhamdulillah, C#";

            char ch = greeting[1];
            Console.WriteLine(ch);
          //  greeting[1] = 'a'; // It is not possible OR cann't be modified BECAUSE of strings are immutable.  

            //ch = greeting[50];  // What happend in it?? 
           // Console.WriteLine(ch); 

            // String -- Simple Example

            Console.WriteLine("String -- Simple Example \n");

            //string message = "This is a simple string message.";
            string message = "String Message.";
            Console.WriteLine("Message : {0} ", message);
            Console.WriteLine("Message Length : {0}",message.Length);

            for (int index = 0; index < message.Length; index++)
            {
                Console.Write("Message[{0}] = {1}\n" , index, message[index]); 
            }

            //String Scaping 

            Console.WriteLine("\n\nString Scaping \n");

            string quote = "Book's title is \"Intro to C#.\"  ";
            Console.WriteLine("Quote = {0}",quote);

            // Creating And Initializing a String 

            Console.WriteLine("\n\nCreating And Initializing a String: \n ");

            Console.WriteLine("We can initialize variable for string three(3) away : \n");

            Console.WriteLine("--> By Assigning a string literal: ");

            string website = "https://www.wikipedia.org";

            Console.WriteLine("String website = {0} ",website);

            Console.WriteLine("\n--> By assigning the valuo of another string :");
            
            string source = "Some source";
            string assigned = source;

            Console.WriteLine("String source = \"Some Source\"; ");
            Console.WriteLine("String assigned = source \n assigned : {0}",assigned);

            Console.WriteLine("\n--> By passing a string expression :");

            string email = "imranbasher@gmail.com";
            string info = "My mail is " + email;

            Console.WriteLine("string email = \"imranbasher@gmail.com\";");
            Console.WriteLine("string info = \"My mail is \" + email;");
            Console.WriteLine("info : {0}", info);














                Console.ReadLine();
        }
    }
}
