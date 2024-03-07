<%@ Page Language="VB" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Sample.WebForm1" %>

<%@ Register Assembly="DevExpress.XtraReports.v14.2.Web, Version=14.2.16.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>

<head runat="server">
    <title></title>

    <link href="CustomLabel/custom-label.css" rel="stylesheet" />
    <!-- #include file = "CustomLabel\custom-label-content.html" --> 

</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <dx:ASPxReportDesigner ID="reportDesigner1" runat="server">
        </dx:ASPxReportDesigner>

        <script src="CustomLabel/custom-label.js"></script>
        <script type="text/javascript">

            DevExpress.Designer.registerControl("<%= typeof(Sample.CustomLabel).ToString() %>", {
                info: newSerializationsInfo,
                defaultVal: {
                    "@ControlType": "<%= typeof(Sample.CustomLabel).AssemblyQualifiedName %>",
                    "@SizeF": "100,23"
                },
                type: DevExpress.Designer.Report.ControlViewModel,
                surfaceType: CustomLabelSurface,
                popularProperties: newPopularProperties,
                elementActionsTypes: [DevExpress.Designer.ElementActions]
            });
        </script>
    </form>
</body>
</html>
