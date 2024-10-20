using Microsoft.AspNetCore.Mvc;
using Project07_MVCTemelleri.Models;

namespace Project07_MVCTemelleri.Controllers
{
    public class MVC03DataTransferController : Controller
    {


        List<Category> categoryList;
        List<Product> productList;
   

        
        public MVC03DataTransferController()
        {
            categoryList = [
               new Category { Id = 1, Name="Telefon", Description="Telefon Kategorisi"},
                new Category { Id = 2, Name="Bilgisayar", Description="Bilgisayar Kategorisi"},
                new Category { Id = 3, Name="Kitap", Description="Kitap Kategorisi"},
                new Category { Id = 4, Name="Oyuncak", Description="Oyuncak Kategorisi"}
           ];


            productList = [
                     new Product { Id=1, Name="Iphone 16", CategoryId=1,Price=120000},
                    new Product { Id=2, Name="Iphone 15", CategoryId=1,Price=50000},
                    new Product { Id=3, Name="Iphone 14", CategoryId=1,Price=40000},
                    new Product { Id=4, Name="Iphone 13", CategoryId=1,Price=30000},
                    new Product { Id=5, Name="Samsung Ultra S24", CategoryId=2,Price=18000},
                    new Product { Id=6, Name="Samsung Ultra S23", CategoryId=2,Price=6000},
                    new Product { Id=7, Name="Samsung Ultra S22", CategoryId=2,Price=20000},
                    new Product { Id=8, Name="Xiomi S24", CategoryId=3,Price=2000},
                    new Product { Id=9, Name="Xiomi S24", CategoryId=3,Price=52000},
                    new Product { Id=10, Name="Xiomi S24", CategoryId=3,Price=12000},
            ];

        }


        public ActionResult Index()
        {
            string name = "Samet Önür";
            ViewBag.WelcomeMessage = $"Hoşgeldin {name}";

            List<Category> categoryList = [
                new Category { Id = 1, Name="Telefon", Description="Telefon Kategorisi"},
                new Category { Id = 2, Name="Bilgisayar", Description="Bilgisayar Kategorisi"},
                new Category { Id = 3, Name="Kitap", Description="Kitap Kategorisi"},
                new Category { Id = 4, Name="Oyuncak", Description="Oyuncak Kategorisi"}
            ];
            ViewBag.CategoryList = categoryList;
            ViewData["CategoryList"] = categoryList;
            return View();

        }

        public ActionResult ModelData()
        {
            //model bazlı veri yollama
            return View(categoryList);
        }

        public ActionResult HomePage()
        {
            string message ="Uygulamamıza Hoş Geldiniz!";
            Campaign campaign =new(){
                Id=1,
                Title="1000TL üzeri ücretsiz Kargo",
                Description="Sepet toplamı 1000tl ve üzeri kargo bizden",
                ImageUrl= "/img/kategorimage.jpg"
            };

            HomePageModel model = new()
            {
                Categories = categoryList,
                Products = productList,
                Message =message,
                Campaign= campaign
            };

            return View(model);
        }
    }






}



