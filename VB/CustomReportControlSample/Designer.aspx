﻿<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Designer.aspx.vb" Inherits="CustomReportControlSample.Designer" %>

<%@ Register Assembly="DevExpress.XtraReports.v22.2.Web.WebForms, Version=22.2.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
	<link href="CustomLabel\custom-label.css" rel="stylesheet" />
	<!-- #include file = "CustomLabel\custom-label-content.html" -->
	<script src="CustomLabel/custom-label.js"></script>

	<script type="text/javascript">
		function onCustomizeToolbox(s, e) {
			customizeToolbox(s, e, "<%=GetType(CustomReportControlSample.CustomLabel).ToString()%>",
					"<%=GetType(CustomReportControlSample.CustomLabel).AssemblyQualifiedName%>");
			var labelInfo = e.ControlsFactory.getControlInfo("XRLabel");
			labelInfo.isToolboxItem = false;
		}
	</script>
	<dx:ASPxReportDesigner EnableRichTextEditor="False" ID="ASPxReportDesigner1" runat="server">
		<ClientSideEvents CustomizeToolbox="onCustomizeToolbox" />
	</dx:ASPxReportDesigner>
</asp:Content>