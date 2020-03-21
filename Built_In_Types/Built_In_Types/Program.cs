using System;
    class Program
    {
        static void Main()
        {
            bool b = true;
            bool b1 = false;

            Console.WriteLine("b : {0} \nb1 : {1} ",b,b1);

            //sbyte 	-128 to 127 	Signed 8-bit integer

            sbyte sb = -126;

            Console.WriteLine("\n sbyte Minimum Value {0} \nsbyte maximum value {1}", sbyte.MinValue, sbyte.MaxValue);

            //byte 	0 to 255 	Unsigned 8-bit integer

            byte by = 255;
            Console.WriteLine("\nbyte  Minimum Value {0} \nbyte maximum value {1}", byte.MinValue, byte.MaxValue);


            //char 	U+0000 to U+ffff 	Unicode 16-bit character
                char ch = 'A';
               Console.WriteLine(" The code of {0} is : {1}\n char Minimum Value {2} \nchar maximum value {3}",ch, (int)ch, char.MinValue, char.MaxValue);


            //short 	-32,768 to 32,767 	Signed 16-bit integer
                short sh = 0x40A;
               Console.WriteLine("\n short Minimum Value {0} \nshort maximum value {1}", short.MinValue, short.MaxValue);

            //ushort 	0 to 65,535 	Unsigned 16-bit integer
                ushort ush = 65000;
               Console.WriteLine("\n ushort Minimum Value {0} \nushort maximum value {1}", ushort.MinValue, ushort.MaxValue);

            // int 	-2,147,483,648 to 2,147,483,647 	Signed 32-bit integer

            int i = 0;

            Console.WriteLine("\n int Minimum Value {0} \nint maximum value {1}", int.MinValue, int.MaxValue);


            //uint 	0 to 4,294,967,295 	Unsigned 32-bit integer
                uint ui = 4000000064;
               Console.WriteLine("\n uint Minimum Value {0} \nuint maximum value {1}", uint.MinValue, uint.MaxValue);

            //long 	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 	Signed 64-bit integer
                long lo = -7854210;
               Console.WriteLine("\nlong  Minimum Value {0} \nlong maximum value {1}", long.MinValue, long.MaxValue);

            //ulong 	0 to 18,446,744,073,709,551,615 	Unsigned 64-bit integer
                ulong ul = 18446744073709551615;
               Console.WriteLine("\n ulong Minimum Value {0} \nulong maximum value {1}", ulong.MinValue, ulong.MaxValue);

           
            // float 
               float fl = 3.564F;
               Console.WriteLine("\nFloat Minimum Value : {0}\nFloat maximum Value {1}",float.MinValue,float.MaxValue);

            // double 
               double d = 5.7;
               double d1 = 5d;
               Console.WriteLine("\nDouble Minimum Value : {0}\nDouble maximum Value {1}", double.MinValue, double.MaxValue);

            //decimal
               decimal myMoney = 11.1m;
               decimal myMoney1 = 11;
               Console.WriteLine("\nDecimal Minimum Value : {0}\nDecimal maximum Value {1}", decimal.MinValue, decimal.MaxValue);
            // String 
               string F_Name = "Imran";
               string L_Name = "Basher";
               string FullName = F_Name + " " + L_Name;
               Console.WriteLine("\nHey "+ F_Name + "!");
               Console.WriteLine("\nYour Full Name is "+ FullName + ".");

            // Escape sequence in string  

               string name = "\"Imran\"";
               Console.WriteLine(name); 
              string fullName = "Imran\nBasher\nPoni";
              Console.WriteLine(fullName);

              string location = "E:\\C# 2019\\Video practice";
              Console.WriteLine(location);
            
            //Verbatim Literal 

              string Locat = @"E:\\C# 2019\\Video practice";

              Console.WriteLine(Locat);


            Console.Read();
        }
    }
