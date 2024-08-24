namespace Proje01_Variables;

class Program
{
    static void Main(string[] args)
    {
        #region Değişken İsimlendirme Kural ve Teknikleri

        // Shift+Alt+F
        /*
            1) C# BÜYÜK/küçük hard duyarlı bir dildir.
            ör: adSoyad ile AdSoyad aynı değildir.
            
            2) Özel karakterler değişken adı içerisinde yer alamaz.(_)
            Ör: Ad Soyad, Ogrenci_Numarası bunlar geçersiz isimlerdir.
            Ör: _AdSoyad, Ad_Soyad
            Ör: Sayi1, Sayi_1, Sayi2Var
            Ör; 1Sayi, 4Not (Bunlar geçersiz isimlerdir. Çünkü değişken ismi harf ya da alt tire ile başlamak zorundadır!)

            3) Anahtar sözcükler yani c#'ın özel anlam yüklediği sözcükler değişken ismi olrak kullanılamaz.
            Ör: int static;
            Ör: string void;

            4) Değişkenler anlamlı bir şekilde isimlendirilir.
            Ör: string as;(olmamalıdır) 
            Ör: string adSoyad (olmalıdır)
            Ör: bool isActive;
             daha basit ama anlanlı olmalıdır.

            5) Değişken isimlendirirken camelCase tekniği kullanılmalıdır.
               -değişken ismi tek sözcükten oluşuyorsa küçük  yaz
               -değişken ismi birden  fazla sözcük içeriyorsa diğer sözcüklerin baş harflerini büyük yaz.
            ör: string anneAdi; 
            Ör: string meğzunOlduOkul;

            6) Değişken isimlendirirken türkçe karakter kullanmak tercih edilmemelidir.

            7) Sabite(Const) tanımlarken genellikle tamamen büyük harf kullanılır.
            Ör: const int  MAX_AGE= 32;

        */

        #endregion

        #region Tamsayılar


        //C# AYRICA BELİRTİLMEDİKÇE TÜM SAYISAL DEĞERLER İNT KABUL EDİLİR.
        sbyte student = 4;
        Console.WriteLine(student);
        #endregion

        #region Ondalık Sayılar



        //  float s1= 0.5f;//32 bit hassasiyet: 7 basamak
        //  double s2= 0.5d; // 64 bit, hassasiyet : 15-16 basamak
        //  decimal s3= 0.5m; //128 bit, hassasiyet ; 28-29 basamak

        // System.Console.WriteLine(s1);
        // System.Console.WriteLine(s2);
        // System.Console.WriteLine(s3);

        #endregion

        #region Diğer Tipler



        // bool varmi=true; 
        // bool gecerliMi=false;// 8 bit yer kaplar

        // char cevap1 = 'Y';
        // char cevap2 = 'N';//UTF-16 charset, 16bit
        // System.Console.WriteLine(cevap1);
        // System.Console.WriteLine(cevap2);
        #endregion

        #region Value Types(Değer Tipleri)



        /*
         Yukarıdaki tüm tiplere c# Value Types der.
         Value Types, bellekte içinde direkt olarak değer saklauyan yapıları anlatır
         ayrıca bunlara Primitive Types de denir.


        */

        #endregion

        #region Reference  Types(Referans Tipler)
        /*   




        */

        #endregion

        #region Temel Referans Tipler


        string AdSoyad = "Samet Önür";
        object nesne = 15;
        object nesne2 = true;
        object nesne3 = "123Uğur123";
        //String ve Object tiplerinin bellekte ne kadar yer kapladığını araştırınız.
        #endregion



    }
}
