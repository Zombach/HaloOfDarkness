using System.Xml.Serialization;
using HaloOfDarkness.Language.Models.Basis;
using static HaloOfDarkness.Language.LanguageConstants;

namespace HaloOfDarkness.Language.Models
{

    [XmlRoot(Namespace = Empty, ElementName = ItemsSections, IsNullable = NoNullable)]
    public class ItemsModel : BaseModel
    {
        [XmlElement(ElementName = WeaponsName)]
        public BagModel<ItemDescriptionModel> WeaponBag { get; set; }
        [XmlElement(ElementName = OthersName)]
        public BagModel<ItemModel> OtherBag { get; set; }

        public ItemsModel()
        {
            WeaponBag = new BagModel<ItemDescriptionModel>();
            OtherBag = new BagModel<ItemModel>();
        }
    }
}