using System;
  class Program
    {
        static void Main(string[] args)
        {
  // Assignment Operators  (=)

            int a = 5;
            int b = 10;
            int c = 15;

  // Arithmatic Operator ( +, -, *, /, % )
            
            int d = a + b + c;                  //Addition
            Console.WriteLine("d = {0} \n",d);

            int e = d - b - c;                  // Subtraction 
            Console.WriteLine("e = {0} \n", e);

            int f = d * e;                      // Multiplication
            Console.WriteLine("f = {0} \n", f);

            float g = (float)f / (float)b;      // Division 
            Console.WriteLine("g = {0} \n", g);

            float h = g % 2;                     // Modulus
            Console.WriteLine("h = {0} \n", h);


            int squareParimeter = 17;

            double squareSide = squareParimeter / 4.0;
            double squareArea = squareSide * squareSide;

            Console.WriteLine(squareSide);
            Console.WriteLine(squareArea);

            int ii = 5;

            int ii1 = 4;

            Console.WriteLine(a+b);
            Console.WriteLine(a+(b++));

            Console.WriteLine(a+b);
            Console.WriteLine(a+(++b));

            Console.WriteLine(a+b);
            Console.WriteLine(14/a);
            Console.WriteLine(14%a);


   // Comparison Operators

            Console.WriteLine(DateTime.Now);

    // Logical operator :
            Console.WriteLine("\n\n------- Logical operator----------\n\n");

            bool a1 = true;
            bool b1 = false;

            

            Console.WriteLine("a1 && b1 : {0} \n" , a1 && b1);
            Console.WriteLine("a1 || b1 : {0} \n" , a1 || b1);
            Console.WriteLine("!b1 : {0} \n", !b1);
            Console.WriteLine("b1 || true : {0} \n", b1 || true);
            Console.WriteLine("(5>7)^(a == b) : {0} \n", (5 > 7) ^ (a == b));

            // De Morgans Law :

            Console.WriteLine("\n\n- _ De Morgans Law _ -\n\n");

            Console.WriteLine(" !(a1 && b1) : {0} \n", !(a1 && b1));
            Console.WriteLine(" (!a1 || !b1) : {0} \n", (!a1 || !b1));
            Console.WriteLine("That means !(a1 && b1) == (!a1 || !b1)  are equivalent. ");

            Console.WriteLine("\n\n !(a1 || b1) : {0} \n", !(a1 || b1));
            Console.WriteLine(" (!a1 && !b1) : {0} \n", (!a1 && !b1));
            Console.WriteLine("That means !(a1 || b1) == (!a1 && !b1)  are equivalent. ");

            // Operator for concatenation of the strings :
            Console.WriteLine("\n\n------- Operator for concatenation of the strings----------\n\n");
		
		    string csharp = "C#";
		    string dotnet = ".NET";
		
		    string csharpdotnet = csharp + dotnet;
		    Console.WriteLine(csharpdotnet);
		
		    string csharpdotnet4 = csharpdotnet + " " + 4 ;
		    Console.WriteLine(csharpdotnet4);

           // Bitwise operator 

            byte ba = 3;
            byte bb = 5;
            Console.WriteLine("\n\t(ba | bb) : " + (ba|bb));
            Console.WriteLine("\n\t(ba & bb) : " + (ba & bb));
            Console.WriteLine("\n\t(ba ^ bb) : " + (ba ^ bb));
            Console.WriteLine("\n\t( ~ba & bb) : " + (~ba & bb));
            Console.WriteLine("\n\t(ba << 1) : " + (ba << 1));
            Console.WriteLine("\n\t(ba << 2) : " + (ba << 2));
            Console.WriteLine("\n\t(ba >> 1) : " + (ba >> 1));

            // Conditional operator :

            int ca = 6;
            int cb = 4;


            if (ca > cb)
            {
                Console.WriteLine("\n ca > cb ");
            }
            else
            {
                Console.WriteLine("\n cb <= ca ");
            }

            // This is short form of if else

            Console.WriteLine("\n (ca>cb ? \"ca>cb\" : \"cb<=ca\") : " + (ca > cb ? "ca>cb" : "cb<=ca")); 

            int num = ca == cb ? 1 : -1;
            Console.WriteLine(" num :" + num);

            // Nullable 

            string name = null;   // string accept null value

            //int number = null;  // but int not accept null value
            // By default value types are non nullable.  To make them nullable use "?" mark after int 

            int? number = null;

            int? ticketOnSale = null;

            int AvaialableTickets; 

            if(ticketOnSale == null)
            {
                AvaialableTickets = 0;
            }
            else
            {
                AvaialableTickets =  ticketOnSale.Value ; 
            }

            Console.WriteLine("AvaialableTicket : {0}",AvaialableTickets);

            int availTicket = ticketOnSale ?? 0;
            Console.WriteLine("AvaialableTicket : {0}", availTicket);

            Console.WriteLine(ticketOnSale ?? 0);


            // Implicite conversion
            Console.WriteLine("\n\n---Implicite conversion----\n\n");
            int myint = 5;
            Console.WriteLine("int = {0}",myint);

            long mylong = myint;
            Console.WriteLine("long : {0}",mylong);

            Console.WriteLine("int + long : {0}", mylong+myint);

            // Explicite conversion

            Console.WriteLine("\n\n---Explicite conversion----\n\n");

            double mydouble = 5.1d;
            Console.WriteLine("double : {0}",mydouble);

            long mylong1 = (long)mydouble;
            Console.WriteLine("Long : {0}",mylong1);

            mydouble = 5e9d;
            Console.WriteLine("double : {0}",mydouble);

            int myInt = (int)mydouble;
            Console.WriteLine("myInt : {0}", myInt);

            Console.WriteLine("int Minimum Value : {0}", int.MinValue);

            // Data lost during type conversion 

            float hightInMeters = 1.74f;
            double maxHight = hightInMeters;
            double minHight = (double)hightInMeters;
            float actualHight = (float)maxHight;

           // float maxHightFloat = maxHight; ////compiler error
            float maxHightFloat = (float)maxHight;

            // Forcing Overflow Exception during casting 

            double dub = 5e9d;
            Console.WriteLine("dub : {0}",dub);

            //int int1 = checked((int)dub);
            // Console.WriteLine("int : {0}",int1);

            // Conversion to string 

            int intA = 5;
            int intB = 7;

            string sum = "Sum = "+ (intA + intB);
            Console.WriteLine(sum);


            string incorrect = "Sum = " + a + b;
            Console.WriteLine(incorrect);

            int intstring = Convert.ToInt32 (sum);
            Console.WriteLine(" intstring : ",intstring);

            Console.WriteLine("Perimeter = " + 2 * (intA + intB) + ".\n Area = " + (intA * intB) + ".");

            Console.ReadLine();
        }
    }
