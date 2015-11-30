﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals
{
    class Dog : Animal
    {
        public Dog(string name, int age, GenderType gender )
            : base(name, age, gender)
        {            
        }

        public override void ProduceSound()
        {
            Console.WriteLine("bauuu");
        }
    }
}
