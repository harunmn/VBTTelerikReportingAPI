-ASP.NET Core Web API projesi içinde Northwind DB ye ait script ve backup dosyaları bulunmaktadır. script çalıştırılacak ise; üst kısmına yorum satırı olarak not yazdım. Dikkat etmenizi tavsiye ederim.





Ders sırasında kullanılan linkler

-ASP.NET Core Web API kurulumu için
https://docs.telerik.com/reporting/telerik-reporting-rest-service-aspnetcore-net5


-Telerik Reporting Angular Viewer, Angular uygulamasında kurulum için
https://docs.telerik.com/reporting/angular-report-how-to-use-with-angular-cli



-Bilgisayarınızda kurulu olan Telerik Reporting ile uyumlu angular report viewer paketi kurulumu için
https://www.npmjs.com/package/@progress/telerik-angular-report-viewer

NOT: API'daki kütüphane versiyonu ile Angular uygulamaya kurulacak kütüphane versiyonuna dikkat...






-ASP.NET Core Web API da EntityFramework Core kütüphaneleri eklendikten sonra DB Context ve Entity dosyalarının otomatik oluşması için 
	dotnet ef dbcontext scaffold "Data Source=.;Initial Catalog=Northwind;Integrated Security=True;" Microsoft.EntityFrameworkCore.SqlServer -o Entities --context-dir "Entities\DbContexts" --no-pluralize -c DashboardContext -f --project VBTTelerikReportingAPI -s VBTTelerikReportingAPI




NOT: Eğer yukarıdaki kod bloğunu çalıştırdığınızda hata alıyorsanız, bilgisayarınızda global olarak dotnet tool yüklü değildir. Aşağıdaki kodu çalıştırıp önce dotnet tool kurulumu yapılır sonra yukarıdaki script tekrar çalıştırıldığında hata oluşmaması gerekir.
	dotnet tool install --global dotnet-ef