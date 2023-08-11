using System.Xml.Serialization;
using HaloOfDarkness.Language.Models.Basis;
using static HaloOfDarkness.Language.LanguageConstants;

namespace HaloOfDarkness.Language.Models
{
    [XmlRoot(Namespace = Empty, ElementName = GeneralsSection, IsNullable = NoNullable)]
    public class GeneralsModel : BaseModel
    {
        [XmlElement(ElementName = MenuName)]
        public BagModel<ItemModel> MenuBag { get; set; }

        public GeneralsModel()
        {
            MenuBag = new BagModel<ItemModel>();
        }
    }
}