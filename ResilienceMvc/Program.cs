var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
    app.UseExceptionHandler("/error/exception");

app.UseHttpsRedirection();
app.UseRouting();
app.UseEndpoints(o => o.MapControllers());

app.Run();
