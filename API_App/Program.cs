using API_App.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApiDbContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppStr"));
});
builder.Services.AddControllers().AddJsonOptions(options => {
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});
builder.Services.AddCors(options => {
    options.AddPolicy("CORS", policy => { 
      policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod();    
    });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("CORS");  
app.UseAuthorization();

app.MapControllers();

app.Run();
