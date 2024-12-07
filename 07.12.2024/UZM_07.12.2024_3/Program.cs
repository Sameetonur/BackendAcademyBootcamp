
// /*  
// OrderStatus:
//      1-> Sipraiş Alındı
//      2-> Kargo Hazırlanıyor
//      3-> Kargoya Verildi
//      4-> Teslim Edildi
// */

// // Yeni Spariş

// int OrderStatus=1;

// //Kargo Hazırlanıyor
// OrderStatus =2;

// //Kargoya Verildiği zaman
// OrderStatus=3;

// //Teslim Edildi
// OrderStatus=4;

//Sipariş Alındı
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

OrderStatus status = OrderStatus.Received;

// //Hazırlanıyor
// status = OrderStatus.Prossesing;
// status=OrderStatus.Shipped;

// enum OrderStatus
// {
//    Received,//0

//    Prossesing,//1

//    Shipped,//2

//    Delivered//3

// }
Gender gender1 = Gender.Female;



status = OrderStatus.Shipped;
System.Console.WriteLine(status);
string? statusDescription = status
        .GetType()?
        .GetField(status.ToString())?
        .GetCustomAttribute<DescriptionAttribute>()?
        .Description;

System.Console.WriteLine(statusDescription);

status = OrderStatus.Delivered;
string? statusDescription2 = status
        .GetType()?
        .GetField(status.ToString())?
        .GetCustomAttribute<DisplayAttribute>()?
        .Name;

System.Console.WriteLine(statusDescription2);

enum Gender
{
    Female,

    Male
}

// enum OrderStatus
// {
//     Received=1,
//     Prossesing=2,
//     Shipped=3,
//     Delivered=4,
// }

enum OrderStatus
{
    [Description("Sipariş Alındı")]
    [Display(Name = "Sipariş Alındı")]
    Received = 1,

    [Description("Hazırlanıyor")]
    [Display(Name = "Hazırlanıyor")]
    Prossesing = 2,

    [Description("Kargoya Verildi")]
    [Display(Name = "Kargoya Verildi")]
    Shipped = 3,

    [Description("Teslim Edildi")]
    [Display(Name = "Teslim Edildi")]
    Delivered = 4,
}