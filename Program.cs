using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reflection.Emit;

namespace application1
{
    internal class Program
    {
         void Main(string[] args)
        {
            /*
            //for loop and initializatio
            Console.WriteLine("Hello Everyone");
            int a = 10;
            int b = (int)20.2;
            for(int i = 0; i < a; i++)
            {
                //Console.WriteLine(a*b/0); ==> shows unchecked exception
                Console.WriteLine(i);
            }*/

            /*
             //if and nested if
             float a = 10;
             int b = (int)20.2;
             for (int i = 0; i < a; i++)
             {
                 if (i == 5 && b >= 0)
                 {
                     if (a / 2 == i)
                     {
                         Console.WriteLine("inside nested-if condn");
                     }
                     else
                     {
                         Console.WriteLine("inside nested-else condn");
                     }
                 }
                 else
                 {
                     Console.WriteLine("else condn");
                 }
             }

                 //while and do-while
                 int j = 0;
                 while(j<=5)
                 {
                     Console.WriteLine(j);
                     j++;
                 }
             int k = 0;
             do
             {
                 Console.WriteLine("inside do while loop");
                 if(k >= 1)
                 {
                     Console.WriteLine("after while condition " + k);
                 }
                 k++;
             }while(k<=5);  */
            //break and
            //goto statements ==> works on c# but java


            /*int c = 0;
            for(c=0; c < 10;c++)
            {
                if (c == 7)
                {
                //break; ==> breaks the loop and exit from the running state
                // continue; ==> skips the current iteration and take the next value into te loop
                

                    goto warning; 
                   
                }
                Console.WriteLine(c);
            warning:  // however tis statement gonna run but goto indicates that to run again (not advisable to use)
                Console.WriteLine("inside label");
            }*/

            /*
            //reading the input from the user:
            Console.WriteLine("enter your age");
            int age= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your entered age is : " + age);
            if(age < 30)
            {
                Console.WriteLine("young champ!! welcome");
            }
            else if(age >= 30)
            {
                Console.WriteLine(":(( getting older");
            }
            else
            {
                Console.WriteLine("specify the correct age in proper format!");
            }
            */
            // function calling using ref and without ref
            /* int a1 = 10;
             Console.WriteLine("before function call: "+a1);
             func1(ref a1);
             Console.WriteLine("after the function call " + a1);
            */

            /*
            //String handling
            string a = "A"; //65   A to Z ==> 65 to 90
            string b = "j"; //   a to z ==> 97 to 122
            //Console.WriteLine(a.Substring(0,5) +" "+ b.ToLower());//substring and lowercase
            Console.WriteLine(string.Concat(a,b)); //concatenation
            Console.WriteLine(string.Compare(a,b, StringComparison.Ordinal)); // 0 ==> identical 1==> a<b (in ascii value -1==> a>b
            bool result = a.Equals(b, StringComparison.OrdinalIgnoreCase); //oridinal tells the difference between specified character in forms of ascii value
            //oridinal ignorecase ==> ignores the upper and lowercase which is in the difference of 32
            Console.WriteLine(result);
            */
            /*string name = Console.ReadLine();
            string demo = "hello and  \"welcome\" everyone";
            Console.WriteLine(demo);
            string exp = $"this is pancake tuesday , welcome {name} have fun";
            Console.WriteLine(exp);*/

            //arrays
            //string[] names = {"Paarkavi", "Kovarthan", "Dwaraka"};
            //Console.WriteLine(names[0]);
            /*Console.WriteLine("length of the string: "+names.Length);
            foreach (string name in names)
            {
                Console.WriteLine(name);
                
            }
            //array declaration
            string[] arr1 = new string[9]; // if the size is known prior
            string[] arr2= new string[3] {"dog","cat","bird"}; //==> 0, 1, 2
            string[] arr3 = { "", "", "" };
            int[] num1 = new int[5];*/

            /* foreach(int i in num1) { 
                 num1[i] = Convert.ToInt32(Console.ReadLine());
             }
             foreach(int i in num1)
             {
                 Console.WriteLine(i);
             }*/

            /*
            for (int i = 0; i < 5; i++)
            {
                //reading array elements from the user   
                num1[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            // accessing array elements using the for loop  
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(num1[i]);
            }
            /*
            int[] num2 = { 12, 24, 67, 89 };
            Console.WriteLine("MAXIMUM : " + num2.Max());
            Console.WriteLine("SUM :" + num2.Sum());
            int number= Convert.ToInt32(Console.ReadLine());
            string res = $"your mark is {number}!";
            Console.WriteLine(res);
            */

            //multidimensional array 
            /*int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 }, { 7,9,0} };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            
            int[,] number = { { 1, 4, 2 }, { 3, 6, 8 } };

            for (int i = 0; i < number.GetLength(0); i++) //==> getlength =?
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    Console.WriteLine(number[i, j]);
                }
            }*/

            /*
            //function 
            Console.WriteLine("Please enter your name: ");
            string your_name=Console.ReadLine();
            Console.WriteLine("Please enter your roll number: ");
            int roll_no=Convert.ToInt32(Console.ReadLine());

            namingfunc(your_name, roll_no);
            //method overloading ==> multiple methods can  have same name with diferent parameters
            */
            /*
            //1D ARRAY
            int[] a1 = { 1, 2, 3 };
            PrintArray(a1);
            //2D ARRAY

            int[,] a3 = new int[3, 3];
            a3[0, 1] = 2;
            int[, ,] a2 = { { { 15, 16, 17 }, { 1, 2, 3 }, { 9, 10, 30 } }, 
                { { 20, 30, 40 }, { 34, 87, 90 }, { 34, 12, 45 } }, 
                { { 45, 56, 78 }, { 87, 90, 43 }, { 8, 2, 1 } } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for(int k=0;k<3;k++)
                    {

                        Console.Write( " index of i : "+i+" index f j: "+j+" index of k: "+k+ " "+a2[i, j, k] + " ");
                        
                    }
                    Console.WriteLine();
                    
                }
                Console.WriteLine();
            }
            */
            //JAGGED ARRAYS
            /*int[][] a4 = new int[2][];
            a4[0] = new int[] { 1, 2 };
            a4[1]= new int[] { 3, 4 };
            for (int i=0;i<a4.Length;i++)
            {
                for(int j=0;j<a4.Length;j++)
                {
                    Console.WriteLine(a4[i][j] );
                }
            }*/



        }

        /*public static void func1(ref int a1) //value will be updated after the execution of the function and reflected outside the function
        {
            a1 = 20;
            Console.WriteLine("inside the function : "+a1);  
        }*/
        /*static void namingfunc(string your_name, int roll_no)
        {
            string name= $"Warm Welcome '{your_name}' , " +
                         $"have a wonderful wednesday! " +
                         $"your rollno. is '{roll_no}'";
            Console.WriteLine(name);
        
        }*/
        /*public static void PrintArray(int[] a1)
        {
           foreach (int i in a1)
            {
                Console.WriteLine(i);
            }
        }*/
        }
    }

