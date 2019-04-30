using FIFOAnimalShelter;
using StacksAndQueues.Classes;
using System;
using Xunit;

namespace FIFOAnimalShelterTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnqueueACat()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue("cat", "Sadie");

            Assert.Equal("Sadie", shelter.CatQueue.Rear.Name);
        }

        [Fact]
        public void CanEnqueueMultipleCats()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue("cat", "Sadie");
            shelter.Enqueue("cat", "Sofie");
            shelter.Enqueue("cat", "Ricky");

            Assert.Equal("Ricky", shelter.CatQueue.Rear.Name);
        }

        [Fact]
        public void CanEnqueueADog()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue("dog", "Josie");

            Assert.Equal("Josie", shelter.DogQueue.Rear.Name);
        }

        [Fact]
        public void CanEnqueueMultipleDogs()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue("dog", "Josie");
            shelter.Enqueue("dog", "Bird");
            shelter.Enqueue("dog", "Demi");

            Assert.Equal("Demi", shelter.DogQueue.Rear.Name);
        }

        [Fact]
        public void CanEnqueueMultipleAnimalsAndCheckCat()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue("cat", "Sadie");
            shelter.Enqueue("cat", "Sofie");
            shelter.Enqueue("cat", "Ricky");
            shelter.Enqueue("dog", "Josie");
            shelter.Enqueue("dog", "Bird");
            shelter.Enqueue("dog", "Demi");

            Assert.Equal("Ricky", shelter.CatQueue.Rear.Name);
        }

        [Fact]
        public void CanEnqueueMultipleAnimalsAndCheckDog()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue("cat", "Sadie");
            shelter.Enqueue("cat", "Sofie");
            shelter.Enqueue("cat", "Ricky");
            shelter.Enqueue("dog", "Josie");
            shelter.Enqueue("dog", "Bird");
            shelter.Enqueue("dog", "Demi");

            Assert.Equal("Demi", shelter.DogQueue.Rear.Name);
        }

        [Fact]
        public void CannotEnqueueOtherAnimals()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue("pinguin", "Sadie");

            Assert.Null(shelter.CatQueue.Rear);
        }

        [Fact]
        public void CanDequeueFrontCat()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue("cat", "Sadie");
            shelter.Enqueue("cat", "Sofie");
            shelter.Enqueue("cat", "Ricky");

            Node<string> node = shelter.Dequeue("cat");

            Assert.Equal("Sadie", node.Name);
        }

        [Fact]
        public void CanDequeueFrontDog()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue("dog", "Josie");
            shelter.Enqueue("dog", "Bird");
            shelter.Enqueue("dog", "Demi");

            Node<string> node = shelter.Dequeue("dog");

            Assert.Equal("Josie", node.Name);
        }

        [Fact]
        public void IfNeitherCatNorDogIsSpecifiedReturnOldestAnimal()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue("cat", "Sadie");
            shelter.Enqueue("dog", "Josie");
            shelter.Enqueue("cat", "Sofie");
            shelter.Enqueue("dog", "Bird");
            shelter.Enqueue("cat", "Ricky");
            shelter.Enqueue("dog", "Demi");

            Node<string> node = shelter.Dequeue("whatever");

            Assert.Equal("Sadie", node.Name);
        }
    }
}
