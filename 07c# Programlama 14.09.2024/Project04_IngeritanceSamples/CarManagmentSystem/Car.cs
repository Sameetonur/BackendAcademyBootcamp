using System;

namespace Project04_IngeritanceSamples.CarManagmentSystem;

public class Car : Vehicle
{
    public Car(string brand, string model, int year, int countOfDoors) : base(brand, model, year)
    {
        CountOfDoors = countOfDoors;
    }

    public int CountOfDoors { get; set; }

    public void OpenTrunk()
    {
        System.Console.WriteLine("Sanruf açık");
    }

    public void CloseTrunk()
    {
        System.Console.WriteLine("Sanruf Kapalı");
    }
    public override void Bilgilendirme()
    {
        base.Bilgilendirme();
        System.Console.WriteLine($"Kaç KAPILI: {CountOfDoors}");
    }

    public override void GetSignal()
    {
        throw new NotImplementedException();
    }
}
