using System;
using System.Collections.Generic;

namespace Collections_Lists
{
    class Program
    {
        static void display(List<string> arr)
        {
            Console.WriteLine("Displaying string");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void display(List<int> arr)
        {
            Console.WriteLine("Displaying int");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 100, 200, 300 };
            string[] city = { "lahore", "karachi", "pindi" };

            var myList1 = new List<string>();

            myList1.Add("wamik");
            myList1.Add("afaq");
            myList1.Add("umair");
            myList1.Add("askari");

            var myList2 = new List<int>
            {
                1, 2, 3, 4
            };

            myList2.AddRange(arr);

            Console.WriteLine("--------------------------------------------------First iteration--------------------------------------------------");
            display(myList1);
            display(myList2);

            myList1.Insert(1, "Ihtisham");
            myList1.InsertRange(5, city);

            Console.WriteLine("--------------------------------------------------Second iteration--------------------------------------------------");
            display(myList1);

            myList1.Remove("wamik");
            myList1.RemoveRange(0, 4);

            Console.WriteLine("--------------------------------------------------Third iteration--------------------------------------------------");
            display(myList1);

           Console.WriteLine(myList1.Contains("wamik"));
            
            myList1.Reverse();
            myList2.Reverse();

            Console.WriteLine("--------------------------------------------------Fourth iteration--------------------------------------------------");
            display(myList1);
            display(myList2);
        }
    }
}
