// //Bir E Ticaret sistemim  var. Ürünlerin farklı tüpleri olabilir. Elektronik,Gıda,Giyim ... Her ürünlerin temel özellikleri aynı iken, bazı özellikleri tipe göre değişiklik gösterebilir. Bu durumda üst sınıf olarak planlayacağımız Product bir abstract class olacaktır.

Electronic electronic1 = new()
{
    Id = 1,
    Name = "Müzik Çalar",
    Price = 580
};

Clothing clothing = new()
{
    Id = 2,
    Name = "Erkek Kot Pantalon",
    Price = 400

};


decimal discount = electronic1.CalculateDiscountedPrice();
System.Console.WriteLine(discount);
decimal discount1 = clothing.CalculateDiscountedPrice();
System.Console.WriteLine(discount1);

interface IProduct
{

    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal Price { get; set; }

    public decimal CalculateDiscountedPrice();

}



class Electronic : IProduct
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }

    public decimal CalculateDiscountedPrice()
    {
        double result = (double)Price * 0.1;
        return Convert.ToDecimal(result);
    }
}


class Clothing : IProduct
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }

    public decimal CalculateDiscountedPrice()
    {
        double result = (double)Price * 0.2 + 1;
        return Convert.ToDecimal(result);
    }
}





























// abstract class Product{

//     public int Id { get; set; }

//     public string? Name { get; set; }

//     public decimal Price { get; set; }

//     public abstract decimal CalculateDiscountedPrice();


// }

// class Electronic : Product
// {
//     public int WarrantPeriod { get; set; }
//     public override decimal CalculateDiscountedPrice()
//     {
//         throw new NotImplementedException();
//     }
// }

// class Clothing : Product
// {
//     public string? Size { get; set; }
//     public override decimal CalculateDiscountedPrice()
//     {
//         throw new NotImplementedException();
//     }
// }


