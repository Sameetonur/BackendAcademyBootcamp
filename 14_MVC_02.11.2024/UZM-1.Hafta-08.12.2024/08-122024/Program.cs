//Senkron
// String şiçinde  \r ne  işe yarar araştırınız.

// System.Console.WriteLine("Birinci İşlem[5 Saniye]");
//  for (int i = 1; i  <=5; i++)
//  {
//     System.Console.WriteLine($"\r[1.İşlem] Geçen Süre : {i}.sn");
//     Thread.Sleep(1000);
//  }
//  System.Console.WriteLine("2.İşlem(10 Saniye) Sona erdi");

// System.Console.WriteLine("ikinci İşlem[10 Saniye]");
// for (int i = 1; i <= 10; i++)
// {
//     System.Console.WriteLine($"\r[2.İşlem] Geçen Süre : {i}.sn");
//     Thread.Sleep(1000);
// }
// System.Console.WriteLine("2.İşlem(10 Saniye) Sona erdi");

//Asenkron

string task1Status ="5 saniyelik işlem bekleniyor...";
string task2Status = "10 saniyelik işlem bekleniyor...";

object consolelock = new Object();


Thread thread1 =  new Thread(()=>{
    for (int i = 1; i <=5; i++)
    {
        lock(consolelock)
        {
            task1Status = $"5 saniyelik işlem için geçen süre: {i} sn";
            Console.Clear();
            System.Console.WriteLine($"{task1Status}\n{task2Status}");
        }
        
        Thread.Sleep(1000);
    }
    lock (consolelock)
    {
        task1Status = "5 saniyelik işlem tamamlandı!";
        Console.Clear();
        System.Console.WriteLine($"{task1Status}\n{task2Status}");
    }
  
});

Thread thread2 = new Thread(() =>
{
    for (int i = 1; i <= 10; i++)
    {
        lock(consolelock)
        {
            task2Status = $"10 saniyelik işlem için geçen süre: {i} sn";
            Console.Clear();
            System.Console.WriteLine($"{task1Status}\n{task2Status}");
        }
  
        Thread.Sleep(1000);
    }
    lock(consolelock)
    {
        task2Status = "10 saniyelik işlem tamamlandı!";
        Console.Clear();
        System.Console.WriteLine($"{task1Status}\n{task2Status}");
    }
  
});

thread1.Start();
thread2.Start();