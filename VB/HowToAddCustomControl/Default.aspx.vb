Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace Sample

    Public Partial Class WebForm1
        Inherits Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            reportDesigner1.OpenReport(New SampleReport())
        End Sub
    End Class
End Namespace
