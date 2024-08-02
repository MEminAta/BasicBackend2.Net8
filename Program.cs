var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    Console.WriteLine("Development");

app.UseHttpsRedirection();
app.Run();