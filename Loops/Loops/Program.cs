using System;
using System.Numerics;
    class Program
    {
        static void Main()
        {
              // While Loop

            int counter = 0; 							 // Initialize the counter	
	
            while (counter <= 9)    					// Execute the loop body while the loop condition holds
            {
                Console.WriteLine("Number : " + counter); // Print the counter value

                counter++;								// Increment the counter
            }

            Console.WriteLine("\n");
            Console.WriteLine("Summing the number from 1 to N.");
            Console.WriteLine("\n");

            int n = 10;
            int num = 1;
            int sum = 1;
            Console.Write("The sum 1");
            while(num < n)
            {
                num++;
                sum += num;
                Console.Write(" + " + num);
            }

            Console.WriteLine(" = " + sum);

            // Example -- Check If a Number Is Prime

            Console.Write("\n\n            ");
            Console.Write("Chack if a number is Prime.");
            Console.Write("\n");

           

            Console.Write("Enter the number : ");
            // int num1 = int.Parse(Console.ReadLine());
            int num1 = 11;
            Console.Write(num1 +"\n");
            int divider = 2; 
            int maxDivider = (int)Math.Sqrt(num1);
            bool prime = true;

            while(prime && (divider <= maxDivider))
            {
                if (num1 % divider == 0)
                    prime = false;
                divider++;
            }
           

             Console.WriteLine("Prime?? : "+prime);


             Console.Write("\n\n            ");
             Console.Write("Calculating Factorial.");
             Console.Write("\n");

             int F_num = 4;
             int factorial = 1;
            int i = 1;
            while (i <= F_num)
             {
                 factorial *= i;
                 i++;
             }
            Console.WriteLine("F_num! : "+factorial);
            
          

            // Do-While Loops
            Console.Write("\n\n            ");
            Console.Write("Calculating Factorial.");
            Console.Write("\n");
            int F_num1 = 100;
            int j = 1;
            BigInteger factorial1 = 1;
            do
            {
                factorial1 *= j;
                j++;
            } while (j <= F_num1);

            Console.WriteLine("do_while  F_num1! : " + factorial1);


            int nn = 2;
            int mm = 6;

           num = nn;
           long product = 1;
           do
           {
               product *= num;
               num++;
           } while (num <= mm);
            Console.WriteLine("product[nn...mm] : "+product);
           

            // for loop
            Console.Write("\n\n            ");
            Console.Write("for loop.\n");
            Console.Write("\n");

            for (int k = 0; k <= 10;k++)
            {
                Console.Write(k + " ");
            }

            Console.Write( "\n ");
            for (int k = 1, aum = 1;  k<=128;  k *=2, aum +=k)
            {
                Console.WriteLine("k = {0},\t sum = {1}",k,aum);
            }

            Console.Write("\n");
            int flnn = 2;
            int flmm = 10;

            decimal result = 1;

            for (int k = 0; k < flmm; k++ )
            {
                result *= flnn;
            }
            Console.WriteLine("{0}^{1}",flnn,flmm +": "+result);

            Console.WriteLine("\n");

            for (int small = 1, large = 10; small < large; small++,large--)
            {
                Console.WriteLine("{0}\t{1}",small,large);
            }

            // continue operator 

            Console.Write("\n\n            ");
            Console.Write("continue operator \n");
            Console.Write("\n");

            int c_num = 11;
            int kam = 0;

            for (int k = 1; k <= c_num; k +=2)
            {
                 if(k % 7 == 0)
                 {
                     continue;
                 }
                
                 kam += k;
                 Console.WriteLine("sum : " + kam);
            }
            Console.WriteLine("\nsum : "+kam);

            // foreach loop

            Console.Write("\n\n            ");
            Console.Write("foreach loop \n");
            Console.Write("\n");

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach(int k in numbers)
            {
                Console.Write(" " + k);
            }

            Console.Write("\nAddress : ");

            string[] towns = { "Hazi_Para,", "Agrabad,",  "Chittagong,",  "Bangladesh." };

            foreach(string k in towns)
            {
                Console.Write(" " + k);
            }

            // nested Loops
            Console.Write("\n\n            ");
            Console.Write("nested Loops \n");
            Console.Write("\n");


            for (int k = 0; k <= 10;k++ )
            {
                for (int k1 = 0; k1 <= k;k1++ )
                {
                    Console.Write(" "+k1);
                }
                Console.WriteLine();

            }

            Console.Write("\n\n            ");
            Console.Write("Prime Numbers in an Interval – Example \n");
            Console.Write("\n");


            int first = 2, last = 100;
            for(int k = first; k <= last; k++ )
            {
                int divider1 = 2, maxDivider1 = (int)Math.Sqrt(k);
                bool  prime1 = true;
            
            while(divider1 <= maxDivider1)
            {
                if(k % divider1 == 0)
                {
                    prime1 = false;
                    break;
                }
                divider1++;
            }
                if(prime1)
                {
                    Console.WriteLine(" " + k );
                }
        }

            Console.Write("\n\n            ");
            Console.Write("Lucky Numbers – Example \n");
            Console.Write("\n");



            for (int a = 1; a <= 3; a++)
            {
                for (int b = 0; b <= 3; b++)
                {
                    for (int c = 0; c <= 3; c++)
                    {
                        for (int d = 0; d <= 3; d++)
                        {
                            if((a+b)==(c+d))
                            {
                                Console.WriteLine(" "+a+" "+b+" "+c+" "+d);
                            }
                        }
                    }
                }
            }



            Console.Write("\n\n            ");
            Console.Write("Lottery 6/49 – Example \n");
            Console.Write("\n");
















































                Console.Write("\n\n            ");
            Console.Write("");
            Console.Write("\n");

            Console.ReadLine();
        }
    }
