﻿using System.Web;

namespace MethodsHomeWork;

class Program
{
    #region Soru1 Method

    // static string YasBulma(int yas)
    // {
    //     string message;

    //     if (yas >= 65)
    //     {
    //         message = "emeklilik yaşınız geldi";
    //         System.Console.WriteLine(message);

    //     }
    //     else
    //     {
    //         message = "Çalışma yaşındasınız";
    //         System.Console.WriteLine(message);

    //     }
    //     return message;


    // }
    #endregion

    #region Soru2 Method


    // static int İkiSayBüyBul(int say1, int say2)
    // {
    //     int enBüyük;
    //     if(say1>say2)
    //     {
    //         enBüyük = say1;
    //         System.Console.WriteLine(enBüyük);
    //     }else
    //     {
    //         enBüyük=say2;
    //         System.Console.WriteLine(enBüyük);
    //     }
    //     return enBüyük;
    //     System.Console.WriteLine("iki tane aynı sayı girdiniz.");
    // }

    #endregion

    #region Soru3 Method


    // static string KelTerÇev (string dizi)
    // {
    //         string terskelime="";

    //         for (int i = dizi.Length - 1; i >= 0; i--)
    //         {
    //            terskelime+=dizi[i];

    //         }

    //         return terskelime;
    // }


    #endregion

    #region Soru4 Merhod

    // static double Ort(int vize , int final)
    // {
    //     double vizeNot  = vize*0.40;
    //     double finalNot = final*0.60;

    //     double top = vizeNot+finalNot;
    //     return top; 
    // }



    #endregion

    #region Soru5 Method


    // static string[] TersÇev(string[] dizi)
    // {
    //     foreach (var item in dizi)
    //     {
    //         System.Console.WriteLine(item.ToUpper());
    //     }
    //     return dizi;

    // }
    #endregion

    #region Soru6 Method
        //  static string TekCift(int sayi)
        // {
        // string message;
        // if(sayi%2==0)
        // {
        //     message=$"Bu sayı çifttir ve Girdiğiniz sayı => {sayi}";
        //     System.Console.WriteLine(message);

        // }
        // else
        // {
        //     message=$"Girdiğiniz sayı tektir ve girdiğiniz sayı => {sayi}";
        //     System.Console.WriteLine(message);

        // }
        // return message;
    
    #endregion

    #region Soru7 Metmod

        // static string Tarih(int saat, int dakika, int saniye)
        // {
        //     DateTime tar = new DateTime(1,1,1,saat,dakika,saniye);

        //     return tar.ToString("HH:mm:ss");
        // }

    #endregion
    static void Main(string[] args)
    {
        #region Soru1

        //  System.Console.WriteLine("Bir yaş giriniz => ");
        //  int input = int.Parse(Console.ReadLine());
        // YasBulma(input);

        #endregion

        #region Soru2


        //    İkiSayBüyBul(5,8);

        #endregion

        #region soru3


        // Console.Write("Bir kelime girin: ");
        // string kullaniciKelime = Console.ReadLine();
        // System.Console.WriteLine(KelTerÇev(kullaniciKelime));




        #endregion

        #region soru4


        // System.Console.WriteLine(Ort(50,90));

        #endregion

        #region soru5


        // string[] mehmet= {"ahmet","murat","elif","burak","aleyna"};

        // TersÇev(mehmet);

        #endregion

        #region soru6


        // TekCift(858);

        #endregion

        #region Soru7


        // System.Console.WriteLine("Saat giriniz (0-23)");
        // int input1 = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Dakika giriniz (0-59)");
        // int input2 = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Saat giriniz (0-59)");
        // int input3 = int.Parse(Console.ReadLine());

        // System.Console.WriteLine(Tarih(input1,input2,input3));  
        #endregion
    }
}