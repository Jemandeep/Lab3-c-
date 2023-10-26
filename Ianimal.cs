
  using System;
using System.Collections.Generic;
namespace c__lab_3;
//  IAnimal interface
interface IAnimal
{
    string Name { get; set; }
    string Colour { get; set; }
    double  Height { get; set; }
    int Age { get; set; }

    string GetName();
    string GetColour();
    double  GetHeight();
    int GetAge();

    void SetName(string name);
    void SetColour(string colour);
    void SetHeight(double  height);
    void SetAge(int age);


     string Cry(); 
     void Eat();
}