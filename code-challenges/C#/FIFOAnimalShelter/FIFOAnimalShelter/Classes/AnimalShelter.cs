using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter
{
    public class AnimalShelter
    {
        public MyQueue<string> CatQueue { get; set; }
        public MyQueue<string> DogQueue { get; set; }

        /// <summary>
        /// Instantiates a new Animal Shelter with one Queue for Cats and one for Dogs.
        /// </summary>
        public AnimalShelter()
        {
            CatQueue = new MyQueue<string>();
            DogQueue = new MyQueue<string>();
        }

        /// <summary>
        /// Takes in a string of Animal Type that can be either Cat or Dog and a string Name.
        /// Creates a Node for that Animal and places it at the back of it's respective Queue.
        /// Affixes a Timestamp for Dequeue use.
        /// </summary>
        /// <param name="animal">Can be either Cat or Dog.  If anything else is specified no action is taken.</param>
        /// <param name="name">The Name to identify the Animal by.</param>
        public void Enqueue(string animal, string name)
        {
            if (animal.ToLower() != "cat" && animal.ToLower() != "dog")
            {
                return;
            }
            else
            {
                Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds; // UTC Timestamp code found on Stack Overflow
                Node<string> node = new Node<string>(animal, unixTimestamp, name);

                if (animal.ToLower() == "cat")
                {
                    CatQueue.Enqueue(node);
                }
                else
                {
                    DogQueue.Enqueue(node);
                }
            }
        }

        /// <summary>
        /// Returns either a Cat or a Dog from the front of their respective Queues depending on what is prefered.
        /// If no preference is entered then the Animal that has been in the Queues the longest will be returned.
        /// </summary>
        /// <param name="pref">Dog, Cat or No Preference.</param>
        /// <returns>The Animal indicated by pref, or the Animal that has been in Queue the longest.</returns>
        public Node<string> Dequeue(string pref)
        {
            if (pref.ToLower() == "cat")
            {
                return CatQueue.Dequeue();
            }
            else if (pref.ToLower() == "dog")
            {
                return DogQueue.Dequeue();
            }
            else
            {
                if (CatQueue.Front.Timestamp >= DogQueue.Front.Timestamp)
                {
                    return CatQueue.Dequeue();
                }
                else
                {
                    return DogQueue.Dequeue();
                }
            }
        }
    }
}