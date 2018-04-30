using KatanaMVC.Middleware.Component;
using Owin;

namespace KatanaMVC.Middleware.Extension
{
    public static class FileLogExtension
    {
        public static void UseFileLog(this IAppBuilder app)
        {
            app.Use<FileLogComponent>();
        }
    }
}
