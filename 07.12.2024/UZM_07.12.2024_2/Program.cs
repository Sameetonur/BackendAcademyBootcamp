/*
    c#8 .0 isonrasında, referance türlerini nullable yapıısı içinde ele alabilme zeşşiği eklenmiştir. bu özellik sayesinde, kod yazarken nulldeğerlerle çalışmayı daha gücenli hale getirebilriz.

    VARSAYILAN DAVRANIŞ
    nullable referance Type Kapalı :(tüm referance türleri varsayılan olarak nullable'dir.)-> Klasik(eski yaklaşım).
    nullable referance type Açık :Tüm referance türleri varsayaılan olarak non-nullabledir. --> Yeni yaklaşım

*/
// string? firstName;

// #nullable disable

// Category category = null;

// class Category
// {
//     public string? Name {get; set;}

//     #nullable disable
//     public string Title { get; set; }

// }
//**********************************************

// string? nullableString = null;
// string nonNullableString ="Merhaba";

// if(nullableString != null)
//     System.Console.WriteLine(nullableString.Length);

// System.Console.WriteLine(nullableString?.Length);

// System.Console.WriteLine(nonNullableString.Length);
//************************************************
//  string? greeting ="Hello!";

// if(greeting==null)
// {
//     greeting = "Hello";
// }

//Null Coalasing Assignment Operator
// greeting ??="Hello";
// System.Console.WriteLine(greeting);
// //Mach Paten
// // if(greeting is null)
// // {

// // }
//**************************************************
//Null Assertin Operator
string? firstName =null;
System.Console.WriteLine(firstName!.Length);

/*
    Modern kodlamada bu null kontrol mekanizmalarından  yaralanmak oldukça faydalıdır.Kodummuzun daha güvenli ve okunambilir hale gelmesini sağlar. Aynı zamanda  Run Time(Çalışa zamaı) hatalarını azaltma konusunda da faydalıdır. Bu da kodumuzun kaliteli kod olmasını sağlayan unsurlardan biridir.
*/




