using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace KatanaMVC.Middleware.Component
{
    using AppFunc = Func<IDictionary<string, object>, Task>;
    public class FileLogComponent
    {
        private string filePath;
        private AppFunc _next;
        private StreamWriter file;
        public FileLogComponent(AppFunc next)
        {
            filePath = ConfigurationManager.AppSettings["FileLog"];
            file = new StreamWriter(filePath, true);
            _next = next;
        }
        public async Task Invoke(IDictionary<string, object> environment)
        {
            foreach (var pair in environment)
            {
                file.WriteLine($"{pair.Key} : {pair.Value}");
            }
            await _next(environment);
        }
    }
}
