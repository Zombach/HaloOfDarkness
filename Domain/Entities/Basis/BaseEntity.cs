using SQLite;

namespace Domain.Entities.Basis;

public class BaseEntity
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
}