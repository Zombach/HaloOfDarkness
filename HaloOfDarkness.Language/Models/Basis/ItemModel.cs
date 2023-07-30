using System;
using System.Xml.Serialization;

namespace HaloOfDarkness.Language.Models.Basis
{
    /// <summary>
    /// Базовый объект
    /// </summary>
    [Serializable]
    public class ItemModel
    {
        [XmlAttribute(AttributeName = "key")]
        public int Key { get; set; }

        [XmlText(DataType = "string", Type = typeof(string))]
        public string Value { get; set; }

        public ItemModel()
        {
            Key = -1;
            Value = string.Empty;
        }

        public ItemModel(int key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}