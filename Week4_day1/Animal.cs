using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_day1
{
    class Animal
    {
        private int legs;
        private int size;
        private int weight;

        private string color;

        private bool isGoodToEat;

        public Animal(int legs, string color)
        {
            this.legs = legs;
            this.color = color;
        }

        public Animal(int legs, int size, int weight)
        {
            this.legs = legs;
            this.size = size;
            this.weight = weight;
        }

        public Animal(int legs, int size, int weight, string color)
        {
            this.legs = legs;
            this.size = size;
            this.weight = weight;
            this.color = color;
        }

        public void PrintAnimalInfo()
        {
            Console.WriteLine("This animal has " + legs + " legs");
            Console.WriteLine("It's size is  " + size);
            Console.WriteLine("It weighs " + weight);
            Console.WriteLine("And it's color is " + color + "\n");
        }

    }
}
