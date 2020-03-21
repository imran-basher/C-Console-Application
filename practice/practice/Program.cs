using System;

    class Program
    {
        static void Main(string[] args)
        {
          /*  int a = 5;
            int b = 10;
            int c;

            c = a;
            a = b;
            b = c;

            Console.WriteLine("a : {0} \nb : {1}",a,b);
            */

            // 

        /*   int num;

           num = Convert.ToInt32(Console.ReadLine());

           string st = (int) num%2==0 ? "Even" : "Odd";

           Console.WriteLine(" This is " + st + " number");
        */
            //---------------------------------------------- ((numb / 5) && (numb / 7)) && ((numb % 5 == 0) && (numb % 7 == 0));

        
            /*
             
           Console.WriteLine("Enter The Number : ");
           int numb =  Convert.ToInt32(Console.ReadLine());

           bool check = (int)numb % 5 == 0 && (int)numb % 7 == 0;
           
            if (check)
           {
               Console.WriteLine( numb + " is divisible by both 5 and 7");
           }
            else
            {
                Console.WriteLine(numb + " is NOT divisible by both 5 and 7");
            }

            */

            /*
            Console.WriteLine("Enter The Number : ");
            int numbe = Convert.ToInt32(Console.ReadLine());

            int numbe1 = numbe / 100;

            int numbe2 = numbe1 % 10;

            if(numbe2 == 7)
            {
                Console.WriteLine("That Expression right to left third digit is 7");
            }
            else
            {
                Console.WriteLine("That Expression right to left third digit is " + numbe2);
            }
            */

            /*
            
            Console.WriteLine("Enter Height :");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter width :");
            int width = Convert.ToInt32(Console.ReadLine());

            int rectangle = height * width ;

            Console.WriteLine("Rectangle  Area is : " + rectangle);
             * 
            */

            /*
            int n = 2;
            int m = 6;

            long product = 1;

            do
            {
                Console.WriteLine("product1  : {0}", product);
                Console.WriteLine("n : {0}", n);
                product *=n;
                Console.WriteLine("product2 : {0}",product);
               
                n++;
                Console.WriteLine("n : {0}\n\n", n);
            }
            while(n <=m);

            Console.WriteLine("product3 : {0}", product);

            */
           /*
            
            int total = 0;
            start :
            Console.WriteLine("Please choice Coffee :\n\t 1.Small \n\t 2.Medium \n\t 3.Large");
            int choice = int.Parse(Console.ReadLine());

            
            switch(choice)
            {
                case 1:
                    total += 1;
                    break;

                case 2:
                    total += 2;
                    break;

                case 3:
                    total += 3;
                    break;
                default:
                    Console.WriteLine("Invalide choice. Please choose again...");
                    goto start;        
            }
        
            again:
            Console.WriteLine("Do you want to bye another coffee. Yes ? No");
            string OtherChoice = Console.ReadLine();
            switch (OtherChoice)
            {
                case "yes":
                    goto start;
                case "no":
                    break;
                default:
                    Console.WriteLine("Your choice is Invalide. Please choice do you want or not..");
                    goto again;

            }

            Console.WriteLine("Thank you for shopping. your total amount is {0}",total);
            */

            int total = 0;
            string OtherChoice = string.Empty;
            do{
                 int choice = -1;
                 do
                 {
                     Console.WriteLine("Please choice Coffee :\n\t 1.Small \n\t 2.Medium \n\t 3.Large");
                     choice = int.Parse(Console.ReadLine());


                     switch (choice)
                     {
                         case 1:
                             total += 1;
                             break;

                         case 2:
                             total += 2;
                             break;

                         case 3:
                             total += 3;
                             break;

                         default:
                             Console.WriteLine("Invalide choice. Please choose again...");
                             break;
                     }
                 }
                 while (choice != 1 && choice != 2 && choice != 3);
            
                do
                {
                    Console.WriteLine("Do you want to bye another coffee. Yes ? No");
                     OtherChoice = Console.ReadLine();
                    if (OtherChoice != "yes" && OtherChoice != "no")
                    {
                        Console.WriteLine("Invalide youse choice. Please try again...");
                    }
                }
                while (OtherChoice != "yes" && OtherChoice != "no");
            } 
            while (OtherChoice != "no");
        

            Console.WriteLine("Thank you for shopping. your total amount is {0}", total);

            Console.ReadLine();
        }
    }

