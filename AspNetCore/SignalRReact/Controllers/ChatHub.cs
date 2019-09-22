using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
    {
        public void SendToChannel(string name, string message)
        {
            Clients.All.SendAsync("SendToChannel", name, message);
        }
    }