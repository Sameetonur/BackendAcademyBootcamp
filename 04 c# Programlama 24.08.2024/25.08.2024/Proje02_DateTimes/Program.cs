using System.Data.Common;

namespace Proje02_DateTimes;

class Program
{
    static void Main(string[] args)
    {
        //c# ta tarih ve saat tipindeli verilerle çalışmak için DateTime adındabir sınıf vardır.
        DateTime now = DateTime.Now;
        //  System.Console.WriteLine($"Şu anki saat ve tarih -> {now}");

        //  System.Console.WriteLine($" 3 hafta sonraki tarih -> {now.AddDays(21)}");
        // System.Console.WriteLine($" e ay sonraki tarih -> {now.AddMonths(3)}");

        // System.Console.WriteLine(now.ToString("dd/MM/yyyy"));
        // System.Console.WriteLine(now.ToString("HH/mm/ss"));
        // System.Console.WriteLine(now.ToString("d"));
        // System.Console.WriteLine(now.ToString("D"));
        // System.Console.WriteLine(now.ToString("MMMM yyyy"));
        // System.Console.WriteLine(now.ToShortDateString());   

        // int day =5;
        // int month = 10;
        // int year = 2024;

        // DateTime date = new DateTime(year, month, day, 4,5,31);
        // System.Console.WriteLine(date);
        // System.Console.WriteLine(date.AddMonths(-3));

        // DateTime birthDate = new DateTime(1975,12,25);
        // int month =birthDate.Month;
        // System.Console.WriteLine();

        System.Console.WriteLine(now.DayOfWeek);



    }
}
