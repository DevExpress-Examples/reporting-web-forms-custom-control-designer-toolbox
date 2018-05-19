' Developer Express Code Central Example:
' How to: Add a Custom Control in the Web Report Designer
' 
' This example shows how to create a custom control and register it in the Web
' Report Designer
' (https://documentation.devexpress.com/#XtraReports/CustomDocument17103)'s
' Toolbox (https://documentation.devexpress.com/#XtraReports/CustomDocument17559).
' The example illustrates the steps to expand a set of native report controls by
' deriving from existing ones.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T209289

Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace Sample
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            reportDesigner1.OpenReport(New SampleReport())
        End Sub
    End Class
End Namespace