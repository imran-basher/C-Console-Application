using System;

    class Program
    {
        static void Main()
        {
            printNumber(7, 5.5f);

            printNumber(8.7f, 4);

            printNumber((float)7, (short)5);
            
            int n = 5;
            for (int i = 1; i <= n;i++ )
            {
                Triangle(1,i);
            }

            for (int i = n - 1; i >= 1;i-- )
            {
                Triangle(1, i);
            }


            Console.ReadLine();
        }

        // Overloaded Methods Invocation - Example 10

        static void printNumber(int IntValue, float FloatValue)
        {
            Console.WriteLine(IntValue+"  "+FloatValue);
        }

        static void printNumber(float FloatValue, int IntValue)
        {
            Console.WriteLine( FloatValue +"  "+ IntValue  );
        }

        //Triangles with Different Size – Example 11

        static void Triangle(int start, int end)
        {
                for (int j=start; j <=end; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
        }




    }

