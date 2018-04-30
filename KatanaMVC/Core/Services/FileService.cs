using KatanaMVC.Core.Interfaces;
using System.IO;

namespace KatanaMVC.Core.Services
{
    public class FileService : IFileService
    {
        public StreamWriter Create(string path)
        {
            FileStream fileStream;
            if (File.Exists(path))
                fileStream = File.Open(path, FileMode.Append, FileAccess.Write, FileShare.None);
            else
                fileStream = File.Create(path);
            return new StreamWriter(fileStream);
        }
        public void CreateDirectory(string path)
        {

        }
    }
}
