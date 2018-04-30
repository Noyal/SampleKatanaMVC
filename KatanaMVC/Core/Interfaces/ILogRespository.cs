namespace KatanaMVC.Core.Interfaces
{
    public interface ILogRespository
    {
        void AddHttpRequestLog();
        void AddHttpResponseLog();
    }
}
