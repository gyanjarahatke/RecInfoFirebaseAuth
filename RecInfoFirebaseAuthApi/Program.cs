using FluentlyHttpClient;
using RecInfoFirebaseAuth;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

InstallRecInfoFirebaseAuth.Install(builder.Services, "AIzaSyB26OaZaDeBYfE9LCL9ovAgdjLwWtZdw6U");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

InstallRecInfoFirebaseAuth.Configure(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
