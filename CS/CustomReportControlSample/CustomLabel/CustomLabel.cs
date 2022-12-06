using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Utils.Serializing;

namespace CustomReportControlSample
{
    public class CustomLabel : XRLabel {
        [Browsable(true), Bindable(false), Category("Data")]
        [XtraSerializableProperty]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
        EditorBrowsable(EditorBrowsableState.Always)]
        public string CustomNumber { get; set; }

        [Browsable(true), Bindable(true), Category("Data")]
        [XtraSerializableProperty]
        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
        EditorBrowsable(EditorBrowsableState.Always)]
        public string StringData { get; set; }

        protected override void PutStateToBrick(DevExpress.XtraPrinting.VisualBrick brick, 
                                                DevExpress.XtraPrinting.PrintingSystemBase ps) {
            base.PutStateToBrick(brick, ps);
            brick.Text = StringData ?? CustomNumber;
        }
    }
}
