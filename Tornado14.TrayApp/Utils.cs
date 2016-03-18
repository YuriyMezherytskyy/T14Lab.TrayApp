using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using Tornado14.Task;

namespace Tornado14.TrayApp
{
    public class Utils
    {
        public static List<ProfileConfigItem> DeserializeParameter(string file)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<ProfileConfigItem>));
            TextReader textReader = new StreamReader(file);
            List<ProfileConfigItem> data;
            data = (List<ProfileConfigItem>)deserializer.Deserialize(textReader);
            textReader.Close();
            return data;
            // TODO: asfg
        }

        public static List<ChecklistItem> DeserializeChecklist(string file)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<ChecklistItem>));
            TextReader textReader = new StreamReader(file);
            List<ChecklistItem> data;
            data = (List<ChecklistItem>)deserializer.Deserialize(textReader);
            textReader.Close();
            return data;
            // TODO: asfg
        }

    }

}
