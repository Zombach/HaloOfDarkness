using System;
using System.Xml.Serialization;
using HaloOfDarkness.Language.Models.Basis;
using static HaloOfDarkness.Language.LanguageConstants;

namespace HaloOfDarkness.Language.Models
{
    [XmlRoot(Namespace = Empty, ElementName = ResourcesSections, IsNullable = NoNullable)]
    public class ResourcesModel : BaseModel
    {
        [XmlElement(ElementName = CurrenciesName)]
        public BagModel<ItemDescriptionModel> CurrencyBag { get; set; }

        public ResourcesModel()
        {
            CurrencyBag = new BagModel<ItemDescriptionModel>();
        }
    }
}