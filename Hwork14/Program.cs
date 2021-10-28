using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.ShowInfo();
            Dog dog = new Dog();
            dog.ShowInfo();
            Console.ReadKey();
        }
        abstract class Animal
        {
            public abstract string Name { get; set; }

            public Animal(string name = "питомец")
            {
                Name = name;
            }

            public abstract void Say();

            public void ShowInfo()
            {
                Console.Write($"{Name}: ");
                Say();
            }
        }
        class Cat : Animal
        {
            string name;
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = "Кошка";
                }
            }

            public override void Say()
            {
                Console.WriteLine("Мяу мяу");
                return;
            }

        }
        class Dog : Animal
        {
            string name;
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = "Собака";
                }
            }

            public override void Say()
            {
                Console.WriteLine("Гав гав");
                return;
            }
        }
    }
}
