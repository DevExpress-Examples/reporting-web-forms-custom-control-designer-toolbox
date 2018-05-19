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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Sample {
    public partial class SampleReport : DevExpress.XtraReports.UI.XtraReport {
        public SampleReport() {
            InitializeComponent();
        }

    }
}
