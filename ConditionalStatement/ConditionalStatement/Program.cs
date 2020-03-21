using System;

    class Program
    {
        static void Main(string[] args)
        {

            int weight = 700;
            Console.WriteLine(weight >= 500); //True
            
            char gender = 'm';
            Console.WriteLine(gender <= 'f'); // False

            double colorWaveLangth = 1.630;
            Console.WriteLine(colorWaveLangth > 1.621); // True

            int a = 5, b = 7;
            bool condtion = (b > a) && (a + b < a * b); // True
            Console.WriteLine(condtion);

            Console.WriteLine('B' == 'A' + 1); // True

            Console.WriteLine("char 'a' == 'a' ? " + ('a' == 'a'));  //true
            Console.WriteLine("char 'a' == 'b' ? " + ('a' == 'b'));  // false
            Console.WriteLine("5 != 6 ? " + (5 != 6));  //true
            Console.WriteLine("5.0 == 5L ? " +(5.0 == 5L));  // true
            Console.WriteLine("true == false ? " + (true == false)); // false

                             // Comparison of References to Objects
            string str = "beer";
            string anotherStr = str;
            string thirdStr = "bee";

            thirdStr = thirdStr + 'r';
            Console.WriteLine("str = {0} ", str);
            Console.WriteLine("anotherStr = {0} ", anotherStr);
            Console.WriteLine("thirdStr = {0} ", thirdStr );

            Console.WriteLine(str == anotherStr);
            Console.WriteLine(str == thirdStr);

            Console.WriteLine((object)str == (object)anotherStr);
            Console.WriteLine((object)str == (object)thirdStr);     // Vary Vary Important

            // conditional statement "if" Example :

            int first = 3;
            Console.WriteLine("Enter First Number : {0}",first);
             

             int second = 4;
            Console.WriteLine("Enter Second Number : {0} ",second);
            

            int biggerNumber = first;

            if(first < second)
            {
                biggerNumber = second;
            }
            Console.WriteLine("Bigger Number is {0}.",biggerNumber);

            // conditional statement "if-else" Example :

            int x = 2;

            if(x>3)
            {
                Console.WriteLine("X is grater than 3.");
            }
            else
            {
                Console.WriteLine("x is not grater than 3");
            }

            // Nested "if" Statements – Example

            if (first == second)
            {
                Console.WriteLine("These two numbers are equal.");
            }
            else
            {
                if (first > second)
                {
                    Console.WriteLine("The first number is greater.");
                }
                else
                {
                    Console.WriteLine("The second number is greater.");
                }
            }


            // Sequences of "if-else-if-else-…" 

            char ch = 'X';
            if (ch == 'A' || ch == 'a')
            {
                Console.WriteLine("Vowel [ei]");
            }
            else if (ch == 'E' || ch == 'e')
            {
                Console.WriteLine("Vowel [i:]");
            }
            else if (ch == 'I' || ch == 'i')
            {
                Console.WriteLine("Vowel [ai]");
            }
            else if (ch == 'O' || ch == 'o')
            {
                Console.WriteLine("Vowel [ou]");
            }
            else if (ch == 'U' || ch == 'u')
            {
                Console.WriteLine("Vowel [ju:]");
            }
            else
            {
                Console.WriteLine("Consonant");
            }

            // 


            Console.WriteLine();
            Console.ReadLine();
        }
    }

