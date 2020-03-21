using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        private double[] coordinates = new double[2];

        private float height;
        private float width;
       public Program()
        {
        }
       public Program(int height, int width)
        {
            this.height = height;
            this.width = width;
        }  

        // Property Declaration of a Field
        public double X
        {
            get { return coordinates[0]; }
            set { coordinates[0] = value; }
        }
        public double Y
        {
            get { return coordinates[1]; }
            set { coordinates[1] = value; }
        }

        // Property without Declaration of a field 
        public float Area                              // Without field diclaration 
        {
            get { return this.height * this.width; }   // just return the height & width value 

        }

        }
}

