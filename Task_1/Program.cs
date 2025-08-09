using System;


class Program
{
    static void Main(string[] args)
    {
        Dog dog_1 = new Dog();
        dog_1.MakeSound();
        Cat cat_1 = new Cat();
        cat_1.MakeSound();
    }

    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }



    
}