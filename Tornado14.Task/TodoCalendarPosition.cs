using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tornado14.Task
{
    [Serializable]
    public class TodoCalendarPosition
    {
        public Guid pId { get; set; }
        //public string Id { get; set; }
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Text { get; set; }

        public Guid TodopId { get; set; }

        public string CalendarName { get; set; }

        public string color { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} {2}", StartTime, EndTime, Text);
        }
    }
}
