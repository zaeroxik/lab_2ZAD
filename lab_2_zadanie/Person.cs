﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Person
    {
        public string Name;
        public int Age;
        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public virtual void Print()
        {

        }
    }
}
