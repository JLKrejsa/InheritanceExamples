﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_examples
{
    class Animal
    {
        private int legs;
        private int size;
        private int weight;
        protected string color;

        protected bool goodToEat;

        //this is a default constructor without any parameters
        public Animal()
        {

        }

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
            Console.WriteLine("It's size is: " + size);
            Console.WriteLine("It weighs " + weight);
            Console.WriteLine("And its color is " + color);
        }




//end of animal class
    }

}
