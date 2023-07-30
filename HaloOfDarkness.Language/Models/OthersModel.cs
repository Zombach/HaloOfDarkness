using System.Xml.Serialization;
using HaloOfDarkness.Language.Models.Basis;
using static HaloOfDarkness.Language.LanguageConstants;

namespace HaloOfDarkness.Language.Models
{
    [XmlRoot(Namespace = Empty, ElementName = OthersSections, IsNullable = NoNullable)]
    public class OthersModel : BaseModel
    {
    }
}