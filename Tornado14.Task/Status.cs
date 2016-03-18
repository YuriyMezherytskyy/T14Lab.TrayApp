using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tornado14.Task
{
    [Serializable]
    public enum Status
    {
        Unknown = 0,
        Backlog = 10,
        Todo = 20,
        Progress = 30,
        Test = 40,
        Done = 50,
        Today = 60,
        Planned = 70
    }
}
