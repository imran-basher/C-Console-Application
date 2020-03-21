using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Your First Name : ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Your Last name :");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello " +firstName + lastName);

            Console.WriteLine("Hello {0} {1} ",firstName, lastName);



            Console.ReadLine();
        }
    }

