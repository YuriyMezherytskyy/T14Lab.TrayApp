using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tornado14Lab.Utils.Text
{
    public class IdGeneration
    {
        public static string NextAutoincrementValue(string lastId)
        {
            string result = string.Empty;
            if (lastId.Contains('-'))
            {
                string[] lastIdSplit = lastId.Split('-');
                int idNo = 0;
                if (int.TryParse(lastIdSplit[1], out idNo))
                {
                    idNo++;
                    result = string.Format("{0}-{1}", lastIdSplit[0], idNo);
                }
            }
            else
            {
                int idNo = 0;
                if (int.TryParse(lastId, out idNo))
                {
                    idNo++;
                    result = string.Format("{0}", idNo);
                }
            }
            return result;
        }
    }
}
