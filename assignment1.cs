using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application1
{
    internal class assignment1
    {
        public void func1()
        {
            dupli_removal obj= new dupli_removal();
            obj.func();
        }

        public class dupli_removal
        {
            int[] array = new int[] { 12,34,67,12,34,71,67,12} ;
            public void func()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    var dict = new Dictionary<int, int>();
                    foreach (var value in array)
                    {
                        if (dict.ContainsKey(value)) 
                            dict[value]++;
                        else 
                            dict[value] = 1;
                    }
                    foreach (var pair in dict)

                        if (pair.Value > 1)
                        {
                            Console.WriteLine("Value {0} occurred {1} times", pair.Key, pair.Value);
                        }
                    Console.ReadKey();
                }

            }
            
        }


        /*
    
foreach (var pair in dict)
    Console.WriteLine("Value {0} occurred {1} times", pair.Key, pair.Value);
Console.ReadKey(); */

    }

    
}
