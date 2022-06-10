var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();


//app.MapControllerRoute(
//                name: "ProductDetail",
//                pattern: "san-pham/id-{id}",
//                defaults: new { controller = "Product", action = "ProductDetail" });

//app.MapControllerRoute(
//    name: "san-pham",
//    pattern: "{controller=Home}/{action=Index}/id-{id?}");

app.MapControllerRoute(
                name: "ProductDetail",
                pattern: "san-pham/id-{id}",
                defaults: new { controller = "Product", action = "ProductDetail" });

app.MapControllerRoute(
                name: "ProductDetail",
                pattern: "san-pham/id-{id}",
                defaults: new { controller = "Product", action = "ProductDetail" });


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Product}/{action=ProductDetail}/{id?}");

//app.mapcontrollerroute(
//        name: "student",
//        url: "student/{id}/{name}/{standardid}",
//        defaults: new { controller = "student", action = "index", id = urlparameter.optional, name = urlparameter.optional, standardid = urlparameter.optional },
//        constraints: new { id = @"\d+" }
//    );


app.Run();
