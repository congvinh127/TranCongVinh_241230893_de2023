using TranCongVinh_241230893_de2023.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(o =>
{
    o.ModelBindingMessageProvider.SetValueMustBeANumberAccessor((x) => "Giá phải là số");
    o.ModelBindingMessageProvider.SetAttemptedValueIsInvalidAccessor((v, f) => "giá phải là số");
});
builder.Services.AddDbContext<QlhangHoaContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
