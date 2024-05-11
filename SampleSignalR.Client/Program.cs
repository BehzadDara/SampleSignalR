using Microsoft.AspNetCore.SignalR.Client;

var connection = new HubConnectionBuilder()
    .WithUrl("http://localhost:5000/message")
    .Build();

connection.On<string, string>("Notify", (user, message) =>
{
    Console.WriteLine($"[{user}]: {message}");
});

await connection.StartAsync();

Console.Write("Enter your name: ");
var user = Console.ReadLine();

while (true)
{
    var message = Console.ReadLine();
    await connection.SendAsync("Broadcast", user, message);
}