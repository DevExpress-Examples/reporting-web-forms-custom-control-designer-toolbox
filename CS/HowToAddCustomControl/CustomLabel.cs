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

using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Utils.Serializing;

namespace Sample  {   
    public class CustomLabel : XRLabel
    {
        private string _someProperty;
        private string _bindableProperty;

        [Browsable(true), Bindable(false), Category("Data")]
        [XtraSerializableProperty]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always)]
        public string SomeProperty
        {
            get { return this._someProperty; }
            set { this._someProperty = value; }
        }

        [Browsable(true), Bindable(false), Category("Data")]
        [XtraSerializableProperty]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always)]
        public string BindableProperty
        {
            get { return this._bindableProperty; }
            set { this._bindableProperty = value; }
        }
    }
}