using System;

namespace Project04_IngeritanceSamples.SchollSystem;

public class Ogrenci : Kisi
{
    public Ogrenci(string ad, string soyAd, DateTime dogumTarihi, int ogrNum) : base(ad, soyAd, dogumTarihi)
    {
        OgrNum = ogrNum;
    }

    public int OgrNum { get; set; }
    public override void BilgileriEkranaYaz()
    {
        base.BilgileriEkranaYaz();
      System.Console.WriteLine($" öğrenci No: {OgrNum} ");
    }


}
