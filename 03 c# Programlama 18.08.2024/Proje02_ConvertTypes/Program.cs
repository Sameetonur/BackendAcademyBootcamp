using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace Proje02_ConvertTypes;

class Program
{
    static void Main(string[] args)
    {
        #region Imlicity Convert(Örtülü dönüştürme)

        // int myAge=49;
        // long newMyAge= myAge;//int to long

        // float rate = 0.87f;
        // double newRate = rate;//float to double

        #endregion

        #region Explicit Convert (Açık Dönüştürme)

        // double myValue = 123.58;
        // int newMyValue = (int)myValue;//Cast etmek  ya da Unboxig
        // System.Console.WriteLine("myValue: " + myValue + "-- newMyValue: " + newMyValue);

        // string numberString ="123";
        // int result =Convert.ToInt32(numberString)  + 7 ;
        // System.Console.WriteLine(result);
        // System.Console.WriteLine(numberString);

        // long numberLong = 58;
        // int numberInt = Convert.ToInt32(numberLong);
        // System.Console.WriteLine(numberInt);


        // int numberInt = 256;
        // byte numberByte = Convert.ToByte(numberInt);////önemli!!
        // System.Console.WriteLine(numberInt);

        //  string age ="57";
        //  byte ageByte = byte.Parse(age);
        //  System.Console.WriteLine(ageByte);

        // string number ="125&";
        // int numberInt =int.Parse(number);
        // System.Console.WriteLine(numberInt);

        // string number = "125";
        // int numberInt;
        // bool result = int.TryParse(number, out numberInt);
        // System.Console.WriteLine(result);

        //00000000-00000000-00000001-00000000
        // int numberInt = 257;
        // byte numberByte = (byte)numberInt;
        // System.Console.WriteLine(numberByte);

        // int tarih = 567;
        // string stgtarih = tarih.ToString();
        // System.Console.WriteLine(stgtarih);

        // int a = 5;
        // int b = 58;
        // string resultstring = a.ToString() + b.ToString();

        // string resultstring2 = (a + b).ToString();

        // System.Console.WriteLine(resultstring);
        // System.Console.WriteLine(resultstring2);





        #endregion
    }
}
