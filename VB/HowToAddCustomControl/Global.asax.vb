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
    Imports System.Collections.Generic
    Imports System.Linq
    Imports System.Web
    Imports System.Web.Security
    Imports System.Web.SessionState
    Imports DevExpress.Web

    Namespace Sample
        Public Class Global_asax
            Inherits System.Web.HttpApplication

            Private Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
                AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf Application_Error
            End Sub

            Private Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
                ' Code that runs on application shutdown
            End Sub

            Private Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
                ' Code that runs when an unhandled error occurs
            End Sub

            Private Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
                ' Code that runs when a new session is started
            End Sub

            Private Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
                ' Code that runs when a session ends. 
                ' Note: The Session_End event is raised only when the sessionstate mode
                ' is set to InProc in the Web.config file. If session mode is set to StateServer 
                ' or SQLServer, the event is not raised.
            End Sub
        End Class
    End Namespace