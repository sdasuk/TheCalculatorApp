namespace TheCalculatorApp.Services
{
    public class LogService : ILogService
    {
        public void WriteLog(string log)
        {
            var logFilePath = GetFilePath();
            FileInfo logFileInfo = new FileInfo(logFilePath);
            DirectoryInfo logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();


            using (FileStream fileStream = new FileStream(logFilePath + "log"+ DateTime.Today.ToString("ddMMyyyy") + ".txt", FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fileStream))
                {
                    sw.WriteLine(log);
                }
            }
        }

        public string GetFilePath()
        {
            var configuration = new ConfigurationBuilder()
                                            .AddJsonFile($"appsettings.json");

            var config = configuration.Build();

            var section =  config.GetSection("LogFilePath");

            return section.Value;
        }
    }
}
