using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application1
{
    internal class LinkedList
    {
        public class ll
        {
            public void func()
            {
                var myLinkedList = new LinkedList<int>();
                myLinkedList.AddLast(1);
                myLinkedList.AddLast(2);
                myLinkedList.AddLast(3);
                myLinkedList.AddLast(1);
                myLinkedList.AddLast(2);
                myLinkedList.AddLast(4);
                myLinkedList.AddLast(5);
                myLinkedList.AddLast(6);

                
                LinkedListNode<int> node = myLinkedList.Find(2);
                LinkedListNode<int> node1 = myLinkedList.FindLast(2);
                myLinkedList.AddBefore(node, 10);
                myLinkedList.AddBefore(node1, 10);
               


            }
        }
    }
}
