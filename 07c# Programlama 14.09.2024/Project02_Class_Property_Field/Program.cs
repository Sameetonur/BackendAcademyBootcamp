using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;

namespace Project02_Class_Property_Field;

//class Product
{
    public int id;
string name;
decimal price;
bool İsActive;
//Class içindeki bilgileri dışarya kontrollü bir şekilde açıılmasını sağlayan apılara properrty diyoruz. yaptığımız bu işe  iste KAPSÜLLEME(ENCAPSULATİON) DİYORUZ.
public string Name
{
    get
    {
        string result = name.Substring(0, 3);
        return result.ToUpper();
    }
    set
    {
        name = value;
    }
}

public decimal Price
{
    get
    {
        return price;
    }
    set
    {
        if (value < 0)
        {
            price = 0;

        }
        else
        {
            price = value;
        }
        //price=value<0 ? 0:value;
    }
}

}

class Product
{
    // private int id;
    // public int Id
    // {
    //     get { return id; }
    //     set { id = value; }
    // }

    public int Id { get; set; }
    public string Name { get; set; } = ""; // ? // ="";// hatayı kapatmak için  çözümler stringte.
    public string? Description { get; set; }
    public required string Notes { get; set; } //required illaki bir şey atıyacağım anlamınageliyor
    public decimal price { get; set; }
    public bool IsActive { get; set; }


}

class Student
{
    public Student()
    {
        System.Console.WriteLine($"{DateTime.Now} Zamanında yeni bir Student oluşturuldu...");
    }

    public Student(int studentNumber)
    {
        StudentNumber = studentNumber;
        System.Console.WriteLine($"{DateTime.Now} Zamanında yeni bir Student oluşturuldu...");

    }
    public int StudentNumber { get; set; }
    public string FirftName { get; set; }
    public string LastName { get; set; }
    public byte Age { get; set; }
    public bool İsActive { get; set; }


}

class Category
{
    public Category(int id, string name, string description)//ctor bunu oluştururken oluşturdupun propları seçip ampule basıp otomatik yazdırabilirsin genereted... seçip
    {
        Id = id;
        Name = name;
        Description = description;
    }
    public int Id { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }


}
class Program
{
    static void Main(string[] args)
    {


        Category cate = new Category(1, "murat", "ok yakışıklı bir cocuk");
        













        //     Product prod = new Product(){Notes="BirŞeyler"};

        //     prod.Id=5;
        //     prod.Name ="murat";
        //     prod.Notes="birşeyler";
        //    //

        // Student s1 = new Student();

        // Student s2 = new Student(48);
        // System.Console.WriteLine(s2.StudentNumber);

    }
}
