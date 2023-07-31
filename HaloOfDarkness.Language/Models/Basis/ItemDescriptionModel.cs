using System.Xml.Serialization;

namespace HaloOfDarkness.Language.Models.Basis
{
    /// <summary>
    /// Расширенная версия конечной ноды, с добавленным описанием
    /// </summary>
    public class ItemDescriptionModel : ItemModel
    {
        /// <summary>
        /// Описание объекта в ноде
        /// </summary>
        [XmlAttribute(AttributeName = LanguageConstants.Description)]
        public string Description { get; set; }

        public ItemDescriptionModel() : base()
        {
            Description = string.Empty;
        }

        public ItemDescriptionModel(string description, int key, string value) : base(key, value)
        {
            Description = description;
        }
    }
}