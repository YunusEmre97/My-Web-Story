using MyWebStory.Services;

var builder = WebApplication.CreateBuilder(args);

//Uygulamamýzýn yapýlandýrýldýðý (Build) kýsýmdýr. Özellikler (MVC, Pages, DataBase vs.)burada eklenir.

//Razor Page formatýnda olan yapýyý tanýmak için kullanýlýr.Genellikle Pages klasörü içinde kullanýlýr.
builder.Services.AddRazorPages();

//Sayfalarýn kullanmasý için gerekli servisler baðlanýr. Bu sayede "Dependency Injection" iþlemi gerçekleþir.
builder.Services.AddSingleton<IBlogService, BlogService>();
builder.Services.AddSingleton<ISpotlightService, SpotlightService>();

var app = builder.Build();
//Uygulamamýzýn yapýlandýrýlmýþ ama iþletilmemiþ ara uygulamalarýný (middlewares) uygulama baþlatýlmadan önce iþletmeye baþladýðýmýz alandýr.
//Düzgün bir sýrayla yazýlmasý gerekir.
//Kullanýcý bir talepte(request) bulunduðu zaman bu alan iþletilir.


//HTTPS: Secure Transfer Protokolü için gerekli yönlendirme. (http -> https)
app.UseHttpsRedirection();

//wwwroot klasörü için tanýmlama oluþturur. Statik dosyalar (html, css ,js, png vs..)  burada tutulur.
app.UseStaticFiles();


//URL yapýsýnýn efektif bir þekilde oluþturmasý için gerekli metotlarý saðlar.
app.UseRouting();

//Controller, Action veya Page tarafýnda giriþ yetkisi için kullanýlýr.
app.UseAuthorization();

// Pages klasörlerine bakarar içindeki RazorPage sayfalarýna otomatik rota belirler.
app.MapRazorPages();

app.Run();
