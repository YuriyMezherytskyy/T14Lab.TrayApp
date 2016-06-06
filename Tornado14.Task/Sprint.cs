using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using Tornado14Lab.Utils.DateHelper;
using System.Globalization;

namespace Tornado14.Task
{
    [Serializable]
    public class Sprint
    {
        public Guid pId { get; set; }
        public string Id { get; set; }

        public string ShortDescription { get; set; }
        public string Description { get; set; }

        public string FilesFolder { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string ShortSummary2
        {
            get
            {
                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = dfi.Calendar;
                string period = string.Format("{1}-{3} {4} WD | KW:{0}-{2}",
                              cal.GetWeekOfYear(StartDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday),
                              StartDate.ToString("ddd"),
                              cal.GetWeekOfYear(EndDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday),
                              EndDate.ToString("ddd"),
                              DateTimeHelper.GetBusinessDays(StartDate, EndDate));
                return period;
            }
            set
            {
            }
        }

        public string ShortSummary
        {
            get
            {
                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = dfi.Calendar;
                string period = string.Format("{2}-{4} ({5} WD) KW:{1}-{3} {0}",
                ShortDescription,
                cal.GetWeekOfYear(StartDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday),
                StartDate.ToString("dd.MM ddd"),
                cal.GetWeekOfYear(EndDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday),
                EndDate.ToString("dd.MM ddd"), 
                DateTimeHelper.GetBusinessDays(StartDate, EndDate)
                );
                return period;
            }
            set
            {
            }
        }
        
        public string Summary
        {
            get
            {

                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = dfi.Calendar;
                int tasksCount = 0;
                if (Kanban != null)
                {
                    tasksCount = Kanban.Count;
                }
                string period = string.Format("{2} - {4} ({5} WD) KW:{1}-{3} {0} ({6} Tasks)",
                ShortDescription,
                cal.GetWeekOfYear(StartDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday),
                StartDate.ToString("dd.MM ddd"),
                cal.GetWeekOfYear(EndDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday),
                EndDate.ToString("dd.MM ddd"),
                DateTimeHelper.GetBusinessDays(StartDate, EndDate),
                tasksCount);
                return period;
            }
            set
            {
            }
        }


    public List<KanbanPosition> Kanban { get; set; }
    }
}
