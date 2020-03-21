using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetRectangleArea(5,10));
            PrintLogo();
            PrintLogoforModifiers();

            decimal[] BPrice = new decimal[] {3m,5m,10m,6m };
            PriceOfBooks(BPrice);

            PrintSign(1);

            MaxNumber(10, 19);

            int numberArg = 3;

            PrintNumber(numberArg);

            Console.WriteLine("Number In Main after calling method.{0}",numberArg);

            int[] ArrArg = new int[] {1,2,3,4,5, 15, 18,20 };

            Console.WriteLine("Did not Modify : ");
            PrintArray(ArrArg);

            ModifyArray(ArrArg);

            Console.WriteLine(UsingParams(2,3,4));
            Console.WriteLine(UsingParams(5,6,7));
            Console.WriteLine(UsingParams(8,9,1));

            OptParameterAndNameArgument(1,2,3);
            OptParameterAndNameArgument(2, 3);
            OptParameterAndNameArgument(1);

            OptParameterAndNameArgument(1, y:20);
            OptParameterAndNameArgument(1,z:50);
            OptParameterAndNameArgument(1, z:50,y:20);
            OptParameterAndNameArgument(z:5,y:6,x:4);

            Console.ReadLine();
        }

        //  What is a "Method" ? :: 1st Example 
        static double GetRectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }

        // Method Name :: Example 2
        static void PrintLogo()
        {
            Console.WriteLine("Microsoft.");
            Console.WriteLine("WWW.Microsoft.com");
        }

        // Modifiers :: Example 3
        public static void PrintLogoforModifiers()
        {
            Console.WriteLine("Microsoft.");
            Console.WriteLine("WWW.Microsoft.com");
        }

        // Method to Calculate the Sum of Prices of Books – Example 4
        static void PriceOfBooks(decimal[] price)
        {
            decimal totalAmount = 0;

            foreach(decimal singlePrice in price)
            {
                totalAmount += singlePrice;
            }

            Console.WriteLine("Total amount of books : {0}",totalAmount);
        }

        //Method to Show whether a Number is Positive – Example 5
        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Posetive Number.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative Number.");
            }
            else
                Console.WriteLine("Zero");

        }

        // the method needs two parameters - Example 6

        static void MaxNumber(int num1, int num2)
        {
            
            int Max = (num1 > num2 ? num1 : num2);

            Console.WriteLine(Max);
        }

        // Passing Arguments of a Primitive Type - Example 7

        static void PrintNumber(int number)
        {
            int num = 5;

            Console.WriteLine("Number In Method {0}",num);
        }

        // Passing Arguments of Reference Type - Example 8
        static void PrintArray(int[] arrayParm)
        {
            Console.Write("[ ");
            for (int i = 0; i < arrayParm.Length; i++ )
            {
                Console.Write("{0},",arrayParm[i]);
            }
            Console.Write("]\n");
        }

        static void ModifyArray(int[] arrayParm)
        {
            arrayParm[0] = 100;
            Console.WriteLine("In ModifyArray() the arryParm Is : ");
            PrintArray(arrayParm);
        }

        // How to Declare Method with Variable Number of Arguments (using params) - Example 9

         static int UsingParams(params int[] numbers)
        {
            int total = 0;

             foreach(int number in numbers)
             {
                 total += number;
             }

            return total;
        }

        // Optional Parameters and Named Arguments - Example 10 

        static void OptParameterAndNameArgument(int x, int y = 10, int z = 5)
         {
             int sum = x + y + z;
             Console.WriteLine("sum : " + sum);

         }


    }

