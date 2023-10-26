using c__lab_3;
using System.Dynamic;

class Program
{
    static void Main()
    {
        // For Dog
        Console.Write("Enter a dog name: ");
        string dogName = Console.ReadLine();

        Dog dog = new Dog();
        dog.SetName(dogName);
        dog.SetColour("Brown");
        dog.SetHeight(30);
        dog.SetAge(5);

        Console.WriteLine($"Name: {dog.GetName()}, Colour: {dog.GetColour()}, Age: {dog.GetAge()},Height:{dog.GetHeight()}");
        dog.Eat();
        Console.WriteLine($"Cry: {dog.Cry()}");


        // For Cat
        Console.Write("\nEnter a cat name: ");
        string catName = Console.ReadLine();

        Cat cat = new Cat();
        cat.SetName(catName);
        cat.SetColour("Gray");
        cat.SetHeight(18);
        cat.SetAge(3);

        Console.WriteLine($"Name: {cat.GetName()}, Colour: {cat.GetColour()}, Age: {cat.GetAge()},Height:{cat.GetHeight()}");
        cat.Eat();
        Console.WriteLine($"Cry: {cat.Cry()}");

    }
}