using SampleSignalR.Server;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

var app = builder.Build();

app.UseRouting();

app.MapHub<MessageHub>("/message");

app.Run();
