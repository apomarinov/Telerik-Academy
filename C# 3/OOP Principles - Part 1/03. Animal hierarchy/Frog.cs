﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fauna
{
    class Frog : Animal
    {
        public Frog(int age, string name, SexType sex)
            : base(age, name, sex)
        {

        }

        public void ProduceSound()
        {
            Console.WriteLine("Croak Croak");
        }
    }
}
