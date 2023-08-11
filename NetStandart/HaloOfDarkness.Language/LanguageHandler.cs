using System;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

namespace HaloOfDarkness.Language
{
    public class LanguageHandler
    {
        public T DeserializeXml<T>(string path) where T : class
        {
            try
            {
                if (!File.Exists(path))
                { throw new FileNotFoundException(path); }
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using TextReader reader = new StreamReader(path);
                T? result = serializer.Deserialize(reader) as T;
                if (result is null)
                { throw new Exception("Пустой файл"); }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Debug.Log($"path: {path}");
                throw new Exception($"{e.Message}");
            }
        }
    }
}