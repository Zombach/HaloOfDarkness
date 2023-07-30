using System.Xml.Serialization;

namespace HaloOfDarkness.Language.Models.Basis
{
    public class ItemDescriptionModel : ItemModel
    {
        [XmlAttribute(AttributeName = "description")]
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