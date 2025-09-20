using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            list.head=new Node(1); 
            Node second= new Node(232);
            Node third= new Node(33);
            list.head.next=second;// link second node with first node
            second.next=third;// Link second node with third
            Console.WriteLine("=====Traversing=====");
            list.printList();
            Console.WriteLine("=====Insertion at Start of list=====");
            list.insertAtStart(4);
            list.printList();
            Console.WriteLine("=====Insertion at End of list=====");
            list.insertAtEnd(5);
            list.printList();
            Console.WriteLine("=====Insertion after any node=====");
            list.insertAfter(second,9);
            list.printList();
            Console.WriteLine("=====Deletion=====");
            list.deleteNode(232);
            list.printList();
            Console.ReadKey();

        }
    }
}
