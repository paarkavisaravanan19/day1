using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application1
{
    internal class stack_queue
    {
        public void calling()
        {
            s_q obj = new s_q();
            obj.stack_queue_func();
        }
        public class s_q
        {
            public void stack_queue_func()
            {


                Console.WriteLine("\nStack");
                Stack<string> stack1 = new Stack<string>();
                stack1.Push("A");
                stack1.Push("B");
                stack1.Push("C");

                string peekvalue;
                while (stack1.Count != 0)
                {
                    Console.Write(stack1.Pop() + " | ");
                    if (stack1.TryPeek(out peekvalue))
                    {
                        Console.WriteLine($"Peak element : {peekvalue}");
                    }


                    Console.WriteLine("\nQueue");

                    Queue<string> queue1 = new Queue<string>();
                    queue1.Enqueue("A");
                    queue1.Enqueue("B");
                    queue1.Enqueue("C");
                    queue1.Enqueue("B");


                    while (queue1.Count != 0)
                    {
                        Console.WriteLine(queue1.Dequeue() + " | ");

                    }

                }

            }
        }
    }
}
