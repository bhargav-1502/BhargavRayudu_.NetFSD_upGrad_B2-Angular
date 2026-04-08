using DataAccessLayer;
using DataAccessLayer.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddControllersWithViews();


var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.Run();

