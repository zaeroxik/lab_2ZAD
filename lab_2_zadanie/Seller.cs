﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Seller : Person
    {
        public Seller(string name, int age) : base(name, age)
        {

        }
        public override void Print()
        {
            Console.WriteLine("      Seller: " + Name + " (" + Age + " y.o." + ")");
        }
    }
}
