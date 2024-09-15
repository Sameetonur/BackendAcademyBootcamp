using System;

namespace Project04_IngeritanceSamples.CarManagmentSystem;

public abstract class Vehicle // !!!abstract!!! işaretlenmiş class artık kendisinden yeni bir nersne yaratılamayan clastır.
{
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public string Brand { get; set; }
    public string Model { get; set; }
    private int Year { get; set; }


    public void Start()
    {
        System.Console.WriteLine("Araç başladı.");
    }

    public void Stop()
    {
        System.Console.WriteLine("Araç Durdu.");
    }

    public virtual void Bilgilendirme()
    {
        System.Console.WriteLine($"Marka: {Brand}\nModeli: {Model}\nYılı: {Year}");
    }

    public abstract void GetSignal();
   




}
