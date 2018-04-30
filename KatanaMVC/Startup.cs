using KatanaMVC.Middleware.Extension;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KatanaMVC.Startup))]
namespace KatanaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.UseFileLog();
            app.UseHttpTrafficLog();
            ConfigureAuth(app);
        }
    }
}
