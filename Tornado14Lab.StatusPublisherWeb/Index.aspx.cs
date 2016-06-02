using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tornado14.Task;
using Tornado14Lab.Utils.DataGridViewHelper;

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
      dataFolder = new DirectoryInfo(Path.Combine(@"c:\trayData\", @"ProjectExplorer\"));
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
        LabelSprint.Text = sprintFilter;
        LabelProject.Text = projectFilter;

        RenderTasks(allSprints, allTodos, sprintFilter, projectFilter);
      } else
      {
        foreach (Sprint sprint in allSprints)
        {
          string sprintName = sprint.ShortDescription;
          string sprintContent = "";//task.PublicText.Replace("\r\n", "<br />");


          StringBuilder sprintSubContentBuilder = new StringBuilder();

          List<string> projectList = new List<string>();
          foreach (KanbanPosition kanbanPosition in sprint.Kanban)
          {
            Todo task = allTodos.Where(t => t.pId == kanbanPosition.TaskPid).Single();
            Project project = allProjects.Where(p => p.pId == task.ProjectPid).Single();
            if (!projectList.Contains(project.ShortDescription)) {
              projectList.Add(project.ShortDescription);
            }
          }

          foreach (string projectName in projectList)
          {
            string content = "";
            string subContent = "";
            string level2Template = "";

            level2Template = $"<ul class=\"cbp-ntsubaccordion\"><li><h4 class=\"cbp-nttrigger\">{projectName}</h4><div class=\"cbp-ntcontent\"><p>{content}</p>{subContent}</div></li></ul>";
            sprintSubContentBuilder.AppendLine(level2Template);
          }



          string sprintSubContent = sprintSubContentBuilder.ToString();
          string level1Template = $"<li><h3 class=\"cbp-nttrigger\">{sprintName}</h3><div class=\"cbp-ntcontent\"><p>{sprintContent}</p>{sprintSubContent}</div></li>";
          TaskList.InnerHtml += level1Template;
        }
      }

      
    }

    private void RenderTasks(SortableBindingList<Sprint> allSprints, SortableBindingList<Todo> allTodos, string sprintFilter, string projectFilter)
    {
      Sprint selectedSprint = allSprints.Where(s => s.ShortDescription == sprintFilter).Single();

      foreach (KanbanPosition kanbanPosition in selectedSprint.Kanban)
      {
        Todo task = allTodos.Where(t => t.pId == kanbanPosition.TaskPid).Single();
        string taskName = task.ShortDescription;
        string taskContent = "";//task.PublicText.Replace("\r\n", "<br />");


        StringBuilder taskSubContentBuilder = new StringBuilder();

        string name = "";
        string content = "";
        string subContent = "";
        string level2Template = "";

        if (!string.IsNullOrEmpty(task.CurrentState))
        {
          name = "Ist zustand: ";
          content = task.CurrentState.Replace("\r\n", "<br />");
          level2Template = $"<ul class=\"cbp-ntsubaccordion\"><li><h4 class=\"cbp-nttrigger\">{name}</h4><div class=\"cbp-ntcontent\"><p>{content}</p>{subContent}</div></li></ul>";
          taskSubContentBuilder.AppendLine(level2Template);
        }
        if (!string.IsNullOrEmpty(task.Description))
        {
          name = "Soll zustand: ";
          content = task.Description.Replace("\r\n", "<br />");
          level2Template = $"<ul class=\"cbp-ntsubaccordion\"><li><h4 class=\"cbp-nttrigger\">{name}</h4><div class=\"cbp-ntcontent\"><p>{content}</p>{subContent}</div></li></ul>";
          taskSubContentBuilder.AppendLine(level2Template);
        }
        if (!string.IsNullOrEmpty(task.Result))
        {
          name = "Recherche: ";
          content = task.Result.Replace("\r\n", "<br />");
          level2Template = $"<ul class=\"cbp-ntsubaccordion\"><li><h4 class=\"cbp-nttrigger\">{name}</h4><div class=\"cbp-ntcontent\"><p>{content}</p>{subContent}</div></li></ul>";
          taskSubContentBuilder.AppendLine(level2Template);
        }
        if (!string.IsNullOrEmpty(task.PublicText))
        {
          name = "Resultat: ";
          content = task.PublicText.Replace("\r\n", "<br />");
          level2Template = $"<ul class=\"cbp-ntsubaccordion\"><li><h4 class=\"cbp-nttrigger\">{name}</h4><div class=\"cbp-ntcontent\"><p>{content}</p>{subContent}</div></li></ul>";
          taskSubContentBuilder.AppendLine(level2Template);
        }


        string taskSubContent = taskSubContentBuilder.ToString();
        string level1Template = $"<li><h3 class=\"cbp-nttrigger\">{taskName}</h3><div class=\"cbp-ntcontent\"><p>{taskContent}</p>{taskSubContent}</div></li>";
        TaskList.InnerHtml += level1Template;
      }
    }

    protected void Unnamed1_Load(object sender, EventArgs e)
    {

    }
  }
}