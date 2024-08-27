using System.Collections;

namespace Proje03_Conditions;

class Program
{
    static void Main(string[] args)
    {
        // if (5 > 14)
        // {
        //     System.Console.WriteLine("İşlem Tamamlandı!!");

        // }
        // else
        // {
        //     System.Console.WriteLine("eRORRRR!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        // }

        // int x = 5;
        //  if (x>15)
        //  {
        //     System.Console.WriteLine("x 15'ten büyüktür.");
        //  }
        //  else if(x<15)
        //  {
        //     System.Console.WriteLine("X 15'ten küçüktür.");
        //  }
        //  else
        //  {
        //     System.Console.WriteLine("X 15' eşittir.");
        //  }

        // kullanıcı klavyeden gireceği yaş bilgisini alıp eğer reşit değilse " reşit değilsiniz, x sene sonra reşit olacaksınız" eğer reşit ise "Giriş yapabilirsiniz"

        //     System.Console.Write("Bir yaş giriniz :");

        //    int yas = int.Parse(Console.ReadLine());


        //     if (yas >= 18)
        //     {
        //         System.Console.WriteLine("Giriş yapabilirsiniz");

        //     }
        //     else
        //     {
        //         System.Console.WriteLine($"Reşit değilsiniz,{18-yas} yıl sonra reşit olacaksınız.");
        //     }

        //    string resultMessage;
        //    System.Console.Write("Bir yaş giriniz :");
        //     int yas = int.Parse(Console.ReadLine());
        //     System.Console.Write("Adınızı giriniz :");
        //     string fullName = Console.ReadLine();

        //     if (yas >= 18)
        //     {
        //         resultMessage = "Giriş yapabilirsiniz";
        //     }
        //     else
        //     {
        //         resultMessage = $"Reşit değilsiniz,{18 - yas} yıl sonra reşit olacaksınız.";
        //     }
        //     System.Console.WriteLine($" Sevgili {fullName},{resultMessage}");


        // System.Console.Write("Adınızı giriniz :");
        // string ad  = Console.ReadLine();

        // System.Console.Write("Yaşınızı giriniz :");
        // int yas = int.Parse(Console.ReadLine());

        // //Ternary IF yapısı
        // string message = yas >=18 
        //                     ? $"Giriş yapabilirsin {ad}"
        //                     : $" {18-yas} sene sonra girebilirsiniz {ad}";
        // System.Console.WriteLine(message);

        // System.Console.Write("Aldığınız puanı giriniz :");
        // int puan = int.Parse(Console.ReadLine());
        //string message;

        // if (puan >= 50)
        // {
        //     message ="Geçerli Not";
        // }
        // else
        // {
        //     message ="Geçersiz Not!";
        // }
        // System.Console.WriteLine(message);
        // string message = puan >= 50 
        //                     ? "Geçeli Not"
        //                     : "Geçersiz Not!";
        //                     System.Console.WriteLine(message);

        // byte point = 55;
        // byte message = 0;

        // switch (point)
        // {
        //     case < 40:
        //         message = 1;
        //         break;
        //     case < 55:
        //         message = 2;
        //         break;
        //     case < 70:
        //         message = 3;
        //         break;
        //     case < 85:
        //         message = 4;
        //         break;
        //     case <= 100:
        //         message = 5;
        //         break;

        //     default:
        //         System.Console.WriteLine("Lütfen 0-100 arasında bir sayı değeri giriniz!!!");
        //         break;
        // }
        // if (point >= 0 && point <= 100)
        // {
        //     System.Console.WriteLine(message);


        // }
        //ödev : bu çalışmanın aynısını if ile yapınız.

        //GİRİLEN TARİHİN HAFTA İÇİ Mİ YOKSA HAFTA SONU MU OLDUĞUNU SÖYLEYEN KODU YAZINIZ.

        // Console.Write("Bir tarih giriniz(gg.aa.yyyy): ");
        // string inputDate = Console.ReadLine();
        // if (DateTime.TryParse(inputDate, out DateTime date))
        // {
        //     DayOfWeek dayOfWeek = date.DayOfWeek; //DayOfWeek.Sunday
        //     System.Console.WriteLine(date.ToLongDateString());
        //     switch (dayOfWeek)
        //     {
        //         case DayOfWeek.Saturday:
        //         case DayOfWeek.Sunday:
        //             System.Console.WriteLine("İyi tatiller!");
        //             break;
        //         default:
        //             System.Console.WriteLine("İyi çalışmalar!");
        //             break;
        //     }
        // }
        // else
        // {
        //     System.Console.WriteLine("Hatalı tarih formatı");
        // }

        //Girilen tarihi hangi mevsime denk geldiğini bulup ekrana yazdıran switch case ile yazınız.

        // System.Console.WriteLine("tarih giriniz :");
        // string veri = Console.ReadLine();
        // if (DateTime.TryParse(veri, out DateTime ay))
        // {
        //     int month = ay.Month;
        //     switch (month)
        //     {
        //         case 1:
        //         case 2:
        //         case 12:
        //             System.Console.WriteLine("Kış");
        //             break;
        //         case 3:
        //         case 4:
        //         case 5:
        //             System.Console.WriteLine("İlk bahar");
        //             break;
        //         case 6:
        //         case 7:
        //         case 8:
        //             System.Console.WriteLine("yaz");
        //             break;
        //         case 9:
        //         case 10:
        //         case 11:
        //             System.Console.WriteLine("sonbahar");
        //             break;
        //     }
        // }
        // else
        // {
        //     System.Console.WriteLine("Hatalı Tarih Formatı.");
        // }








    }
}
