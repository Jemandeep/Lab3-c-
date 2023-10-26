using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lab_3
{
    internal class Dog : animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat");

        }
        public override string Cry()
        {
            return "Woof!";
        }
    }
}

