using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            doListDemo();
            doStackDemo();
            doQueueDemo();
            doSetDemo();
            doDictionaryDemo();
        }


        private static void doDictionaryDemo()
        {
            Console.WriteLine("In doDictionaryDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");

            Console.WriteLine("Access value using key(key=100): " + dictionary[100]);
            Console.WriteLine("Iterating Dictionary");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key : " + element.Key + " Value :" + element.Value);
            }
        }
        private static void doSetDemo()
        {
            Console.WriteLine("In doSetDemo");

            var set = new HashSet<string>();

            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");

            foreach (var element in set)
            {
                Console.WriteLine(element);
            }
        }
        private static void doQueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay");
            queue.Enqueue("Jaishankar");
            queue.Enqueue("Raj");
            Console.WriteLine("Head: " + queue.Peek());
            Console.WriteLine("Iterating the queue elements: ");

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }

            string dequeue = queue.Dequeue();

            Console.WriteLine("Dequeue element :" + dequeue);
            Console.WriteLine("Iterating the queue elements");

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }

        }

        private static void doStackDemo()
        {
            Console.WriteLine("In doStackDemo");

            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvi");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");

            string pop = stack.Pop();

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poppped element: " + pop);

        }

        private static void doListDemo()
        {
            Console.WriteLine("In doListDemo");

            List<string> list = new List<string>();

            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}