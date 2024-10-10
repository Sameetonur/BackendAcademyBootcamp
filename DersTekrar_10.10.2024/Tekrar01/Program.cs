using System.Reflection;

namespace Tekrar01;

class Program
{
    static void Main(string[] args)
    {
        #region soru1
        //diziyi ters çevirme işlemi

        //     int[] newDizi = {1,5,6,8,9};
        //     System.Console.WriteLine("Dizimin ilk hali");
        //     foreach (var item in newDizi)
        //     {
        //         System.Console.WriteLine(item);
        //     }
        // System.Console.WriteLine("Ters çevrilmiş hali");
        //     for (int i =newDizi.Length-1; i >= 0; i--)
        //     {
        //         System.Console.WriteLine(newDizi[i]);
        //     }

        //
        #endregion

        #region Soru2

        // sayı bulma oyunu yapın mesela 1-100 sayıları arasında random bir sayı üretilsin girilen 1-100 arasındaki sayıya göre info verilsin daha büyük daha küçük gibi bilince kazandınız diyip bana kazandınız random sayı neyse onu yazsın!.

        // int[] rndDizi = new int[1];
        // int input;
        // Random rnd = new Random();

        // for (int i = 0; i < rndDizi.Length; i++)
        // {
        //     rndDizi[i] = rnd.Next(1, 101);
        // }
        // // foreach (var item in rndDizi)
        // // {
        // //     System.Console.WriteLine($"Random Üretilen sayımız {item}");
        // // }

        // do
        // {
        //     System.Console.WriteLine("1-100 arasında bir sayı giriniz !");
        //     input = int.Parse(Console.ReadLine());

        //     if (input > rndDizi[0])
        //     {
        //         System.Console.WriteLine("Daha Küçük bir sayı giriniz (1-100) arasında!");
        //     }
        //     else if (input < rndDizi[0])
        //     {
        //         System.Console.WriteLine("Daha büyük bir sayı giriniz (1-100) arasında!");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Bildiniz!!");
        //     }

        // } while (rndDizi[0] != input);
        // {
        //     System.Console.WriteLine($"Tebrikler Sayıyı Bildiniz {rndDizi[0]}");
        // }
        #endregion

        #region Soru3

        // kullanıcıdan istenen 10 adet sayı dizesinin içerisindeki tek ve çift sayıların adetini yazdıran algoritma


        // System.Console.WriteLine("10 adet sayınızı giriniz");
        // int[] dizi = new int[10];
        // int tekSay = 0;
        // int çiftSay = 0;

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     System.Console.WriteLine($"{i + 1}. sayınızı giriniz: ");
        //     int input = int.Parse(Console.ReadLine());
        //     dizi[i] = input;
        // }
        // System.Console.Write("Dizideki sayılar: ");
        // foreach (var item in dizi)
        // {
        //     System.Console.Write($"{item} ");
        // }
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     if (dizi[i] % 2 == 0)
        //     {
        //         çiftSay++;
        //     }
        //     else if (dizi[i] % 2 != 0)
        //     {
        //         tekSay++;
        //     }


        // }
        // System.Console.WriteLine();
        // System.Console.WriteLine($"Dizideki tek sayı adeti: {tekSay}\nDizideki çift sayı adeti: {çiftSay}");


        #endregion

        #region Soru4

        // bir kelime dizisindeki 8 tane hayvanı kullanıcıya buldurmaya çalışınız kullanıcı her yanlış tahmininde  random olarak seçilen dizideki hayvanın harf harf infosunu veriniz mesela( seçilen hayvanın 1. harfi m (seçilen hayfan maymun olarak varsaydım))

        // string[] dizi = { "aslan", "kaplan", "çita", "panter", "çekirge", "ayı", "kaplumbağa", "puma" };
        // Random rnd = new Random();
        // string seçDizi = dizi[rnd.Next(0, 8)];
        // int sayaç = 0;


        // string input;

        // do
        // {
        //     System.Console.WriteLine("(aslan,kaplan,çita,inek) dizisinden bir tanesini bilmeye çalışınız!");
        //     input = Console.ReadLine();

        //     if (seçDizi == input)
        //     {
        //         System.Console.WriteLine("hayvanı buldunuz!");
        //     }
        //     else
        //     {
        //         for (int i = sayaç; i <= seçDizi.Length; i++)
        //         {
        //             System.Console.WriteLine($"Kelimenin {i + 1}. Harf => {seçDizi[sayaç]}");
        //             sayaç++;
        //             break;
        //         }
        //     }


        // } while (seçDizi != input);
        // System.Console.WriteLine("Tebrikler!!");

        #endregion

        #region Soru5

        //Kullanıcıya basit matematik işlemleri (toplama, çıkarma) sorarak cevaplarını kontrol edin. 

        // int input;
        // int cevap;
        // int tahmin;
        // int can = 5;
        // int puan = 0;

        // System.Console.WriteLine("!!Bilgilendirme!!\n 5 adet yanlış yaparsanız oyununuz sona erecektir! \n 5 adet doğru yaparsanız kazanıcaksınız!");
        // System.Console.WriteLine("---------------------------------------------------");
        // do
        // {
        //     Random rnd = new Random();
        //     int sayı1 = rnd.Next(1, 11);
        //     int sayı2 = rnd.Next(1, 11);
        //     int işlem = rnd.Next(0, 2);

        //     System.Console.WriteLine("Yapıcağınız işlemi seçiniz (0=toplama,1=çıkarma)");
        //     input = int.Parse(Console.ReadLine());
        //     cevap = 0;
        //     if (input == 0)
        //     {
        //         cevap = sayı1 + sayı2;
        //         System.Console.WriteLine($"Toplama işlemini seçtiniz!\n{sayı1}+{sayı2}= ?");
        //         tahmin = int.Parse(Console.ReadLine());
        //         if (cevap != tahmin) can--;
        //         if (cevap == tahmin) puan++;
        //         System.Console.WriteLine($"Canınız=> {can}");
        //         System.Console.WriteLine($"Doğru=> {puan}");
        //     }
        //     else if (input == 1)
        //     {
        //         cevap = sayı1 - sayı2;
        //         System.Console.WriteLine($"Çıkarma işlemini seçtiniz!\n{sayı1} - {sayı2}= ?");
        //         tahmin = int.Parse(Console.ReadLine());
        //         if (cevap != tahmin) can--;
        //         if (cevap == tahmin) puan++;
        //         System.Console.WriteLine($"Canınız=> {can}");
        //         System.Console.WriteLine($"Doğru=> {puan}");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Lütfen 0 veya 1 giriniz!");
        //     }

        // }
        // while (can != 0 && puan != 5);
        // {
        //     if (can == 0)
        //         System.Console.WriteLine("Hakkınız kalmadı :(( ");
        //     else
        //     {
        //         System.Console.WriteLine("5 DOĞRU YAPRINIZ KAZANDINIZ!!");
        //     }
        #endregion
    }
    #region Sorular
    //         Soru1
    //         //Kullanıcıya basit matematik işlemleri (toplama, çıkarma) sorarak cevaplarını kontrol edin. 
    //         soru2
    //         // bir kelime dizisindeki 8 tane hayvanı kullanıcıya buldurmaya çalışınız kullanıcı her yanlış tahmininde  random olarak seçilen dizideki hayvanın harf harf infosunu veriniz mesela( seçilen hayvanın 1. harfi m (seçilen hayfan maymun olarak varsaydım))
    //         Soru3
    //          // kullanıcıdan istenen 10 adet sayı dizesinin içerisindeki tek ve çift sayıların adetini yazdıran algoritma
    //          soru4
    //          // sayı bulma oyunu yapın mesela 1-100 sayıları arasında random bir sayı üretilsin girilen 1-100 arasındaki sayıya göre info verilsin daha büyük daha küçük gibi bilince kazandınız diyip bana kazandınız random sayı neyse onu yazsın!.
    //          Soru5
    //          //diziyi ters çevirme işlemi
    // }

    #endregion

}
