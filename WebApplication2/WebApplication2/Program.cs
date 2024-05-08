namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseStaticFiles();

            // app.MapGet("/", () => "Hello World!");
            app.UseRouting();

            app.MapControllerRoute(name: "Default", pattern: "{Controller=Home}/{action= index }");


            app.Run();
        }
    }
}
