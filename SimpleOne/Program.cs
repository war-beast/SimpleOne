using Microsoft.AspNetCore.Mvc;
using SimpleOne.Initialization;
using SimpleOne.Middlewares;

//Расскоментировать, если нужно запускать бенчмарки
//var benchmark = BenchmarkRunner.Run<AlgorithmsBenchmark>();
//var benchmark = BenchmarkRunner.Run<SearchAlgorithmsBenchmark>();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.InstallSwagger();

builder.Services.AddCustomServices();

var app = builder.Build();

app.UseExceptionHandler(new ExceptionHandlerOptions
{
	ExceptionHandler = new ExceptionMiddleware(app.Services.GetRequiredService<IHostEnvironment>(), app.Services.GetRequiredService<ILogger<ExceptionMiddleware>>()).Invoke
});

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
