namespace PD.Services.Logging
{
    public interface ILogger
    {

        void LogError();

        void LogWarning();

        void LogInformation();  

        void LogWarning(string message);

        void Log();
    }
}