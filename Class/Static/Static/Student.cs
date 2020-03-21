using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Student
    {
        int roll;
        double _marks;

        static int schoolCode = 555;


        public double Marks(int Bangla, int English)
        {
             this._marks = Bangla + English;
             return _marks;
        }

        static void Main(string[] args)
        {
           
            Student id = new Student();

            id.roll = 1;

            Console.WriteLine("School Code " + Student.schoolCode);
            Student.schoolCode = 10;
            Console.WriteLine("School Code " + Student.schoolCode); 


            Student id2 = new Student();
            Console.WriteLine(id2.roll);

            Console.ReadLine();





        }
    }
}
