namespace HaloOfDarkness.Database;

public static class Constants
{
    public const string DatabasePlayer = "Player.db3";
    public const string DatabaseObjects = "Objects.db3";
    public const string DatabaseTexts = "Texts.db3";

    public const SQLite.SQLiteOpenFlags Flags =
        // open the database in read/write mode
        SQLite.SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
        SQLite.SQLiteOpenFlags.Create |
        // enable multi-threaded database access
        SQLite.SQLiteOpenFlags.SharedCache;

    public static string DatabasePath(DatabaseTypeEnum databaseType)
    {
        var databasePath = databaseType switch
        {
            DatabaseTypeEnum.Player => DatabasePlayer,
            DatabaseTypeEnum.Objects => DatabaseObjects,
            DatabaseTypeEnum.Texts => DatabaseTexts,
            _ => throw new Exception()
        };
        return Path.Combine(FileSystem.AppDataDirectory, databasePath);
    }
}
