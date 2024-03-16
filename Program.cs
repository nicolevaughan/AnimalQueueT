using System;
using System.Collections.Generic;

namespace AnimalQueueT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates the animals queue
            Queue<string> animals = new Queue<string>();

            //adding animals
            animals.Enqueue("Dog");
            animals.Enqueue("Cat");
            animals.Enqueue("Hamster");
            animals.Enqueue("Chicken");
            animals.Enqueue("Goat");

            // counts the members in the queue
            Console.WriteLine($"Here are the {animals.Count()} animals in the queue");
            // displays the queue contents without removing anything
            foreach (var a in animals)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("***********************************************************************");
            string firstAnimal = animals.Peek();
            Console.WriteLine("The first animal in the queue is " + (firstAnimal));

            animals.Dequeue();
            Console.WriteLine((firstAnimal) + " has been removed from the queue" );
            Console.WriteLine("***********************************************************************");
            // counts the members in the queue
            Console.WriteLine($"Here are the {animals.Count()} animals in the queue");
            
            // displays the queue contents without removing anything
            foreach (var a in animals)
            {
                Console.WriteLine(a);
            }
        }
    }
}