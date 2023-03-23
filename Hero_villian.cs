using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application1
{
    internal class Hero_villian
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hero = 1");
            Console.WriteLine("villian = 2");

            int count = 100; // villian bullets
            int count2 = 150; //hero bullets
            Console.WriteLine("Initial bullets with hero: " + count2);
            Console.WriteLine("Intial Bullets with villian " + count);
            string opt = " ";

            do
            {
                Console.WriteLine("press 1 or 2");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        count2 = count2 - 1;
                        Console.WriteLine("bullets with hero : " + count2);
                        break;
                    case 2:
                        count = count - 3;
                        Console.WriteLine("bullets with villian : " + count);
                        break;
                    default:
                        Console.WriteLine("inside default");
                        break;
                }
                Console.WriteLine("do you want to continue? Press yes or no");
                opt = Console.ReadLine();

            } while (string.Equals(opt, "yes"));
            if (string.Equals("no", opt))
            {
                Console.WriteLine("Thanks for playing !");
            }
            if (count > count2)
            {
                Console.WriteLine("villian won");
            }
            if (count < count2)
            {
                Console.WriteLine("hero won");
            }

        }
    }
}
