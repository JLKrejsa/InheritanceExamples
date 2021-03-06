﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_examples
{
    class Fish:Animal
    {
        private int fins;
        private bool scales;
        private bool teeth;
        private string waterType;

        //constructor *base(hard coding anything in here)
        public Fish(int fins, bool scales, bool teeth, string waterType): base(0, "silver")
        {
            this.fins = fins;
            this.scales = scales;
            this.teeth = teeth;
            this.waterType = waterType;
        }

        //method
        public void Swim()
        {
            Console.WriteLine("Just keep swimming, just keep swimming...");
        }

    }
}
