namespace Project03_Class_Inheritance;

class Bird
{
    public void Fly()
    {
        System.Console.WriteLine("Kuş uçuyor!");
    }
}

class Penguin : Bird//base  class (miras veren class)
{
    public void Swim()
    {
        System.Console.WriteLine("Penguen yüzüyor");
    }

}

class Otomobil
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int ModelYılı { get; set; }
}

class IctenYanmalıOto  : Otomobil
{
    public string YakıtTipi { get; set; }
    public string MotorGücü { get; set; }

}

class ElektrikliOto : Otomobil
{
    public string Menzil { get; set; }
    public bool KendiniŞarjEtme { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Penguin penguin1 = new Penguin();

        // penguin1.Swim();
        // penguin1.Fly();

        ElektrikliOto elektriklioto1 =new ElektrikliOto();
        elektriklioto1.KendiniŞarjEtme=true;

        
    }
}
