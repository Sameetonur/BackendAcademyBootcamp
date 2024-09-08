using System.Globalization;
using System.Reflection.Emit;

namespace Proje01_Arrays;

class Program
{
    static void Main(string[] args)
    {
        // int[] numbers;

        // numbers = new int[5];

        // numbers[0] = 45;
        // numbers[1] = 56;
        // numbers[2] = 2;
        // numbers[3] = 453;
        // numbers[4] = 4;

        // for (int i = 0; i < 5; i++)
        // {
        //     System.Console.WriteLine($"Dizinin {i + 1}. Elemanı {numbers[i]}");
        // }

        // int[] numbers = {5,8,98,75,56}; //boyutu 5 olacak
        // for (int i = 0; i < 5; i++)
        //  {
        //  System.Console.WriteLine($"Dizinin {i + 1}. Elemanı {numbers[i]}");
        //  }

        // string[] studentNames =
        // {
        //     "Ali",
        //     "Veli",
        //     "Burak",
        //     "Murat"
        // };

        // for (int i = 0; i < studentNames.Length; i++)
        // {
        //     Console.WriteLine(studentNames[i]);
        // }
        // for (int i = 0; i < studentNames.Length; i++)
        // {
        //     studentNames[i] += " Canoğlu";
        // }
        // System.Console.WriteLine();
        // System.Console.WriteLine("Değişmiş Hali");
        // System.Console.WriteLine();
        // for (int i = 0; i < studentNames.Length; i++)
        // {
        //     Console.WriteLine(studentNames[i]);
        // }

        // string[] studentNames =
        // {
        //     "Ali",
        //     "Veli",
        //     "Burak",
        //     "Murat"
        // };

        // foreach (string student in studentNames)
        // {
        //     System.Console.WriteLine(student);
        // }

        // int[] prices = { 40, 50, 60, 70, 80 };
        // // prices dizisinin içindeki fiyatlara %10 zam gelmiştir
        // System.Console.WriteLine("Zamsız ürünler");
        // System.Console.WriteLine("-------------------");
        // foreach (int p in prices)
        // {
        //     System.Console.WriteLine(p);

        // }
        // System.Console.WriteLine("------------------");
        // System.Console.WriteLine("Zamlı hali");
        // System.Console.WriteLine("--------------------------");
        // for (int i = 0; i < prices.Length; i++)
        // {
        //     prices[i] = (int)(prices[i] * 1.1);
        // }
        // foreach (int p in prices)
        // {
        //     System.Console.WriteLine(p);

        // }

        //a=40 b=50 c=45 şeklinde elimizde bulunan üç sayıdan en büyüğünü bulduran kodu yazınız.

        // int a=400;
        // int b=50;
        // int c=450;

        // int max = int.MinValue;

        // if(a>max)
        // {
        //     max =a;
        // }
        // if(b>max)
        // {
        //     max =b;
        // }
        // if(c>max)
        // {
        //     max =c;
        // }
        // System.Console.WriteLine(max);

        // 20 elemanlı bir int dizisine 1-100 rastgele değerler atayalım . ardından vu dizinin içindeki en küçük ve en büyük  değeri tespit edip ekrana yazdıralım.

        // dizimizi olturup içine rastgele değerşer atıyoruz.

        // Random rnd = new Random();

        // int[] numbers = new int[20];

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 101);
        //     System.Console.WriteLine(numbers[i]);
        // }

        // //en büyük ve en küçükğü bulduruyoruz.
        // int max = int.MinValue;
        // int min = int.MaxValue;

        // foreach (int number in numbers)
        // {
        //     if (number > max) max = number;
        //     if (number < min) min = number;
        // }

        // //en büyük ve en küçüğü yazdırıyoruz.

        // System.Console.WriteLine($"En küçük : {min} \n En Büyük {max}");

        // Random rnd = new Random();

        // int[] numbers = new int[10];

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 1001);
        //     System.Console.WriteLine(numbers[i]);
        // }
        // Array.Sort(numbers);
        // System.Console.WriteLine("Dizenin küçükten büyüğe sıralı hali ");
        // for (int i = 0; i < numbers.Length; i++)
        // {

        //     System.Console.WriteLine(numbers[i]);
        // }
        // Array.Reverse(numbers);
        // System.Console.WriteLine("Dizenin büyükten küçüğe sıralı hali ");
        // for (int i = 0; i < numbers.Length; i++)
        // {

        //     System.Console.WriteLine(numbers[i]);
        // }


        // Random rnd = new Random();

        // int[] numbers = new int[10];

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = rnd.Next(1, 1001);

        // }
        // numbers[0]=99;
        // //Console.WriteLine(Array.IndexOf(numbers,99));
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //    // numbers[i] = rnd.Next(1, 1001);
        //     System.Console.WriteLine($"Index : {i} - Number: {numbers[i]}");
        // }
        // Console.WriteLine(Array.IndexOf(numbers, 99));

        // string fistName = "Samet Önür";
        // System.Console.WriteLine(fistName[4]);

        // string text = "merhaba burak bugün nasılsın";

        // string[] result = text.Split();  //split boşluğa göre ayırır defult olarak eğersplit((bir şey atarsak onu görünce ayırır))

        // System.Console.WriteLine(result[0]);

        // string text = "çok hava çok güzel çok";

        // string[] result = text.Split("çok");  //split boşluğa göre ayırır defult olarak eğersplit((bir şey atarsak onu görünce ayırır))
        // int wordCount = result.Length-1;
        // System.Console.WriteLine(wordCount);

        //Dizileri Kopyalamak

        // string [ ] names = {
        //     "Ayşen",
        //     "Umay",
        //     "Ceyda",
        //     "Begüm"
        // };


        // string[] newNames= new string[names.Length];
        // Array.Copy(names,newNames,names.Length);

        // foreach (var name in names)
        // {
        //     Console.WriteLine(name);
        // }
        // System.Console.WriteLine("-----------------------------");
        // newNames[0] = "Heda";

        // foreach (var name in newNames)
        // {
        //     System.Console.WriteLine(name);   
        // }

        //DİZİDE VAR YOK KONTROLÜ

        // int[] numbers= {2,4,5,6,7};
        // bool exists = Array.Exists(numbers,n  => n==6);

        // System.Console.WriteLine(exists ? "var" : "yok");

        // büyük küçük te yapabilriz

        // int[] numbers = { 2, 4, 5, 6, 7 };
        // bool exists = Array.Exists(numbers, n => n > 6); // > koyarak bakabiliriz.

        // System.Console.WriteLine(exists ? "var" : "yok");

        // dizide belirtilen koşula uygun ilk elemanı getirme

        // int[] numbers = { 2, 4, 5, 6, 7,};
        // int result = Array.Find(numbers,n => n==1);
        // Console.WriteLine(result);

        // dizide belirtilen koşula ugun tüm elemanları getirmek

        // int[] numbers = { 2, 4, 5, 6, 7,5,6 };
        // int[] result =Array.FindAll(numbers,x => x==6);
        //     foreach (var n  in result)
        //     {
        //         System.Console.WriteLine(n);
        //     }

        //DİZİNİN BOYUTUNU (ELEMAN SAYISINI) DEĞİŞTİRMEK

        // int[] numbers = {3,5,7,9};

        // System.Console.WriteLine(numbers.Length);
        // Array.Resize(ref numbers,numbers.Length+1);
        // numbers[3]=55;//yapamıycağımızı göstermek için
        // System.Console.WriteLine(numbers.Length);

        // DİZİNİN BELİRLİ BİR BÖLÜMÜNÜ TEMİZLEMEK
        int[] numbers = { 5, 4, 7, 9, 5, 5, 8, 75, 88, 96 };
        System.Console.WriteLine("Dizinin orjinal hali ");

        foreach (var num in numbers)
        {
            System.Console.WriteLine(num);
        }

        Array.Clear(numbers, 2, 3);
        System.Console.WriteLine("-----------------------------");
        System.Console.WriteLine("Dizinin temizlenmiş hali ");

        foreach (var num in numbers)
        {
            System.Console.WriteLine(num);
        }


    }
}
