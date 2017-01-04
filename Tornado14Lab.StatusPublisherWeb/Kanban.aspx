<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kanban.aspx.cs" Inherits="Tornado14Lab.StatusPublisherWeb.Kanban" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
  <link href="~/css/default.css" rel="stylesheet" />
  <link href="~/css/component.css" rel="stylesheet" />

  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
  <script src='<%= Page.ResolveUrl("~/scripts/modernizr.custom.js")%>'></script>
  <script src='<%= Page.ResolveUrl("~/scripts/jquery.cbpNTAccordion.js")%>'></script>
  <script>
    $(function () {
      $('#TaskListPlanned').cbpNTAccordion();
      $('#TaskListToday').cbpNTAccordion();
      $('#TaskListProgress').cbpNTAccordion();
      $('#TaskListTest').cbpNTAccordion();
      $('#TaskListDone').cbpNTAccordion();

      var planned = true;
      var today = true;
      var progress = true;
      var test = true;
      var done = true;

      $('.SwitchPlanned').click(function () {
        planned = !planned; $('.colPlanned').toggle(); $('.SwitchPlanned').toggleClass('Show');
        reload();
      });
      $('.SwitchToday').click(function () {
        today = !today; $('.colToday').toggle(); $('.SwitchToday').toggleClass('Show');
        reload();
      });
      $('.SwitchProgress').click(function () {
        progress = !progress; $('.colProgess').toggle(); $('.SwitchProgress').toggleClass('Show');
        reload();
      });
      $('.SwitchTest').click(function () {
        test = !test; $('.colTest').toggle(); $('.SwitchTest').toggleClass('Show');
        reload();
      });
      $('.SwitchDone').click(function () {
        done = !done; $('.colDone').toggle(); $('.SwitchDone').toggleClass('Show');
        reload();
      });

      function reload() {
        $('.col').width(100 / (planned + today + progress + test + done) + '%');
      }
      reload();
    });
  </script>
</head>

<body>
  <form id="form1" runat="server">

    <div id="header">
      <h1>Sprint Project</h1>
      <span class="Switch SwitchPlanned Show">Geplannt</span> |
      <span class="Switch SwitchToday Show">Heute</span> |
      <span class="Switch SwitchProgress Show">Progress</span> |
      <span class="Switch SwitchTest Show">Test</span> |
      <span class="Switch SwitchDone Show">Fertig</span>
    </div>

    <div class="container1">
      <div class="col colPlanned">
        <h2>Geplannt</h2>
        <ul id="TaskListPlanned" class="cbp-ntaccordion" runat="server"></ul>
      </div>
      <div class="col colToday">
        <h2>Heute</h2>
        <ul id="TaskListToday" class="cbp-ntaccordion" runat="server"></ul>
      </div>
      <div class="col colProgess">
        <h2>Progress</h2>
        <ul id="TaskListProgress" class="cbp-ntaccordion" runat="server"></ul>
      </div>
      <div class="col colTest">
        <h2>Test</h2>
        <ul id="TaskListTest" class="cbp-ntaccordion" runat="server"></ul>
      </div>
      <div class="col colDone">
        <h2>Fertig</h2>
        <ul id="TaskListDone" class="cbp-ntaccordion" runat="server"></ul>
      </div>
      <div style="clear: both"></div>
    </div>

    <div id="footer">
      <h1>Sprint Project</h1>
    </div>

  </form>
</body>
</html>
