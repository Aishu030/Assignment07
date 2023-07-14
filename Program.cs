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
            // Create an ArrayList and add elements to it
            ArrayList arrayList = new ArrayList();
            arrayList.Add("apple");
            arrayList.Add("banana");
            arrayList.Add("cherry");
            arrayList.Add("date");
            arrayList.Add("elderberry");

            // Print the total no of elements 
            Console.WriteLine("Total number of elements: " + arrayList.Count);
            Console.WriteLine();

            // prompt user
            Console.Write("Enter an element to check if the arraylist contains it: ");
            string elementToCheck = Console.ReadLine();

            // Check the ArrayList 
            bool containsElement = arrayList.Contains(elementToCheck);
            Console.WriteLine("Does the ArrayList contain '{0}'? {1}", elementToCheck, containsElement);
            Console.WriteLine();

            Console.Write("Enter an element to insert in the ArrayList: ");
            string elementToInsert = Console.ReadLine();
            Console.Write("Enter the position to insert the element (0 - {0}): ", arrayList.Count);
            int positionToInsert = int.Parse(Console.ReadLine());

            arrayList.Insert(positionToInsert, elementToInsert);

            // Prompt the user to enter an element to remove from the ArrayList
            Console.Write("Enter an element to remove from the ArrayList: ");
            string elementToRemove = Console.ReadLine();

            // Remove the user-entered element from the ArrayList
            arrayList.Remove(elementToRemove);

            // Print all the elements
            Console.WriteLine("\nElements in the ArrayList:");
            foreach (var fruit in arrayList)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadLine();
        }
    }

}


