namespace Assaignment02.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();


            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();

            app.Use(async (context, next) => {
                Endpoint endpoint = context.GetEndpoint();
                if (endpoint == null)
                    await context.Response.WriteAsync("Your Request Page Not Found");
                await next();
            });
            app.MapControllerRoute(

                name: "defult",
                pattern: "/{Controller=Home}/{Action=Index}",
                defaults: new { Controller = "Home" ,Action = "Index" }

                );

            #region Routing
           // app.UseEndpoints(endpoints =>
           //{
           //    endpoints.MapGet("/", async context =>
           //    {
           //        await context.Response.WriteAsync("Hello World");
           //    });

           //    endpoints.MapGet("/Products/{id:int?}", async context =>
           //    {
           //        var IdState = context.Request.RouteValues["id"];
           //        if (IdState is not null)
           //        {
           //            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
           //            await context.Response.WriteAsync($"You Are At Product With Id ==> {id}");

           //        }
           //        else
           //        {
           //            await context.Response.WriteAsync("You Are At Products Page  ");

           //        }

           //    });

           //    endpoints.MapGet("/Books/{id}/{auther:alpha:minlength(2)}", async context =>
           //    {
           //        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
           //        string auther = context.Request.RouteValues["auther"].ToString();


           //        await context.Response.WriteAsync($"You Are At Product With Id ==> {id} and Auther Is  {auther}");
           //    });


           //}); 
            #endregion


            #region Error Handling
            //app.Run(async (HttpContext) => 
            //{
            //    await HttpContext.Response.WriteAsync("Your Request Page Not Found");
            //}); 
            #endregion

            app.Run();
        }
    }
}
