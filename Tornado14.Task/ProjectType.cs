using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tornado14.Task
{
    [Serializable]
    public enum ProjectType
    {
        Unknown = 0,
        Web = 10,
        WindowsApplication = 20,
        ConsoleApplication = 30,
        CommonLib = 40,
        Lib = 50,
        Database = 60,
        RESTService = 70,
        Documentation = 80,
        CProject = 90,
        Other = 10000,
    }
}
