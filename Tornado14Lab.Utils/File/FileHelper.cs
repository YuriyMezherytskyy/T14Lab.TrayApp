using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Tornado14Lab.Utils.File
{
    public class FileHelper
    {
        public static string RemoveBadCharactersFromFileName(string fileName) 
        {
            //string illegal = "\"M\"\\a/ry/ h**ad:>> a\\/:*?\"| li*tt|le|| la\"mb.?";
            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());

            foreach (char c in invalid)
            {
                fileName = fileName.Replace(c.ToString(), "");
            }
            return fileName.Replace(" ", "_");
        }
    }
}
