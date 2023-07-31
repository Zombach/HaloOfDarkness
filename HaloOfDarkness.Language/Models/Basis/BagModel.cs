using System;
using System.Xml.Serialization;

namespace HaloOfDarkness.Language.Models.Basis
{
    /// <summary>
    /// Модель сумки
    /// </summary>
    /// <typeparam name="T">Тип конечной ноды</typeparam>
    [Serializable]
    public class BagModel<T>
    {
        /// <summary>
        /// Размер элементов в сумке
        /// </summary>
        [XmlAttribute(AttributeName = LanguageConstants.Count)]
        public int Count { get; set; }

        /// <summary>
        /// Итоговая нода
        /// </summary>
        [XmlElement(ElementName = LanguageConstants.Item)]
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