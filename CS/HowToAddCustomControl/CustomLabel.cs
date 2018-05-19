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