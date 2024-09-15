using Project04_IngeritanceSamples.CarManagmentSystem;
using Project04_IngeritanceSamples.SchollSystem;

namespace Project04_IngeritanceSamples;



class Program
{
    static void Main(string[] args)
    {
        // Kisi kisi1 = new Kisi("Samet","Önür",new DateTime(2000));
        // kisi1.BilgileriEkranaYaz();

        // Ogrenci ogr1 = new Ogrenci("Murat","Önür",new DateTime(2000,4,21),2548452);
        // ogr1.BilgileriEkranaYaz();

        // Ogretmen ogrtmn1 = new Ogretmen("murat","kara",new DateTime(1996,5,7),85655,"matematik");
        // ogrtmn1.BilgileriEkranaYaz();

        Car car1 = new Car("nissan", "kaşkai", 2023, 4);
        car1.Bilgilendirme();
        car1.OpenTrunk();
        car1.Start();
        
        System.Console.WriteLine();

        MotorCycle motor1 = new MotorCycle("honda","Yamaha",2020,"Su Soğutmalı");
        motor1.Bilgilendirme();
        motor1.Start();
























        // Cat cat1 = new Cat("Heda", 1, "Mor");
        // cat1.MakeSound();

        // Dog dog1 = new Dog("Coni",3,60,"doğurgan");
        // dog1.MakeSound();
        // dog1.Swimm();
    }
}
