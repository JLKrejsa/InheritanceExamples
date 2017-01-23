using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_examples
{
    //cat class is now descendant of Animal class
    class Cat : Animal
    {
        //fields

        private string breed;
        private string furlength;

        private bool deClawed;

        //constructor
        public Cat(string breed, string furlength, bool deClawed, string color): base(4,3,3)
        {
            this.breed = breed;
            this.furlength = furlength;
            this.deClawed = deClawed;
            this.color = color;
            this.goodToEat = false;



  //end Cat class
        }

    }
}
