using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal(2, "Tan");
            //instantiator this allows us to use constructors in main

            Animal animal2 = new Animal(6, 1, 1);

            animal1.PrintAnimalInfo();
            animal2.PrintAnimalInfo();

            //instantiator (cat1 is a Cat object but still has Animal object behind it)
            Cat cat1 = new Cat("tabby", "short", false, "brown");
            cat1.PrintAnimalInfo();
            cat1.Speak();

            Fish fish1 = new Fish(5, true, true, "salt");
            fish1.PrintAnimalInfo();
            fish1.Swim();






//end static 
        }

       
    }
}
