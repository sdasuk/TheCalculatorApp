namespace TheCalculatorApp.Services
{
    public interface ILogService
    {
        public void WriteLog(string log);

        public string GetFilePath();
    }
}
