using MyWebStory.Services;

var builder = WebApplication.CreateBuilder(args);

//Uygulamam�z�n yap�land�r�ld��� (Build) k�s�md�r. �zellikler (MVC, Pages, DataBase vs.)burada eklenir.

//Razor Page format�nda olan yap�y� tan�mak i�in kullan�l�r.Genellikle Pages klas�r� i�inde kullan�l�r.
builder.Services.AddRazorPages();

//Sayfalar�n kullanmas� i�in gerekli servisler ba�lan�r. Bu sayede "Dependency Injection" i�lemi ger�ekle�ir.
builder.Services.AddSingleton<IBlogService, BlogService>();
builder.Services.AddSingleton<ISpotlightService, SpotlightService>();

var app = builder.Build();
//Uygulamam�z�n yap�land�r�lm�� ama i�letilmemi� ara uygulamalar�n� (middlewares) uygulama ba�lat�lmadan �nce i�letmeye ba�lad���m�z aland�r.
//D�zg�n bir s�rayla yaz�lmas� gerekir.
//Kullan�c� bir talepte(request) bulundu�u zaman bu alan i�letilir.


//HTTPS: Secure Transfer Protokol� i�in gerekli y�nlendirme. (http -> https)
app.UseHttpsRedirection();

//wwwroot klas�r� i�in tan�mlama olu�turur. Statik dosyalar (html, css ,js, png vs..)  burada tutulur.
app.UseStaticFiles();


//URL yap�s�n�n efektif bir �ekilde olu�turmas� i�in gerekli metotlar� sa�lar.
app.UseRouting();

//Controller, Action veya Page taraf�nda giri� yetkisi i�in kullan�l�r.
app.UseAuthorization();

// Pages klas�rlerine bakarar i�indeki RazorPage sayfalar�na otomatik rota belirler.
app.MapRazorPages();

app.Run();
