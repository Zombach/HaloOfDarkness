using SQLite;

namespace TestCmd;

public class ItemEntity
{
    [PrimaryKey, AutoIncrement]
    public uint Id { get; set; }

    public string? Name { get; set; }
}