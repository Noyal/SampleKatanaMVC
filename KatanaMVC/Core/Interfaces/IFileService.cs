using System.IO;

namespace KatanaMVC.Core.Interfaces
{
    public interface IFileService
    {
        StreamWriter Create(string path);
    }
}
