using SQLite;

namespace HaloOfDarkness.Database.Entities.Basis;

public abstract class BaseEntity
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
}