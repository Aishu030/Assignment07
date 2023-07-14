using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //DAY05
                //ASSIGNMENT 07
                // Creating an ArrayList
                ArrayList myList = new ArrayList();
                myList.Add("apple");
                myList.Add("banana");
                myList.Add("cherry");
                myList.Add("date");
                myList.Add("elderberry");

                // Print total no. of elements
                Console.WriteLine("Total number of elements in the ArrayList: {0}", myList.Count);

                // Check if the ArrayList contains the element "date" and print the result....
                bool containsDate =myList.Contains("date");
                Console.WriteLine("ArrayList contains 'date': {0}", containsDate);

                // Insert the element "fig" at the second position in the ArrayList...
                myList.Insert(1, "fig");

                // Remove the element "banana" from the ArrayList.....
                myList.Remove("banana");

                // Print all the elements in the ArrayList using a loop......
                Console.WriteLine("Elements in the ArrayList:");
                foreach (var fruit in myList)
                {
                    Console.WriteLine(fruit);
                }
                Console.ReadKey();  
            }
        }

    }


