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
		    $('#TaskList').cbpNTAccordion();
		  });
		</script>
</head>

<body>
    <form id="form1" runat="server">
    <div>
      <ul id="TaskList" class="cbp-ntaccordion" runat="server"></ul>
    </div>
    </form>
</body>
</html>
