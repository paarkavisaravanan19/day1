using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application1
{
    internal class assignment3
    {
        public void even_odd()
        {
            separate obj= new separate();
            obj.func_oddeven();
        }
        public class separate
        {
            public void func_oddeven()
            {
                int[] arr1 = new int[5];
                int[] arr2 = new int[5];
                int s1=arr1.Length;
                int s2=arr2.Length;
                int s3=0;
                Console.WriteLine("enter the elements for array 1: ");
                for(int i=0; i<arr1.Length; i++)
                {
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("enter the elements for array 2: ");
                for(int i=0; i<arr2.Length ; i++)
                {
                    arr2[i]=Convert.ToInt32(Console.ReadLine());
                }
                s3=s1+s2;
                int[] arr3= new int[s3];
                int k;
                 for ( k = 0; k < s1; k++)
                {
                    arr3[k] = arr1[k];
                }
                for (int j = 0; j < s2; j++)
                {
                    arr3[k] = arr2[j];
                    k++;
                }
                Console.WriteLine("s3 elements");
                for(int b=0; b<s3; b++)
                {
                    Console.WriteLine(arr3[b]);
                }
                Console.WriteLine("end");
                int[] even=new int[s3];
                int[] odd=new int[s3];

                for(int a=0; a < s3; a++)
                {
                    int s = arr3[a];
                    if ((s%2) == 0)
                    {
                        even[a] = arr3[a];
                    }
                    else
                    {
                        odd[a] = arr3[a];
                    }
                }
                Console.WriteLine("odd elements are: ");
                for (int q=0; q < odd.Length; q++) {
                    Console.WriteLine(odd[q]);
                    

                }
                Console.WriteLine("even elements are: ");
                for (int q = 0; q < even.Length; q++)
                {
                    Console.WriteLine(even[q]);

                }
            }
        }
    }
}
