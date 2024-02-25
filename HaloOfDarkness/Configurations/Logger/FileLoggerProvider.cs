using Microsoft.Extensions.Logging;

namespace HaloOfDarkness.Configurations.Logger;

public class FileLoggerProvider(string fileName) : ILoggerProvider
{
    public ILogger CreateLogger(string categoryName) => new FileLogger(fileName);

    public void Dispose() { }
}