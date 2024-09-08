using System.Runtime.CompilerServices;

namespace Proje_Method;

class Program
{

    static void Greet()
    {
        System.Console.WriteLine("Merhaba Dünya");
    }

    static string Greet2(string name, bool gender)
    {
        if(gender)
        {
            return $"Merhaba {name} Hanım :)";
        }   
            return $"Merhaba {name} Bey :)";   
    }

    static int Sum1()
    {
        int a = 40;
        int b = 50;
        int c = a + b;
        return c;
    }

    static int Sum2(int num1, int num2)
    {
        int resul = num1 + num2;
        return resul;
    }

    static double SumSqrt(double num1, double num2)
    {
        double total = num1 + num2;
        double result = Math.Sqrt(total);
        return result;
    }

    static void SampleNumberValue(ref int originalNumber)
    {
        originalNumber+=3;
        System.Console.WriteLine($"Methodun içindeki yazdırma satırı: {originalNumber}");
    }

    static void Bolme(int bolunen, int bolen, out int bolum , out int kalan)// out ile birden fazla veriyi gönderebiliyoruz çünkü return tek bir değer döndürebiliyor.
    {
         bolum = bolunen / bolen;
         kalan = bolunen % bolen;
        
    }
    static void Main(string[] args)
    {
        int bolum;
        int kalan;
        Bolme(8, 3, out bolum, out kalan);
        System.Console.WriteLine($"8/3={bolum}\n 8/3 işleminden kalan {kalan}");



        //Greet();
        // int x = Sum1();
        // int y = Sum2(50, 70);
        // int z = Sum2(90, 250);
        // System.Console.WriteLine(x + y + z);

        // double result1 = SumSqrt(4, 12);//4
        // double result2 = SumSqrt(5, 11);//4
        // double result3 = SumSqrt(2, 23);//5
        // double result4 = SumSqrt(7, 42);//7

        // Console.WriteLine(Greet2("Tuna",true));
        // Console.WriteLine(Greet2("Samet", false));

        //  int originalNumber  =15;
        //  System.Console.WriteLine($"Method çağırılmadan önceki değeri: {originalNumber}");

        //  SampleNumberValue( ref originalNumber);

        // System.Console.WriteLine($"Method çalıştıktan sonraki number : {originalNumber}");

    }
}
