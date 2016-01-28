using Microsoft.AspNet.SignalR;

namespace backend.Utils
{
    public class SignalRChat : Hub
    {

        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
    }
}