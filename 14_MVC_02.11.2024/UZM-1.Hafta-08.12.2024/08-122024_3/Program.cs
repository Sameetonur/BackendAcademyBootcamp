/*
LINQ(language Integrated Query): C# Programlama Dİlinde veri sorgulama ve dönüştürmek işlemlerini BASİTLEŞTİREN çok güçlü bir özelliktir
Amaç: Farklı veri kaynaklarından sorgulama yapmayı kolaylaştırarak standart ve daha okunabilir hale getirmektir.

TEMEL ÖZELLİKLER:
1- Syntax(Söz Dizimi) bütünlüğü
2- Tip Güvenliği
3- Performans artışı

***NOT: Bazı durumlar için LINQ tercih edilmemek durumunda kalınabilir.İlerledikçe bu konulara örnek senaryolarla çalışıyor olacağız.

LINQ TÜRLERİ
1) LINQ to Object
2) LINQ to Entities
3) LINQ to XML
4) LINQ to Dataset

*/

// int[] numbers = [10, 2, 3, 4, 5, 6, 7, 8, 9, 1];
// //Method Syntax ****************

// var result1 = numbers.Where(x => x % 2 == 0);

// var result2 = numbers.OrderBy(x => x );

// var result3 = numbers.Select(x => x *x);

// foreach (var number in numbers)
// {
//     System.Console.WriteLine(number);
    
// }

// //Query Syntax ****************
// var result4 = from number in numbers
//                 where number%2==0
//                     select number;

//LINQ to Objects 

// List<Student>  students = [
//     new Student {Id=1 , Name="Ahmet"    , Age=18 , Grade=85},
//     new Student {Id=2 , Name="Mehmet"    , Age=17 , Grade=79},
//     new Student {Id=3 , Name="Selim"    , Age=25 , Grade=63},
//     new Student {Id=4 , Name="Ayşe"    , Age=21 , Grade=78},
//     new Student {Id=5 , Name="Mahmut"    , Age=22 , Grade=55},

// ];


// //Grade değer 90 ve üzeri olanları filtrelemek istiyoruz.
// //1)Method Syntax
//     var result = students
//                 .Where(x => x.Grade > 90)
//                 .OrderBy(x=> x.Name);
//                 foreach (var s in result)
//                 {
//                     System.Console.WriteLine($"{s.Name}: {s.Grade}");
//                 }


// //2) Query Syntax
//     var resultquery = from student in students
//                             where student.Grade>=90
//                                 orderby student.Name
//                                     select student;
// foreach (var s in resultquery)
// {
//     System.Console.WriteLine($"{s.Name}: {s.Grade}");
// }

//LINQ to Arrays
//ilk yazdığımız linq kodları buna bir örnektir.

//


class Student
 {
    public int Id { get; set; } 
    public string? Name { get; set; }
    public int Age { get; set; }
    public int Grade { get; set; }

 }

                
