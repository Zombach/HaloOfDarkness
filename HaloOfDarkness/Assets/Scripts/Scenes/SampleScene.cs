using System.Linq;
using Assets.Scripts.Languages;
using HaloOfDarkness.Language;
using HaloOfDarkness.Language.Models;
using HaloOfDarkness.Language.Models.Basis;
using UnityEngine;

#nullable enable
namespace Assets.Scripts.Scenes
{
    public class SampleScene : MonoBehaviour
    {
        private GeneralsModel _generals;

        void Awake()
        {
            string path = "Assets\\Resources\\ru_RU\\General.xml";
            LanguageHandler handler = new LanguageHandler();
            _generals = handler.DeserializeXml<GeneralsModel>(path);
            Debug.Log("Загружен GeneralsModel");
        }

        public void B()
        {
            ItemLanguage[] items = FindObjectsByType<ItemLanguage>(FindObjectsSortMode.None);
            foreach (ItemLanguage item in items)
            {
                ItemModel? model = _generals.MenuBag.Items.FirstOrDefault(obj => obj.Key == item.Key);
                if (model is null)
                { continue; }
                item.Text.text = model.Value;
            }
        }
    }
}