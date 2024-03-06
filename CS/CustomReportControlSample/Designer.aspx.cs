using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomReportControlSample {
    public partial class Designer : System.Web.UI.Page {

        private void Page_Load(object sender, System.EventArgs e) {
            ASPxReportDesigner1.CustomControlTypes.AddRange(new[] { typeof(MyControl), typeof(NumericLabel)});
        }
    }
}
