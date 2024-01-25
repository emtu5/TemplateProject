using Microsoft.EntityFrameworkCore;
using net_project.Data;
using net_project.Models.Repositories;

var AllowSpecificOrigin = "_allowSpecificOrigin";
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowSpecificOrigin,
        policy =>
        {
            policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
        });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<TemplateContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IProfesorRepository, ProfesorRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
/*builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(AllowSpecificOrigin);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
