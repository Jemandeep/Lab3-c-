using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lab_3
{
    internal class Cat : animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice");

        }
        public override string Cry()
        {
            return "Meow!";
        }
    }
}
