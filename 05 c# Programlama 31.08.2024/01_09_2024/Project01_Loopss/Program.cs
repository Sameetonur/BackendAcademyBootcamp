using System.Diagnostics;

namespace Project01_Loopss;

class Program
{
    static void Main(string[] args)
    {
        //     #region 

        //     int num1 = 0;
        //     int toplam = 0;

        //     while (toplam <= 100)
        //     {
        //         System.Console.WriteLine("Bir sayı giriniz :");
        //         num1 = int.Parse(Console.ReadLine());

        //         toplam += num1;

        //     }

        //     Console.WriteLine(toplam);

        // #endregion

        //sadece sayı girişi yaptıralım.

        // ConsoleKeyInfo karakter;
        // string resNum = "";

        // System.Console.Write("Bir Sayı Giriniz =");

        // do
        // {
        //     karakter = Console.ReadKey(true);//kontrol etmek için defult(false) olarak girilen veriyi ekrana giriceğimiz veriyi ekrana yazdırır ama biz sayı girmesini istediğimiz için ekrana basmasın(true çekiyoruz(manipüle ediyoruz)) ve sayıysa yazmasını istenilen sorguya götürebiliyoruz ve ona göre yazdıyoruz (yani eksana string veya sayı olmayan veriyi gösterme sadece sayıysa göster diyerek true çekiyoruz)
        //     if(char.IsDigit(karakter.KeyChar))
        //     {
        //         resNum += karakter.KeyChar.ToString();
        //         Console.Write(karakter.KeyChar.ToString());
        //     }
        //     else
        //     {
        //         if (karakter.Key ==ConsoleKey.Backspace && resNum.Length > 0)
        //         {
        //             resNum = resNum.Substring(0, resNum.Length - 1); // substring (index1,index2) index1=nereye gidiceği,index2= ondan sonra ne kadarı alınacağı
        //             System.Console.Write("\b \b");

        //         }

        //     }


        // } while (karakter.Key != ConsoleKey.Enter);

        /*-----------------------------------------------------------------------------------------------------------*/
        // bool isPrime = true;
        // System.Console.WriteLine("Bir sayı giriniz = ");
        // int num = int.Parse(Console.ReadLine());
        // if (num <= 1)
        // {
        //     isPrime = false;
        // }
        // else
        // {
        //     for (int i = 2; i < num - 1; i++)
        //     {
        //         if (num % i == 0)
        //         {
        //             isPrime = false;
        //             break;
        //         }

        //     }
        // }
        // if (isPrime)
        // {
        //     System.Console.WriteLine($"{num}Sayı Asaldır");
        // }
        // else
        // {
        //     System.Console.WriteLine($"{num}Sayı Asaldeğildir.");
        // }

        /*-----------------------------------------------------------------------------------------------------------*/
        // bool kontrol = true;
        // int num = 0;

        // while (num <= 1)
        // {
        //     System.Console.WriteLine("Bir sayı giriniz =");
        //     num = int.Parse(Console.ReadLine());

        //     for (int i = 2; i < num - 1; i++)
        //     {
        //         if(num % 2 == 0)
        //         {
        //             kontrol=false;
        //             break;
        //         }
        //     }
        // }
        // if (kontrol)
        // {
        //     System.Console.WriteLine($"{num} sayısı asal");
        // }
        // else
        // {
        //     System.Console.WriteLine($"{num} sayısı asaldeğil");
        // }

        /*-----------------------------------------------------------------------------------------------------------*/
        bool kontrol = true;
        int num = 0;
        string answer;
        do
        {
            System.Console.WriteLine("Bir sayı giriniz =");
            num = int.Parse(Console.ReadLine());

            for (int i = 2; i < num - 1; i++)
                if (num % 2 == 0)
                {
                    kontrol = false;
                    break;
                }
            if (kontrol)
            {
                System.Console.WriteLine($"{num} sayısı asal");
            }
            else
            {
                System.Console.WriteLine($"{num} sayısı asaldeğil");
            }
            System.Console.WriteLine("Tekrar denemek ister misin(e/h)");
            answer = Console.ReadLine();



        } while (answer != "h");



    }
}
