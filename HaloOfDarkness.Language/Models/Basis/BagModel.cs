using System;
using System.Xml.Serialization;

namespace HaloOfDarkness.Language.Models.Basis
{
    [Serializable]
    public class BagModel<T>
    {
        private const string AttributeCount = "count";
        private const string AttributeItems = "item";

        [XmlAttribute(AttributeName = AttributeCount)]
        public int Count { get; set; }

        [XmlElement(ElementName = AttributeItems)]
        public T[] Items { get; set; }

        public BagModel()
        {
            Count = -1;
            Items = Array.Empty<T>();
        }

        public BagModel(int count, T[] items)
        {
            Count = count;
            Items = items;
        }
    }
}