<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Tornado14Lab.StatusPublisherWeb.Index" %>

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
    <div class="sprintList">
      <ul id="TaskListPlanned" class="cbp-ntaccordion" runat="server"></ul>
    </div>
  </form>
</body>
</html>
