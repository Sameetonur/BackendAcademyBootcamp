using System.Reflection.Metadata.Ecma335;

namespace Proje01_VaribalSamples;

class Program
{
    static void Main(string[] args)
    {
        #region YaşHesaplama

        // kullanıcıdan doğum yılını alıp yaşını hesaplaycak ve bunu ekrana yazdıracak kodu hazırlıyoruz.

        // Console.Write("Doğum yılınzı giriniz : ");
        // string Tarih = Console.ReadLine();
        // int dogTarih = Convert.ToInt32(Tarih);
        // int age = DateTime.Now.Year - dogTarih;
        // string message = "Yaşınız: " + age;
        // System.Console.WriteLine(age);

        #endregion

        #region Ürün Fiyatı Hesaplama

        // bir ürünün fiyatı girildiğinde onun kdv dahil fiyatını hesaplayp hem ham hemde kdv dahil fiyatını ekrana yazdıracağız.
        // System.Console.Write("Girilen Ürün Fiyatı :");

        // decimal ÜrünFiyat = decimal.Parse(Console.ReadLine());

        // double vatRate = 0.18;
        // double vat = (double)ÜrünFiyat * vatRate;
        // decimal total = ÜrünFiyat + (decimal)vat;

        // string resulMessage = $@"
        //  Ürün Fiyatı     : {ÜrünFiyat}
        //  KDV             : {vat}
        //  KDV Dahil Fiyat : {total} 
        //     ";
        // System.Console.WriteLine(resulMessage);
        //   string resulMessage = $" Ürün Fiyatı  : {ÜrünFiyat}\n KDV : {vat}\n KDV Dahil Fiyat : {total}\n ";
        //   System.Console.WriteLine(resulMessage);






        #endregion

        #region Sıcaklık Dönüştürme


        //Kullancıdan celcisus cinsinden alınan sıcaklık değereini fahrenheit cinsine çevirip  ekrana her ikisini de alt alta yazdıran kodu hazırlayınız.
        // System.Console.Write("Kullanıcıdan Girilen Sıcaklık : ");
        // decimal girilenSıcaklık = decimal.Parse(System.Console.ReadLine());

        // double çevirme = 33.8;
        // double çevVeri = (double)girilenSıcaklık * çevirme;
        // decimal sonHal = girilenSıcaklık + (decimal)çevVeri;
        // Console.Clear();
        // string resulMessage = $@"
        //   Sıcaklık (C)                  : {girilenSıcaklık}
        //   Fahrenheit (F)                : {çevirme}
        //   Fahrenheit Çevrilmiş Hali (F) : {sonHal} 
        //      ";
        // System.Console.WriteLine(resulMessage);





        #endregion

        #region Ağırlık Döönüştürme

        // kullanıcının girdiği kg cinsinden ağırlığı grama çevirip sonucu ekrana yazdıran kodu yazdırınız.

        Console.Write("Ağırlığı giriniz : ");
        double kgAğırlık = double.Parse(Console.ReadLine());

        double gramCevirme = kgAğırlık * 1000;
        Console.Clear();
        string resulMessage = $@"
           Ağırlık (KG)             : {kgAğırlık}         
           Gram Çevrilmiş Hali (GR) : {(int)gramCevirme} 
              ";
        System.Console.WriteLine("SONU:");
        System.Console.WriteLine();
        System.Console.WriteLine(resulMessage);


        #endregion
    }
}
