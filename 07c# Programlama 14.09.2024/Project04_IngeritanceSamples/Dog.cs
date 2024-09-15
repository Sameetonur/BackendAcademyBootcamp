using System;

namespace Project04_IngeritanceSamples;

public class Dog : Animal
{
    public Dog(string name, int age, int olFactionLevel, string breed) : base(name, age)
    {
        OlFactionLevel = olFactionLevel;
        Breed = breed;
    }
    public int OlFactionLevel { get; set; }
    public string Breed { get; set; }

    public override void MakeSound()
    {
        System.Console.WriteLine($"{Name} Havladı!!");
    }

    public void Swimm ()
    {
        System.Console.WriteLine($"{Name} Yüzdü!");
    }

}
