using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Shop
    {
        string Name;
        Person[] _persons;
        Product[] _products;
        
        public Shop(string name, Person[] persons, Product[] products)
        {
            Name = name;
            _persons = persons;
            _products = products;
        }
        public void Print()
        {
            Console.WriteLine(Name);
            Console.WriteLine("-- People: --");
            foreach(Person a in _persons)
            {
                if(a is Seller)
                {
                    a.Print();
                }
                else if(a is Buyer)
                {
                    a.Print();
                }                
            }
            Console.WriteLine("-- Products: --");
            for(int i = 0; i < _products.Length; i++)
            {
                _products[i].Print();
            }
        }
    }
}
