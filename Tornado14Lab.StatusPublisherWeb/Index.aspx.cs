using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tornado14.Task;
using Tornado14Lab.StatusPublisherWeb.Properties;
using Tornado14Lab.Utils.DataGridViewHelper;
using Tornado14Lab.Utils.DateHelper;

namespace Tornado14Lab.StatusPublisherWeb
{
  public partial class Index : System.Web.UI.Page
  {
    public static DirectoryInfo dataFolder = null;
    private string sprintXMLFilePath;
    private string todoXMLFilePath;
    private string projectXMLFilePath;

    protected void Page_Load(object sender, EventArgs e)
    {
      dataFolder = new DirectoryInfo(Path.Combine(Settings.Default.DataFolder, @"ProjectExplorer\"));
      sprintXMLFilePath = Path.Combine(dataFolder.FullName, "sprints.xml");
      todoXMLFilePath = Path.Combine(dataFolder.FullName, "todos.xml");
      projectXMLFilePath = Path.Combine(dataFolder.FullName, "projects.xml");

      SortableBindingList<Sprint> allSprints = SortableBindingListHelper.GetBindingListFromXmlFile<Sprint>(sprintXMLFilePath);
      SortableBindingList<Todo> allTodos = SortableBindingListHelper.GetBindingListFromXmlFile<Todo>(todoXMLFilePath);
      SortableBindingList<Project> allProjects = SortableBindingListHelper.GetBindingListFromXmlFile<Project>(projectXMLFilePath);

      RenderSiteMap(allSprints, allTodos, allProjects);

    }

    private void RenderSiteMap(SortableBindingList<Sprint> allSprints, SortableBindingList<Todo> allTodos, SortableBindingList<Project> allProjects)
    {
      foreach (Sprint sprint in allSprints.Reverse())
      {
        DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
        System.Globalization.Calendar cal = dfi.Calendar;
        int tasksCount = 0;
        if (sprint.Kanban != null)
        {
          tasksCount = sprint.Kanban.Count;
        }
        string period = string.Format("<span class='sprintName'>{0}    <span class='period'>{1}-{2}</span> <span class='kw'> K.W.:{3}-{4}</span> <span class='wd'>(Left:{5} from {6} W.D.)</span> <span class='tasks'>{7} Tasks</span>",
        sprint.ShortDescription,
        sprint.StartDate.ToString("dd.MM ddd"),
        sprint.EndDate.ToString("dd.MM ddd"),
        cal.GetWeekOfYear(sprint.StartDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday),
        cal.GetWeekOfYear(sprint.EndDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday),
        DateTimeHelper.GetBusinessDays(DateTime.Now, sprint.EndDate),
        DateTimeHelper.GetBusinessDays(sprint.StartDate, sprint.EndDate),
        tasksCount);


        string sprintName = period;
        string sprintContent = "";//task.PublicText.Replace("\r\n", "<br />");


        StringBuilder sprintSubContentBuilder = new StringBuilder();

        List<Project> projectList = new List<Project>();
        Dictionary<Project, List<Status>> projectStatusList = new Dictionary<Project, List<Status>>();
        foreach (KanbanPosition kanbanPosition in sprint.Kanban)
        {
          Todo task = allTodos.Where(t => t.pId == kanbanPosition.TaskPid).Single();
          Project project = allProjects.Where(p => p.pId == task.ProjectPid).Single();
          if (!projectList.Contains(project))
          {
            projectList.Add(project);
            projectStatusList.Add(project, new List<Status>());
            projectStatusList[project].Add(kanbanPosition.Status);
          }
        }

        string currentUrl = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + ResolveUrl("~/");

        sprintSubContentBuilder.AppendLine("<ul>");
        foreach (Project project in projectList)
        {
          string subContent = "";
          string level2Template = "";
          string link = $"{currentUrl}status/{sprint.Id}/{project.Id}";
          level2Template = $"<li><a href=\"{link}\">{project.ShortDescription}</a></li>";
          sprintSubContentBuilder.AppendLine(level2Template);
        }
        sprintSubContentBuilder.AppendLine("</ul>");



        string sprintSubContent = sprintSubContentBuilder.ToString();
        string level1Template = $"<li><h3 class=\"cbp-nttrigger\">{sprintName}</h3><div class=\"cbp-ntcontent\">{sprintSubContent}</div></li>";
        TaskListPlanned.InnerHtml += level1Template;
      }
    }

    protected void Unnamed1_Load(object sender, EventArgs e)
    {

    }
  }
}