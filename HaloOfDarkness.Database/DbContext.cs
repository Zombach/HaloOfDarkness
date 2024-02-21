using SQLite;

namespace HaloOfDarkness.Database;

// All the code in this file is included in all platforms.
public abstract class DbContext(DatabaseTypeEnum databaseType) : IAsyncDisposable
{
    protected readonly SQLiteAsyncConnection Db = new(Constants.DatabasePath(databaseType));

    public async Task<CreateTableResult> CreateTableAsync<T>() where T : class, new()
    {
        return await Db.CreateTableAsync<T>();
    }

    public async Task<int> InsertAsync<T>(T entity)
    {
        return await Db.InsertAsync(entity);
    }

    public async Task<T> GetAsync<T>(object pk) where T : class, new()
    {
        return await Db.GetAsync<T>(pk);
    }

    public async ValueTask DisposeAsync() => await Db.CloseAsync();
}