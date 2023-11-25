using CityOfCincy.Utilities;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ConfigurationSettingResolver>();
builder.Services.AddSingleton<IDataResolver, APIDataResolver>();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();



builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "City Of Cincinnati Joined Data",
        Description = "API for other groups to use",
        TermsOfService = new Uri("https://support.socrata.com/hc/en-us/articles/360019057154")
    });
});

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
app.MapControllers();
app.UseRouting();
app.UseSwagger();
app.UseSwaggerUI();

app.Run();
