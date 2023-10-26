using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lab_3
{
    abstract class animal : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }  
        // getters 
        public string GetName() { return Name; }
        public string GetColour() { return Colour; }
        public int GetAge() { return Age; }
        public double GetHeight() { return Height; }
        //setters
        public void SetName(string name) { Name = name; }
        public void SetColour(string colour) { Colour = colour; }
        public void SetAge(int age) { Age = age; }
        public void SetHeight (double height) { Height = height; }

        public abstract void Eat();
        public abstract string Cry();

    }
}
