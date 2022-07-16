using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Meat : Product
    {
        public double Count;
        public Meat(string name, double count) : base(name)
        {
            Count = count;
        }
        public override void Print()
        {
            Console.WriteLine("            " + Name + " (" + Count + " kg)");
        }
    }
}
