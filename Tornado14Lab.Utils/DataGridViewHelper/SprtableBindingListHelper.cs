using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Tornado14Lab.Utils.DataGridViewHelper
{
    public class SortableBindingListHelper
    {
        #region Methods

        public static SortableBindingList<T> GetBindingListFromXmlFile<T>(string fileName)
        {
            FileInfo projectListXmlFile = new FileInfo(fileName);
            List<T> projects = new List<T>();
            if (projectListXmlFile.Exists)
            {
                StreamReader projectsXmlFileReader = new StreamReader(fileName);
                string projectsInXml = projectsXmlFileReader.ReadToEnd();

                projectsXmlFileReader.Close();
                projects = XmlSerializationHelper.Desirialize<List<T>>(projectsInXml);
            }
            SortableBindingList<T> result = new SortableBindingList<T>(projects);
            return result;
        }

        #endregion
    }
}
