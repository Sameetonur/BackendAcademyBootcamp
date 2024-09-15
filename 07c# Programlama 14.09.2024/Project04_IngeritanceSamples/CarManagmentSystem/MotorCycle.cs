using System;

namespace Project04_IngeritanceSamples.CarManagmentSystem;

public class MotorCycle : Vehicle
{
    public MotorCycle(string brand, string model, int year, string coolingSystem) : base(brand, model, year)
    {
        CoolingSystem = coolingSystem;
    }

    public string CoolingSystem { get; set; }

    public override void Bilgilendirme()
    {
        base.Bilgilendirme();
        System.Console.WriteLine($"CoolingSytstem: {CoolingSystem}");
    }

    public override void GetSignal()
    {
        throw new NotImplementedException();
    }
}
