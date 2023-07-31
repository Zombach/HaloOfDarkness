using HaloOfDarkness.Language;
using HaloOfDarkness.Language.Models;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Languages
{
    public class Test
    {
        [SerializeField] private Button _btn;

        public void T()
        {
            string path = "Assets\\Resources\\ru_RU\\General.xml";
            string path2 = "Assets\\Resources\\ru_RU\\Character.xml";
            string path3 = "Assets\\Resources\\ru_RU\\Items.xml";
            string path4 = "Assets\\Resources\\ru_RU\\NPCs.xml";
            string path5 = "Assets\\Resources\\ru_RU\\Others.xml";
            string path6 = "Assets\\Resources\\ru_RU\\Resources.xml";
            LanguageHandler handler = new LanguageHandler();
            GeneralsModel generals = handler.DeserializeXml<GeneralsModel>(path);
            CharactersModel characters = handler.DeserializeXml<CharactersModel>(path2);
            ItemsModel items = handler.DeserializeXml<ItemsModel>(path3);
            NPCsModel npcs = handler.DeserializeXml<NPCsModel>(path4);
            OthersModel others = handler.DeserializeXml<OthersModel>(path5);
            ResourcesModel resources = handler.DeserializeXml<ResourcesModel>(path6);

            TextMeshProUGUI textMeshPro = _btn.GetComponentInChildren<TextMeshProUGUI>();
        }
    }
}