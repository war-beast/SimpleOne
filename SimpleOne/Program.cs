using SimpleOne.Initialization;
using SimpleOne.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.InstallSwagger();

builder.Services.AddCustomServices();

var app = builder.Build();

var serviceProvider = builder.Services.BuildServiceProvider();

app.UseExceptionHandler(new ExceptionHandlerOptions
{
	ExceptionHandler = new ExceptionMiddleware(serviceProvider.GetService<IHostEnvironment>()!, serviceProvider.GetService<ILogger<ExceptionMiddleware>>()!).Invoke
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
