using KatanaMVC.Middleware.Component;
using Owin;

namespace KatanaMVC.Middleware.Extension
{
    public static class HttpTrafficLogExtension
    {
        public static void UseHttpTrafficLog(this IAppBuilder app)
        {
            app.Use<HttpTrafficLogComponent>();
        }
    }
}
