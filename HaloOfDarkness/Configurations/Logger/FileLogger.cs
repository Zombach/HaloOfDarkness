using Microsoft.Extensions.Logging;

namespace HaloOfDarkness.Configurations.Logger;

public class FileLogger(string fileName) : ILogger, IDisposable
{
    private static readonly object Lock = new object();

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        lock (Lock)
        {
            var filePath = Path.Combine(FileSystem.AppDataDirectory, fileName);
            File.AppendAllText(filePath, formatter(state, exception) + Environment.NewLine);
        }
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        //return logLevel == LogLevel.Trace;
        return true;
    }

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull => this;

    public void Dispose() { }
}