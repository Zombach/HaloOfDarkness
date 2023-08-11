using System;
using System.Xml.Serialization;

namespace HaloOfDarkness.Language.Models.Basis
{
    /// <summary>
    /// Базовая нода
    /// </summary>
    [Serializable]
    public class ItemModel
    {
        /// <summary>
        /// Ключ для связывания с конечным объектом
        /// </summary>
        [XmlAttribute(AttributeName = LanguageConstants.Key)]
        public int Key { get; set; }

        /// <summary>
        /// Значение в ноде
        /// </summary>
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