using System.ComponentModel.Design.Serialization;
using System.Security.Permissions;
using System.Text.RegularExpressions;

namespace Proje_MethodOverloading;

class Program
{

    // static int Sum (int a , int b)
    // {
    //     return a+b;
    // }
    // static int Sum(int a, int b, int c)
    // {
    //     return a + b + c;
    // }
    // static int Sum(int a, int b, int c, int d)
    // {
    //     return a + b + c+ d;
    // }


    // static void Greet(string name, byte age)
    // {
    //     System.Console.WriteLine($"Merhaba {name} Yaş {age}!");
    // }
    static string GetCoffe(string coffeType, int quantitiSugar = 0, bool withMilk = true)//defult parametre girilicek veriyi en sonda tutmalısın sonrasında paramtreli varsa sorun yok ama parametresiz parametreli parametresiz olmaz parametreli en sonra olmalı.
    {
        string coffe = $"{coffeType} Kahve,";
        coffe += quantitiSugar > 0 ? $"{quantitiSugar} Şekerli, " : " Şekersiz, ";
        if (withMilk)
        {
            coffe = coffe + " Sütlü";

        }
        else
        {
            coffe = coffe + " Sade ";
        }
        coffe += "\n Kahveniz Hazır, Afiyet olsun :)";
        return coffe;
    }


    static void Main(string[] args)
    {
        System.Console.WriteLine(GetCoffe(" Americano", 0, true));
        System.Console.WriteLine("------------------------------------");
        System.Console.WriteLine(GetCoffe(" Americano", 2));
        System.Console.WriteLine("------------------------------------");
        System.Console.WriteLine(GetCoffe(" Americano", 0, false));










        // Console.WriteLine(Sum(5,7));
        // Console.WriteLine(Sum(5, 7,8));
        // Console.WriteLine(Sum(5, 7,8,9));
        // Greet("Engin", 32);
    }
}
