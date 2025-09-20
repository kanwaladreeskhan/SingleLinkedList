using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class SingleLinkedList
    {
        public Node head;// head of list
        public void insertAtStart(int newdata)
        {
            Node fourth = new Node(newdata);
            fourth.next = head;
            head = fourth;
        }
        public void insertAtEnd(int newdata)
        {
            Node newnode = new Node(newdata);
            if (head == null)
            {
                head = new Node(newdata);
                return;
            }
            else
            {
                newnode.next = null;
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = newnode;
                return;
            }
        }
        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(" ==> "+n.data);
                n = n.next;
            }
            Console.WriteLine("\n");
        }
        public void insertAfter(Node prev_node, int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous" +
                                  " node cannot be null");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }
        public void deleteNode(int data)
        {
            if (head == null)
            {
                return;
            }
            if (head.data == data)
            {
                head = head.next;
                return;
            }
            Node temp = head;
            Node prevs = null;
            while (temp != null && temp.data != data)
            {
                prevs = temp;
                temp = temp.next;
            }
            if (temp == null) { return; }
            prevs.next = temp.next;
        }
     }
}
