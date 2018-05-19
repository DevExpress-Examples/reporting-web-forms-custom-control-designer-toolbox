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

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace Sample
    Partial Public Class SampleReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

    End Class
End Namespace
