using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application1
{
    internal class struct_and_class
    {

        public void triangle()
        {
            demo de= new demo();

            Console.WriteLine("enter the side1: ");
            de.side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the side2 : ");
            de.side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the side3 : ");
            de.side3 = Convert.ToInt32(Console.ReadLine());
            int perimeter = de.side1+de.side2+ de.side3;
            Console.WriteLine("perimeter of triangle: "+perimeter);
        }

        public struct demo
        {
            public int side1;
            public int side2;
            public int side3;
        }
    
    }
}
