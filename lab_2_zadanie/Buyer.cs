using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    class Buyer : Person
    {
        public List<Product> Products = new List<Product>();

        public Buyer(string name, int age) : base(name, age)
        {

        }
        public virtual void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public virtual void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }
        public override void Print()
        {
            Console.WriteLine("      Buyer: " + Name + " (" + Age + " y.o." + ")");
            
            if(Products.Count > 0)
            {
                Console.WriteLine("          -- Products: --");
                for (int i = 0; i < Products.Count; i++)
                {
                    Products[i].Print();
                }
            }                    
        }
    }
}
