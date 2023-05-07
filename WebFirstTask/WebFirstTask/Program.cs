using Microsoft.AspNetCore.Builder;

namespace WebFirstTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
           

            //app.MapGet("/", () => "Hello World!");
            app.UseRouting();//rutinq sistemin qurmaq ucun istifade olunur
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"


                    );



            });
            app.Run();
        }
    }
}