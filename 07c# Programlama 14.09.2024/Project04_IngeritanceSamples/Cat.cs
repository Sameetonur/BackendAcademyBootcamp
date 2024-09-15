using System;

namespace Project04_IngeritanceSamples;

public class Cat : Animal
{
    public Cat(string name, int age, string color) : base(name, age)
    {

        Color = color;
    }
    public string Color { get; set; }
    public override void MakeSound()
    {
        System.Console.WriteLine($"{Name} Miyavladı !");
    }
}
