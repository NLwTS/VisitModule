using VisitModule.API;
using VisitModule.API.Pages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRazorComponents();


var app = builder.Build();

app.UseAntiforgery();

app.MapRazorComponents<Visits>();


app.Run();
