using System;

namespace Project04_IngeritanceSamples;

public class Animal
{
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void MakeSound() //virtual bu class hangi başka classa miras veriliyorsa geçersiz sayılıp yerine girilebilir polimorfizim
    {
        System.Console.WriteLine($"{Name} Ses çıkardı!!");
    }

    
}
