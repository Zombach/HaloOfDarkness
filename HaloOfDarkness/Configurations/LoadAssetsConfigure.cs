using Microsoft.Extensions.Configuration;

namespace HaloOfDarkness.Configurations;

public static class LoadAssetsConfigure
{
    public static Stream LoadAsset(string fileName)
    {
        var stream = Task.Run(async () => await FileSystem.OpenAppPackageFileAsync(fileName)).Result;
        ArgumentNullException.ThrowIfNull(stream, $"Не удалось получить файл {fileName}");
        return stream;
    }

    public static void AddJsonConfigure(this ConfigurationManager configurationManager, string fileName)
    {
        using var stream = LoadAsset(fileName);
        var config = new ConfigurationBuilder().AddJsonStream(stream).Build();
        configurationManager.AddConfiguration(config);
    }
}