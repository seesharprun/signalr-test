using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace signalr.Models
{
    public class ChatHub : Hub
    {
        public Task Send(string message)
        {
            return Clients.All.InvokeAsync("Send", $"Received: {message}");
        }
    }
}