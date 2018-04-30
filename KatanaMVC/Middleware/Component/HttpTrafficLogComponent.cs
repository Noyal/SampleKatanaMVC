using KatanaMVC.Core.Services;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace KatanaMVC.Middleware.Component
{
    public class HttpTrafficLogComponent : OwinMiddleware
    {
        private string logFilePath;
        private readonly FileService _fileService;
        public HttpTrafficLogComponent(OwinMiddleware next) : base(next)
        {
            _fileService = new FileService();
            logFilePath = ConfigurationManager.AppSettings["FileHttpTrafficLog"];
        }
        public async override Task Invoke(IOwinContext context)
        {

            var dateTime = DateTime.Now.ToLongTimeString();
            await Next.Invoke(context);
            var userIdentity = context.Authentication.User?.Identity;
            var file = _fileService.Create(logFilePath);
            file.WriteLine($"Request | Path : {context.Request.Path} | UserId : {userIdentity?.GetUserId() ?? ""} | UserName : {userIdentity?.GetUserName() ?? ""} | TimeStamp : {dateTime}");
            file.WriteLine($"Response | StatusCode : {context.Response.StatusCode} | TimeStamp : {DateTime.Now.ToLongTimeString()}");
            file.Close();
        }
    }
}
