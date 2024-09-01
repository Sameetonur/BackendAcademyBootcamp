using System.Reflection.Metadata.Ecma335;

namespace Project2_GuessNumberGame;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        int generatedNumber = rnd.Next(1, 101);
        Console.WriteLine($"{generatedNumber} (Random Sayısı) ");

        Console.WriteLine("------------------------------------------------------------------");
        System.Console.WriteLine();

        int guessNumber;
        int live = 1;
        int liveLimit = 5;
        string resultMessage = "";
        string deneme = "";

        do
        {
            Console.Write($"{live}.Hak(1-100): ");
            guessNumber = int.Parse(Console.ReadLine());
            if (guessNumber < generatedNumber)
            {
                resultMessage = "Daha büyük bir sayı giriniz!";
            }
            else if (guessNumber > generatedNumber)
            {
                resultMessage = "Daha küçük bir sayı giriniz!";
            }

            if (guessNumber != generatedNumber) live++;

            if (live <= liveLimit && guessNumber != generatedNumber) Console.WriteLine(resultMessage);


            do
            {

                Console.Write($"{live}.Hak(1-100): ");
                guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber < generatedNumber)
                {
                    resultMessage = "Daha büyük bir sayı giriniz!";
                }
                else if (guessNumber > generatedNumber)
                {
                    resultMessage = "Daha küçük bir sayı giriniz!";
                }

                if (guessNumber != generatedNumber) live++;

                if (live <= liveLimit && guessNumber != generatedNumber) Console.WriteLine(resultMessage);




            } while (guessNumber != generatedNumber && live <= liveLimit);
            resultMessage = guessNumber == generatedNumber ? $" Kazandın! \n Puanın:{(liveLimit - live + 1) * 10} " : "Kaybettin!";
            System.Console.WriteLine("Tekrar oynamak ister misin ?");
            deneme = Console.ReadLine();
            Console.WriteLine(resultMessage);
            System.Console.WriteLine("Tekrar oynamak ister misin ?");

        }
        while (deneme != "h");











    }
}


/*
    Sayı Tahmin Oyunu

    Uyg rast gele üreteceği 1-100 arasındaki sayıyı kullanıcı tahmin ederek bulmasını sağlayacağımız kodu yazınız.

    Kullanıcının tahmini üretilen sayıdan küçükse ya da büyükse buna göre aşağı yukarı yönlendirme yapsın..

    kullanıcının 5 hakkı olsun.

    kullanıcı doğru tahmin yaptıysa ya da tahmin hakkı dolduysa(uygun mesajı vererek) oyun sona ersin
*/
