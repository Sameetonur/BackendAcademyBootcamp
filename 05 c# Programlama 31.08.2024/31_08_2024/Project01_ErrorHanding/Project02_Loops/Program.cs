using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;
using System.Numerics;

namespace Project02_Loops;

class Program
{
    static void Main(string[] args)
    {
        #region For


        // for (int counter = 1; counter <= 5; counter = counter + 1)
        // {
        //     System.Console.WriteLine($"{counter}. Merhaba");
        // }

        //for (int i = 1; i <= 5; i++)
        // {
        //     System.Console.WriteLine($"{i}. Merhaba");
        // }
        /*----------------------------------------------------------------------------------------------------------*/
        //ekrana 1-10 arasındaki sayıları yazdırınız
        // string Message;
        // int counter = 1;
        // for (int i = 100; i <= 150; i++)
        // {
        //     Message = $"sayı{counter++} : {i}";
        //     System.Console.WriteLine(Message);

        // }
        /*----------------------------------------------------------------------------------------------------------*/
        // for (int i = 0; i <= 10; i += 2)
        // {

        //     System.Console.WriteLine(i);

        // }
        /*----------------------------------------------------------------------------------------------------------*/
        // for (int i = 1; i < 11; i++)
        // {
        //     if (i % 2 == 0)
        //     {
        //         System.Console.WriteLine(i);
        //     }

        // }
        /*----------------------------------------------------------------------------------------------------------*/
        /* Kullanıcıdan 2 sayı alınız bu iki sayı arasındaki çift sayıları ekrena yazdırın*/

        // System.Console.Write("1.Sayıyı giriniz :");
        // int sayı1 = int.Parse(Console.ReadLine());
        // sayı1 = sayı1 % 2 ==0 ? sayı1: ++sayı1;

        // System.Console.Write("2.Sayıyı giriniz :");
        // int sayı2 = int.Parse(Console.ReadLine());

        // for (int i = sayı1; i <= sayı2; i+=2)
        // {   
        //     System.Console.WriteLine(i);
        // }
        /*----------------------------------------------------------------------------------------------------------*/
        //kullanıcının klavyeden giridği sayının faktöriyelini hesaplayan uygulamayı yazınız

        // System.Console.WriteLine("Bir sayı giriniz :");
        // int sayı1 = int.Parse(Console.ReadLine());
        // int factorial = 1;

        // for (int i = 2; i <= sayı1; i++)
        // {
        //     factorial *= i;

        // }
        // System.Console.WriteLine($"{sayı1}!= {factorial}");
        /*----------------------------------------------------------------------------------------------------------*/
        // System.Console.WriteLine("Bir sayı giriniz :");
        // int sayı1 = int.Parse(Console.ReadLine());
        // int factorial = sayı1;

        // for (int i = sayı1-1; i >1; i--)
        // {
        //     factorial *= i;

        // }
        // System.Console.WriteLine($"{sayı1}!= {factorial}");

        #endregion

        #region While

        // int i=1;
        // while (i<=5)
        // {
        //     System.Console.WriteLine($"{i}  Hello World");
        //     i++;
        // }

        // int toplam = 0;
        // string imput = "";

        // while (imput != "exit")
        // {
        //     System.Console.WriteLine("Bir sayı Gİriniz (çıkış işin = exit):");
        //     imput = Console.ReadLine();
        //     if (int.TryParse(imput, out int imputNumber))
        //     {
        //         toplam += imputNumber;
        //     }
        //     else if (imput != "exit")
        //     {
        //         System.Console.WriteLine(" Geçerli bir değer giriniz!!");
        //     }

        // }
        // System.Console.WriteLine($"Toplam = {toplam}");

        // kullanıcıdan arka arkaya alınacak sayıları toplayan kodu hazırlayınız. ancak kullanıcının girdiği sayıların toplamı 100den büyükk ya da eşitse program sona erip toplamı ekrana yazsın

        int toplam = 0;
        string imput = "";

        while (toplam > 100)
        {
            System.Console.WriteLine("Bir sayı Gİriniz (çıkış işin = exit):");
            int num1 =int.Parse( Console.ReadLine());
            if (int.TryParse(imput, out  num1))
            {
                toplam += num1;
            }
            else if (imput != "exit")
            {
                System.Console.WriteLine(" Geçerli bir değer giriniz!!");
            }

        }





        #endregion
    }
}
