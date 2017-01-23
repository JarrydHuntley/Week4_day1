using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal(2, "Tan");
            Animal animal2 = new Animal(6, 1, 1);

            animal1.PrintAnimalInfo();
            Console.WriteLine();
            animal2.PrintAnimalInfo();
            Console.WriteLine();

            Cat cat1 = new Cat("Grumpy", "Short", false, "Grey");
            cat1.PrintAnimalInfo();
            cat1.Speak();
            Console.WriteLine();

            Fish fish1 = new Fish(5, true, true, "salt");
            fish1.PrintAnimalInfo();
            fish1.Swim();
            Console.WriteLine();
        }
    }
}
