//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace KatanaMVC.Extensions
//{
//    using Owin;
//    using System.Configuration;
//    using System.IO;
//    using AppFunc = Func<IDictionary<string, object>, Task>;
//    public static class FileLogMiddleware
//    {
//        public static void UseFileLog(this IAppBuilder app)
//        {
//            app.Use<FileLogComponent>();
//        }
//    }
//    public class FileLogComponent
//    {
//        private string filePath;
//        private AppFunc _next;
//        private StreamWriter file;
//        public FileLogComponent(AppFunc next)
//        {
//            filePath = ConfigurationManager.AppSettings["FileLog"];
//            file = new StreamWriter(filePath, true);
//            _next = next;
//        }
//        public async Task Invoke(IDictionary<string, object> environment)
//        {
//            foreach (var pair in environment)
//            {
//                file.WriteLine($"{pair.Key} : {pair.Value}");
//            }
//            await _next(environment);
//        }
//    }
//}
