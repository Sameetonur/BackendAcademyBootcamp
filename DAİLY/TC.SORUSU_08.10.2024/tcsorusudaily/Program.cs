namespace tcsorusudaily;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan T.C. Kimlik numarasını alıyoruz.
        Console.Write("Lütfen T.C. Kimlik Numaranızı Giriniz: ");
        string tcKimlikNo = Console.ReadLine();

        // Eğer uzunluğu 11 değilse, hatalı giriş yapıldığını bildirelim.
        if (tcKimlikNo.Length != 11 || !long.TryParse(tcKimlikNo, out _))
        {
            Console.WriteLine("Hatalı T.C. Kimlik Numarası! 11 basamaklı olmalıdır ve yalnızca rakamlardan oluşmalıdır.");
            return;
        }

        // Her karakteri integer bir diziye çeviriyoruz.
        int[] tcDigits = new int[11];
        for (int i = 0; i < 11; i++)
        {
            tcDigits[i] = int.Parse(tcKimlikNo[i].ToString());
        }

        // İlk 9 haneden 10. haneyi bulalım.
        int sumOdd = tcDigits[0] + tcDigits[2] + tcDigits[4] + tcDigits[6] + tcDigits[8]; // 1, 3, 5, 7, 9. haneler
        int sumEven = tcDigits[1] + tcDigits[3] + tcDigits[5] + tcDigits[7]; // 2, 4, 6, 8. haneler
        int tenthDigit = (sumOdd * 7 - sumEven) % 10;

        // İlk 10 haneden 11. haneyi bulalım.
        int sumAll = 0;
        for (int i = 0; i < 10; i++)
        {
            sumAll += tcDigits[i];
        }
        int eleventhDigit = sumAll % 10;

        // Sonuçları kontrol edelim.
        bool isValid = (tcDigits[9] == tenthDigit) && (tcDigits[10] == eleventhDigit);

        if (isValid)
        {
            Console.WriteLine("Geçerli bir T.C. Kimlik Numarası.");
        }
        else
        {
            Console.WriteLine("Geçersiz bir T.C. Kimlik Numarası.");
        }




    }
}
