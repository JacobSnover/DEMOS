using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList
{
    class LinkedList
    {
        private Node head;
        private Node current;//This will have latest node
        public int Count;

        public LinkedList()
        {
            head = null;
            current = null;
            Count = 0;
        }

        public void AddAtStart(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;

            //first time--list is empty if (head == null)
            if (head == null)
            {
                newNode.Next = null;

                //only one node--both the start (head) and end (current)
                head = newNode;
                current = newNode;
            }
            else //not my first rodeo
            {
                newNode.Next = head;
                head = newNode;
                //current is correct--don't change
            }
            //could reset head = newNode here
            Count++;
        }

        public void AddToEnd(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            newNode.Next = null; //its actually null by default

            //firts time
            if (head == null)
            {
                //only one node-- both the start (head) and end (current)
                head = newNode;
                //tell the list is its last(current)
                current = newNode;
            }
            else//every other time (list has something)
            {
                current.Next = newNode;
                current = newNode;
            }
            Count++;
        }
        public void RemoveFromStart()
        {
            //TODO: what if we remove the only element on the list?
            if (Count == 1)
            {
                //back to an empty list
                head = null;
                current = null;
                Count = 0;

            }
            else if (Count > 1)
            {
                head = head.Next;

            }
            else
            {
                //really we want to throw an exception here
                Console.WriteLine("No elements in list");
            }
        }
        public void PrintAllNodes()
        {
            //go through all nodes-- start at the first node
            //console.writeline the nodes value
            //go to the next node

            Node thisNode = head;
            while (thisNode != null)
            {
                Console.WriteLine(thisNode.Value);
                thisNode = thisNode.Next;
            }
        }
        public void RemoveAll(object value)
        {
            //int i = 0;
            //i++;
            //while (i < list.Count)
            //{
            Node thisNode = /*(Node)*//*list.*/head;
            //thisNode.Value = list.head.Value;

            while (thisNode.Next != null /*&& thisNode.Value == value */&& Count >= 1)
            {
                if (thisNode.Next.Value == value)
                {
                    thisNode.Next = thisNode.Next.Next;
                }
                else
                {
                    thisNode = thisNode.Next;
                }

            }
            //    thisNode = thisNode.Next;

            ////thisNode = thisNode.Next;
            // }
            //    thisNode.Next = thisNode.Next.Next;

            //if (list.head.Value == value)
            //{

            // 
            //}
        }
    }
}
