using System.Xml.Serialization;
using HaloOfDarkness.Language.Models.Basis;
using static HaloOfDarkness.Language.LanguageConstants;

namespace HaloOfDarkness.Language.Models
{
    [XmlRoot(Namespace = Empty, ElementName = CharactersSection, IsNullable = NoNullable)]
    public class CharactersModel : BaseModel
    {
        [XmlElement(ElementName = ParametersName)]
        public BagModel<ItemDescriptionModel> ParameterBag { get; set; }

        [XmlElement(ElementName = PerksName)]
        public BagModel<ItemModel> PerkBag { get; set; }

        [XmlElement(ElementName = SkillsName)]
        public BagModel<ItemModel> SkillBag { get; set; }

        public CharactersModel()
        {
            ParameterBag = new BagModel<ItemDescriptionModel>();
            PerkBag = new BagModel<ItemModel>();
            SkillBag = new BagModel<ItemModel>();
        }
    }
}