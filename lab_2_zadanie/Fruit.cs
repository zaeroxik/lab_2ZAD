using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Fruit : Product
    {
        public int Count;
        public Fruit(string name, int count) : base(name)
        {
            Count = count;
        }
        public override void Print()
        {
            Console.WriteLine("            " + Name + " (" + Count + " fruits)");
        }
    }
}
