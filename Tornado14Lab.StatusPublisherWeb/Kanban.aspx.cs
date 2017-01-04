using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tornado14.Task;
using Tornado14Lab.StatusPublisherWeb.Properties;
using Tornado14Lab.Utils.DataGridViewHelper;

namespace Tornado14Lab.StatusPublisherWeb
{
  public partial class Kanban : System.Web.UI.Page
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


      string sprintFilter = null;
      string projectFilter = null;
      if (Page.RouteData.Values.ContainsKey("sprint") && Page.RouteData.Values.ContainsKey("project"))
      {
        sprintFilter = Page.RouteData.Values["sprint"].ToString();
        projectFilter = Page.RouteData.Values["project"].ToString();
        Guid projectId = allProjects.Where(p => p.Id == projectFilter).Single().pId;
        RenderTasks(allSprints, allTodos, sprintFilter, projectId);
      }
      else
      {
        RenderSiteMap(allSprints, allTodos, allProjects);
      }


    }

    private void RenderSiteMap(SortableBindingList<Sprint> allSprints, SortableBindingList<Todo> allTodos, SortableBindingList<Project> allProjects)
    {
      foreach (Sprint sprint in allSprints)
      {
        string sprintName = sprint.ShortDescription;
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

        foreach (Project project in projectList)
        {
          string subContent = "";
          string level2Template = "";


          foreach (Status statusItem in projectStatusList[project])
          {
            string link = $"{currentUrl}status/{sprint.Id}/{project.Id}";
            string status = statusItem.ToString();
            subContent += $"<a href=\"{link}\">{status}</a><br/>";
          }

          level2Template = $"<ul class=\"cbp-ntsubaccordion\"><li><h4 class=\"cbp-nttrigger\">{project.ShortDescription}</h4><div class=\"cbp-ntcontent\"><p>{subContent}</p></div></li></ul>";
          sprintSubContentBuilder.AppendLine(level2Template);
        }



        string sprintSubContent = sprintSubContentBuilder.ToString();
        string level1Template = $"<li><h3 class=\"cbp-nttrigger\">{sprintName}</h3><div class=\"cbp-ntcontent\"><p>{sprintContent}</p>{sprintSubContent}</div></li>";
        TaskListPlanned.InnerHtml += level1Template;
      }
    }

    private void RenderTasks(SortableBindingList<Sprint> allSprints, SortableBindingList<Todo> allTodos, string sprintFilter, Guid projectFilter)
    {
      Sprint selectedSprint = allSprints.Where(s => s.Id == sprintFilter).Single();
      List<KanbanPosition> sortedList = selectedSprint.Kanban.OrderBy(p1 => p1.Status).ThenBy(p2 => p2.Position).ToList<KanbanPosition>();

      List<List<KanbanPosition>> statusPositionList = selectedSprint.Kanban.Select(
        (p) => new { p })
        .GroupBy(x => x.p.Status)
        .Select(x => x.Select(v => v.p).ToList())
        .ToList();

      foreach (List<KanbanPosition> positionList in statusPositionList)
      {
        foreach (KanbanPosition kanbanPosition in positionList)
        {
          Todo task = allTodos.Where(t => t.pId == kanbanPosition.TaskPid).Single();
          if (task.ProjectPid == projectFilter)
          {
            string taskName = task.ShortDescription + "<span><</span>";
            string taskContent = "";
            string status = kanbanPosition.Status.ToString();

            StringBuilder taskSubContentBuilder = new StringBuilder();

            string name = "";
            string content = "";
            string subContent = "";
            string level2Template = "";

            if (!string.IsNullOrEmpty(task.CurrentState))
            {
              name = "Ist zustand: ";
              content = task.CurrentState.Replace("\n", "<br />").Replace("\t", "    ");
              level2Template = $"<ul class=\"cbp-ntsubaccordion\"><li><h4 class=\"cbp-nttrigger\">{name}</h4><div class=\"cbp-ntcontent\"><p>{content}</p>{subContent}</div></li></ul>";
              taskSubContentBuilder.AppendLine(level2Template);
            }
            if (!string.IsNullOrEmpty(task.Description))
            {
              name = "Soll zustand: ";
              content = task.Description.Replace("\r\n", "<br />").Replace("\t", "    ");
              level2Template = $"<ul class=\"cbp-ntsubaccordion\"><li><h4 class=\"cbp-nttrigger\">{name}</h4><div class=\"cbp-ntcontent\"><p>{content}</p>{subContent}</div></li></ul>";
              taskSubContentBuilder.AppendLine(level2Template);
            }
            if (!string.IsNullOrEmpty(task.Result))
            {
              name = "Recherche: ";
              content = task.Result.Replace("\r\n", "<br />").Replace("\t", "    ");
              level2Template = $"<ul class=\"cbp-ntsubaccordion\"><li><h4 class=\"cbp-nttrigger\">{name}</h4><div class=\"cbp-ntcontent\"><p>{content}</p>{subContent}</div></li></ul>";
              taskSubContentBuilder.AppendLine(level2Template);
            }
            if (!string.IsNullOrEmpty(task.PublicText))
            {
              name = "Resultat: ";
              content = task.PublicText.Replace("\r\n", "<br />").Replace("\t", "    ");
              level2Template = $"<ul class=\"cbp-ntsubaccordion\"><li><h4 class=\"cbp-nttrigger\">{name}</h4><div class=\"cbp-ntcontent\"><p>{content}</p>{subContent}</div></li></ul>";
              taskSubContentBuilder.AppendLine(level2Template);
            }


            string taskSubContent = taskSubContentBuilder.ToString();
            string level1Template = $"<li><h3 class=\"cbp-nttrigger\">{taskName}</h3><div class=\"cbp-ntcontent\"><p>{taskContent}</p>{taskSubContent}</div></li>";
            switch (kanbanPosition.Status)
            {
              case Status.Planned:
                TaskListPlanned.InnerHtml += level1Template;
                break;
              case Status.Today:
                TaskListToday.InnerHtml += level1Template;
                break;
              case Status.Progress:
                TaskListProgress.InnerHtml += level1Template;
                break;
              case Status.Test:
                TaskListTest.InnerHtml += level1Template;
                break;
              case Status.Done:
                TaskListDone.InnerHtml += level1Template;
                break;
              default:
                break;
            }
          }
        }
      }
    }

    protected void Unnamed1_Load(object sender, EventArgs e)
    {

    }
  }
  
}