using System;

namespace Project04_IngeritanceSamples.SchollSystem;

public class Kisi
{
    public Kisi(string ad, string soyAd, DateTime dogumTarihi)
    {
        Ad = ad;
        SoyAd = soyAd;
        DogumTarihi = dogumTarihi;
        
    }

    public string Ad { get; set; }
    public string SoyAd { get; set; }
    public DateTime DogumTarihi { get; set; }
    
    public byte Yas //Salt okunur yani (readonly) property yani sadece get edilir set edilemez!.
    {
        get
        {

            return (byte)(DateTime.Now.Year - DogumTarihi.Year);
        }
    }
    public virtual void BilgileriEkranaYaz()
    {
        System.Console.WriteLine($"Ad: {Ad}\n Soyad: {SoyAd}\n Yaşınız. {Yas} ");
    }


}
