using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;
using HaloOfDarkness.Language.Enums;

namespace HaloOfDarkness.Language.Models.Basis
{
    /// <summary>
    /// Базовая модель xml - контейнера
    /// </summary>
    [Serializable]
    public abstract class BaseModel
    {
        /// <summary>
        /// Текущий язык модели
        /// </summary>
        [XmlIgnore]
        public LanguageEnum Language { get; set; }

        /// <summary>
        /// Атрибут версии документа
        /// </summary>
        [XmlAttribute(AttributeName = LanguageConstants.Version)]
        public float Version { get; set; }

        /// <summary>
        /// Количество объектов в модели
        /// </summary>
        [XmlAttribute(AttributeName = LanguageConstants.Count)]
        public int Count { get; set; }

        /// <summary>
        /// Ресурс для языка, для записи в Language
        /// </summary>
        [XmlAttribute(AttributeName = LanguageConstants.Language)]
        public string LanguageSource
        {
            get => $"{Language}";
            set
            {
                Type enumType = typeof(LanguageEnum);
                List<MemberInfo> memberInfos = enumType.GetMembers().Where(memberInfo => memberInfo.DeclaringType == enumType).ToList();
                foreach (MemberInfo memberInfo in memberInfos)
                {
                    object[] obj = memberInfo.GetCustomAttributes(typeof(XmlEnumAttribute), false);
                    if
                    (
                        obj.Length > 0 &&
                        obj.First() is XmlEnumAttribute attribute &&
                        string.Equals(attribute.Name, value, StringComparison.CurrentCultureIgnoreCase)
                    )
                    {
                        Language = Enum.Parse<LanguageEnum>(memberInfo.Name, true);
                        return;
                    }
                }
                Language = LanguageEnum.Unknown;
            }
        }
    }
}