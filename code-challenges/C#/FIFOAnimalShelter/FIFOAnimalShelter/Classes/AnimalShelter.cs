using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter
{
    public class AnimalShelter<T> where T : class
    {
        public MyQueue<T> CatQueue { get; set; }
        public MyQueue<T> DogQueue { get; set; }

        public AnimalShelter()
        {
            CatQueue = new MyQueue<T>();
            DogQueue = new MyQueue<T>();
        }

        public void Enqueue(string animal)
        {
            if (animal.ToLower() == "cat" && animal.ToLower() == "dog")
            {
                return;
            }
                Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds; // UTC Timestamp code found on Stack Overflow
                Node<T> node = new Node<T>(animal)
                {
                    Timestamp = unixTimestamp
                };
            T temp = node;

            if (animal.ToLower() == "cat")
            {
                CatQueue.Enqueue(temp);
            }

            if (animal.ToLower() == "dog")
            {
                CatQueue.Enqueue(node);
            }
        }
    }
}
