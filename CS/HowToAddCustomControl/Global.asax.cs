// Developer Express Code Central Example:
// How to: Add a Custom Control in the Web Report Designer
// 
// This example shows how to create a custom control and register it in the Web
// Report Designer
// (https://documentation.devexpress.com/#XtraReports/CustomDocument17103)'s
// Toolbox (https://documentation.devexpress.com/#XtraReports/CustomDocument17559).
// The example illustrates the steps to expand a set of native report controls by
// deriving from existing ones.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T209289

using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Security;
    using System.Web.SessionState;
    using DevExpress.Web;

    namespace Sample {
        public class Global_asax : System.Web.HttpApplication {
            void Application_Start(object sender, EventArgs e) {
                DevExpress.Web.ASPxWebControl.CallbackError += new EventHandler(Application_Error);
            }

            void Application_End(object sender, EventArgs e) {
                // Code that runs on application shutdown
            }

            void Application_Error(object sender, EventArgs e) {
                // Code that runs when an unhandled error occurs
            }

            void Session_Start(object sender, EventArgs e) {
                // Code that runs when a new session is started
            }

            void Session_End(object sender, EventArgs e) {
                // Code that runs when a session ends. 
                // Note: The Session_End event is raised only when the sessionstate mode
                // is set to InProc in the Web.config file. If session mode is set to StateServer 
                // or SQLServer, the event is not raised.
            }
        }
    }