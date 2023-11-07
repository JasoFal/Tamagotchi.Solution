namespace ProjectName
{
  class Program
  {
    static void Main(string[] arg)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(arg);
      builder.Services.AddControllersWithViews();
      WebApplication app = builder.Build();
      // app.UseDeveloperExceptionPage();
      app.UseHttpsRedirection();
      app.UseRouting();
      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );
      app.Run();
    }
  }
}