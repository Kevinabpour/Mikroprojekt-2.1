using Mikroprojekt_2.Repo;
using Mikroprojekt_2.Services;

namespace Mikroprojekt_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<IRoomRepo, RoomCollectionRepo>(); // Links service for room collections
            builder.Services.AddSingleton<RoomService>();
            builder.Services.AddSingleton<IBookingRepo, BookingCollectionRepo>(); // Links service for booking collections
            builder.Services.AddSingleton<BookingService>();
            builder.Services.AddSingleton<IUserRepo, UserCollectionRepo>(); // Links service for user collections
            builder.Services.AddSingleton<UserService>();

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();

        }
    }
}
