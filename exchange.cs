using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application1
{
    //Write a C# Sharp program to exchange the first and last characters in a given string and return the new string
    internal class exchange
    {
        public void demo()
        {
            exchange_letters obj= new exchange_letters();
            obj.func();

        }
    }
    public class exchange_letters
    {
        public void func()
        {
            Console.WriteLine("enter a string :");
            string name= Console.ReadLine();
            Console.WriteLine("your entered string is: " + name);
            int len= name.Length;
            Console.WriteLine("enter a first character to change :");
            char a1 = Console.ReadLine()[0];
            Console.WriteLine("enter a second character to change :");
            var a2 = Console.ReadLine()[0];
            string name1=name.Replace(name[0], a1);
            string name2= name1.Replace(name[len -1 ], a2);
            Console.WriteLine("string after first letter alteration: "+name1);
            Console.WriteLine("string after last letter alteration: "+name2);


            //second problem 
            Console.WriteLine("after adding front and back of the given string: ");
            var second= name.Substring(name.Length - 1);
            string final = second + name + second;
            Console.WriteLine("string is : "+final);





        }
    }
}
