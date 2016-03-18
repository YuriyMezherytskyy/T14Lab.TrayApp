using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tornado14.Task
{
    public class KanbanPosition
    {
        public Status Status { get; set; }
        public int Position { get; set; }
        public Guid TaskPid { get; set; }
    }
}
