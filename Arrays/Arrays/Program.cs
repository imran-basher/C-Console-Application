using System;
    class Program
    {
        static void Main()
        {
            // reversing an array

            int[] arr = {1,2,3,4,5,6 };

            int[] reverse = new int[6];

            for(int i=0; i<arr.Length;i++)
            {
                reverse[arr.Length - i - 1] = arr[i];
            }

            for (int i = 0; i < arr.Length;i++)
            {
                Console.Write(reverse[i]);
                Console.Write(" ");
            }

                   // Reading an Array from the Console - Example

            /*
            string[] FN = new string[2];
            string[] LN = new string[2];

            for (int i = 0; i < FN.Length;i++ )
            {
                Console.Write("\nEnter Your First Name : ");
                FN[i] = Console.ReadLine();

                Console.Write("\nEnter Your Last Name : ");
                LN[i] = Console.ReadLine();
            }
            for (int i = 0; i <LN.Length; i++)
            {
                Console.WriteLine(FN[i] +"\n"+LN[i]);
            }
            */
              
            // Check for Symmetric Array – Example
            /*
            int n = 7;

            int[] numbers = new int[n];

            Console.Write("\n\nEnter Numbers : ");

            for (int i = 0; i < n;i++ )
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            bool Symetric = true;

            for (int i = 0; i < n / 2;i++)
            {
                if(numbers[i] != numbers[n-i-1])
                {
                    Symetric = false;
                    break;
                }
            }

            Console.WriteLine("Is Numbers are Symetric ?? : {0}",Symetric);
            */

            Console.WriteLine(" ");
            //Iteration with a for Loop

            int[] num = new int[] { 1,2,3,4,5};

            for (int i = 0; i < num.Length;i++ )
            {
                Console.Write(num[i] + " ");
                num[i] = 2 * num[i];
                
            }
            Console.WriteLine(" ");
            for (int index = 0; index < num.Length; index++)
            {
                Console.Write(num[index] + " ");
            }

            // more Example ::
            Console.WriteLine(" ");
            int[] digit = new int[] { 1,2,3,4,5};
            for (int index = 0; index < digit.Length;index++)
            {
                digit[index] = digit[index] * digit[index];

                Console.Write(digit[index] + " ");
            }

            // more Example :: Reverse

            Console.WriteLine();

            int[] number = new int[] { 1,2,3,4,5};

            for (int i = number.Length - 1; i >= 0; i-- )
            {
                Console.Write(number[i]+ " ");
            }

            //"foreach" Loop – Example

            Console.WriteLine();

            string[] info = {"Imran","Basher","01781619408","Hazipara","Chittagong" };
            foreach(string information in info)
            {
                Console.WriteLine(information);
            }

            // Maximal Platform in a Matrix – Example

            int[,] matrix = 
            {
                {0,2,4,0,9,5},
                {7,1,3,3,2,1},
                {1,3,9,8,5,6},
                {4,6,7,9,1,0}
            };

            long bestSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                Console.Write("Row :{0}\n",row);
                Console.Write("-------\n");

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    Console.Write("Colmn :{0} \n ", col);
                    Console.Write("matrix[{0}][{1}] : {2}  ", row, col,matrix[row, col]);
                    Console.Write("\tmatrix[{0}][{1}] : {2}  ", row, col+1, matrix[row, col + 1]);
                    Console.Write("\tmatrix[{0}][{1}] : {2}  ", row+1, col, matrix[row + 1, col]);
                    Console.Write("\tmatrix[{0}][{1}] : {2}  ", row+1, col+1, matrix[row + 1, col + 1]);
                    Console.WriteLine("");

                    long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    Console.Write("\nSum ==>> {0}\n\n",sum);

                            if (sum > bestSum)
                            {
                                bestSum = sum;
                                bestRow = row;
                                bestCol = col;
                            }
                }

                Console.WriteLine("\n\n");
            }

            Console.WriteLine("The best platform is:");
            Console.WriteLine(" {0} {1}",matrix[bestRow, bestCol],matrix[bestRow, bestCol + 1]);

            Console.WriteLine(" {0} {1}",matrix[bestRow + 1, bestCol],matrix[bestRow + 1, bestCol + 1]);
            Console.WriteLine("The maximal sum is: {0}", bestSum);


            // Pascal’s Triangle – Example


            const int height = 12;

            long[][] traingle = new long[height + 1][];

            for (int row = 0; row < height;row++ )
            {
                traingle[row] = new long[row + 1];
            }

            traingle[0][0] = 1;

            for (int row = 0; row < height - 1;row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    traingle[row + 1][col] = traingle[row + 1][col] + traingle[row][col];
                    traingle[row + 1][col+1] = traingle[row + 1][col+1] + traingle[row][col];
                }
            }

            for (int row = 0; row < height;row++ )
            {
                Console.Write("" .PadLeft((height-row)*2));
                for (int col = 0; col <= row; col++ )
                {
                    Console.Write("{0,3} ", traingle[row][col]);
                }
                Console.WriteLine();
            }











                Console.ReadLine();
        }
    }

