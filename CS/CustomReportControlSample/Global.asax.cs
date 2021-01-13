using System;
using System.IO;
using System.Web;
using DevExpress.XtraReports.Web;
using CustomReportControlSample.Services;

namespace CustomReportControlSample {
    public class Global_asax : System.Web.HttpApplication {
        void Application_Start(object sender, EventArgs e) {
            System.Web.Routing.RouteTable.Routes.MapPageRoute("defaultRoute", "", "~/Default.aspx");
            DevExpress.XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions;
            DevExpress.XtraReports.Web.WebDocumentViewer.Native.WebDocumentViewerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default;
            DevExpress.XtraReports.Web.QueryBuilder.Native.QueryBuilderBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default;
            DevExpress.XtraReports.Web.ReportDesigner.Native.ReportDesignerBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Default;
            DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(new CustomReportStorageWebExtension(Server.MapPath("/Reports")));

            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;
            ASPxReportDesigner.StaticInitialize();

            DevExpress.XtraReports.Web.ClientControls.LoggerService.Initialize(ProcessException);

            DevExpress.Web.ASPxWebControl.CallbackError += new EventHandler(Application_Error);
        }

        void Application_End(object sender, EventArgs e) {
            // Code that runs on application shutdown
        }
    
        void Application_Error(object sender, EventArgs e) {
            // Code that runs when an unhandled error occurs
            Exception ex = Server.GetLastError().GetBaseException();
            ProcessException(ex, "");
        }
    
        void Session_Start(object sender, EventArgs e) {
            // Code that runs when a new session is started
        }

        void ProcessException(Exception ex, string message)
        {
            string logFile = Server.MapPath(@"Log\LogFile_" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + ".txt");

            StreamWriter writer;
            if (File.Exists(logFile))
            {
                writer = new StreamWriter(logFile, true);
            }
            else
            {
                writer = File.CreateText(logFile);
            }

            writer.WriteLine("[{0}]: Exception occured. Message: '{1}'. Exception Details:\r\n{2}",
                DateTime.Now, message, ex);

            writer.Close();
        }

        void Session_End(object sender, EventArgs e) {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.
        }
    }
}