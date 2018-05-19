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

using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            reportDesigner1.OpenReport(new SampleReport());
        }
    }
}