// buradaki tüm kodlar aslnda Main metodun içerisindeler
var builder = WebApplication.CreateBuilder(args);//bir web app oluşturucu

// Bu satorla bu uygulamanın bir mvc uygulaması olucağı bildiriliyor
builder.Services.AddControllersWithViews();

var app = builder.Build();//bir web app(mvc) oluşturuluyor

// bu aşamadan  run yapılana kadar olan kısımda  gelen istekler yapılandırılıyor.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();//http üzerinden gelen isterkleri https e yönlendiriyor.
app.UseStaticFiles();//wwwroot klasörünün kullanılabilir olmasını sağlar.

app.UseRouting();//gelen  isteklerin hangi controllere girmesi gerektiğini belirler.

app.UseAuthorization();//yetkilendirme özelliklerini aktif kılar.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//https://lochalhost:5100/Home/Index
//https://lochalhost:5100/Home/
//https://lochalhost:5100
//https://lochalhost:5100
//https://lochalhost:5100
//https://lochalhost:5100
//https://lochalhost:5100



app.Run();//oluşturulan web app çalıştırılıyor
