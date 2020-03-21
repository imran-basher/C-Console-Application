using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsOperations
{
    class Program1
    {
        static void Main(string[] args)
        {
            // Comparison for Equlity 

            Console.WriteLine("\nComparison for Equlity ::\n");

            string word1 = "C#";
            string word2 = "c#";

            Console.WriteLine(word1.Equals("C#"));
            Console.WriteLine(word2.Equals(word1));

            Console.WriteLine("word1 == \"c#\" : {0}", word1 == "c#");
            Console.WriteLine("word1 == \"C#\" : {0}", word1 == "C#");
            Console.WriteLine("word1 == word2 : {0}", word1 == word2);

            Console.WriteLine("\n\nUsing  \"word1.Equals(word2,StringComparison.CurrentCultureIgnoreCase)\" \n");
            Console.WriteLine(word1.Equals(word2,StringComparison.CurrentCultureIgnoreCase));


            // Comparing strings in Alphabetical order

            Console.WriteLine("\n\nComparing strings in Alphabetical order : \n");

            string score = "sCore";
            string scary = "scary";

            Console.WriteLine(score.CompareTo(scary));  // 2nd string(scary) is lexicographically before 1st(sCore)

            Console.WriteLine(scary.CompareTo(score)); // 1st string(sCore) is lexicographically before 2nd(scary)

            Console.WriteLine(scary.CompareTo(scary)); // Two string are Equal.

            // Using Compare() Method

            Console.WriteLine("\n\nUsing Compare() Method : \n");

            string alpha = "alpha";
            string score1 = "sCorE";
            string score2 = "score";

            Console.WriteLine(string.Compare(alpha,score1));
            Console.WriteLine(string.Compare(score1,score2,false));
            Console.WriteLine(string.Compare(score1,score2,true));
            Console.WriteLine(string.Compare(score1,score2,StringComparison.CurrentCultureIgnoreCase));

            // Memory optimization for strings(Interning)
            Console.WriteLine("\n\n-->Memory optimization for strings(Interning)\n");
            string name = "Imran";
            string FName = "Imran";

 /*  String Interning :: Memory Optimization n the C# compiler and in CLR, which saves the memory from  
                         creating duplicated strings. This optimization is called STRING INTERNING.
 */
            // using Intern() method

            Console.WriteLine("\n\n--> using Intern() method ::  \n");

            string declared = "Intern Pool";
            string built = new StringBuilder("Intern Pool").ToString();
            string interned = string.Intern(built);
            string sum = string.Intern(declared);

            Console.WriteLine(object.ReferenceEquals(declared, built));
            Console.WriteLine(object.ReferenceEquals(declared,interned));
            Console.WriteLine(object.ReferenceEquals(built,interned));
            Console.WriteLine(object.ReferenceEquals(interned,sum));
            Console.WriteLine(object.ReferenceEquals(built,sum));




            Console.ReadLine();
        }
    }
}
