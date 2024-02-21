using SQLite;
using TestCmd;

var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyData.db");

var db = new SQLiteAsyncConnection(databasePath);
await db.CreateTableAsync<ItemEntity>();

await db.InsertAsync(new ItemEntity
{
    Name = "Name"
});

var entity = await db.GetAsync<ItemEntity>(1);