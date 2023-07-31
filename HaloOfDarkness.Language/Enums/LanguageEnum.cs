using System;
using System.Xml.Serialization;
using static HaloOfDarkness.Language.LanguageConstants;

namespace HaloOfDarkness.Language.Enums
{
    [Serializable]
    public enum LanguageEnum
    {
        [XmlEnum(Name = Empty)]
        Unknown = 0,
        [XmlEnum(Name = LanguageRuRu)]
        RuRu = 1,
        [XmlEnum(Name = LanguageEnUs)]
        EnUs = 2
    }
}