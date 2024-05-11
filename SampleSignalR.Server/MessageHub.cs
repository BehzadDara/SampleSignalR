using Microsoft.AspNetCore.SignalR;

namespace SampleSignalR.Server;

public class MessageHub : Hub
{
    public async Task Broadcast(string user, string message)
    {
        await Clients.All.SendAsync("Notify", user, message);
    }
}