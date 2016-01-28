using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(backend.SignalRChat))]
namespace backend
{
    public class SignalRChat
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
