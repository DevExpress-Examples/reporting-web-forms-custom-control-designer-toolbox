Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.Utils.Serializing

Namespace CustomReportControlSample
	Public Class CustomLabel
		Inherits XRLabel

		<Browsable(True), Bindable(False), Category("Data"), XtraSerializableProperty, DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always)>
		Public Property CustomNumber() As String

		<Browsable(True), Bindable(True), Category("Data"), XtraSerializableProperty, DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always)>
		Public Property StringData() As String

		Protected Overrides Sub PutStateToBrick(ByVal brick As DevExpress.XtraPrinting.VisualBrick, ByVal ps As DevExpress.XtraPrinting.PrintingSystemBase)
			MyBase.PutStateToBrick(brick, ps)
			brick.Text = Me.StringData
		End Sub
	End Class
End Namespace