namespace Project01_OOP_Intro;


class FirstClass
{
    //Buraya sınıfın özellik ve  davranışlarını kodluyor olacağız
    //özellik : property
    //Davranış : Method
    // private: buraya özel

    public string message;

    public string age;

    public void DisplayMessage()
    {
        System.Console.WriteLine(message);
    }

}
class Program
{
    static void Main(string[] args)
    {
        FirstClass frm = new FirstClass();
        frm.message ="Selam";

        //System.Console.WriteLine(frm.message);
        frm.DisplayMessage();


    }
}
