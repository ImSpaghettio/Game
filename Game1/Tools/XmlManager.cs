using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Game1.Tools
{
    /// <summary>
    /// Author: Alex
    /// 
    /// Description: Serializes and deserialzes classes and 
    /// structs from and into xml files, mostly to be used 
    /// for saving inventory, and map data and events.
    /// </summary>

    public class XmlManager <T>
    {
        
        // The type of the object to be serialized or deserialize
        public Type Type;

        // Loads a class or struct from xml file
        public T Load(string path)
        {
            T instance;
            using (TextReader reader = new StreamReader(path))
            {
                XmlSerializer xml = new XmlSerializer(Type);
                instance = (T)xml.Deserialize(reader);
            }
            return instance;
        }

        // Saves a class in an xml file
        public void Save(string path, object obj)
        {
            using (TextWriter writer = new StreamWriter(path))
            {
                XmlSerializer xml = new XmlSerializer(Type);
                xml.Serialize(writer, obj); 
            }
        }
    }
}
