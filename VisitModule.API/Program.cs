using Microsoft.EntityFrameworkCore;
using VisitModule.API;
using VisitModule.API.Pages;
using VisitModule.Infrastructure.Data;
using VisitModule.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddDbContext<VisitContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IVisitRepository, VisitRepository>();


var app = builder.Build();


app.UseStatusCodePagesWithReExecute("/404");
app.UseAntiforgery();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();


app.Run();
