using ETrade.Dal;
using ETrade.Ent;
using ETrade.Rep.Abstract;
using ETrade.Rep.Concretes;
using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
/*****************************************************************/
// ADDED
builder.Services.AddSession();
builder.Services.AddDbContext<Context>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("Personel")));
builder.Services.AddScoped<IUow, Uow>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IFoodRepository, FoodRepository>();
builder.Services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IPropertyRepository, PropertyRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
// abstract ve concreteleri yaptýk program.cs de scoped ladýk. bundan sonra crud ý yapýcaz.
//newlersek burda yazmaya gerek yok. yeni bir degisiklik deneme yapýnca uygulamak icin  sadece yeni  CategoryRepository 2 olarak class olusturunca burda sadece degiþiklik yapýnca direk ICategoryRepository yazan yere  CategoryRepository2 yazýcak tek bir seferde tüm projeye uygulamýs olacagýz. 

builder.Services.AddScoped<FoodsModel>();
builder.Services.AddScoped<AdminModel>();
builder.Services.AddScoped<CategoriesModel>();
builder.Services.AddScoped<PropertiesModel>();
builder.Services.AddScoped<Users>();
builder.Services.AddScoped<Orders>();
builder.Services.AddScoped<OrderDetails>();




// ADDED
/*****************************************************************/
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
//session yazdý1105k
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
