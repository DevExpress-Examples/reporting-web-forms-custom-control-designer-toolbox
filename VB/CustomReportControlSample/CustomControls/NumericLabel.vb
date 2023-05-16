Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System.ComponentModel

Public Class NumericLabel
	Inherits XRLabel

	<Browsable(True), Bindable(False), Category("Data"), XtraSerializableProperty, DefaultValue(""), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always)>
	Public Property Number() As Integer

	' Render the control in the Designer's Preview and in the document.
	Protected Overrides Sub PutStateToBrick(ByVal brick As VisualBrick, ByVal ps As PrintingSystemBase)
		MyBase.PutStateToBrick(brick, ps)
		brick.Text = Me.Number.ToString()
	End Sub
End Class
