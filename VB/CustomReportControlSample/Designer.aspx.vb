Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace CustomReportControlSample

    Public Partial Class Designer
        Inherits Page

        Private Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ASPxReportDesigner1.CustomControlTypes.AddRange({GetType(MyControl), GetType(NumericLabel)})
        End Sub
    End Class
End Namespace
