﻿using System;
using System.Collections.Generic;

namespace LinkedListSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListOperations linkedListOperations1 = new LinkedListOperations();
            LinkedListOperations linkedListOperations2 = new LinkedListOperations();

            linkedListOperations1.AddAtHead(70);
            linkedListOperations1.AddAtHead(56);
            linkedListOperations1.DisplayLinkedList();

            linkedListOperations2.AddAtLast(56);
            linkedListOperations2.AddAtLast(30);
            linkedListOperations2.AddAtLast(70);
            linkedListOperations2.DisplayLinkedList();

            int positionOf56th = linkedListOperations1.Search(56);
            int positionOf70th = linkedListOperations1.Search(70);
            if ((positionOf70th - positionOf56th) == 1)
            {
                linkedListOperations1.InsertAtParticularPosition(positionOf56th + 1, 30);
                Console.WriteLine("List after inserting 30 between 56 and 70");
            }
            linkedListOperations1.DisplayLinkedList();

            linkedListOperations1.RemoveFirstNode();
            Console.WriteLine("First List after Deleting Node from first Position");
            linkedListOperations1.DisplayLinkedList();

            linkedListOperations2.RemoveLastNode();
            Console.WriteLine("Second List after Deleting Node from Last Position");
            linkedListOperations2.DisplayLinkedList();

            SortingList<int> sortingList = new SortingList<int>();
            sortingList.AddNode(56);
            sortingList.AddNode(30);
            sortingList.AddNode(40);
            sortingList.AddNode(70);

            Console.WriteLine("Original List ");
            sortingList.DisplaySort();
            sortingList.SortOrderedList();
            Console.WriteLine("Sorted List ");
            sortingList.DisplaySort();

        }
    }
}
