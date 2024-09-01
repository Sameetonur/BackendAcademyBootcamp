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

        ConsoleKeyInfo karakter;
        string resNum = "";

        System.Console.Write("Bir Sayı Giriniz =");

        do
        {
            karakter = Console.ReadKey(true);
            if(char.IsDigit(karakter.KeyChar))
            {
                resNum += karakter.KeyChar.ToString();
                Console.Write(karakter.KeyChar.ToString());
            }
            else
            {
                if (karakter.Key ==ConsoleKey.Backspace && resNum.Length > 0)
                {
                    resNum = resNum.Substring(0, resNum.Length - 1);
                    System.Console.Write("\b \b");

                }

            }


        } while (karakter.Key != ConsoleKey.Enter);

        #region Do While



        #endregion


    }
}
