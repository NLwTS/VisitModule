using Microsoft.EntityFrameworkCore;
using VisitModule.MemberUniversity;
using VisitModule.AcademicDiscipline;
using VisitModule.API.UniverMember;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<AttendanceService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<VisitModule.Infrastructure.Data.AttendanceDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));

var app = builder.Build();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
