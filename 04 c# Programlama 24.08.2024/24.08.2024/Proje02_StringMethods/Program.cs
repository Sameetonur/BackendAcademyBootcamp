namespace Proje02StringMethods;

class Program
{
    static void Main(string[] args)
    {
        //  string fullName = "halil Umut MELER";

        // int len = fullName.Length;

        // System.Console.WriteLine(len);
        // Console.WriteLine(fullName.ToLower());//küçük harfe çevirir

        // Console.WriteLine(fullName.ToUpper());// büyük harfe çevirir

        // string address1="Canakkale Şeh. Caddesi";
        // string address2="No : 16 D:5 K: 5";
        // string address3="Sultangazi";
        // string address4="İstanbul";

        //  string address = address1 +" "+ address2 +" "+ address3+ "/" + address4;
        //  System.Console.WriteLine(address);

        //  string fulladdress = $"{address1} {address2} {address3}/{address4}";
        //  System.Console.WriteLine(fulladdress);

        // string text1 ="Nişantaşı";
        // string text2 = "Üniversitesi";
        // string loc1 = "Bayrampaşa";
        // string currentLoc = "Sarıyer";
        // string date1 = " 09.09.2009";
        // string date2 = "05.05.2015";

        // // Nişantaşı üniversitesi 
        // string aciklama = $" {text1} {text2}, {date1} tarihinde İstanbul'un {loc1} İlçesinde faaliyete başladı. Ardından {date2} tarihinde yine İstanbul'un {currentLoc} ilçesinde kurulan TechCampus'e taşındı ";

        // System.Console.WriteLine(aciklama);

        // System.Console.WriteLine("----------------------------------");
        // string aciklama2 = String.Concat(text1," ", text2,", ",date1," tarihinde İstanbul'un", loc1," ilçesinde faaliyete başladı. Ardından ", date2," tarihinde yine İstanbulun", currentLoc, "İlçesinde kurulan TechCampus'e taşındı.");

        // System.Console.WriteLine(aciklama2);

        // string fullName = "halil Umut MELER";
        // string fineText = "umut";
        // bool response = fullName.ToLower().Contains(fineText.ToLower()); //constains küçük harf büyük harf  duyarlıdır.(o yüzden ToLower ile metni komple küçük harfe çevirip küçük harf ile sorgulatıyoruz.)
        // System.Console.WriteLine(response);

        // string firstName = "Begüm";
        // Console.WriteLine(firstName.IndexOf("ü"));// sarayı bulmak için kullanılır IndexOf.(-1)

        // string firstName = " Ayşen Umay";
        // System.Console.WriteLine(firstName.StartsWith("Ayşen"));
        // System.Console.WriteLine(firstName.EndsWith("Umay"));

        string newTitle = "Dolar'ın ateşi çıktı!";
        string new1 = "54651";
        string new2 = "Başlık";
        newTitle = newTitle.ToLower();


        string newUrl = newTitle.Replace(" ", "-");
        newUrl = newUrl.Replace("'", "");
        newUrl = newUrl.Replace("ş", "s");
        newUrl = newUrl.Replace("ç", "c");
        newUrl = newUrl.Replace("!", "");
        newUrl = newUrl.Replace("ı", "i");

        newUrl = $"{newUrl}-{new1}-{new2}";

        System.Console.WriteLine(newUrl);


    }
}
