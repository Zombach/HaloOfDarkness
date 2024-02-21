using HaloOfDarkness.Database.Entities.Basis;

namespace HaloOfDarkness.Database.Entities;

public class ResourceEntity : BaseEntity
{
    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Размер
    /// </summary>
    public float Size { get; set; }

    /// <summary>
    /// Вес
    /// </summary>
    public float Weight { get; set; }

    /// <summary>
    /// Количество в паке
    /// </summary>
    public uint Quantity { get; set; }

    /// <summary>
    /// Картинка
    /// </summary>
    public string Image { get; set; }
}