namespace ArraysHomework;

class Program
{
    static void Main(string[] args)
    {
        #region soru1

        // int[] sayılar = { 3, 5, 2, 8, 4, 15, 20, 11, 12, 9 };

        // for (int i = 1; i < sayılar.Length - 1; i++)
        // {
        //     if (sayılar[i] > sayılar[i - 1] && sayılar[i] > sayılar[i + 1])
        //     {
        //         System.Console.WriteLine($"{sayılar[i]} sağındaki ve solundaki sayılardan büyüktür!");
        //     }   
        // }
        #endregion

        #region Soru2

        // int[] dizi = new int[10];
        // int[] ciftDizi = new int[10];
        // int sayaç = 0;
        // System.Console.WriteLine("10 adet sayı giriniz = ");

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     while (!int.TryParse(Console.ReadLine(), out dizi[i]))
        //     {
        //         System.Console.WriteLine("geçerli sayı giriniz");
        //     }
        // }

        // System.Console.WriteLine("------------------------------------------------");

        // foreach (var sayı in dizi)
        // {
        //     System.Console.WriteLine(sayı);
        // }

        // for (int i = 0; i < 10; i++)
        // {
        //     if (dizi[i] % 2 == 0)
        //     {
        //         ciftDizi[sayaç] = dizi[i];
        //         sayaç++;

        //     }

        // }

        // Array.Sort(ciftDizi);
        // System.Console.WriteLine("Çiftve küçükten büyüğe sıralı dizilerim ");
        // foreach (var item in ciftDizi)
        // {
        //     System.Console.WriteLine(item);
        // }

        #endregion

        #region Soru3

        // 10 elemanlı rastgele değerlerden oluşan bir dizideki tüm pozitif sayıları ve negatif sayıları ayrı dizilere ayıran ve her iki diziyi de ekrana yazdıran bir program yazın.İşlemi gerçekleştirmek için `while` döngüsü kullanın.

        // int[] dizi = new int[10];
        // int[] pozDizi = new int[10];
        // int[] negdİZİ = new int[10];
        // int sayaç = 0;
        // int sıra =1;
        // int sayaç1=1;

        // Random rnd = new Random();

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i] = rnd.Next(-10, 11);
        // }

        // foreach (var eleman in dizi)
        // {
        //     // for (int i = 1; i <= dizi.Length ; i++)
        //     // {
        //     //      sıra = i;
        //     // }
        //     System.Console.WriteLine($"{sayaç1}. {eleman}");
        //     sayaç1++;

        // }

        // for (int i = 0; i < 10; i++)
        // {
        //     if (dizi[i] > 0)
        //     {
        //         pozDizi[sayaç] = dizi[i];
        //         sayaç++;
        //     }

        //     if (dizi[i] < 0)
        //     {
        //         negdİZİ[sayaç] = dizi[i];
        //         sayaç++;
        //     }


        // }
        // System.Console.WriteLine("Negatif dizim");
        // System.Console.WriteLine("---------------------------------");
        // foreach (var item in negdİZİ)
        // {
        //     System.Console.WriteLine(item);
        // }
        // System.Console.WriteLine("pozitif dizim");
        // System.Console.WriteLine("---------------------------------");
        // foreach (var item in pozDizi)
        // {
        //     System.Console.WriteLine(item);
        // }


        #endregion

        #region Soru4

        // //100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde tekrar eden elemanları bulan bir program yazın.Diziyi tararken, elemanların hangi pozisyonlarda(kaçıncı indexte) tekrarlandığını ekrana yazdırın.Bu işlemi hem `for` hem de `foreach` döngüleri ile gerçekleştirin.
        // int sayaç=0;
        // int sayaç1 = 0;
        // int sayaç2= 0;
        // bool tekrar=false;
        // int[] dizi = new int[20];
        // int[] tekrarElDiz = new int[20];

        // int addSayaç=0;

        // Random rnd = new Random();

        // for (int i = 0; i < dizi.Length ; i++)
        // {
        //     dizi[i]=rnd.Next(1,21);
        // }

        // foreach (var eleman in dizi)
        // {
        //     System.Console.WriteLine($" {sayaç}. Elemanı =>{eleman}");
        //     sayaç++;
        // }

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     for (int j = i + 1; j < dizi.Length; j++)
        //     {
        //         if (dizi[i] == dizi[j])
        //         {
        //             Console.WriteLine($"Sayı {dizi[i]} index {i} ve index {j} tekrar ediyor.");
        //         }
        //     }
        // }
        #endregion

        #region Soru5
        //Klavyeden girilen bir sayının, 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde olup olmadığını kontrol eden bir algoritma yazın.Eğer sayı  dizide varsa, sayının dizideki yerini ve tekrar sayısını ekrana yazdırın.
        //     int sayaç = 0;
        //     int[] dizi = new int[20];
        //     int sayaç1=0;

        //     Random rnd = new Random();

        // System.Console.WriteLine("bir sayı giriniz");
        // int input = int.Parse(Console.ReadLine());

        //     for (int i = 0; i < dizi.Length; i++)
        //     {
        //         dizi[i] = rnd.Next(1, 21);
        //     }
        //     foreach (var item in dizi)
        //     {
        //         System.Console.WriteLine($" {sayaç}.İndex = {item}");
        //         sayaç++;
        //     }
        //     for (int i = 0; i < dizi.Length; i++)
        //     {

        //         if(dizi[i] == input)
        //         {
        //             sayaç1++;
        //             System.Console.WriteLine($"Girilen sayı => {i}.İndexte bulunuyor. "); 
        //         }

        //     }
        //     System.Console.WriteLine($"Girdiğiniz (sayı= {input}) dizide {sayaç1} kere geçiyor");
        #endregion

        #region Soru6
        //100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en büyük ve en küçük sayıyı bulan programı yazın.

        // int[] dizi = new int[10];

        // Random rnd = new Random();

        // for (int i = 0; i < dizi.Length; i++)
        // {   
        //     dizi[i]=rnd.Next(1,11);
        // }

        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }

        // Array.Sort(dizi);
        // int enBuyuk = dizi[0];
        // System.Console.WriteLine($"Dizinin en küçüğü {enBuyuk}");
        // Array.Reverse(dizi);

        // int enKucuk =dizi[0];
        // System.Console.WriteLine($"Dizinin en Büyüğü {enKucuk}");


        #endregion

        #region Soru7
        // 50 elemanlı rastgele değerlerden oluşan bir tam sayı dizisindeki tüm çift sayıları toplayan ve bu toplamı ekrana yazdıran bir program yazın. `foreach` döngüsü kullanarak bu işlemi gerçekleştirin.
        // int toplam = 0;
        // int[] dizi = new int[10];


        // Random rnd = new Random();

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i] = rnd.Next(1, 11);
        //     if (dizi[i] % 2 == 0)
        //     {
        //         toplam += dizi[i];
        //     }
        // }

        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }


        // System.Console.WriteLine($"Çiftlerin toplamı {toplam}");

        #endregion

        #region Soru8
        //Klavyeden girilen bir sayıyı, 10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde aratın.Eğer sayı dizide yoksa, diziyi sıralayın ve sayıyı dizinin doğru(olması gereken sıra) yerine ekleyin. Ekledikten sonra yeni diziyi ekrana yazdırın.


        // int[] dizi2= new int[10];
        // int[] dizi = new int[10];
        // int sayaç=0;

        // Random rnd = new Random();

        // for (int i = 0; i < dizi.Length; i++)
        // {   
        //     dizi[i] =rnd.Next(1,11);
        // }
        // System.Console.WriteLine("RANDOM OLUŞAN DİZİM");
        // System.Console.WriteLine("----------------------");
        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }

        // System.Console.Write("Bir sayı giriniz = ");
        // int input = int.Parse(Console.ReadLine());

        // bool varmi =Array.Exists(dizi,elemen)

        #endregion

        #region Soru9

        // int[] dizi={-6,5,6,-9,-8,2,6,7,1,-50};

        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     if (dizi[i]>0)
        //     {
        //         dizi[i]=-dizi[i];
        //     }
        // }

        // Array.Sort(dizi);
        // Array.Reverse(dizi);
        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }
        #endregion

        #region Soru10
        // Random rnd=new Random();
        // int[] dizi =new int[5];
        // int[] dizi2 = new int[5];
        // int sayaç=0;
        // for (int i = 0; i < 5; i++)
        // {
        //     dizi[i]=rnd.Next(1,79);


        // }

        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }
        // System.Console.WriteLine("--------------------------");
        // Array.Reverse(dizi);
        // foreach (var item in dizi)
        // {
        //     System.Console.WriteLine(item);
        // }

        #endregion

        #region soru11

        #endregion
    }
}
