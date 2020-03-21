using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class InheritedFromPoint : Program
    {
        static void Main()
        {
            Program point = new Program();
            point.X = 20.0;
            point.Y = 30.0;
            Console.WriteLine("Coordinate x : " + point.X  + " Coordinate y : " + point.Y);

            Program Rectangle = new Program(5, 3);
            Console.WriteLine("The Rectangle : "+ Rectangle.Area);


            Console.ReadLine();

        }



    }
}
