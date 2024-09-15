using System;
using System.Runtime.InteropServices;

namespace Project04_IngeritanceSamples.SchollSystem;

public class Ogretmen : Kisi
{
    public Ogretmen(string ad, string soyAd, DateTime dogumTarihi, decimal maaş, string branş) : base(ad, soyAd, dogumTarihi)
    {

        this.Maaş = maaş;
        this.Branş = branş;
    }

    public string Branş { get; set; }   
    decimal maaş;
    public decimal Maaş
    {
        get{             
                return maaş;
        }
        set
        {
            if (value < 0) 
            {
              throw  new ArgumentException("Negatif giremezsiniz!!");
            }
             maaş =value;
        }
    }

    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
        System.Console.WriteLine($"Branş: {Branş} \n Maaş: {Maaş:C0}");
    }



}
