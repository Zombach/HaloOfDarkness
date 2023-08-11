using System.Xml.Serialization;
using HaloOfDarkness.Language.Models.Basis;
using static HaloOfDarkness.Language.LanguageConstants;

namespace HaloOfDarkness.Language.Models
{
    [XmlRoot(Namespace = Empty, ElementName = NPCsSections, IsNullable = NoNullable)]
    public class NPCsModel : BaseModel
    {
    }
}